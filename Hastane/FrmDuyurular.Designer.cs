
namespace Hastane
{
    partial class FrmDuyurular
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
            this.DgvDuyurular = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDuyurular)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDuyurular
            // 
            this.DgvDuyurular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDuyurular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDuyurular.Location = new System.Drawing.Point(0, 0);
            this.DgvDuyurular.Name = "DgvDuyurular";
            this.DgvDuyurular.Size = new System.Drawing.Size(622, 348);
            this.DgvDuyurular.TabIndex = 0;
            // 
            // FrmDuyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 348);
            this.Controls.Add(this.DgvDuyurular);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDuyurular";
            this.Text = "FrmDuyurular";
            this.Load += new System.EventHandler(this.FrmDuyurular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDuyurular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDuyurular;
    }
}