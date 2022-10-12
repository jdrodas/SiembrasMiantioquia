using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiembrasCorantioquia.vistas
{
    public partial class FormaNuevaSiembra : Form
    {
        public FormaNuevaSiembra()
        {
            InitializeComponent();
        }

        private void pbxBotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaNuevaSiembra_Load(object sender, EventArgs e)
        {
            InicializaLstMunicipios();
            InicializaLstArboles();
            InicializaLstContratistas();
        }

        public void InicializaLstMunicipios()
        {
            lstMunicipios.DataSource = null;
            lstMunicipios.DataSource = AccesoDatos.ObtieneListaMunicipios();
            lstMunicipios.DisplayMember = "nombre";

            //Seleccionamos el primer municipio de la lista
            lstMunicipios.SelectedIndex = 0;
        }


        private void InicializaLstContratistas()
        {
            lstContratistas.DataSource = null;
            lstContratistas.DataSource = AccesoDatos.ObtieneListaContratistas();
            lstContratistas.DisplayMember = "nombre";
        }

        private void InicializaLstArboles()
        {
            lstArboles.DataSource = null;
            lstArboles.DataSource = AccesoDatos.ObtieneListaArboles();
            lstArboles.DisplayMember = "nombre";
        }

        /// <summary>
        /// Actualiza la lista de Veredas
        /// </summary>
        public void ActualizaLstVeredas()
        {
            lstVeredas.DataSource = null;

            //Verificamos que haya un municipio seleccionado en lstMunicipios
            if (lstMunicipios.SelectedItems.Count != 0)
            {
                lstVeredas.DataSource = AccesoDatos.ObtieneListaVeredas(lstMunicipios.SelectedItem.ToString());
                lstVeredas.DisplayMember = "nombre";
            }
        }

        private void btnAgregarSiembra_Click(object sender, EventArgs e)
        {
            try
            {
                string mensajeError;
                Siembra unaSiembra = new Siembra();
                unaSiembra.Total_Hectareas = double.Parse(txtTotalHectareas.Text);
                unaSiembra.Total_Arboles = int.Parse(txtTotalArboles.Text);
                unaSiembra.Fecha_Siembra = dtpFecha.Value.ToShortDateString();
                unaSiembra.Nombre_Vereda = lstVeredas.SelectedItem.ToString();
                unaSiembra.Nombre_Municipio = lstMunicipios.SelectedItem.ToString();
                unaSiembra.Nombre_Arbol = lstArboles.SelectedItem.ToString();
                unaSiembra.Nombre_Contratista = lstContratistas.SelectedItem.ToString();

                bool registroCorrecto = AccesoDatos.GuardarSiembra(unaSiembra, out mensajeError);

                if (registroCorrecto)
                {
                    MessageBox.Show("La siembra se registró correctamente");

                    //Cerramos la forma
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Se presentaron problemas con la siembra. {mensajeError}",
                        "Fallo al guardar la siembra",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (FormatException unErrorFormato)
            {
                MessageBox.Show($"Datos numéricos no tienen el formato Esperado. {unErrorFormato.Message}");
            }
        }

        private void lstMunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si hay municipios seleccionados, se actualiza la lista de veredas
            if (lstMunicipios.SelectedItems.Count != 0)
            {
                ActualizaLstVeredas();
            }
            else
            {
                //De lo contrario, se borra la lista de Veredas
                lstVeredas.DataSource = null;
            }
        }
    }
}
