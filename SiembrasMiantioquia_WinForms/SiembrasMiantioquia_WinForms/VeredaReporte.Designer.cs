namespace Miantioquia.Formularios
{
    partial class VeredaReporte
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
            this.lstVeredas = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstMunicipios = new System.Windows.Forms.ListBox();
            this.pbxBotonCerrar = new System.Windows.Forms.PictureBox();
            this.botonGenerarJSON = new System.Windows.Forms.Button();
            this.txtJSON = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(849, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reporte Veredas Registradas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstVeredas
            // 
            this.lstVeredas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVeredas.FormattingEnabled = true;
            this.lstVeredas.ItemHeight = 20;
            this.lstVeredas.Location = new System.Drawing.Point(488, 89);
            this.lstVeredas.Margin = new System.Windows.Forms.Padding(2);
            this.lstVeredas.Name = "lstVeredas";
            this.lstVeredas.Size = new System.Drawing.Size(226, 64);
            this.lstVeredas.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Municipio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Vereda:";
            // 
            // lstMunicipios
            // 
            this.lstMunicipios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMunicipios.FormattingEnabled = true;
            this.lstMunicipios.ItemHeight = 20;
            this.lstMunicipios.Location = new System.Drawing.Point(135, 89);
            this.lstMunicipios.Margin = new System.Windows.Forms.Padding(2);
            this.lstMunicipios.Name = "lstMunicipios";
            this.lstMunicipios.Size = new System.Drawing.Size(226, 64);
            this.lstMunicipios.TabIndex = 34;
            this.lstMunicipios.SelectedIndexChanged += new System.EventHandler(this.lstMunicipios_SelectedIndexChanged);
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
            // botonGenerarJSON
            // 
            this.botonGenerarJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(236)))), ((int)(((byte)(191)))));
            this.botonGenerarJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGenerarJSON.Location = new System.Drawing.Point(341, 206);
            this.botonGenerarJSON.Margin = new System.Windows.Forms.Padding(2);
            this.botonGenerarJSON.Name = "botonGenerarJSON";
            this.botonGenerarJSON.Size = new System.Drawing.Size(224, 32);
            this.botonGenerarJSON.TabIndex = 35;
            this.botonGenerarJSON.Text = "Generar export en JSON";
            this.botonGenerarJSON.UseVisualStyleBackColor = false;
            this.botonGenerarJSON.Click += new System.EventHandler(this.botonGenerarJSON_Click);
            // 
            // txtJSON
            // 
            this.txtJSON.Location = new System.Drawing.Point(53, 311);
            this.txtJSON.Multiline = true;
            this.txtJSON.Name = "txtJSON";
            this.txtJSON.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtJSON.Size = new System.Drawing.Size(661, 139);
            this.txtJSON.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "JSON Generado:";
            // 
            // FormaReporteVereda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 572);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJSON);
            this.Controls.Add(this.botonGenerarJSON);
            this.Controls.Add(this.lstMunicipios);
            this.Controls.Add(this.lstVeredas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbxBotonCerrar);
            this.Controls.Add(this.label1);
            this.Name = "FormaReporteVereda";
            this.Text = "FormaReporteVereda";
            this.Load += new System.EventHandler(this.FormaReporteVereda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxBotonCerrar;
        private System.Windows.Forms.ListBox lstVeredas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstMunicipios;
        private System.Windows.Forms.Button botonGenerarJSON;
        private System.Windows.Forms.TextBox txtJSON;
        private System.Windows.Forms.Label label3;
    }
}