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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiembras)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(70, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Siembras vigiladas por Corantioquia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vereda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Árboles:";
            // 
            // cbxArboles
            // 
            this.cbxArboles.FormattingEnabled = true;
            this.cbxArboles.Location = new System.Drawing.Point(88, 241);
            this.cbxArboles.Margin = new System.Windows.Forms.Padding(2);
            this.cbxArboles.Name = "cbxArboles";
            this.cbxArboles.Size = new System.Drawing.Size(126, 21);
            this.cbxArboles.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contratistas";
            // 
            // cbxContratistas
            // 
            this.cbxContratistas.FormattingEnabled = true;
            this.cbxContratistas.Location = new System.Drawing.Point(88, 282);
            this.cbxContratistas.Margin = new System.Windows.Forms.Padding(2);
            this.cbxContratistas.Name = "cbxContratistas";
            this.cbxContratistas.Size = new System.Drawing.Size(126, 21);
            this.cbxContratistas.TabIndex = 6;
            // 
            // dgvSiembras
            // 
            this.dgvSiembras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiembras.Location = new System.Drawing.Point(4, 10);
            this.dgvSiembras.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSiembras.Name = "dgvSiembras";
            this.dgvSiembras.RowHeadersWidth = 51;
            this.dgvSiembras.RowTemplate.Height = 24;
            this.dgvSiembras.Size = new System.Drawing.Size(600, 244);
            this.dgvSiembras.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Municipio";
            // 
            // cbxMunicipios
            // 
            this.cbxMunicipios.FormattingEnabled = true;
            this.cbxMunicipios.Location = new System.Drawing.Point(91, 206);
            this.cbxMunicipios.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMunicipios.Name = "cbxMunicipios";
            this.cbxMunicipios.Size = new System.Drawing.Size(124, 21);
            this.cbxMunicipios.TabIndex = 9;
            // 
            // lsbVeredas
            // 
            this.lsbVeredas.FormattingEnabled = true;
            this.lsbVeredas.Location = new System.Drawing.Point(88, 96);
            this.lsbVeredas.Margin = new System.Windows.Forms.Padding(2);
            this.lsbVeredas.Name = "lsbVeredas";
            this.lsbVeredas.Size = new System.Drawing.Size(126, 95);
            this.lsbVeredas.TabIndex = 10;
            this.lsbVeredas.SelectedIndexChanged += new System.EventHandler(this.lsbVeredas_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(259, 129);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(643, 311);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvSiembras);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(635, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle Siembras";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFecha.Location = new System.Drawing.Point(64, 318);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(151, 20);
            this.dtpFecha.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 323);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha:";
            // 
            // txtTotalArboles
            // 
            this.txtTotalArboles.Location = new System.Drawing.Point(139, 358);
            this.txtTotalArboles.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalArboles.Name = "txtTotalArboles";
            this.txtTotalArboles.Size = new System.Drawing.Size(76, 20);
            this.txtTotalArboles.TabIndex = 14;
            // 
            // txtTotalHectareas
            // 
            this.txtTotalHectareas.Location = new System.Drawing.Point(139, 395);
            this.txtTotalHectareas.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalHectareas.Name = "txtTotalHectareas";
            this.txtTotalHectareas.Size = new System.Drawing.Size(76, 20);
            this.txtTotalHectareas.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 360);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total Arboles:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 400);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total Hectáreas";
            // 
            // btnAgregarSiembra
            // 
            this.btnAgregarSiembra.Location = new System.Drawing.Point(64, 434);
            this.btnAgregarSiembra.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarSiembra.Name = "btnAgregarSiembra";
            this.btnAgregarSiembra.Size = new System.Drawing.Size(104, 19);
            this.btnAgregarSiembra.TabIndex = 18;
            this.btnAgregarSiembra.Text = "Agregar Siembra";
            this.btnAgregarSiembra.UseVisualStyleBackColor = true;
            this.btnAgregarSiembra.Click += new System.EventHandler(this.btnAgregarSiembra_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SiembrasCorantioquia.Properties.Resources.logo_corantioquia;
            this.pictureBox1.Location = new System.Drawing.Point(656, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 111);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 517);
            this.Controls.Add(this.pictureBox1);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siembras vigiladas por Corantioquia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiembras)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

