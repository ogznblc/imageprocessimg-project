namespace görüntüişlemeproje
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cameraBox = new System.Windows.Forms.ComboBox();
            this.btnbaslat = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.kaynakBox = new System.Windows.Forms.PictureBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.btnbaglan = new System.Windows.Forms.Button();
            this.islemBox = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cameraBox
            // 
            this.cameraBox.FormattingEnabled = true;
            this.cameraBox.Location = new System.Drawing.Point(12, 31);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(165, 21);
            this.cameraBox.TabIndex = 0;
            this.cameraBox.SelectedIndexChanged += new System.EventHandler(this.cameraBox_SelectedIndexChanged);
            // 
            // btnbaslat
            // 
            this.btnbaslat.Location = new System.Drawing.Point(183, 29);
            this.btnbaslat.Name = "btnbaslat";
            this.btnbaslat.Size = new System.Drawing.Size(75, 23);
            this.btnbaslat.TabIndex = 1;
            this.btnbaslat.Text = "BAŞLAT";
            this.btnbaslat.UseVisualStyleBackColor = true;
            this.btnbaslat.Click += new System.EventHandler(this.btnbaslat_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(747, 109);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(33, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "R";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // kaynakBox
            // 
            this.kaynakBox.Location = new System.Drawing.Point(12, 78);
            this.kaynakBox.Name = "kaynakBox";
            this.kaynakBox.Size = new System.Drawing.Size(360, 275);
            this.kaynakBox.TabIndex = 3;
            this.kaynakBox.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(747, 195);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(33, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "G";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(747, 276);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(32, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "B";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // PortBox
            // 
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Location = new System.Drawing.Point(338, 29);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(165, 21);
            this.PortBox.TabIndex = 6;
            // 
            // btnbaglan
            // 
            this.btnbaglan.Location = new System.Drawing.Point(509, 27);
            this.btnbaglan.Name = "btnbaglan";
            this.btnbaglan.Size = new System.Drawing.Size(75, 23);
            this.btnbaglan.TabIndex = 7;
            this.btnbaglan.Text = "BAGLAN";
            this.btnbaglan.UseVisualStyleBackColor = true;
            this.btnbaglan.Click += new System.EventHandler(this.btnbaglan_Click);
            // 
            // islemBox
            // 
            this.islemBox.Location = new System.Drawing.Point(378, 78);
            this.islemBox.Name = "islemBox";
            this.islemBox.Size = new System.Drawing.Size(360, 275);
            this.islemBox.TabIndex = 8;
            this.islemBox.TabStop = false;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(867, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 424);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.islemBox);
            this.Controls.Add(this.btnbaglan);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.kaynakBox);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnbaslat);
            this.Controls.Add(this.cameraBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cameraBox;
        private System.Windows.Forms.Button btnbaslat;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox kaynakBox;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox PortBox;
        private System.Windows.Forms.Button btnbaglan;
        private System.Windows.Forms.PictureBox islemBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

