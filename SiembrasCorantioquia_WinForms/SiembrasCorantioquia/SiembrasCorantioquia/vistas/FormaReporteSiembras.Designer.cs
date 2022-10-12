namespace SiembrasCorantioquia.vistas
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
            this.dgvDetalleSiembras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleSiembras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(236)))), ((int)(((byte)(191)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1112, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Siembras registradas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxBotonCerrar
            // 
            this.pbxBotonCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbxBotonCerrar.Image = global::SiembrasCorantioquia.Properties.Resources.cerrar;
            this.pbxBotonCerrar.Location = new System.Drawing.Point(1075, 15);
            this.pbxBotonCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.pbxBotonCerrar.Name = "pbxBotonCerrar";
            this.pbxBotonCerrar.Size = new System.Drawing.Size(21, 20);
            this.pbxBotonCerrar.TabIndex = 2;
            this.pbxBotonCerrar.TabStop = false;
            this.pbxBotonCerrar.Click += new System.EventHandler(this.pbxBotonCerrar_Click);
            // 
            // dgvDetalleSiembras
            // 
            this.dgvDetalleSiembras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleSiembras.Location = new System.Drawing.Point(41, 78);
            this.dgvDetalleSiembras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDetalleSiembras.Name = "dgvDetalleSiembras";
            this.dgvDetalleSiembras.RowHeadersWidth = 51;
            this.dgvDetalleSiembras.RowTemplate.Height = 24;
            this.dgvDetalleSiembras.Size = new System.Drawing.Size(1034, 494);
            this.dgvDetalleSiembras.TabIndex = 8;
            // 
            // FormaReporteSiembras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 703);
            this.Controls.Add(this.dgvDetalleSiembras);
            this.Controls.Add(this.pbxBotonCerrar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormaReporteSiembras";
            this.Text = "Reporte de Siembras registradas";
            this.Load += new System.EventHandler(this.FormaReporteSiembras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleSiembras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxBotonCerrar;
        private System.Windows.Forms.DataGridView dgvDetalleSiembras;
    }
}