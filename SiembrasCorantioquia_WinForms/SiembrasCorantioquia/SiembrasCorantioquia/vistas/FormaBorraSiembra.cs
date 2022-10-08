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
    public partial class FormaBorraSiembra : Form
    {
        public FormaBorraSiembra()
        {
            InitializeComponent();
        }

        private void pbxBotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaBorraSiembra_Load(object sender, EventArgs e)
        {
            InicializaListaInfoSiembras();
        }

        private void InicializaListaInfoSiembras()
        {
            lstInfoSiembras.DataSource = null;
            lstInfoSiembras.DataSource = AccesoDatos.ObtieneListaInfoSiembras();
            lstInfoSiembras.DisplayMember = "infoSiembra";

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
                "Borrar siembra, WTF?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Hand);

            //Si el usuario quiere borrar
            if (resultado == DialogResult.Yes)
            {
                borradoCorrecto = AccesoDatos.BorrarSiembra(codigoSiembra, out mensajeError);

                if (borradoCorrecto)
                {
                    MessageBox.Show("La siembra se borró correctamente");

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
    }
}
