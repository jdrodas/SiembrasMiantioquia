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
            this.cbxVeredas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxArboles = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxContratistas = new System.Windows.Forms.ComboBox();
            this.dgvSiembras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiembras)).BeginInit();
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
            // cbxVeredas
            // 
            this.cbxVeredas.FormattingEnabled = true;
            this.cbxVeredas.Location = new System.Drawing.Point(101, 115);
            this.cbxVeredas.Name = "cbxVeredas";
            this.cbxVeredas.Size = new System.Drawing.Size(167, 24);
            this.cbxVeredas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vereda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Árboles:";
            // 
            // cbxArboles
            // 
            this.cbxArboles.FormattingEnabled = true;
            this.cbxArboles.Location = new System.Drawing.Point(101, 166);
            this.cbxArboles.Name = "cbxArboles";
            this.cbxArboles.Size = new System.Drawing.Size(167, 24);
            this.cbxArboles.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contratistas";
            // 
            // cbxContratistas
            // 
            this.cbxContratistas.FormattingEnabled = true;
            this.cbxContratistas.Location = new System.Drawing.Point(101, 216);
            this.cbxContratistas.Name = "cbxContratistas";
            this.cbxContratistas.Size = new System.Drawing.Size(167, 24);
            this.cbxContratistas.TabIndex = 6;
            // 
            // dgvSiembras
            // 
            this.dgvSiembras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiembras.Location = new System.Drawing.Point(313, 115);
            this.dgvSiembras.Name = "dgvSiembras";
            this.dgvSiembras.RowHeadersWidth = 51;
            this.dgvSiembras.RowTemplate.Height = 24;
            this.dgvSiembras.Size = new System.Drawing.Size(710, 247);
            this.dgvSiembras.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 501);
            this.Controls.Add(this.dgvSiembras);
            this.Controls.Add(this.cbxContratistas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxArboles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxVeredas);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siembras vigiladas por Corantioquia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiembras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxVeredas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxArboles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxContratistas;
        private System.Windows.Forms.DataGridView dgvSiembras;
    }
}

