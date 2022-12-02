using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiembrasMiantioquia_NoSQL_WinForms
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

        /// <summary>
        /// Inicializa la lista de los municipios
        /// </summary>
        public void InicializaLstMunicipios()
        {
            lstMunicipios.DataSource = null;
            lstMunicipios.DataSource = AccesoDatos.ObtieneListaNombreMunicipios();
            lstMunicipios.DisplayMember = "nombre";

            //Seleccionamos el primer municipio de la lista
            lstMunicipios.SelectedIndex = 0;
        }

        /// <summary>
        /// Inicializa la lista de contratista
        /// </summary>
        private void InicializaLstContratistas()
        {
            lstContratistas.DataSource = null;
            lstContratistas.DataSource = AccesoDatos.ObtieneListaNombreContratistas();
            lstContratistas.DisplayMember = "nombre";
        }

        /// <summary>
        /// Inicializa la lista de árboles
        /// </summary>
        private void InicializaLstArboles()
        {
            lstArboles.DataSource = null;
            lstArboles.DataSource = AccesoDatos.ObtieneListaNombreArboles();
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
                List<Vereda> lasVeredasDelMunicipio = AccesoDatos.ObtieneListaVeredasMunicipio(lstMunicipios.SelectedItem.ToString());
                List<string> nombresVeredas = new List<string>();

                foreach (Vereda unaVereda in lasVeredasDelMunicipio)
                    nombresVeredas.Add(unaVereda.Nombre);

                lstVeredas.DataSource = nombresVeredas;
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
                unaSiembra.Fecha = dtpFecha.Value;
                unaSiembra.Vereda = lstVeredas.SelectedItem.ToString();
                unaSiembra.Municipio = lstMunicipios.SelectedItem.ToString();
                unaSiembra.Arbol = lstArboles.SelectedItem.ToString();
                unaSiembra.Contratista = lstContratistas.SelectedItem.ToString();

                //Aqui validamos datos ingresados por el usuario
                bool datosNuevaSiembraCorrectos = ValidaDatosNuevaSiembra(unaSiembra, out mensajeError);

                if (!datosNuevaSiembraCorrectos)
                {
                    MessageBox.Show($"Se presentaron problemas con la siembra. {mensajeError}",
                    "Fallo al procesar la siembra",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else
                {
                    AccesoDatos.GuardaSiembra(unaSiembra);

                    MessageBox.Show("La siembra se registró correctamente",
                        "Inserción exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                    //Aqui actualizamos las formas de las siembras, si se encuentran abiertas
                    RefrescaFormasSiembras();

                    //Cerramos la forma
                    this.Close();
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

        /// <summary>
        /// Refresca las formas de siembras, si éstas se encuentran abiertas
        /// </summary>
        public void RefrescaFormasSiembras()
        {
            //FormaReporteSiembras
            FormaReporteSiembras formaReportes =
                (FormaReporteSiembras)Application.OpenForms["FormaReporteSiembras"];

            if (formaReportes != null)
                formaReportes.InicializaDgvDetalleSiembras();
        }

        /// <summary>
        /// Valida si los datos de la siembra ingresados por el usuario son correctos
        /// </summary>
        /// <param name="unaSiembra">La siembra a validar</param>
        /// <param name="mensajeError">mensaje de error en caso de fallo</param>
        /// <returns>Resultado validación</returns>
        public bool ValidaDatosNuevaSiembra(Siembra unaSiembra, out string mensajeError)
        {
            bool resultado = true;
            mensajeError = "";

            //Aqui validamos que no haya siembras en fechas futuras
            if (unaSiembra.Fecha > DateTime.Now)
            {
                mensajeError = "No se puede registrar una siembra en fecha futura.";
                return false;
            }

            //Aqui validamos que el valor de las hectáreas sea positivo
            if (unaSiembra.Total_Hectareas <= 0)
            {
                mensajeError = "El valor de las hectáreas sembradas debe ser mayor que cero.";
                return false;
            }

            //Aqui validamos que el valor del total de los árboles sea positivo
            if (unaSiembra.Total_Arboles <= 0)
            {
                mensajeError = "El valor del total de árboles debe ser mayor que cero.";
                return false;
            }

            return resultado;
        }
    }
}
