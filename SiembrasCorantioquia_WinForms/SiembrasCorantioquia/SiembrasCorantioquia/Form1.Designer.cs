namespace SiembrasCorantioquia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxArboles = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxContratistas = new System.Windows.Forms.ComboBox();
            this.dgvSiembras = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMunicipios = new System.Windows.Forms.ComboBox();
            this.lsbVeredas = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalArboles = new System.Windows.Forms.TextBox();
            this.txtTotalHectareas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregarSiembra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiembras)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(93, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Siembras vigiladas por Corantioquia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vereda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Árboles:";
            // 
            // cbxArboles
            // 
            this.cbxArboles.FormattingEnabled = true;
            this.cbxArboles.Location = new System.Drawing.Point(118, 297);
            this.cbxArboles.Name = "cbxArboles";
            this.cbxArboles.Size = new System.Drawing.Size(167, 24);
            this.cbxArboles.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contratistas";
            // 
            // cbxContratistas
            // 
            this.cbxContratistas.FormattingEnabled = true;
            this.cbxContratistas.Location = new System.Drawing.Point(118, 347);
            this.cbxContratistas.Name = "cbxContratistas";
            this.cbxContratistas.Size = new System.Drawing.Size(167, 24);
            this.cbxContratistas.TabIndex = 6;
            // 
            // dgvSiembras
            // 
            this.dgvSiembras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiembras.Location = new System.Drawing.Point(6, 12);
            this.dgvSiembras.Name = "dgvSiembras";
            this.dgvSiembras.RowHeadersWidth = 51;
            this.dgvSiembras.RowTemplate.Height = 24;
            this.dgvSiembras.Size = new System.Drawing.Size(800, 300);
            this.dgvSiembras.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Municipio";
            // 
            // cbxMunicipios
            // 
            this.cbxMunicipios.FormattingEnabled = true;
            this.cbxMunicipios.Location = new System.Drawing.Point(121, 253);
            this.cbxMunicipios.Name = "cbxMunicipios";
            this.cbxMunicipios.Size = new System.Drawing.Size(164, 24);
            this.cbxMunicipios.TabIndex = 9;
            // 
            // lsbVeredas
            // 
            this.lsbVeredas.FormattingEnabled = true;
            this.lsbVeredas.ItemHeight = 16;
            this.lsbVeredas.Location = new System.Drawing.Point(118, 118);
            this.lsbVeredas.Name = "lsbVeredas";
            this.lsbVeredas.Size = new System.Drawing.Size(167, 116);
            this.lsbVeredas.TabIndex = 10;
            this.lsbVeredas.SelectedIndexChanged += new System.EventHandler(this.lsbVeredas_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(347, 106);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(857, 383);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvSiembras);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(849, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle Siembras";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFecha.Location = new System.Drawing.Point(85, 392);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha:";
            // 
            // txtTotalArboles
            // 
            this.txtTotalArboles.Location = new System.Drawing.Point(185, 440);
            this.txtTotalArboles.Name = "txtTotalArboles";
            this.txtTotalArboles.Size = new System.Drawing.Size(100, 22);
            this.txtTotalArboles.TabIndex = 14;
            // 
            // txtTotalHectareas
            // 
            this.txtTotalHectareas.Location = new System.Drawing.Point(185, 486);
            this.txtTotalHectareas.Name = "txtTotalHectareas";
            this.txtTotalHectareas.Size = new System.Drawing.Size(100, 22);
            this.txtTotalHectareas.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total Arboles:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total Hectáreas";
            // 
            // btnAgregarSiembra
            // 
            this.btnAgregarSiembra.Location = new System.Drawing.Point(85, 534);
            this.btnAgregarSiembra.Name = "btnAgregarSiembra";
            this.btnAgregarSiembra.Size = new System.Drawing.Size(139, 23);
            this.btnAgregarSiembra.TabIndex = 18;
            this.btnAgregarSiembra.Text = "Agregar Siembra";
            this.btnAgregarSiembra.UseVisualStyleBackColor = true;
            this.btnAgregarSiembra.Click += new System.EventHandler(this.btnAgregarSiembra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 569);
            this.Controls.Add(this.btnAgregarSiembra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalHectareas);
            this.Controls.Add(this.txtTotalArboles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lsbVeredas);
            this.Controls.Add(this.cbxMunicipios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxContratistas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxArboles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siembras vigiladas por Corantioquia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiembras)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxArboles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxContratistas;
        private System.Windows.Forms.DataGridView dgvSiembras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxMunicipios;
        private System.Windows.Forms.ListBox lsbVeredas;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalArboles;
        private System.Windows.Forms.TextBox txtTotalHectareas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregarSiembra;
    }
}

