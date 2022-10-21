using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.IO;

namespace SiembrasMiantioquia_WinForms
{
    public partial class FormaReporteSiembras : Form
    {
        public FormaReporteSiembras()
        {
            InitializeComponent();
        }

        private void pbxBotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaReporteSiembras_Load(object sender, EventArgs e)
        {
            InicializaDgvDetalleSiembras();
        }

        /// <summary>
        /// Inicializa el DataGridView con el detalle de siembras
        /// </summary>
        public void InicializaDgvDetalleSiembras()
        {
            dgvDetalleSiembras.DataSource = null;
            dgvDetalleSiembras.DataSource = AccesoDatos.ObtenerDetalleSiembras();
        }

        /// <summary>
        /// Actualiza los campos de información sobre la siembra cuando se cambia el item seleccionado en el DataGridView
        /// </summary>
        private void dgvDetalleSiembras_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvDetalleSiembras.SelectedRows.Count > 0)
            {
                int codigoSiembra = int.Parse(dgvDetalleSiembras.SelectedRows[0].Cells[0].Value.ToString());
                txtCodigoSiembra.Text = codigoSiembra.ToString();

                Siembra unaSiembra = AccesoDatos.ObtenerSiembra(codigoSiembra);

                //Llenamos la versión en texto plano
                txtSiembraTextoPlano.Text = unaSiembra.ToString();

                //Llenamos la versión en formato JSON
                txtSiembraJSON.Text = JsonConvert.SerializeObject(unaSiembra, Formatting.Indented);

                //Llenamos la versión en formato XML
                var stringwriter = new StringWriter();
                var serializadorXML = new XmlSerializer(unaSiembra.GetType());
                serializadorXML.Serialize(stringwriter, unaSiembra);

                txtSiembraXML.Text = stringwriter.ToString();
            }
            else
            {
                txtCodigoSiembra.Text = "";
                txtSiembraJSON.Text = "";
                txtSiembraTextoPlano.Text = "";
                txtSiembraXML.Text = "";
            }
        }
    }
}
