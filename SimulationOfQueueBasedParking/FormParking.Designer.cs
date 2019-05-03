namespace SimulationOfQueueBasedParking
{
    partial class FormParking
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParking));
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxSil = new System.Windows.Forms.CheckBox();
            this.checkBoxKazanc = new System.Windows.Forms.CheckBox();
            this.btnKazancHesapla = new System.Windows.Forms.Button();
            this.btnOncelikliSil = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOncelikliListele = new System.Windows.Forms.Button();
            this.txtArabaSayisi = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnOtoparkArabaEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Zamandan;";
            // 
            // checkBoxSil
            // 
            this.checkBoxSil.AutoSize = true;
            this.checkBoxSil.Location = new System.Drawing.Point(88, 209);
            this.checkBoxSil.Name = "checkBoxSil";
            this.checkBoxSil.Size = new System.Drawing.Size(128, 17);
            this.checkBoxSil.TabIndex = 21;
            this.checkBoxSil.Text = "Kazananları Listeleme";
            this.checkBoxSil.UseVisualStyleBackColor = true;
            this.checkBoxSil.CheckedChanged += new System.EventHandler(this.CheckBoxSil_CheckedChanged);
            // 
            // checkBoxKazanc
            // 
            this.checkBoxKazanc.AutoSize = true;
            this.checkBoxKazanc.Location = new System.Drawing.Point(88, 190);
            this.checkBoxKazanc.Name = "checkBoxKazanc";
            this.checkBoxKazanc.Size = new System.Drawing.Size(114, 17);
            this.checkBoxKazanc.TabIndex = 20;
            this.checkBoxKazanc.Text = "Kazananları Listele";
            this.checkBoxKazanc.UseVisualStyleBackColor = true;
            this.checkBoxKazanc.CheckedChanged += new System.EventHandler(this.CheckBoxKazanc_CheckedChanged);
            // 
            // btnKazancHesapla
            // 
            this.btnKazancHesapla.Location = new System.Drawing.Point(63, 291);
            this.btnKazancHesapla.Name = "btnKazancHesapla";
            this.btnKazancHesapla.Size = new System.Drawing.Size(211, 23);
            this.btnKazancHesapla.TabIndex = 19;
            this.btnKazancHesapla.Text = "Öncelikli Kuyrukta Zamandan Kazananlar";
            this.btnKazancHesapla.UseVisualStyleBackColor = true;
            this.btnKazancHesapla.Click += new System.EventHandler(this.BtnKazancHesapla_Click);
            // 
            // btnOncelikliSil
            // 
            this.btnOncelikliSil.Location = new System.Drawing.Point(63, 262);
            this.btnOncelikliSil.Name = "btnOncelikliSil";
            this.btnOncelikliSil.Size = new System.Drawing.Size(211, 23);
            this.btnOncelikliSil.TabIndex = 18;
            this.btnOncelikliSil.Text = "Otoparktan Arabaları Çıkar (Öncelikli)";
            this.btnOncelikliSil.UseVisualStyleBackColor = true;
            this.btnOncelikliSil.Click += new System.EventHandler(this.BtnOncelikliSil_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(63, 233);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(211, 23);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Otoparktan Arabaları Çıkar (FIFO)";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Araba Sayısı :";
            // 
            // btnOncelikliListele
            // 
            this.btnOncelikliListele.Location = new System.Drawing.Point(63, 117);
            this.btnOncelikliListele.Name = "btnOncelikliListele";
            this.btnOncelikliListele.Size = new System.Drawing.Size(211, 23);
            this.btnOncelikliListele.TabIndex = 14;
            this.btnOncelikliListele.Text = "Öncelikli Kuyruk Listele";
            this.btnOncelikliListele.UseVisualStyleBackColor = true;
            this.btnOncelikliListele.Click += new System.EventHandler(this.BtnOncelikliListele_Click);
            // 
            // txtArabaSayisi
            // 
            this.txtArabaSayisi.Location = new System.Drawing.Point(154, 33);
            this.txtArabaSayisi.Name = "txtArabaSayisi";
            this.txtArabaSayisi.Size = new System.Drawing.Size(109, 20);
            this.txtArabaSayisi.TabIndex = 13;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(63, 88);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(211, 23);
            this.btnListele.TabIndex = 12;
            this.btnListele.Text = "Basit Kuyruk Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // btnOtoparkArabaEkle
            // 
            this.btnOtoparkArabaEkle.Location = new System.Drawing.Point(63, 59);
            this.btnOtoparkArabaEkle.Name = "btnOtoparkArabaEkle";
            this.btnOtoparkArabaEkle.Size = new System.Drawing.Size(211, 23);
            this.btnOtoparkArabaEkle.TabIndex = 23;
            this.btnOtoparkArabaEkle.Text = "Otoparka Arabaları Ekle";
            this.btnOtoparkArabaEkle.UseVisualStyleBackColor = true;
            this.btnOtoparkArabaEkle.Click += new System.EventHandler(this.BtnOtoparkArabaEkle_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 348);
            this.Controls.Add(this.btnOtoparkArabaEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxSil);
            this.Controls.Add(this.checkBoxKazanc);
            this.Controls.Add(this.btnKazancHesapla);
            this.Controls.Add(this.btnOncelikliSil);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOncelikliListele);
            this.Controls.Add(this.txtArabaSayisi);
            this.Controls.Add(this.btnListele);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormParking";
            this.Text = "Simulation Of Queue Based Parking";
            this.Load += new System.EventHandler(this.FormParking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxSil;
        private System.Windows.Forms.CheckBox checkBoxKazanc;
        private System.Windows.Forms.Button btnKazancHesapla;
        private System.Windows.Forms.Button btnOncelikliSil;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOncelikliListele;
        private System.Windows.Forms.TextBox txtArabaSayisi;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnOtoparkArabaEkle;
    }
}

