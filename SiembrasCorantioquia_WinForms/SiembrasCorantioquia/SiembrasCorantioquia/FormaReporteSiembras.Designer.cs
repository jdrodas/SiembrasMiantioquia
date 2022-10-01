namespace SiembrasCorantioquia
{
    partial class FormaReporteSiembras
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
            this.label1 = new System.Windows.Forms.Label();
            this.pbxBotonCerrar = new System.Windows.Forms.PictureBox();
            this.dgvSiembras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiembras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(273, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Siembras registradas";
            // 
            // pbxBotonCerrar
            // 
            this.pbxBotonCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbxBotonCerrar.Image = global::SiembrasCorantioquia.Properties.Resources.cerrar;
            this.pbxBotonCerrar.Location = new System.Drawing.Point(772, 12);
            this.pbxBotonCerrar.Name = "pbxBotonCerrar";
            this.pbxBotonCerrar.Size = new System.Drawing.Size(16, 16);
            this.pbxBotonCerrar.TabIndex = 2;
            this.pbxBotonCerrar.TabStop = false;
            this.pbxBotonCerrar.Click += new System.EventHandler(this.pbxBotonCerrar_Click);
            // 
            // dgvSiembras
            // 
            this.dgvSiembras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiembras.Location = new System.Drawing.Point(100, 103);
            this.dgvSiembras.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSiembras.Name = "dgvSiembras";
            this.dgvSiembras.RowHeadersWidth = 51;
            this.dgvSiembras.RowTemplate.Height = 24;
            this.dgvSiembras.Size = new System.Drawing.Size(600, 244);
            this.dgvSiembras.TabIndex = 8;
            // 
            // FormaReporteSiembras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSiembras);
            this.Controls.Add(this.pbxBotonCerrar);
            this.Controls.Add(this.label1);
            this.Name = "FormaReporteSiembras";
            this.Text = "Reporte de Siembras registradas";
            this.Load += new System.EventHandler(this.FormaReporteSiembras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiembras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxBotonCerrar;
        private System.Windows.Forms.DataGridView dgvSiembras;
    }
}