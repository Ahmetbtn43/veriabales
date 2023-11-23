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

namespace Personel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=PersonelVeriTabani;integrated security=true");
      
        private void Form2_Load(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select Count(*)From Tbl_Personel", Baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblToplamPersonel.Text = dr1[0].ToString();//toplam personel sayısını aldık
            }
            Baglanti.Close();
            //evli personle sayısı
            Baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personel where PerDurum=1", Baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblEvli.Text = dr2[0].ToString();
            }
            Baglanti.Close();
            //Bekar Personel Sayısı

            Baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personel where PerDurum=0", Baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblBekar.Text = dr3[0].ToString();
            }
            Baglanti.Close();
            // burada şehir sayısını bulduk count=komut olarak bize sayıları getiriyor
            //distinct komutuda tekrarsız olarak getiriyor yani birden fazla aynı şehir varsa sadece bir kere sayıyor
            Baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(distinct(PerSehir)) From Tbl_Personel ", Baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblSehir.Text = dr4[0].ToString();
            }
            Baglanti.Close();

            Baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaas) From Tbl_Personel", Baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblToplamMaas.Text = dr5[0].ToString();
            }
            Baglanti.Close();
            Baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(PerMaas) From Tbl_Personel", Baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblOrtalamaMaas.Text = dr6[0].ToString();
            }
            Baglanti.Close();
        }
        
    }
}
