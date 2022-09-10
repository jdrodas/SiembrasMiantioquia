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
            ActualizaComboBoxVeredas();
        }

        private void ActualizaComboBoxVeredas()
        {
            cbxVeredas.DataSource = null;
            cbxVeredas.DataSource = AccesoDatos.ObtenerVeredasMunicipios();
            cbxVeredas.DisplayMember = "nombre";
        }
    }
}
