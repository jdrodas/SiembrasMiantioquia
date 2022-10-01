namespace SiembrasCorantioquia
{
    partial class FormaPrincipal
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelCrudSiembra = new System.Windows.Forms.Panel();
            this.btnFormaSiembras = new System.Windows.Forms.Button();
            this.btnFormaVeredas = new System.Windows.Forms.Button();
            this.btnFormaContratistas = new System.Windows.Forms.Button();
            this.pbxLogoCorantioquia = new System.Windows.Forms.PictureBox();
            this.btnFormaArboles = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.etiquetaTituloAplicacion = new System.Windows.Forms.Label();
            this.pbxBotonMinimizar = new System.Windows.Forms.PictureBox();
            this.pbxBotonCerrar = new System.Windows.Forms.PictureBox();
            this.btnFormaNuevaSiembra = new System.Windows.Forms.Button();
            this.btnFormaActualizaSiembra = new System.Windows.Forms.Button();
            this.btnFormaBorraSiembra = new System.Windows.Forms.Button();
            this.btnFormaConsultaSiembra = new System.Windows.Forms.Button();
            this.panelContenedor.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelCrudSiembra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoCorantioquia)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelContenedor.Controls.Add(this.panelFormularios);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.panelTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1050, 650);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.SystemColors.Control;
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(220, 40);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(830, 610);
            this.panelFormularios.TabIndex = 2;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Green;
            this.panelMenu.Controls.Add(this.panelCrudSiembra);
            this.panelMenu.Controls.Add(this.btnFormaSiembras);
            this.panelMenu.Controls.Add(this.btnFormaVeredas);
            this.panelMenu.Controls.Add(this.btnFormaContratistas);
            this.panelMenu.Controls.Add(this.pbxLogoCorantioquia);
            this.panelMenu.Controls.Add(this.btnFormaArboles);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 610);
            this.panelMenu.TabIndex = 1;
            // 
            // panelCrudSiembra
            // 
            this.panelCrudSiembra.BackColor = System.Drawing.Color.Green;
            this.panelCrudSiembra.Controls.Add(this.btnFormaConsultaSiembra);
            this.panelCrudSiembra.Controls.Add(this.btnFormaBorraSiembra);
            this.panelCrudSiembra.Controls.Add(this.btnFormaActualizaSiembra);
            this.panelCrudSiembra.Controls.Add(this.btnFormaNuevaSiembra);
            this.panelCrudSiembra.Location = new System.Drawing.Point(17, 350);
            this.panelCrudSiembra.Name = "panelCrudSiembra";
            this.panelCrudSiembra.Size = new System.Drawing.Size(200, 200);
            this.panelCrudSiembra.TabIndex = 5;
            this.panelCrudSiembra.Visible = false;
            // 
            // btnFormaSiembras
            // 
            this.btnFormaSiembras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(157)))), ((int)(((byte)(112)))));
            this.btnFormaSiembras.FlatAppearance.BorderSize = 0;
            this.btnFormaSiembras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormaSiembras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormaSiembras.ForeColor = System.Drawing.Color.White;
            this.btnFormaSiembras.Location = new System.Drawing.Point(10, 310);
            this.btnFormaSiembras.Name = "btnFormaSiembras";
            this.btnFormaSiembras.Size = new System.Drawing.Size(200, 40);
            this.btnFormaSiembras.TabIndex = 4;
            this.btnFormaSiembras.Text = "Siembras";
            this.btnFormaSiembras.UseVisualStyleBackColor = true;
            this.btnFormaSiembras.Click += new System.EventHandler(this.btnFormaSiembras_Click);
            // 
            // btnFormaVeredas
            // 
            this.btnFormaVeredas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(157)))), ((int)(((byte)(112)))));
            this.btnFormaVeredas.FlatAppearance.BorderSize = 0;
            this.btnFormaVeredas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormaVeredas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormaVeredas.ForeColor = System.Drawing.Color.White;
            this.btnFormaVeredas.Location = new System.Drawing.Point(10, 260);
            this.btnFormaVeredas.Name = "btnFormaVeredas";
            this.btnFormaVeredas.Size = new System.Drawing.Size(200, 40);
            this.btnFormaVeredas.TabIndex = 3;
            this.btnFormaVeredas.Text = "Veredas";
            this.btnFormaVeredas.UseVisualStyleBackColor = true;
            // 
            // btnFormaContratistas
            // 
            this.btnFormaContratistas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(157)))), ((int)(((byte)(112)))));
            this.btnFormaContratistas.FlatAppearance.BorderSize = 0;
            this.btnFormaContratistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormaContratistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormaContratistas.ForeColor = System.Drawing.Color.White;
            this.btnFormaContratistas.Location = new System.Drawing.Point(10, 210);
            this.btnFormaContratistas.Name = "btnFormaContratistas";
            this.btnFormaContratistas.Size = new System.Drawing.Size(200, 40);
            this.btnFormaContratistas.TabIndex = 2;
            this.btnFormaContratistas.Text = "Contratistas";
            this.btnFormaContratistas.UseVisualStyleBackColor = true;
            this.btnFormaContratistas.Click += new System.EventHandler(this.btnFormaContratistas_Click);
            // 
            // pbxLogoCorantioquia
            // 
            this.pbxLogoCorantioquia.Image = global::SiembrasCorantioquia.Properties.Resources.logo_corantioquia;
            this.pbxLogoCorantioquia.Location = new System.Drawing.Point(30, 18);
            this.pbxLogoCorantioquia.Name = "pbxLogoCorantioquia";
            this.pbxLogoCorantioquia.Size = new System.Drawing.Size(151, 112);
            this.pbxLogoCorantioquia.TabIndex = 1;
            this.pbxLogoCorantioquia.TabStop = false;
            // 
            // btnFormaArboles
            // 
            this.btnFormaArboles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(157)))), ((int)(((byte)(112)))));
            this.btnFormaArboles.FlatAppearance.BorderSize = 0;
            this.btnFormaArboles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormaArboles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormaArboles.ForeColor = System.Drawing.Color.White;
            this.btnFormaArboles.Location = new System.Drawing.Point(10, 160);
            this.btnFormaArboles.Name = "btnFormaArboles";
            this.btnFormaArboles.Size = new System.Drawing.Size(200, 40);
            this.btnFormaArboles.TabIndex = 0;
            this.btnFormaArboles.Text = "Arboles";
            this.btnFormaArboles.UseVisualStyleBackColor = false;
            this.btnFormaArboles.Click += new System.EventHandler(this.btnFormaArboles_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(63)))));
            this.panelTitulo.Controls.Add(this.etiquetaTituloAplicacion);
            this.panelTitulo.Controls.Add(this.pbxBotonMinimizar);
            this.panelTitulo.Controls.Add(this.pbxBotonCerrar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1050, 40);
            this.panelTitulo.TabIndex = 0;
            this.panelTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseMove);
            // 
            // etiquetaTituloAplicacion
            // 
            this.etiquetaTituloAplicacion.AutoSize = true;
            this.etiquetaTituloAplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaTituloAplicacion.ForeColor = System.Drawing.Color.White;
            this.etiquetaTituloAplicacion.Location = new System.Drawing.Point(236, 4);
            this.etiquetaTituloAplicacion.Name = "etiquetaTituloAplicacion";
            this.etiquetaTituloAplicacion.Size = new System.Drawing.Size(536, 31);
            this.etiquetaTituloAplicacion.TabIndex = 2;
            this.etiquetaTituloAplicacion.Text = "Siembras de Reforestación en Antioquia";
            // 
            // pbxBotonMinimizar
            // 
            this.pbxBotonMinimizar.Image = global::SiembrasCorantioquia.Properties.Resources.minimizar;
            this.pbxBotonMinimizar.Location = new System.Drawing.Point(1000, 12);
            this.pbxBotonMinimizar.Name = "pbxBotonMinimizar";
            this.pbxBotonMinimizar.Size = new System.Drawing.Size(16, 16);
            this.pbxBotonMinimizar.TabIndex = 1;
            this.pbxBotonMinimizar.TabStop = false;
            this.pbxBotonMinimizar.Click += new System.EventHandler(this.pbxBotonMinimizar_Click);
            // 
            // pbxBotonCerrar
            // 
            this.pbxBotonCerrar.Image = global::SiembrasCorantioquia.Properties.Resources.cerrar;
            this.pbxBotonCerrar.Location = new System.Drawing.Point(1020, 12);
            this.pbxBotonCerrar.Name = "pbxBotonCerrar";
            this.pbxBotonCerrar.Size = new System.Drawing.Size(16, 16);
            this.pbxBotonCerrar.TabIndex = 0;
            this.pbxBotonCerrar.TabStop = false;
            this.pbxBotonCerrar.Click += new System.EventHandler(this.pbxBotonCerrar_Click);
            // 
            // btnFormaNuevaSiembra
            // 
            this.btnFormaNuevaSiembra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(157)))), ((int)(((byte)(112)))));
            this.btnFormaNuevaSiembra.FlatAppearance.BorderSize = 0;
            this.btnFormaNuevaSiembra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormaNuevaSiembra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormaNuevaSiembra.ForeColor = System.Drawing.Color.White;
            this.btnFormaNuevaSiembra.Location = new System.Drawing.Point(0, 10);
            this.btnFormaNuevaSiembra.Name = "btnFormaNuevaSiembra";
            this.btnFormaNuevaSiembra.Size = new System.Drawing.Size(200, 40);
            this.btnFormaNuevaSiembra.TabIndex = 5;
            this.btnFormaNuevaSiembra.Text = "Nueva Siembra";
            this.btnFormaNuevaSiembra.UseVisualStyleBackColor = true;
            // 
            // btnFormaActualizaSiembra
            // 
            this.btnFormaActualizaSiembra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(157)))), ((int)(((byte)(112)))));
            this.btnFormaActualizaSiembra.FlatAppearance.BorderSize = 0;
            this.btnFormaActualizaSiembra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormaActualizaSiembra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormaActualizaSiembra.ForeColor = System.Drawing.Color.White;
            this.btnFormaActualizaSiembra.Location = new System.Drawing.Point(0, 55);
            this.btnFormaActualizaSiembra.Name = "btnFormaActualizaSiembra";
            this.btnFormaActualizaSiembra.Size = new System.Drawing.Size(200, 40);
            this.btnFormaActualizaSiembra.TabIndex = 6;
            this.btnFormaActualizaSiembra.Text = "Actualiza Siembra";
            this.btnFormaActualizaSiembra.UseVisualStyleBackColor = true;
            // 
            // btnFormaBorraSiembra
            // 
            this.btnFormaBorraSiembra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(157)))), ((int)(((byte)(112)))));
            this.btnFormaBorraSiembra.FlatAppearance.BorderSize = 0;
            this.btnFormaBorraSiembra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormaBorraSiembra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormaBorraSiembra.ForeColor = System.Drawing.Color.White;
            this.btnFormaBorraSiembra.Location = new System.Drawing.Point(3, 101);
            this.btnFormaBorraSiembra.Name = "btnFormaBorraSiembra";
            this.btnFormaBorraSiembra.Size = new System.Drawing.Size(200, 40);
            this.btnFormaBorraSiembra.TabIndex = 7;
            this.btnFormaBorraSiembra.Text = "Elimina Siembra";
            this.btnFormaBorraSiembra.UseVisualStyleBackColor = true;
            // 
            // btnFormaConsultaSiembra
            // 
            this.btnFormaConsultaSiembra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(157)))), ((int)(((byte)(112)))));
            this.btnFormaConsultaSiembra.FlatAppearance.BorderSize = 0;
            this.btnFormaConsultaSiembra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormaConsultaSiembra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormaConsultaSiembra.ForeColor = System.Drawing.Color.White;
            this.btnFormaConsultaSiembra.Location = new System.Drawing.Point(3, 147);
            this.btnFormaConsultaSiembra.Name = "btnFormaConsultaSiembra";
            this.btnFormaConsultaSiembra.Size = new System.Drawing.Size(200, 40);
            this.btnFormaConsultaSiembra.TabIndex = 8;
            this.btnFormaConsultaSiembra.Text = "Reportes Siembras";
            this.btnFormaConsultaSiembra.UseVisualStyleBackColor = true;
            // 
            // FormaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1050, 650);
            this.MinimumSize = new System.Drawing.Size(1050, 650);
            this.Name = "FormaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siembras Corantioquia";
            this.panelContenedor.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelCrudSiembra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoCorantioquia)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotonCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.PictureBox pbxBotonCerrar;
        private System.Windows.Forms.PictureBox pbxBotonMinimizar;
        private System.Windows.Forms.Button btnFormaArboles;
        private System.Windows.Forms.PictureBox pbxLogoCorantioquia;
        private System.Windows.Forms.Label etiquetaTituloAplicacion;
        private System.Windows.Forms.Button btnFormaSiembras;
        private System.Windows.Forms.Button btnFormaVeredas;
        private System.Windows.Forms.Button btnFormaContratistas;
        private System.Windows.Forms.Panel panelCrudSiembra;
        private System.Windows.Forms.Button btnFormaNuevaSiembra;
        private System.Windows.Forms.Button btnFormaConsultaSiembra;
        private System.Windows.Forms.Button btnFormaBorraSiembra;
        private System.Windows.Forms.Button btnFormaActualizaSiembra;
    }
}

