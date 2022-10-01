namespace SiembrasCorantioquia
{
    partial class FormaInsertaSiembra
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
            this.btnAgregarSiembra = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalHectareas = new System.Windows.Forms.TextBox();
            this.txtTotalArboles = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lsbVeredas = new System.Windows.Forms.ListBox();
            this.cbxMunicipios = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxContratistas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxArboles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(255, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registra Nueva Siembra";
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
            // btnAgregarSiembra
            // 
            this.btnAgregarSiembra.Location = new System.Drawing.Point(471, 330);
            this.btnAgregarSiembra.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarSiembra.Name = "btnAgregarSiembra";
            this.btnAgregarSiembra.Size = new System.Drawing.Size(104, 19);
            this.btnAgregarSiembra.TabIndex = 33;
            this.btnAgregarSiembra.Text = "Agregar Siembra";
            this.btnAgregarSiembra.UseVisualStyleBackColor = true;
            this.btnAgregarSiembra.Click += new System.EventHandler(this.btnAgregarSiembra_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 280);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Total Hectáreas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 240);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Total Arboles:";
            // 
            // txtTotalHectareas
            // 
            this.txtTotalHectareas.Location = new System.Drawing.Point(499, 275);
            this.txtTotalHectareas.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalHectareas.Name = "txtTotalHectareas";
            this.txtTotalHectareas.Size = new System.Drawing.Size(76, 20);
            this.txtTotalHectareas.TabIndex = 30;
            // 
            // txtTotalArboles
            // 
            this.txtTotalArboles.Location = new System.Drawing.Point(499, 238);
            this.txtTotalArboles.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalArboles.Name = "txtTotalArboles";
            this.txtTotalArboles.Size = new System.Drawing.Size(76, 20);
            this.txtTotalArboles.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFecha.Location = new System.Drawing.Point(234, 235);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(151, 20);
            this.dtpFecha.TabIndex = 27;
            // 
            // lsbVeredas
            // 
            this.lsbVeredas.FormattingEnabled = true;
            this.lsbVeredas.Location = new System.Drawing.Point(234, 98);
            this.lsbVeredas.Margin = new System.Windows.Forms.Padding(2);
            this.lsbVeredas.Name = "lsbVeredas";
            this.lsbVeredas.Size = new System.Drawing.Size(126, 95);
            this.lsbVeredas.TabIndex = 26;
            this.lsbVeredas.SelectedIndexChanged += new System.EventHandler(this.lsbVeredas_SelectedIndexChanged);
            // 
            // cbxMunicipios
            // 
            this.cbxMunicipios.FormattingEnabled = true;
            this.cbxMunicipios.Location = new System.Drawing.Point(452, 100);
            this.cbxMunicipios.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMunicipios.Name = "cbxMunicipios";
            this.cbxMunicipios.Size = new System.Drawing.Size(124, 21);
            this.cbxMunicipios.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Municipio";
            // 
            // cbxContratistas
            // 
            this.cbxContratistas.FormattingEnabled = true;
            this.cbxContratistas.Location = new System.Drawing.Point(449, 176);
            this.cbxContratistas.Margin = new System.Windows.Forms.Padding(2);
            this.cbxContratistas.Name = "cbxContratistas";
            this.cbxContratistas.Size = new System.Drawing.Size(126, 21);
            this.cbxContratistas.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Contratistas";
            // 
            // cbxArboles
            // 
            this.cbxArboles.FormattingEnabled = true;
            this.cbxArboles.Location = new System.Drawing.Point(449, 135);
            this.cbxArboles.Margin = new System.Windows.Forms.Padding(2);
            this.cbxArboles.Name = "cbxArboles";
            this.cbxArboles.Size = new System.Drawing.Size(126, 21);
            this.cbxArboles.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Árboles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Vereda";
            // 
            // FormaInsertaSiembra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarSiembra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalHectareas);
            this.Controls.Add(this.txtTotalArboles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lsbVeredas);
            this.Controls.Add(this.cbxMunicipios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxContratistas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxArboles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbxBotonCerrar);
            this.Controls.Add(this.label1);
            this.Name = "FormaInsertaSiembra";
            this.Text = "Inserta Nueva Siembra";
            this.Load += new System.EventHandler(this.FormaInsertaSiembra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxBotonCerrar;
        private System.Windows.Forms.Button btnAgregarSiembra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalHectareas;
        private System.Windows.Forms.TextBox txtTotalArboles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ListBox lsbVeredas;
        private System.Windows.Forms.ComboBox cbxMunicipios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxContratistas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxArboles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}