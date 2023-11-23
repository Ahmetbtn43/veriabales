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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblTc.Text = tc;
            //Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text=dr[0] +" "+ dr[1];
            }
            bgl.baglanti().Close();
            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular Where HastaTC=" + tc, bgl.baglanti());
            da.Fill(dt);
            DgvGecmisRandevular.DataSource = dt;
            //Branşları çektik hasta detaydaki randevu panelinden
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            
        }
        // branşalara tıklandığında seçildiğinde seçilen branşın doktorlarını getiriyor 

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular Where RandevuBrans='" + CmbBrans.Text+"'" + "and RandevuDoktor='"+ CmbDoktor.Text +"'and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            DgvAktifRandevular.DataSource = dt;
        }

        private void LnkDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.TCno = LblTc.Text;
            fr.Show();
        }

        private void DgvAktifRandevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = DgvAktifRandevular.SelectedCells[0].RowIndex;
            Txtid.Text = DgvAktifRandevular.Rows[secilen].Cells[0].Value.ToString();

        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("Update Tbl_Randevular set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 Where Randevuid=@p3", bgl.baglanti());
            komut4.Parameters.AddWithValue("@p1", LblTc.Text);
            komut4.Parameters.AddWithValue("@p2", RchSikayet.Text);
            komut4.Parameters.AddWithValue("@p3", Txtid.Text);
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("randevu alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
