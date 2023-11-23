using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kisiler _kisiler = new Kisiler();

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
        private void LoadTbl_Personel()
        {
            dataGridView1.DataSource = _kisiler.GetAll();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _kisiler.Add(new Kisi
            {
                PerAd = txtAd.Text,
                PerSoyad = txtSoyad.Text,
                PerSehir = cmbSehir.Text,
                PerMaas = Convert.ToInt32(msdMaas.Text),
                PerDurum = label8.Text,
                PerMeslek = txtMeslek.Text
                

            });
            LoadTbl_Personel();
            MessageBox.Show("personel eklendi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Kisi kisi = new Kisi
            {
                Perid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                PerAd = txtAd.Text,
                PerSoyad = txtSoyad.Text,
                PerSehir = cmbSehir.Text,
                PerMaas = Convert.ToInt32(msdMaas.Text),
                PerDurum =label8.Text,
                PerMeslek = txtMeslek.Text
            };
            _kisiler.Update(kisi);
            LoadTbl_Personel();
            MessageBox.Show("güncellendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int Perid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            _kisiler.Delete(Perid);
            LoadTbl_Personel();
            MessageBox.Show("ürün silindi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            label8.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            msdMaas.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtMeslek.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            LoadTbl_Personel();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "True";
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "False";
            }
        }
        void temizle()
        {
            txtid.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtMeslek.Text = "";
            msdMaas.Text = "";
            cmbSehir.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtAd.Focus();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "False")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text == "True")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();

        }
    }
}
