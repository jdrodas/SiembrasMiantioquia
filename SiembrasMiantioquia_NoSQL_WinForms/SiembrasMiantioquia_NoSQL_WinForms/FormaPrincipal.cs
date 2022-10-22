/*
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

namespace SiembrasMiantioquia_NoSQL_WinForms
{
    public partial class FormaPrincipal : Form
    {
        public FormaPrincipal()
        {
            InitializeComponent();
            OcultaPanelesCrud();

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

        private void OcultaPanelesCrud()
        {
            Panel[] panelesCrud =   
                { 
                    panelCrudArboles, 
                    panelCrudContratistas, 
                    panelCrudVeredas, 
                    panelCrudSiembras 
                };

            foreach(Panel unPanel in panelesCrud)
                unPanel.Visible = false;

            Button[] botonesCrud =
                {
                    btnFormaArboles,
                    btnFormaContratistas,
                    btnFormaVeredas,
                    btnFormaSiembras
                };

            foreach (Button unBoton in botonesCrud)
            {
                unBoton.BackColor = Color.FromArgb(144, 157, 112);
                unBoton.ForeColor = Color.White;
            }
        }

        private void VisualizaPanelCrud(Panel elPanel, Button botonCrud)
        {
            if (!elPanel.Visible)
            {
                OcultaPanelesCrud();
                elPanel.Visible = true;
                botonCrud.BackColor = Color.FromArgb(216, 236, 191);
                botonCrud.ForeColor = Color.Black;
            }
            else
            {
                elPanel.Visible = false;
                botonCrud.BackColor = Color.FromArgb(144, 157, 112);
                botonCrud.ForeColor = Color.White;
            }

        }

        private void CerrarFormulario(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FormaReporteSiembras"] == null)
            {
                btnFormaReporteSiembras.BackColor = Color.FromArgb(144, 157, 112);
                btnFormaReporteSiembras.ForeColor = Color.White;
            }

            if (Application.OpenForms["FormaReporteVereda"] == null)
            {
                btnFormaReporteVereda.BackColor = Color.FromArgb(144, 157, 112);
                btnFormaReporteVereda.ForeColor = Color.White;
            }

            if (Application.OpenForms["FormaInsertaSiembra"] == null)
            {
                btnFormaNuevaSiembra.BackColor = Color.FromArgb(144, 157, 112);
                btnFormaNuevaSiembra.ForeColor = Color.White;
            }

            if (Application.OpenForms["FormaActualizaSiembra"] == null)
            {
                btnFormaActualizaSiembra.BackColor = Color.FromArgb(144, 157, 112);
                btnFormaActualizaSiembra.ForeColor = Color.White;
            }

            if (Application.OpenForms["FormaBorraSiembra"] == null)
            {
                btnFormaBorraSiembra.BackColor = Color.FromArgb(144, 157, 112);
                btnFormaBorraSiembra.ForeColor = Color.White;
            }
        }

        #endregion

        private void btnFormaSiembras_Click(object sender, EventArgs e)
        {
            VisualizaPanelCrud(panelCrudSiembras, btnFormaSiembras);
        }

        private void btnFormaArboles_Click(object sender, EventArgs e)
        {
            VisualizaPanelCrud(panelCrudArboles, btnFormaArboles);
        }

        private void btnFormaContratistas_Click(object sender, EventArgs e)
        {
            VisualizaPanelCrud(panelCrudContratistas, btnFormaContratistas);
        }

        private void btnFormaVeredas_Click(object sender, EventArgs e)
        {
            VisualizaPanelCrud(panelCrudVeredas, btnFormaVeredas);
        }

        private void btnFormaNuevaSiembra_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormaNuevaSiembra>();
            btnFormaNuevaSiembra.BackColor = Color.FromArgb(216, 236, 191);
            btnFormaNuevaSiembra.ForeColor = Color.Black;
        }

        private void btnFormaReporteSiembras_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormaReporteSiembras>();
            btnFormaReporteSiembras.BackColor = Color.FromArgb(216, 236, 191);
            btnFormaReporteSiembras.ForeColor = Color.Black;
        }

        private void btnFormaActualizaSiembra_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<FormaActualizaSiembra>();
            //btnFormaActualizaSiembra.BackColor = Color.FromArgb(216, 236, 191);
            //btnFormaActualizaSiembra.ForeColor = Color.Black;
        }

        private void btnFormaBorraSiembra_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<FormaBorraSiembra>();
            //btnFormaBorraSiembra.BackColor = Color.FromArgb(216, 236, 191);
            //btnFormaBorraSiembra.ForeColor = Color.Black;
        }

        private void btnFormaReporteVereda_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<FormaReporteVereda>();
            //btnFormaReporteSiembras.BackColor = Color.FromArgb(216, 236, 191);
            //btnFormaReporteSiembras.ForeColor = Color.Black;
        }
    }
}
