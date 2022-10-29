using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SiembrasMiantioquia_NoSQL_WinForms
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
            InicializaLstInfoSiembras();
        }

        private void FormaActualizaSiembra_Activated(object sender, EventArgs e)
        {
            InicializaLstInfoSiembras();
        }

        /// <summary>
        /// Inicializa la lista que contiene la información resumida de la siembras
        /// </summary>
        public void InicializaLstInfoSiembras()
        {
            lstInfoSiembras.DataSource = null;
            lstInfoSiembras.DataSource = AccesoDatos.ObtieneListaInfoSiembras();
            lstInfoSiembras.DisplayMember = "infoSiembra";

            //Seleccionamos el primer municipio de la lista
            lstInfoSiembras.SelectedIndex = 0;
        }

        private void lstInfoSiembras_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtenemos el código de la siembra
            string[] infoSiembra = lstInfoSiembras.SelectedItem.ToString().Split('-');
            int codigo_siembra = int.Parse(infoSiembra[0].Trim());
            txtCodigoSiembra.Text = codigo_siembra.ToString();

            //Leemos desde la DB, la siembra asociada al codigo_obtenido
            Siembra unaSiembra = AccesoDatos.ObtieneSiembra(codigo_siembra);

            //Actualizamos las listas asignando como item seleccionado
            //el valor correspondiente de la siembra

            //Actualiza las listas de los atributos de la siembra
            InicializaLstMunicipios(unaSiembra.Municipio);

            //Actualiza la lista de las veredas
            InicializaLstVeredas(unaSiembra.Vereda);

            //Actualizamos la lista de Arboles
            InicializaLstArboles(unaSiembra.Arbol);

            //Actualizamos la lista de Contratistas
            InicializaLstContratistas(unaSiembra.Contratista);

            //Actualizamos total arboles, total hectáreas y Fecha de la siembra
            txtTotalArboles.Text = unaSiembra.Total_Arboles.ToString();
            txtTotalHectareas.Text = unaSiembra.Total_Hectareas.ToString();
            dtpFecha.Value = unaSiembra.Fecha;
        }

        /// <summary>
        /// Inicializa la lista de los municipios
        /// </summary>
        /// <param name="nombreMunicipio">el municipio que se espera sea seleccionado</param>
        public void InicializaLstMunicipios(string nombreMunicipio)
        {
            lstMunicipios.DataSource = null;
            lstMunicipios.DataSource = AccesoDatos.ObtieneListaNombreMunicipios();
            lstMunicipios.DisplayMember = "nombre";

            //Seleccionamos el municipio que se llama igual al de la siembra seleccionada
            if (string.IsNullOrEmpty(nombreMunicipio))
                lstMunicipios.SelectedIndex = 0;
            else
                lstMunicipios.SelectedIndex = lstMunicipios.Items.IndexOf(nombreMunicipio);
        }

        /// <summary>
        /// Inicializa la lista de los veredas
        /// </summary>
        /// <param name="nombreVereda">la vereda que se espera sea seleccionada</param>
        public void InicializaLstVeredas(string nombreVereda)
        {
            lstVeredas.DataSource = null;
            lstVeredas.DataSource = AccesoDatos.ObtieneListaNombresVeredasMunicipio(lstMunicipios.SelectedItem.ToString());
            lstVeredas.DisplayMember = "nombre";

            //Seleccionamos la vereda que se llama igual al de la siembra seleccionada
            if (string.IsNullOrEmpty(nombreVereda))
                lstVeredas.SelectedIndex = 0;
            else
                lstVeredas.SelectedIndex = lstVeredas.Items.IndexOf(nombreVereda);
        }

        /// <summary>
        /// Inicializa la lista de los arboles
        /// </summary>
        /// <param name="nombreArbol">El arbol que se espera sea seleccionado</param>
        private void InicializaLstArboles(string nombreArbol)
        {
            lstArboles.DataSource = null;
            lstArboles.DataSource = AccesoDatos.ObtieneListaNombreArboles();
            lstArboles.DisplayMember = "nombre";

            //Seleccionamos el arbol que se llama igual al de la siembra seleccionada
            if (string.IsNullOrEmpty(nombreArbol))
                lstArboles.SelectedIndex = 0;
            else
                lstArboles.SelectedIndex = lstArboles.Items.IndexOf(nombreArbol);
        }

        /// <summary>
        /// Inicializa la lista de contratista
        /// </summary>
        /// <param name="nombreContratista">El contratista que se espera sea seleccionado</param>
        private void InicializaLstContratistas(string nombreContratista)
        {
            lstContratistas.DataSource = null;
            lstContratistas.DataSource = AccesoDatos.ObtieneListaNombreContratistas();
            lstContratistas.DisplayMember = "nombre";

            //Seleccionamos el arbol que se llama igual al de la siembra seleccionada
            if (string.IsNullOrEmpty(nombreContratista))
                lstContratistas.SelectedIndex = 0;
            else
                lstContratistas.SelectedIndex = lstContratistas.Items.IndexOf(nombreContratista);
        }

        /// <summary>
        /// Obtiene objeto tipo fecha a partir de su representación como cadena corta
        /// </summary>
        /// <param name="datoFecha">La fecha en formato cadena corta</param>
        /// <returns></returns>
        private bool ObtieneFechaSiembra(string datoFecha, out DateTime fechaResultado, out string mensajeError)
        {
            bool resultadoConversion = false;
            try
            {
                string[] laFecha = datoFecha.Split('/');
                fechaResultado = new DateTime(
                    int.Parse(laFecha[2]),
                    int.Parse(laFecha[1]),
                    int.Parse(laFecha[0])
                    );
                resultadoConversion = true;
                mensajeError = "";
            }
            catch(ArgumentOutOfRangeException error)
            { 
                resultadoConversion=false;
                mensajeError = error.Message;
                fechaResultado = DateTime.Now;
            }

            return resultadoConversion;
        }

        private void btnActualizaSiembra_Click(object sender, EventArgs e)
        {
            try
            {
                Siembra unaSiembra = new Siembra();
                unaSiembra.Codigo = int.Parse(txtCodigoSiembra.Text);
                unaSiembra.Total_Hectareas = double.Parse(txtTotalHectareas.Text);
                unaSiembra.Total_Arboles = int.Parse(txtTotalArboles.Text);
                unaSiembra.Fecha = dtpFecha.Value;
                unaSiembra.Vereda = lstVeredas.SelectedItem.ToString();
                unaSiembra.Municipio = lstMunicipios.SelectedItem.ToString();
                unaSiembra.Arbol = lstArboles.SelectedItem.ToString();
                unaSiembra.Contratista = lstContratistas.SelectedItem.ToString();

                AccesoDatos.ActualizaSiembra(unaSiembra);

                MessageBox.Show("La siembra se actualizó correctamente",
                    "Actualización exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //Aqui actualizamos las formas de las siembras, si se encuentran abiertas
                RefrescaFormasSiembras();

                //Cerramos la forma
                this.Close();

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
                ActualizaLstVeredas("");
            else
                //De lo contrario, se borra la lista de Veredas
                lstVeredas.DataSource = null;
        }

        /// <summary>
        /// Actualiza la lista de Veredas
        /// </summary>
        public void ActualizaLstVeredas(string veredaSeleccionada)
        {
            lstVeredas.DataSource = null;

            //Verificamos que haya un municipio seleccionado en lstMunicipios
            //Si no hay ninguno seleccionado, seleccionamos la primera vereda
            if (lstMunicipios.SelectedItems.Count == 0)
                lstMunicipios.SelectedIndex = 0;
            {
                List<Vereda> lasVeredasDelMunicipio = AccesoDatos.ObtieneListaVeredasMunicipio(lstMunicipios.SelectedItem.ToString());
                List<string> nombresVeredas = new List<string>();

                foreach (Vereda unaVereda in lasVeredasDelMunicipio)
                    nombresVeredas.Add(unaVereda.Nombre);

                lstVeredas.DataSource = nombresVeredas;
                lstVeredas.DisplayMember = "nombre";

                if (veredaSeleccionada=="")
                    lstVeredas.SelectedIndex = 0;
                else
                    lstVeredas.SelectedIndex = lstVeredas.Items.IndexOf(veredaSeleccionada);
                
            }
        }

        /// <summary>
        /// Refresca la forma de reporte de siembras, si ésta se encuentra abierta
        /// </summary>
        public void RefrescaFormasSiembras()
        {
            //FormaReporteSiembras
            FormaReporteSiembras formaReportes =
                (FormaReporteSiembras)Application.OpenForms["FormaReporteSiembras"];

            if (formaReportes != null)
                formaReportes.InicializaDgvDetalleSiembras();
        }
    }
}
