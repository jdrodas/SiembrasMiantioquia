namespace Miantioquia.Formularios
{
    partial class SiembraReportes
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
            this.txtCodigoSiembra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSiembraJSON = new System.Windows.Forms.TextBox();
            this.txtSiembraXML = new System.Windows.Forms.TextBox();
            this.txtSiembraTextoPlano = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(834, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Siembras registradas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxBotonCerrar
            // 
            this.pbxBotonCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbxBotonCerrar.Image = global::SiembrasMiantioquia_WinForms.Properties.Resources.cerrar;
            this.pbxBotonCerrar.Location = new System.Drawing.Point(806, 12);
            this.pbxBotonCerrar.Name = "pbxBotonCerrar";
            this.pbxBotonCerrar.Size = new System.Drawing.Size(16, 16);
            this.pbxBotonCerrar.TabIndex = 2;
            this.pbxBotonCerrar.TabStop = false;
            this.pbxBotonCerrar.Click += new System.EventHandler(this.pbxBotonCerrar_Click);
            // 
            // dgvDetalleSiembras
            // 
            this.dgvDetalleSiembras.AllowUserToAddRows = false;
            this.dgvDetalleSiembras.AllowUserToDeleteRows = false;
            this.dgvDetalleSiembras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleSiembras.Location = new System.Drawing.Point(28, 51);
            this.dgvDetalleSiembras.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalleSiembras.Name = "dgvDetalleSiembras";
            this.dgvDetalleSiembras.ReadOnly = true;
            this.dgvDetalleSiembras.RowHeadersWidth = 51;
            this.dgvDetalleSiembras.RowTemplate.Height = 24;
            this.dgvDetalleSiembras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleSiembras.Size = new System.Drawing.Size(774, 202);
            this.dgvDetalleSiembras.TabIndex = 8;
            this.dgvDetalleSiembras.SelectionChanged += new System.EventHandler(this.dgvDetalleSiembras_SelectionChanged);
            // 
            // txtCodigoSiembra
            // 
            this.txtCodigoSiembra.Enabled = false;
            this.txtCodigoSiembra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoSiembra.Location = new System.Drawing.Point(218, 285);
            this.txtCodigoSiembra.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoSiembra.Name = "txtCodigoSiembra";
            this.txtCodigoSiembra.Size = new System.Drawing.Size(98, 26);
            this.txtCodigoSiembra.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Siembra seleccionada:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 330);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Versión en JSON:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(562, 330);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Versión en XML:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSiembraJSON
            // 
            this.txtSiembraJSON.Location = new System.Drawing.Point(284, 362);
            this.txtSiembraJSON.Margin = new System.Windows.Forms.Padding(2);
            this.txtSiembraJSON.Multiline = true;
            this.txtSiembraJSON.Name = "txtSiembraJSON";
            this.txtSiembraJSON.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSiembraJSON.Size = new System.Drawing.Size(241, 196);
            this.txtSiembraJSON.TabIndex = 13;
            // 
            // txtSiembraXML
            // 
            this.txtSiembraXML.Location = new System.Drawing.Point(562, 362);
            this.txtSiembraXML.Margin = new System.Windows.Forms.Padding(2);
            this.txtSiembraXML.Multiline = true;
            this.txtSiembraXML.Name = "txtSiembraXML";
            this.txtSiembraXML.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSiembraXML.Size = new System.Drawing.Size(241, 196);
            this.txtSiembraXML.TabIndex = 14;
            // 
            // txtSiembraTextoPlano
            // 
            this.txtSiembraTextoPlano.Location = new System.Drawing.Point(29, 362);
            this.txtSiembraTextoPlano.Margin = new System.Windows.Forms.Padding(2);
            this.txtSiembraTextoPlano.Multiline = true;
            this.txtSiembraTextoPlano.Name = "txtSiembraTextoPlano";
            this.txtSiembraTextoPlano.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSiembraTextoPlano.Size = new System.Drawing.Size(241, 196);
            this.txtSiembraTextoPlano.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 330);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Versión en texto plano:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormaReporteSiembras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 571);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSiembraTextoPlano);
            this.Controls.Add(this.txtSiembraXML);
            this.Controls.Add(this.txtSiembraJSON);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoSiembra);
            this.Controls.Add(this.dgvDetalleSiembras);
            this.Controls.Add(this.pbxBotonCerrar);
            this.Controls.Add(this.label1);
            this.Name = "FormaReporteSiembras";
            this.Text = "FormaReporteSiembras";
            this.Load += new System.EventHandler(this.FormaReporteSiembras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleSiembras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxBotonCerrar;
        private System.Windows.Forms.DataGridView dgvDetalleSiembras;
        private System.Windows.Forms.TextBox txtCodigoSiembra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSiembraJSON;
        private System.Windows.Forms.TextBox txtSiembraXML;
        private System.Windows.Forms.TextBox txtSiembraTextoPlano;
        private System.Windows.Forms.Label label5;
    }
}