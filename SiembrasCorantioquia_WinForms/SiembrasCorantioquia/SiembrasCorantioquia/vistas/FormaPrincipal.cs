﻿/*
Codigo adaptado del proyecto presentado en https://www.youtube.com/watch?v=Z7TfV7LZzp4
https://rjcodeadvance.com/interfaz-grafico-de-usuario-modernista-multi-window-con-c-version-completa/
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace SiembrasCorantioquia
{
    public partial class FormaPrincipal : Form
    {
        public FormaPrincipal()
        {
            InitializeComponent();

            //Reduce el "flickering"
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        #region Funcionalidad para implementar el arrastre de la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void pbxBotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxBotonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region Funcionalidad para manipular formularios dentro del panel

        private void AbrirFormulario<unFormulario>() where unFormulario : Form, new()
        {
            Form formulario;
            //Busca en la colecion el formulario
            formulario = panelFormularios.Controls.OfType<unFormulario>().FirstOrDefault();
            
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new unFormulario();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CerrarFormulario);
            }
            else
            {
                //si el formulario/instancia existe
                formulario.BringToFront();
            }
        }

        private void CerrarFormulario(object sender, FormClosedEventArgs e)
        {

            if (Application.OpenForms["FormaArboles"] == null)
            {
                btnFormaArboles.BackColor = Color.FromArgb(144, 157, 112);
                btnFormaArboles.ForeColor = Color.White;
            }

            if (Application.OpenForms["FormaContratistas"] == null)
            {
                btnFormaContratistas.BackColor = Color.FromArgb(144, 157, 112);
                btnFormaContratistas.ForeColor = Color.White;
            }

            if (Application.OpenForms["FormaReporteSiembras"] == null)
            {
                btnFormaConsultaSiembra.BackColor = Color.FromArgb(144, 157, 112);
                btnFormaConsultaSiembra.ForeColor = Color.White;
            }

            if (Application.OpenForms["FormaInsertaSiembra"] == null)
            {
                btnFormaNuevaSiembra.BackColor = Color.FromArgb(144, 157, 112);
                btnFormaNuevaSiembra.ForeColor = Color.White;
            }


            


            //if (Application.OpenForms["Form2"] == null)
            //    button2.BackColor = Color.FromArgb(4, 41, 68);
            //if (Application.OpenForms["Form3"] == null)
            //    button3.BackColor = Color.FromArgb(4, 41, 68);
        }

        #endregion

        private void btnFormaArboles_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormaArboles>();
            btnFormaArboles.BackColor = Color.FromArgb(216, 236, 191);
            btnFormaArboles.ForeColor = Color.Black;
        }

        private void btnFormaContratistas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormaContratistas>();
            btnFormaContratistas.BackColor = Color.FromArgb(216, 236, 191);
            btnFormaContratistas.ForeColor = Color.Black;   
        }

        private void btnFormaSiembras_Click(object sender, EventArgs e)
        {
            if (panelCrudSiembra.Visible)
            {
                panelCrudSiembra.Visible = false;
                btnFormaSiembras.BackColor = Color.FromArgb(144, 157, 112);
                btnFormaSiembras.ForeColor = Color.White;
            }
            else
            {
                panelCrudSiembra.Visible = true;
                btnFormaSiembras.BackColor = Color.FromArgb(216, 236, 191);
                btnFormaSiembras.ForeColor = Color.Black;
            }
        }

        private void btnFormaConsultaSiembra_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormaReporteSiembras>();
            btnFormaConsultaSiembra.BackColor = Color.FromArgb(216, 236, 191);
            btnFormaConsultaSiembra.ForeColor = Color.Black;
        }

        private void btnFormaNuevaSiembra_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormaInsertaSiembra>();
            btnFormaNuevaSiembra.BackColor = Color.FromArgb(216, 236, 191);
            btnFormaNuevaSiembra.ForeColor = Color.Black;
        }
    }
}