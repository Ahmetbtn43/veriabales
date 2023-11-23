
namespace Hastane
{
    partial class FrmRandevuListele
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
            this.DgvRandevuListele = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRandevuListele)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvRandevuListele
            // 
            this.DgvRandevuListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvRandevuListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRandevuListele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvRandevuListele.Location = new System.Drawing.Point(0, 0);
            this.DgvRandevuListele.Name = "DgvRandevuListele";
            this.DgvRandevuListele.Size = new System.Drawing.Size(731, 359);
            this.DgvRandevuListele.TabIndex = 0;
            // 
            // FrmRandevuListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 359);
            this.Controls.Add(this.DgvRandevuListele);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRandevuListele";
            this.Text = "FrmRandevuListele";
            this.Load += new System.EventHandler(this.FrmRandevuListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRandevuListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRandevuListele;
    }
}