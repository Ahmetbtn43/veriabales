
namespace Hastane
{
    partial class FrmHastaDetay
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
            this.LnkDuzenle = new System.Windows.Forms.LinkLabel();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRandevuAl = new System.Windows.Forms.Button();
            this.RchSikayet = new System.Windows.Forms.RichTextBox();
            this.CmbDoktor = new System.Windows.Forms.ComboBox();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DgvGecmisRandevular = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DgvAktifRandevular = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGecmisRandevular)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAktifRandevular)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LnkDuzenle);
            this.groupBox1.Controls.Add(this.LblAdSoyad);
            this.groupBox1.Controls.Add(this.LblTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgisi";
            // 
            // LnkDuzenle
            // 
            this.LnkDuzenle.ActiveLinkColor = System.Drawing.Color.White;
            this.LnkDuzenle.AutoSize = true;
            this.LnkDuzenle.BackColor = System.Drawing.Color.Teal;
            this.LnkDuzenle.LinkColor = System.Drawing.Color.Black;
            this.LnkDuzenle.Location = new System.Drawing.Point(94, 83);
            this.LnkDuzenle.Name = "LnkDuzenle";
            this.LnkDuzenle.Size = new System.Drawing.Size(110, 23);
            this.LnkDuzenle.TabIndex = 11;
            this.LnkDuzenle.TabStop = true;
            this.LnkDuzenle.Text = "Bilgi Düzenle";
            this.LnkDuzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkDuzenle_LinkClicked);
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.Location = new System.Drawing.Point(94, 55);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(106, 28);
            this.LblAdSoyad.TabIndex = 10;
            this.LblAdSoyad.Text = "NULL NULL";
            // 
            // LblTc
            // 
            this.LblTc.Location = new System.Drawing.Point(94, 27);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(106, 28);
            this.LblTc.TabIndex = 9;
            this.LblTc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txtid);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.BtnRandevuAl);
            this.groupBox2.Controls.Add(this.RchSikayet);
            this.groupBox2.Controls.Add(this.CmbDoktor);
            this.groupBox2.Controls.Add(this.CmbBrans);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 323);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Paneli";
            // 
            // Txtid
            // 
            this.Txtid.Enabled = false;
            this.Txtid.Location = new System.Drawing.Point(79, 24);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(121, 31);
            this.Txtid.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(39, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "id:";
            // 
            // BtnRandevuAl
            // 
            this.BtnRandevuAl.Location = new System.Drawing.Point(82, 278);
            this.BtnRandevuAl.Name = "BtnRandevuAl";
            this.BtnRandevuAl.Size = new System.Drawing.Size(118, 40);
            this.BtnRandevuAl.TabIndex = 14;
            this.BtnRandevuAl.Text = "Randevu Al";
            this.BtnRandevuAl.UseVisualStyleBackColor = true;
            this.BtnRandevuAl.Click += new System.EventHandler(this.BtnRandevuAl_Click);
            // 
            // RchSikayet
            // 
            this.RchSikayet.Location = new System.Drawing.Point(79, 133);
            this.RchSikayet.Name = "RchSikayet";
            this.RchSikayet.Size = new System.Drawing.Size(137, 142);
            this.RchSikayet.TabIndex = 13;
            this.RchSikayet.Text = "";
            // 
            // CmbDoktor
            // 
            this.CmbDoktor.FormattingEnabled = true;
            this.CmbDoktor.Location = new System.Drawing.Point(79, 95);
            this.CmbDoktor.Name = "CmbDoktor";
            this.CmbDoktor.Size = new System.Drawing.Size(121, 31);
            this.CmbDoktor.TabIndex = 12;
            this.CmbDoktor.SelectedIndexChanged += new System.EventHandler(this.CmbDoktor_SelectedIndexChanged);
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(79, 58);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(121, 31);
            this.CmbBrans.TabIndex = 11;
            this.CmbBrans.SelectedIndexChanged += new System.EventHandler(this.CmbBrans_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "Şikayet:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Doktor:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Branş:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DgvGecmisRandevular);
            this.groupBox3.Location = new System.Drawing.Point(252, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(589, 210);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Geçmiş Randevular";
            // 
            // DgvGecmisRandevular
            // 
            this.DgvGecmisRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGecmisRandevular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvGecmisRandevular.Location = new System.Drawing.Point(3, 27);
            this.DgvGecmisRandevular.Name = "DgvGecmisRandevular";
            this.DgvGecmisRandevular.Size = new System.Drawing.Size(583, 180);
            this.DgvGecmisRandevular.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DgvAktifRandevular);
            this.groupBox4.Location = new System.Drawing.Point(252, 247);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(589, 226);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // DgvAktifRandevular
            // 
            this.DgvAktifRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAktifRandevular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAktifRandevular.Location = new System.Drawing.Point(3, 27);
            this.DgvAktifRandevular.Name = "DgvAktifRandevular";
            this.DgvAktifRandevular.Size = new System.Drawing.Size(583, 196);
            this.DgvAktifRandevular.TabIndex = 0;
            this.DgvAktifRandevular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAktifRandevular_CellClick);
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(853, 485);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmHastaDetay";
            this.Text = "HastaDetay";
            this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGecmisRandevular)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAktifRandevular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRandevuAl;
        private System.Windows.Forms.RichTextBox RchSikayet;
        private System.Windows.Forms.ComboBox CmbDoktor;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DgvGecmisRandevular;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DgvAktifRandevular;
        private System.Windows.Forms.LinkLabel LnkDuzenle;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label3;
    }
}