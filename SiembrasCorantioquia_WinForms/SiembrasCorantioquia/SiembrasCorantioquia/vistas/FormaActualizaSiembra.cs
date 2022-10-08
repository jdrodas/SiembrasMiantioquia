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
    public partial class FormaActualizaSiembra : Form
    {
        public FormaActualizaSiembra()
        {
            InitializeComponent();
        }

        private void pbxBotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaActualizaSiembra_Load(object sender, EventArgs e)
        {
            InicializaListaInfoSiembras();
        }

        public void InicializaLstMunicipios(string nombreMunicipio)
        {
            lstMunicipios.DataSource = null;
            lstMunicipios.DataSource = AccesoDatos.ObtieneListaMunicipios();
            lstMunicipios.DisplayMember = "nombre";

            //Seleccionamos el municipio que se llama igual al de la siembra seleccionada
            int municipioSeleccionado = lstMunicipios.Items.IndexOf(nombreMunicipio);
            lstMunicipios.SelectedIndex = municipioSeleccionado;
        }

        public void InicializaLstVeredas(string nombreVereda)
        {
            lstVeredas.DataSource = null;
            lstVeredas.DataSource = AccesoDatos.ObtieneListaVeredas(lstMunicipios.SelectedItem.ToString());
            lstVeredas.DisplayMember = "nombre";

            //Seleccionamos el municipio que se llama igual al de la siembra seleccionada
            int veredaSeleccionada = lstVeredas.Items.IndexOf(nombreVereda);
            lstVeredas.SelectedIndex = veredaSeleccionada;
        }

        private void InicializaLstArboles(string nombreArbol)
        {
            lstArboles.DataSource = null;
            lstArboles.DataSource = AccesoDatos.ObtieneListaArboles();
            lstArboles.DisplayMember = "nombre";

            //Seleccionamos el arbol que se llama igual al de la siembra seleccionada
            int arbolSeleccionado = lstArboles.Items.IndexOf(nombreArbol);
            lstArboles.SelectedIndex = arbolSeleccionado;
        }

        private void InicializaLstContratistas(string nombreContratista)
        {
            lstContratistas.DataSource = null;
            lstContratistas.DataSource = AccesoDatos.ObtieneListaContratistas();
            lstContratistas.DisplayMember = "nombre";

            //Seleccionamos el arbol que se llama igual al de la siembra seleccionada
            int contratistaSeleccionado = lstContratistas.Items.IndexOf(nombreContratista);
            lstContratistas.SelectedIndex = contratistaSeleccionado;
        }

        private void InicializaListaInfoSiembras()
        {
            lstInfoSiembras.DataSource = null;
            lstInfoSiembras.DataSource = AccesoDatos.ObtieneListaInfoSiembras();
            lstInfoSiembras.DisplayMember = "infoSiembra";

            //Seleccionamos el primer municipio de la lista
            lstInfoSiembras.SelectedIndex = 0;
        }

        private void FormaActualizaSiembra_Activated(object sender, EventArgs e)
        {
            InicializaListaInfoSiembras();
        }

        private void lstInfoSiembras_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] infoSiembra = lstInfoSiembras.SelectedItem.ToString().Split('-');
            int codigo_siembra = int.Parse(infoSiembra[0].Trim());
            txtCodigoSiembra.Text = codigo_siembra.ToString();

            //Leemos la siembra asociada al codigo_obtenido
            Siembra unaSiembra = AccesoDatos.ObtenerSiembra(codigo_siembra);

            //Actualiza las listas de los atributos de la siembra
            InicializaLstMunicipios(unaSiembra.Nombre_Municipio);

            //Actualiza la lista de las veredas
            InicializaLstVeredas(unaSiembra.Nombre_Vereda);

            //Actualizamos la lista de Arboles
            InicializaLstArboles(unaSiembra.Nombre_Arbol);

            //Actualizamos la lista de Contratistas
            InicializaLstContratistas(unaSiembra.Nombre_Contratista);

            //Actualizamos total arboles, total hectáreas y Fecha de la siembra
            txtTotalArboles.Text = unaSiembra.Total_Arboles.ToString();
            txtTotalHectareas.Text = unaSiembra.Total_Hectareas.ToString();
            dtpFecha.Value = ObtieneFechaSiembra(unaSiembra.Fecha_Siembra);
        }

        private DateTime ObtieneFechaSiembra(string datoFecha)
        {
            string[] laFecha = datoFecha.Split('/');
            DateTime resultado = new DateTime(
                int.Parse(laFecha[2]),
                int.Parse(laFecha[1]),
                int.Parse(laFecha[0])
                );

            return resultado;
        }

        private void btnActualizaSiembra_Click(object sender, EventArgs e)
        {
            try
            {
                string mensajeError;
                Siembra unaSiembra = new Siembra();
                unaSiembra.Codigo_Siembra = int.Parse(txtCodigoSiembra.Text);
                unaSiembra.Total_Hectareas = double.Parse(txtTotalHectareas.Text);
                unaSiembra.Total_Arboles = int.Parse(txtTotalArboles.Text);
                unaSiembra.Fecha_Siembra = dtpFecha.Value.ToShortDateString();
                unaSiembra.Nombre_Vereda = lstVeredas.SelectedItem.ToString();
                unaSiembra.Nombre_Municipio = lstMunicipios.SelectedItem.ToString();
                unaSiembra.Nombre_Arbol = lstArboles.SelectedItem.ToString();
                unaSiembra.Nombre_Contratista = lstContratistas.SelectedItem.ToString();

                bool registroCorrecto = AccesoDatos.ActualizarSiembra(unaSiembra, out mensajeError);

                if (registroCorrecto)
                {
                    MessageBox.Show("La siembra se actualizó correctamente");

                    //Cerramos la forma
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Se presentaron problemas con la siembra. {mensajeError}",
                        "Fallo al actualizar la siembra",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (FormatException unErrorFormato)
            {
                MessageBox.Show($"Datos numéricos no tienen el formato Esperado. {unErrorFormato.Message}");
            }
        }
    }
}
