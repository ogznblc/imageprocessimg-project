using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using AForge;
using AForge.Video;            //newframerate
using AForge.Video.DirectShow; //filterınfoCollectin ve VideocaptureDevice için 
using AForge.Imaging.Filters;
using AForge.Imaging;
using AForge.Vision;



namespace görüntüişlemeproje
{
    public partial class Form1 : Form
    {

        private FilterInfoCollection allcameras; //Pc' de bulunan cameralar dizi olarak allcameras değişkenindedir
        private VideoCaptureDevice pccamera;  //kullanacağımız aygıt


        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnbaslat_Click(object sender, EventArgs e)
        {
            pccamera = new VideoCaptureDevice(allcameras[cameraBox.SelectedIndex].MonikerString); //başlaya basıldığıdnda cameraboxtaki allcameralardan select edilen camera 
                                                                                                    //yani bilgisayarın camerası seçilir ve pccamera değişkenine atılır.

            pccamera.NewFrame += new NewFrameEventHandler(pccamera_newFrame);  // video kaynağından alınan her yeni kare işlenir.real time için
                                                                                //kullanıcıya yeni çerçevede  görüntü işleme  şansı verir.
            
            pccamera.Start();
        }

        void pccamera_newFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone(); //kameradan alınan real time görüntü.görütünün tutulması için klonlanır.
            Bitmap sameimage = (Bitmap)eventArgs.Frame.Clone(); //kameradan alınan real time görüntü
            kaynakBox.Image = image; 


            if (radioButton1.Checked)
            {
                EuclideanColorFiltering Colorfilter = new EuclideanColorFiltering();  // create filter
                Colorfilter.CenterColor = new RGB(Color.FromArgb(215, 30, 30));   //set center color and radius
                Colorfilter.Radius = 100;
                Colorfilter.ApplyInPlace(sameimage);   //kameradan alınan image1 e filtre uygulanır
                findobject(sameimage);
            }
           
            if (radioButton2.Checked)
            {
                EuclideanColorFiltering Colorfilter = new EuclideanColorFiltering();

                Colorfilter.CenterColor = new RGB(Color.FromArgb(30, 215, 30));
                Colorfilter.Radius = 100;

                Colorfilter.ApplyInPlace(sameimage);

                findobject(sameimage);

            }
            if (radioButton3.Checked)
            {
                EuclideanColorFiltering Colorfilter = new EuclideanColorFiltering();

                Colorfilter.CenterColor = new RGB(Color.FromArgb(30, 144, 255));
                Colorfilter.Radius = 100;

                Colorfilter.ApplyInPlace(sameimage);

                findobject(sameimage);
            }
        }
        public void findobject(Bitmap sameimage)  //Algilanan rengi Çevrçevelemek veya hedeflemek için gerekli Method.
        {

            BlobCounter bc = new BlobCounter(); //kameradaki objeleri algılamak için çerçeve gibi bişi oluşturuyorsun
            bc.MinWidth = 5;  //ne kadar küçük olursa o kadar cok kare olur nesne daha kolay  belirlenir.
            bc.MinHeight = 5;
            bc.FilterBlobs = true;

            bc.ProcessImage(sameimage);//Renkfiltresi uygulanan görüntü'ye blob counter uygulandı.
            Rectangle[] rects = bc.GetObjectsRectangles();  // oluşan rectangler'ın bilgileri alınır.
            

            islemBox.Image = sameimage;


            foreach (Rectangle recs in rects)
            {

                if (rects.Length > 0) //Filtrelenmiş görüntüden çerceve bilgiler alınmıssa
                {
                    Rectangle ourobject = rects[0];  //işlemboxta yakalanan ik rectangle ourobject olur.

                   
                    Graphics graph = kaynakBox.CreateGraphics();

                   using (Pen cerceve = new Pen(Color.Black, 2))  //kaynakboxtaki objeyi çerceveleyen kutu tasarımı
                   {
                       graph.DrawRectangle(cerceve, ourobject);
                    }

                   int objectX = ourobject.X + (ourobject.Width / 2);  //görüntüdeki piksellerin koordinat hesabı 
                   int objectY = ourobject.Y + (ourobject.Height / 2);

                   graph.Dispose(); //kontrolde tutmak için





                    if (objectX < 120 && objectY < 90) //  (360,275) normal kaynakBox ve işlembox için
                    {

                        serialPort1.Write("a");

                    }
                    else if ((objectX > 120 && objectX < 240) && (objectY < 90))
                    {

                        serialPort1.Write("b");
                    }
                    else if ((objectX > 240 && objectX < 360) && (objectY < 90))
                    {

                        serialPort1.Write("c");
                    }
                    else if ((objectX < 120) && (objectY > 90 && objectY < 185))
                    {

                        serialPort1.Write("d");
                    }
                    else if ((objectX > 120 && objectX < 240) && (objectY > 90 && objectY < 185))
                    {
                        serialPort1.Write("e");
                    }
                    else if ((objectX > 240 && objectX < 360) && (objectY > 90 && objectY < 185))
                    {

                        serialPort1.Write("f");
                    }
                    else if ((objectX < 120) && (objectY > 185 && objectY < 275))
                    {

                        serialPort1.Write("g");
                    }
                    else if ((objectX > 120 && objectX < 240) && (objectY > 185 && objectY < 275))
                    {

                        serialPort1.Write("h");
                    }
                    else if (objectX > 240 && (objectY > 185 && objectY < 275))
                    {

                        serialPort1.Write("k");
                    }


                }
            }
        }


        private void btnbaglan_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = PortBox.SelectedItem.ToString(); // portboxta  seçilen  port(com3)  port ismidir.
            serialPort1.BaudRate = 9600;
            serialPort1.Open(); 
            if (serialPort1.IsOpen)
            {
                toolStripLabel1.Text = PortBox.SelectedItem.ToString() + "portuna bağlandı";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PortBox.DataSource = SerialPort.GetPortNames(); //arduinodaki portların isimleri  portBox'a(comboBox'a yazılır)
            int number = PortBox.Items.Count;   //portBox'ta portların sayısı
            if (number == 0)
            {
                toolStripLabel1.Text = "Bağlı Port Bulunamadı.";
                PortBox.Enabled = false;
                btnbaglan.Enabled = false;
            }

            else
            {
                toolStripLabel1.Text = number + "Tane Port var";
            }

            allcameras = new FilterInfoCollection(FilterCategory.VideoInputDevice); //allcameras dizisine bilgisayardaki mevcut kameraları dolduruyoruz.

            foreach (FilterInfo VideoCaptureDevice in allcameras)
            {

                cameraBox.Items.Add(VideoCaptureDevice.Name);   //Bilgisayardaki Kameralar hepsi ComboBox'da listelenir

            }

            cameraBox.SelectedIndex = 0;  //Comboboxtaki ilk index numaralı kameranın ekranda görünmesi için
        }

        private void cameraBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
