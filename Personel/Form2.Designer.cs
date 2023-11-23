
namespace Personel
{
    partial class Form2
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblToplamPersonel = new System.Windows.Forms.Label();
            this.lblEvli = new System.Windows.Forms.Label();
            this.lblBekar = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.lblToplamMaas = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblOrtalamaMaas = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(30, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(192, 23);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Toplam Personel Sayısı:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(62, 55);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(160, 23);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Evli Personel Sayısı:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(45, 91);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(177, 23);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Bekar Personel Sayısı:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(120, 127);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(102, 23);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Şehir Sayısı:";
            // 
            // lblToplamPersonel
            // 
            this.lblToplamPersonel.AutoSize = true;
            this.lblToplamPersonel.Location = new System.Drawing.Point(239, 20);
            this.lblToplamPersonel.Name = "lblToplamPersonel";
            this.lblToplamPersonel.Size = new System.Drawing.Size(20, 23);
            this.lblToplamPersonel.TabIndex = 4;
            this.lblToplamPersonel.Text = "0";
            // 
            // lblEvli
            // 
            this.lblEvli.AutoSize = true;
            this.lblEvli.Location = new System.Drawing.Point(239, 55);
            this.lblEvli.Name = "lblEvli";
            this.lblEvli.Size = new System.Drawing.Size(20, 23);
            this.lblEvli.TabIndex = 5;
            this.lblEvli.Text = "0";
            // 
            // lblBekar
            // 
            this.lblBekar.AutoSize = true;
            this.lblBekar.Location = new System.Drawing.Point(239, 91);
            this.lblBekar.Name = "lblBekar";
            this.lblBekar.Size = new System.Drawing.Size(20, 23);
            this.lblBekar.TabIndex = 6;
            this.lblBekar.Text = "0";
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Location = new System.Drawing.Point(239, 127);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(20, 23);
            this.lblSehir.TabIndex = 7;
            this.lblSehir.Text = "0";
            // 
            // lblToplamMaas
            // 
            this.lblToplamMaas.AutoSize = true;
            this.lblToplamMaas.Location = new System.Drawing.Point(239, 169);
            this.lblToplamMaas.Name = "lblToplamMaas";
            this.lblToplamMaas.Size = new System.Drawing.Size(20, 23);
            this.lblToplamMaas.TabIndex = 9;
            this.lblToplamMaas.Text = "0";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(120, 169);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(120, 23);
            this.lbl5.TabIndex = 8;
            this.lbl5.Text = "Toplam Maaş:";
            // 
            // lblOrtalamaMaas
            // 
            this.lblOrtalamaMaas.AutoSize = true;
            this.lblOrtalamaMaas.Location = new System.Drawing.Point(239, 211);
            this.lblOrtalamaMaas.Name = "lblOrtalamaMaas";
            this.lblOrtalamaMaas.Size = new System.Drawing.Size(20, 23);
            this.lblOrtalamaMaas.TabIndex = 11;
            this.lblOrtalamaMaas.Text = "0";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(105, 211);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(135, 23);
            this.lbl6.TabIndex = 10;
            this.lbl6.Text = "Ortalama Maaş:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 481);
            this.Controls.Add(this.lblOrtalamaMaas);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lblToplamMaas);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lblSehir);
            this.Controls.Add(this.lblBekar);
            this.Controls.Add(this.lblEvli);
            this.Controls.Add(this.lblToplamPersonel);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lblToplamPersonel;
        private System.Windows.Forms.Label lblEvli;
        private System.Windows.Forms.Label lblBekar;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.Label lblToplamMaas;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblOrtalamaMaas;
        private System.Windows.Forms.Label lbl6;
    }
}