namespace SiembrasCorantioquia.vistas
{
    partial class FormaBorraSiembra
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
            this.pbxBotonCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoSiembra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstInfoSiembras = new System.Windows.Forms.ListBox();
            this.btnBorraSiembra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Text = "Borrar Siembra existente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigoSiembra
            // 
            this.txtCodigoSiembra.BackColor = System.Drawing.Color.Azure;
            this.txtCodigoSiembra.Enabled = false;
            this.txtCodigoSiembra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoSiembra.Location = new System.Drawing.Point(590, 176);
            this.txtCodigoSiembra.Name = "txtCodigoSiembra";
            this.txtCodigoSiembra.Size = new System.Drawing.Size(100, 30);
            this.txtCodigoSiembra.TabIndex = 57;
            this.txtCodigoSiembra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(309, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(275, 25);
            this.label10.TabIndex = 56;
            this.label10.Text = "Código siembra seleccionada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 55;
            this.label2.Text = "Siembra:";
            // 
            // lstInfoSiembras
            // 
            this.lstInfoSiembras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInfoSiembras.FormattingEnabled = true;
            this.lstInfoSiembras.ItemHeight = 25;
            this.lstInfoSiembras.Location = new System.Drawing.Point(190, 74);
            this.lstInfoSiembras.Name = "lstInfoSiembras";
            this.lstInfoSiembras.Size = new System.Drawing.Size(834, 79);
            this.lstInfoSiembras.TabIndex = 54;
            this.lstInfoSiembras.SelectedIndexChanged += new System.EventHandler(this.lstInfoSiembras_SelectedIndexChanged);
            // 
            // btnBorraSiembra
            // 
            this.btnBorraSiembra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(236)))), ((int)(((byte)(191)))));
            this.btnBorraSiembra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorraSiembra.Location = new System.Drawing.Point(415, 347);
            this.btnBorraSiembra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorraSiembra.Name = "btnBorraSiembra";
            this.btnBorraSiembra.Size = new System.Drawing.Size(298, 40);
            this.btnBorraSiembra.TabIndex = 59;
            this.btnBorraSiembra.Text = "Borrar esta siembra";
            this.btnBorraSiembra.UseVisualStyleBackColor = false;
            this.btnBorraSiembra.Click += new System.EventHandler(this.btnBorraSiembra_Click);
            // 
            // FormaBorraSiembra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 704);
            this.Controls.Add(this.btnBorraSiembra);
            this.Controls.Add(this.txtCodigoSiembra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstInfoSiembras);
            this.Controls.Add(this.pbxBotonCerrar);
            this.Controls.Add(this.label1);
            this.Name = "FormaBorraSiembra";
            this.Text = "FormaBorraSiembra";
            this.Load += new System.EventHandler(this.FormaBorraSiembra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBotonCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoSiembra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstInfoSiembras;
        private System.Windows.Forms.Button btnBorraSiembra;
    }
}