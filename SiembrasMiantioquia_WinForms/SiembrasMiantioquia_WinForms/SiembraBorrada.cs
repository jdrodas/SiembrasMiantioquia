using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miantioquia.Formularios
{
    public partial class SiembraBorrada : Form
    {
        public SiembraBorrada()
        {
            InitializeComponent();
        }

        private void pbxBotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaBorraSiembra_Load(object sender, EventArgs e)
        {
            InicializaLstInfoSiembras();
        }

        /// <summary>
        /// Inicializa la lista con la información resumida de las siembras
        /// </summary>
        public void InicializaLstInfoSiembras()
        {
            lstInfoSiembras.DataSource = null;
            lstInfoSiembras.DataSource = AccesoDatos.ObtieneListaInfoSiembras();
            lstInfoSiembras.DisplayMember = "infoSiembra";

            lstInfoSiembras.Invalidate();
            lstInfoSiembras.Refresh();

            //Seleccionamos el primer municipio de la lista
            lstInfoSiembras.SelectedIndex = 0;
        }

        private void lstInfoSiembras_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] infoSiembra = lstInfoSiembras.SelectedItem.ToString().Split('-');
            int codigo_siembra = int.Parse(infoSiembra[0].Trim());
            txtCodigoSiembra.Text = codigo_siembra.ToString();
        }

        private void btnBorraSiembra_Click(object sender, EventArgs e)
        {
            bool borradoCorrecto = false;
            string mensajeError = "";
            int codigoSiembra = int.Parse(txtCodigoSiembra.Text);

            
            DialogResult resultado = MessageBox.Show("Esta seguro de querer borrar esta siembra?",
                "Confirmación borrado siembra",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Hand);

            //Si el usuario quiere borrar
            if (resultado == DialogResult.Yes)
            {
                borradoCorrecto = AccesoDatos.BorrarSiembra(codigoSiembra, out mensajeError);

                if (borradoCorrecto)
                {
                    MessageBox.Show("La siembra se borró correctamente",
                        "Borrado exitoso",
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
                        "Fallo al borrar la siembra",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Refresca la forma de reporte de siembras, si ésta se encuentra abierta
        /// </summary>
        public void RefrescaFormasSiembras()
        {
            //FormaReporteSiembras
            SiembraReportes formaReportes =
                (SiembraReportes)Application.OpenForms["FormaReporteSiembras"];

            if (formaReportes != null)
                formaReportes.InicializaDgvDetalleSiembras();
        }
    }
}
