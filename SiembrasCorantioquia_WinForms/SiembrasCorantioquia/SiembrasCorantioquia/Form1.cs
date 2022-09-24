using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiembrasCorantioquia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento a ejecutar cuando se carga la forma
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizaCbxVeredas();
            ActualizaCbxArboles();
            ActualizaCbxContratistas();
            InicializaDgvSiembrasDetalleSiembras();
        }

        private void InicializaDgvSiembrasDetalleSiembras()
        {
            dgvSiembras.DataSource = null;
            dgvSiembras.DataSource = AccesoDatos.ObtenerDetalleSiembras();
        }

        private void ActualizaCbxContratistas()
        {
            cbxContratistas.DataSource = null;
            cbxContratistas.DataSource = AccesoDatos.ObtenerNombresContratistas();
            cbxContratistas.DisplayMember = "nombre";
        }

        private void ActualizaCbxArboles()
        {
            cbxArboles.DataSource = null;
            cbxArboles.DataSource = AccesoDatos.ObtenerNombresArboles();
            cbxArboles.DisplayMember = "nombre";
        }

        private void ActualizaCbxVeredas()
        {
            cbxVeredas.DataSource = null;
            cbxVeredas.DataSource = AccesoDatos.ObtenerVeredasMunicipios();
            cbxVeredas.DisplayMember = "nombre";
        }
    }
}
