using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yerX = 5;
        int yerY = 5, can = 3;
        
        
        private void carpma()
        {
            //üst tarafa çarpma olayı
            if (top.Top <= label4.Bottom)
                yerY = yerY * -1;
            // kontrole çarpma olayı
            if (top.Bottom >= Kontrol.Top && top.Left >= Kontrol.Left && top.Right <= Kontrol.Right)
                yerY = yerY * -1;
            // sağ kenara çarpma olayı
            else if (top.Right >= label3.Left)
                yerX = yerX * -1;
            // sol kenara çarpma olayı
            else if (top.Left <= label1.Right)
                yerX = yerX * -1;
            
        }
        private void yanma(object sender, EventArgs e )
        {
            if (top.Top >= label3.Bottom)
            {
                if (can > 0)
                {
                    timer1.Stop();
                    can--;
                    MessageBox.Show("yandınız kalan canınız:" + can.ToString());
                    Form1_Load(sender,e);
                }
                else if (can == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("oyun bitti", "", MessageBoxButtons.OK);
                }
            }
            label2.Text =("kalan canınız:"+can.ToString());
        }
        private void topbasa()
        {
            top.Location = new Point(275, 227);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            topbasa();
            

        }

    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Kontrol.Left = e.X;
            

        }

        private void Top_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            top.Location = new Point(top.Location.X + yerX, top.Location.Y + yerY);
            carpma();
            yanma(sender,e);

        }
    }
}
