using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace SiembrasMiantioquia_WinForms
{
    public partial class FormaReporteVereda : Form
    {
        public FormaReporteVereda()
        {
            InitializeComponent();
        }

        private void pbxBotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaReporteVereda_Load(object sender, EventArgs e)
        {
            InicializaLstMunicipios();
        }

        /// <summary>
        /// Inicializa la lista de los municipios
        /// </summary>
        public void InicializaLstMunicipios()
        {
            lstMunicipios.DataSource = null;
            lstMunicipios.DataSource = AccesoDatos.ObtieneListaMunicipios();
            lstMunicipios.DisplayMember = "nombre";

            //Seleccionamos el primer municipio de la lista
            lstMunicipios.SelectedIndex = 0;
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

        private void botonGenerarJSON_Click(object sender, EventArgs e)
        {
            List<Vereda> lasVeredas = AccesoDatos.ObtieneListaVeredas();

            //Llenamos la versión en formato JSON
            txtJSON.Text = JsonConvert.SerializeObject(lasVeredas, Formatting.Indented);
        }
    }
}
