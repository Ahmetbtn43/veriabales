using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;
            //ad soyad çektik sekreter detaya
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreterler where SekreterTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
            // Branşları çekitik
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            DgvBrans.DataSource = dt;

            //doktorları çekiyoruz
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select (DoktorAd+' '+DoktorSoyad)as Doktorlar ,(DoktorBrans)as Branslar From Tbl_Doktorlar",bgl.baglanti());
            da1.Fill(dt1);
            DgvDoktorlar.DataSource = dt1;
            //branşu randdevu oluşturdaki comboboxa çekme
            SqlCommand komut1 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                CmbBrans.Items.Add(dr1[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values(@p1,@p2,@p3,@p4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", MskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2", MskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@p4", CmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("randevunuz yapılmıştır");
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbDoktor.Items.Add(dr2[0] + " " + dr2[1]);
            }
            bgl.baglanti().Close();
        }

        private void BtnOLustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@p1)", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", RchDuyuru.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu");
            
        }

        private void BtnDoktorPnl_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli fr = new FrmDoktorPaneli();
            fr.Show();

        }

        private void BtnBransPnl_Click(object sender, EventArgs e)
        {
            FrmBransPaneli fr = new FrmBransPaneli();
            fr.Show();

        }

        private void BtnRandevuPnl_Click(object sender, EventArgs e)
        {
            FrmRandevuListele fr = new FrmRandevuListele();
            fr.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }
    }
}
