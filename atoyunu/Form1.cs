using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklik, ikinciatsolauzaklik, ucuncuatsolauzaklik;
        Random rastgele = new Random();
       

        private void label6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
           
        }
        private void atlaryerine()
        {
            pictureBox1.Location = new Point(0, 37);
            pictureBox2.Location = new Point(0, 153);
            pictureBox3.Location = new Point(0, 260);

        }

        private void label8_Click(object sender, EventArgs e)
        {
            atlaryerine();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciatıngenisligi = pictureBox1.Width;
            int ikinciatıngenisligi = pictureBox2.Width;
            int ucuncuatıngenisligi = pictureBox3.Width;
            int bitisuzakligi = label5.Left;
            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);
            if (birinciatıngenisligi + pictureBox1.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("1 numaralı at yarışı kazandı");
            }
            if (ikinciatıngenisligi + pictureBox2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 numaralı at yarışı kazandı");
            }
            if (ucuncuatıngenisligi + pictureBox3.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 numaralı at yarışı kazandı");
            }
            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label7.Text = "1 numaralı at yarışı önde götürüyor.";
            }
            else if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label7.Text="2 numaralı at yarışı önde götürüyor.";
            }
            else if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label7.Text = "3 numaralı at yarışı önde götürüyor";
            }
            




        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklik = pictureBox1.Left;
            ikinciatsolauzaklik = pictureBox2.Left;
            ucuncuatsolauzaklik = pictureBox3.Left;


        }
    }
}
