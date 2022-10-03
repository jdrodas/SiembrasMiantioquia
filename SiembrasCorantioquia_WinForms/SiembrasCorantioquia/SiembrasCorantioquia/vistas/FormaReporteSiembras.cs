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
            InicializaDgvSiembrasDetalleSiembras();
        }

        private void InicializaDgvSiembrasDetalleSiembras()
        {
            dgvSiembras.DataSource = null;
            dgvSiembras.DataSource = AccesoDatos.ObtenerDetalleSiembras();
        }

        private void FormaReporteSiembras_Activated(object sender, EventArgs e)
        {
            InicializaDgvSiembrasDetalleSiembras();
        }

        private void FormaReporteSiembras_Enter(object sender, EventArgs e)
        {
            InicializaDgvSiembrasDetalleSiembras();
        }
    }
}
