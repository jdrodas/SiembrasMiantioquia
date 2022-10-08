namespace SiembrasCorantioquia.vistas
{
    partial class FormaActualizaSiembra
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
            this.lstInfoSiembras = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstContratistas = new System.Windows.Forms.ListBox();
            this.lstArboles = new System.Windows.Forms.ListBox();
            this.lstMunicipios = new System.Windows.Forms.ListBox();
            this.btnActualizaSiembra = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalHectareas = new System.Windows.Forms.TextBox();
            this.txtTotalArboles = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lstVeredas = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodigoSiembra = new System.Windows.Forms.TextBox();
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
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1132, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Actualiza Siembra existente";
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
            // lstInfoSiembras
            // 
            this.lstInfoSiembras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInfoSiembras.FormattingEnabled = true;
            this.lstInfoSiembras.ItemHeight = 25;
            this.lstInfoSiembras.Location = new System.Drawing.Point(164, 84);
            this.lstInfoSiembras.Name = "lstInfoSiembras";
            this.lstInfoSiembras.Size = new System.Drawing.Size(834, 79);
            this.lstInfoSiembras.TabIndex = 3;
            this.lstInfoSiembras.SelectedIndexChanged += new System.EventHandler(this.lstInfoSiembras_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Siembra:";
            // 
            // lstContratistas
            // 
            this.lstContratistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstContratistas.FormattingEnabled = true;
            this.lstContratistas.ItemHeight = 25;
            this.lstContratistas.Location = new System.Drawing.Point(699, 354);
            this.lstContratistas.Name = "lstContratistas";
            this.lstContratistas.Size = new System.Drawing.Size(300, 79);
            this.lstContratistas.TabIndex = 51;
            // 
            // lstArboles
            // 
            this.lstArboles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstArboles.FormattingEnabled = true;
            this.lstArboles.ItemHeight = 25;
            this.lstArboles.Location = new System.Drawing.Point(699, 248);
            this.lstArboles.Name = "lstArboles";
            this.lstArboles.Size = new System.Drawing.Size(300, 79);
            this.lstArboles.TabIndex = 50;
            // 
            // lstMunicipios
            // 
            this.lstMunicipios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMunicipios.FormattingEnabled = true;
            this.lstMunicipios.ItemHeight = 25;
            this.lstMunicipios.Location = new System.Drawing.Point(202, 244);
            this.lstMunicipios.Name = "lstMunicipios";
            this.lstMunicipios.Size = new System.Drawing.Size(300, 79);
            this.lstMunicipios.TabIndex = 49;
            // 
            // btnActualizaSiembra
            // 
            this.btnActualizaSiembra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(236)))), ((int)(((byte)(191)))));
            this.btnActualizaSiembra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizaSiembra.Location = new System.Drawing.Point(457, 647);
            this.btnActualizaSiembra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizaSiembra.Name = "btnActualizaSiembra";
            this.btnActualizaSiembra.Size = new System.Drawing.Size(298, 40);
            this.btnActualizaSiembra.TabIndex = 48;
            this.btnActualizaSiembra.Text = "Actualiza Siembra";
            this.btnActualizaSiembra.UseVisualStyleBackColor = false;
            this.btnActualizaSiembra.Click += new System.EventHandler(this.btnActualizaSiembra_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(375, 523);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 25);
            this.label8.TabIndex = 47;
            this.label8.Text = "Total Hectáreas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(395, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 25);
            this.label7.TabIndex = 46;
            this.label7.Text = "Total Arboles:";
            // 
            // txtTotalHectareas
            // 
            this.txtTotalHectareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalHectareas.Location = new System.Drawing.Point(549, 523);
            this.txtTotalHectareas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalHectareas.Name = "txtTotalHectareas";
            this.txtTotalHectareas.Size = new System.Drawing.Size(100, 30);
            this.txtTotalHectareas.TabIndex = 45;
            this.txtTotalHectareas.Text = "0";
            this.txtTotalHectareas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalArboles
            // 
            this.txtTotalArboles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalArboles.Location = new System.Drawing.Point(549, 473);
            this.txtTotalArboles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalArboles.Name = "txtTotalArboles";
            this.txtTotalArboles.Size = new System.Drawing.Size(100, 30);
            this.txtTotalArboles.TabIndex = 44;
            this.txtTotalArboles.Text = "0";
            this.txtTotalArboles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 573);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFecha.Location = new System.Drawing.Point(549, 573);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(285, 22);
            this.dtpFecha.TabIndex = 42;
            // 
            // lstVeredas
            // 
            this.lstVeredas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVeredas.FormattingEnabled = true;
            this.lstVeredas.ItemHeight = 25;
            this.lstVeredas.Location = new System.Drawing.Point(202, 354);
            this.lstVeredas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstVeredas.Name = "lstVeredas";
            this.lstVeredas.Size = new System.Drawing.Size(300, 79);
            this.lstVeredas.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Municipio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(559, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Contratistas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(596, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Árboles:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(106, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 25);
            this.label9.TabIndex = 37;
            this.label9.Text = "Vereda:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(283, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(275, 25);
            this.label10.TabIndex = 52;
            this.label10.Text = "Código siembra seleccionada:";
            // 
            // txtCodigoSiembra
            // 
            this.txtCodigoSiembra.BackColor = System.Drawing.Color.Azure;
            this.txtCodigoSiembra.Enabled = false;
            this.txtCodigoSiembra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoSiembra.Location = new System.Drawing.Point(564, 186);
            this.txtCodigoSiembra.Name = "txtCodigoSiembra";
            this.txtCodigoSiembra.Size = new System.Drawing.Size(100, 30);
            this.txtCodigoSiembra.TabIndex = 53;
            this.txtCodigoSiembra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormaActualizaSiembra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 704);
            this.Controls.Add(this.txtCodigoSiembra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lstContratistas);
            this.Controls.Add(this.lstArboles);
            this.Controls.Add(this.lstMunicipios);
            this.Controls.Add(this.btnActualizaSiembra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalHectareas);
            this.Controls.Add(this.txtTotalArboles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lstVeredas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstInfoSiembras);
            this.Controls.Add(this.pbxBotonCerrar);
            this.Controls.Add(this.label1);
            this.Name = "FormaActualizaSiembra";
            this.Text = "FormaActualizaSiembra";
            this.Activated += new System.EventHandler(this.FormaActualizaSiembra_Activated);
            this.Load += new System.EventHandler(this.FormaActualizaSiembra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxBotonCerrar;
        private System.Windows.Forms.ListBox lstInfoSiembras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstContratistas;
        private System.Windows.Forms.ListBox lstArboles;
        private System.Windows.Forms.ListBox lstMunicipios;
        private System.Windows.Forms.Button btnActualizaSiembra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalHectareas;
        private System.Windows.Forms.TextBox txtTotalArboles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ListBox lstVeredas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigoSiembra;
    }
}