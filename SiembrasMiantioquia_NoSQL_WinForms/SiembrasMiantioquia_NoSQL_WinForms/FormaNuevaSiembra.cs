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
                Siembra unaSiembra = new Siembra();
                unaSiembra.Total_Hectareas = double.Parse(txtTotalHectareas.Text);
                unaSiembra.Total_Arboles = int.Parse(txtTotalArboles.Text);
                unaSiembra.Fecha = dtpFecha.Value;
                unaSiembra.Vereda = lstVeredas.SelectedItem.ToString();
                unaSiembra.Municipio = lstMunicipios.SelectedItem.ToString();
                unaSiembra.Arbol = lstArboles.SelectedItem.ToString();
                unaSiembra.Contratista = lstContratistas.SelectedItem.ToString();

                AccesoDatos.GuardarSiembra(unaSiembra);

                MessageBox.Show("La siembra se registró correctamente",
                    "Inserción exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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
    }
}
