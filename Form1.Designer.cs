namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEmanetKitapAl = new System.Windows.Forms.Button();
            this.btnEmanetKitapListele = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(45, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye İşlemleri";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(20, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(299, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "ÜYE LİSTELEME İŞLEMLERİ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "ÜYE EKLME İŞLEMLERİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKitapListele);
            this.groupBox2.Controls.Add(this.btnKitapEkle);
            this.groupBox2.Location = new System.Drawing.Point(413, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.BackColor = System.Drawing.Color.White;
            this.btnKitapListele.Location = new System.Drawing.Point(25, 54);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(298, 27);
            this.btnKitapListele.TabIndex = 1;
            this.btnKitapListele.Text = "KİTAP LİSTELEME İŞLEMLERİ";
            this.btnKitapListele.UseVisualStyleBackColor = false;
            this.btnKitapListele.Click += new System.EventHandler(this.btnKitapListele_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(25, 22);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(298, 27);
            this.btnKitapEkle.TabIndex = 0;
            this.btnKitapEkle.Text = "KİTAP EKLEME İŞLEMLERİ";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEmanetKitapAl);
            this.groupBox3.Controls.Add(this.btnEmanetKitapListele);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Location = new System.Drawing.Point(223, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 118);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emanet Kitap İşlemleri";
            // 
            // btnEmanetKitapAl
            // 
            this.btnEmanetKitapAl.Location = new System.Drawing.Point(20, 80);
            this.btnEmanetKitapAl.Name = "btnEmanetKitapAl";
            this.btnEmanetKitapAl.Size = new System.Drawing.Size(298, 23);
            this.btnEmanetKitapAl.TabIndex = 2;
            this.btnEmanetKitapAl.Text = "EMANET KİTAP TESLİM ALMA İŞLEMLRİ";
            this.btnEmanetKitapAl.UseVisualStyleBackColor = true;
            this.btnEmanetKitapAl.Click += new System.EventHandler(this.btnEmanetKitapAl_Click);
            // 
            // btnEmanetKitapListele
            // 
            this.btnEmanetKitapListele.Location = new System.Drawing.Point(20, 51);
            this.btnEmanetKitapListele.Name = "btnEmanetKitapListele";
            this.btnEmanetKitapListele.Size = new System.Drawing.Size(298, 23);
            this.btnEmanetKitapListele.TabIndex = 1;
            this.btnEmanetKitapListele.Text = "EMANET KİTAP LİSTELEME İŞLEMLERİ";
            this.btnEmanetKitapListele.UseVisualStyleBackColor = true;
            this.btnEmanetKitapListele.Click += new System.EventHandler(this.btnEmanetKitapListele_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(20, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(298, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "EMANET KİTAP VERME İŞLEMLERİ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Location = new System.Drawing.Point(763, 428);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(10, 10);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sıralama ve Grafikler";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(25, 63);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(298, 27);
            this.button9.TabIndex = 1;
            this.button9.Text = "GRAFİKLER";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(25, 30);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(298, 27);
            this.button8.TabIndex = 0;
            this.button8.Text = "SIRALAMALAR";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private Button btnKitapListele;
        private Button btnKitapEkle;
        private GroupBox groupBox3;
        private Button btnEmanetKitapAl;
        private Button btnEmanetKitapListele;
        private Button button5;
        private GroupBox groupBox4;
        private Button button9;
        private Button button8;
    }
}