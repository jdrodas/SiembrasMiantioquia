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
            ActualizaLsbVeredas();
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

        public void ActualizaLsbVeredas()
        {
            lsbVeredas.DataSource = null;
            lsbVeredas.DataSource = AccesoDatos.ObtenerNombreVeredas();
            lsbVeredas.DisplayMember = "nombre";
        }

        private void lsbVeredas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbVeredas.SelectedItem.ToString() != "")
            {
                cbxMunicipios.DataSource = null;
                cbxMunicipios.DataSource = AccesoDatos.ObtieneMunicipios(lsbVeredas.SelectedItem.ToString());
                cbxMunicipios.DisplayMember = "nombre";
            }
        }

        private void btnAgregarSiembra_Click(object sender, EventArgs e)
        {
            //Pasos
            /*
            OK! - Crear un objeto siembra con la información de la UI
            OK! - Invocar el método en la capa de acceso a datos para guardar la siembra
            OK! - crear el método para guardar la siembra
            - actualizar el DataGridView con la información desde la DB
            */

            try
            {
                Siembra unaSiembra = new Siembra();
                unaSiembra.Total_Hectareas = double.Parse(txtTotalHectareas.Text);
                unaSiembra.Total_Arboles = int.Parse(txtTotalArboles.Text);
                unaSiembra.Fecha_Siembra = dtpFecha.Value.ToString();
                unaSiembra.Nombre_Vereda = lsbVeredas.SelectedItem.ToString();
                unaSiembra.Nombre_Municipio = cbxMunicipios.SelectedItem.ToString();
                unaSiembra.Nombre_Arbol = cbxArboles.SelectedItem.ToString();
                unaSiembra.Nombre_Contratista = cbxContratistas.SelectedItem.ToString();

                bool registroCorrecto = AccesoDatos.GuardarSiembra(unaSiembra);

                if (registroCorrecto)
                {
                    MessageBox.Show("La siembra se registró correctamente");
                    InicializaDgvSiembrasDetalleSiembras();
                }
                else
                {
                    MessageBox.Show("Se presentaron problemas con la siembra. Intenta nuevamente!");
                }
            }
            catch (FormatException unErrorFormato)
            {
                MessageBox.Show($"Datos numéricos no tienen el formato Esperado. {unErrorFormato.Message}");
            }



        }
    }
}
