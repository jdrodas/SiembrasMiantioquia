using System;
using System.Windows.Forms;
using Miantioquia.Modelos;
using Miantioquia.Validaciones;

namespace Miantioquia.Formularios
{
    public partial class SiembraActualizada : Form
    {
        public SiembraActualizada()
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
            Siembra unaSiembra = AccesoDatos.ObtenerSiembra(codigo_siembra);

            //Actualizamos las listas asignando como item seleccionado
            //el valor correspondiente de la siembra

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

            //Aqui controlamos la visualización del formato de fecha
            DateTime fechaNormalizada;
            string mensajeError;
            bool resultadoCorrecto = ObtieneFechaSiembra(unaSiembra.Fecha_Siembra, 
                out fechaNormalizada, out mensajeError);

            if (resultadoCorrecto)
                dtpFecha.Value = fechaNormalizada;
            else
                MessageBox.Show($"La fecha no tiene el formato DD/MM/YYYY. {mensajeError}",
                    "Error al extraer fecha",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
        }

        /// <summary>
        /// Inicializa la lista de los municipios
        /// </summary>
        /// <param name="nombreMunicipio">el municipio que se espera sea seleccionado</param>
        public void InicializaLstMunicipios(string nombreMunicipio)
        {
            lstMunicipios.DataSource = null;
            lstMunicipios.DataSource = AccesoDatos.ObtieneListaMunicipios();
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
            lstVeredas.DataSource = AccesoDatos.ObtieneListaNombreVeredasMunicipio(lstMunicipios.SelectedItem.ToString());
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
            lstArboles.DataSource = AccesoDatos.ObtieneListaArboles();
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
            lstContratistas.DataSource = AccesoDatos.ObtieneListaContratistas();
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

                //Aqui validamos datos ingresados por el usuario
                bool datosSiembraActualizadaCorrectos = Validador.DatosSiembra(unaSiembra, out mensajeError);

                if (!datosSiembraActualizadaCorrectos)
                {
                    MessageBox.Show($"Se presentaron problemas con la siembra. {mensajeError}",
                    "Fallo al procesar la siembra",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else
                {
                    bool registroCorrecto = AccesoDatos.ActualizarSiembra(unaSiembra, out mensajeError);

                    if (registroCorrecto)
                    {
                        MessageBox.Show("La siembra se actualizó correctamente",
                            "Actualización exitosa",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        //Aqui actualizamos las formas de las siembras, si se encuentran abiertas
                        RefrescaFormasSiembras();

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
                ActualizaLstVeredas();
            else
                //De lo contrario, se borra la lista de Veredas
                lstVeredas.DataSource = null;
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
                lstVeredas.DataSource = AccesoDatos.ObtieneListaNombreVeredasMunicipio(lstMunicipios.SelectedItem.ToString());
                lstVeredas.DisplayMember = "nombre";
            }
        }

        /// <summary>
        /// Refresca la forma de reporte de siembras, si ésta se encuentra abierta
        /// </summary>
        public void RefrescaFormasSiembras()
        {
            //FormaReporteSiembras
            SiembraReportes formaReportes =
                (SiembraReportes)Application.OpenForms["SiembraReportes"];

            if (formaReportes != null)
                formaReportes.InicializaDgvDetalleSiembras();
        }
    }
}
