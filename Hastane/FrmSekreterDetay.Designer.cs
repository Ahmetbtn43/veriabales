
namespace Hastane
{
    partial class FrmSekreterDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnOLustur = new System.Windows.Forms.Button();
            this.RchDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnRandevuPnl = new System.Windows.Forms.Button();
            this.BtnBransPnl = new System.Windows.Forms.Button();
            this.BtnDoktorPnl = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DgvBrans = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DgvDoktorlar = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.ChkbDurum = new System.Windows.Forms.CheckBox();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.CmbDoktor = new System.Windows.Forms.ComboBox();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnDuyurular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBrans)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoktorlar)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblAdSoyad);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(94, 73);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(66, 19);
            this.LblAdSoyad.TabIndex = 3;
            this.LblAdSoyad.Text = "Null Null";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(94, 27);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(97, 19);
            this.LblTC.TabIndex = 2;
            this.LblTC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD-Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnOLustur);
            this.groupBox2.Controls.Add(this.RchDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // BtnOLustur
            // 
            this.BtnOLustur.Location = new System.Drawing.Point(25, 193);
            this.BtnOLustur.Name = "BtnOLustur";
            this.BtnOLustur.Size = new System.Drawing.Size(179, 29);
            this.BtnOLustur.TabIndex = 1;
            this.BtnOLustur.Text = "Oluştur";
            this.BtnOLustur.UseVisualStyleBackColor = true;
            this.BtnOLustur.Click += new System.EventHandler(this.BtnOLustur_Click);
            // 
            // RchDuyuru
            // 
            this.RchDuyuru.Location = new System.Drawing.Point(6, 26);
            this.RchDuyuru.Name = "RchDuyuru";
            this.RchDuyuru.Size = new System.Drawing.Size(231, 160);
            this.RchDuyuru.TabIndex = 0;
            this.RchDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnDuyurular);
            this.groupBox3.Controls.Add(this.BtnRandevuPnl);
            this.groupBox3.Controls.Add(this.BtnBransPnl);
            this.groupBox3.Controls.Add(this.BtnDoktorPnl);
            this.groupBox3.Location = new System.Drawing.Point(12, 381);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hızlı Erişim";
            // 
            // BtnRandevuPnl
            // 
            this.BtnRandevuPnl.Location = new System.Drawing.Point(228, 46);
            this.BtnRandevuPnl.Name = "BtnRandevuPnl";
            this.BtnRandevuPnl.Size = new System.Drawing.Size(121, 29);
            this.BtnRandevuPnl.TabIndex = 4;
            this.BtnRandevuPnl.Text = "Randevu Listele";
            this.BtnRandevuPnl.UseVisualStyleBackColor = true;
            this.BtnRandevuPnl.Click += new System.EventHandler(this.BtnRandevuPnl_Click);
            // 
            // BtnBransPnl
            // 
            this.BtnBransPnl.Location = new System.Drawing.Point(124, 46);
            this.BtnBransPnl.Name = "BtnBransPnl";
            this.BtnBransPnl.Size = new System.Drawing.Size(98, 29);
            this.BtnBransPnl.TabIndex = 3;
            this.BtnBransPnl.Text = "Branş Paneli";
            this.BtnBransPnl.UseVisualStyleBackColor = true;
            this.BtnBransPnl.Click += new System.EventHandler(this.BtnBransPnl_Click);
            // 
            // BtnDoktorPnl
            // 
            this.BtnDoktorPnl.Location = new System.Drawing.Point(6, 46);
            this.BtnDoktorPnl.Name = "BtnDoktorPnl";
            this.BtnDoktorPnl.Size = new System.Drawing.Size(112, 29);
            this.BtnDoktorPnl.TabIndex = 2;
            this.BtnDoktorPnl.Text = "Doktor Paneli";
            this.BtnDoktorPnl.UseVisualStyleBackColor = true;
            this.BtnDoktorPnl.Click += new System.EventHandler(this.BtnDoktorPnl_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DgvBrans);
            this.groupBox4.Location = new System.Drawing.Point(479, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(417, 201);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // DgvBrans
            // 
            this.DgvBrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvBrans.Location = new System.Drawing.Point(3, 23);
            this.DgvBrans.Name = "DgvBrans";
            this.DgvBrans.Size = new System.Drawing.Size(411, 175);
            this.DgvBrans.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DgvDoktorlar);
            this.groupBox5.Location = new System.Drawing.Point(479, 228);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(417, 253);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // DgvDoktorlar
            // 
            this.DgvDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDoktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDoktorlar.Location = new System.Drawing.Point(3, 23);
            this.DgvDoktorlar.Name = "DgvDoktorlar";
            this.DgvDoktorlar.Size = new System.Drawing.Size(411, 227);
            this.DgvDoktorlar.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnKaydet);
            this.groupBox6.Controls.Add(this.ChkbDurum);
            this.groupBox6.Controls.Add(this.Txtid);
            this.groupBox6.Controls.Add(this.CmbDoktor);
            this.groupBox6.Controls.Add(this.CmbBrans);
            this.groupBox6.Controls.Add(this.MskTC);
            this.groupBox6.Controls.Add(this.MskSaat);
            this.groupBox6.Controls.Add(this.MskTarih);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(273, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 358);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Randevu Paneli";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(73, 281);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(112, 29);
            this.BtnKaydet.TabIndex = 14;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // ChkbDurum
            // 
            this.ChkbDurum.AutoSize = true;
            this.ChkbDurum.Location = new System.Drawing.Point(74, 252);
            this.ChkbDurum.Name = "ChkbDurum";
            this.ChkbDurum.Size = new System.Drawing.Size(73, 23);
            this.ChkbDurum.TabIndex = 12;
            this.ChkbDurum.Text = "Durum";
            this.ChkbDurum.UseVisualStyleBackColor = true;
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(73, 46);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(121, 27);
            this.Txtid.TabIndex = 11;
            // 
            // CmbDoktor
            // 
            this.CmbDoktor.FormattingEnabled = true;
            this.CmbDoktor.Location = new System.Drawing.Point(74, 181);
            this.CmbDoktor.Name = "CmbDoktor";
            this.CmbDoktor.Size = new System.Drawing.Size(121, 27);
            this.CmbDoktor.TabIndex = 10;
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(73, 148);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(121, 27);
            this.CmbBrans.TabIndex = 9;
            this.CmbBrans.SelectedIndexChanged += new System.EventHandler(this.CmbBrans_SelectedIndexChanged);
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(74, 219);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(119, 27);
            this.MskTC.TabIndex = 8;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // MskSaat
            // 
            this.MskSaat.Location = new System.Drawing.Point(73, 113);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(120, 27);
            this.MskSaat.TabIndex = 7;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(74, 80);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(120, 27);
            this.MskTarih.TabIndex = 6;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(17, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "Saat:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(27, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "TC:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Doktor:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(17, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Branş:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(18, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tarih:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(37, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "id:";
            // 
            // BtnDuyurular
            // 
            this.BtnDuyurular.Location = new System.Drawing.Point(354, 46);
            this.BtnDuyurular.Name = "BtnDuyurular";
            this.BtnDuyurular.Size = new System.Drawing.Size(100, 29);
            this.BtnDuyurular.TabIndex = 5;
            this.BtnDuyurular.Text = "Duyurular";
            this.BtnDuyurular.UseVisualStyleBackColor = true;
            this.BtnDuyurular.Click += new System.EventHandler(this.BtnDuyurular_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(908, 493);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSekreterDetay";
            this.Text = "FrmSekreterDetay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBrans)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoktorlar)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnOLustur;
        private System.Windows.Forms.RichTextBox RchDuyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnRandevuPnl;
        private System.Windows.Forms.Button BtnBransPnl;
        private System.Windows.Forms.Button BtnDoktorPnl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.ComboBox CmbDoktor;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DgvBrans;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.CheckBox ChkbDurum;
        private System.Windows.Forms.DataGridView DgvDoktorlar;
        private System.Windows.Forms.Button BtnDuyurular;
    }
}