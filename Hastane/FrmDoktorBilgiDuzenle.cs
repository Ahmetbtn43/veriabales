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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TcNo;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = TcNo;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar Where DoktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                TxtSifre.Text = dr[5].ToString();
                CmbBrans.Text = dr[3].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
