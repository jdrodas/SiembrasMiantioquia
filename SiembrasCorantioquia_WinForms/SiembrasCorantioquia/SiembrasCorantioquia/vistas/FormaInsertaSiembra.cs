﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiembrasCorantioquia
{
    public partial class FormaInsertaSiembra : Form
    {
        public FormaInsertaSiembra()
        {
            InitializeComponent();
        }

        private void pbxBotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaInsertaSiembra_Load(object sender, EventArgs e)
        {
            ActualizaLsbVeredas();
            ActualizaCbxArboles();
            ActualizaCbxContratistas();
        }

        private void ActualizaCbxContratistas()
        {
            cbxContratistas.DataSource = null;
            cbxContratistas.DataSource = AccesoDatos.ObtieneListaContratistas();
            cbxContratistas.DisplayMember = "nombre";
        }

        private void ActualizaCbxArboles()
        {
            cbxArboles.DataSource = null;
            cbxArboles.DataSource = AccesoDatos.ObtieneListaArboles();
            cbxArboles.DisplayMember = "nombre";
        }

        public void ActualizaLsbVeredas()
        {
            lsbVeredas.DataSource = null;
            lsbVeredas.DataSource = AccesoDatos.ObtieneListaVeredas();
            lsbVeredas.DisplayMember = "nombre";
        }

        private void lsbVeredas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbVeredas.SelectedItem.ToString() != "")
            {
                cbxMunicipios.DataSource = null;
                cbxMunicipios.DataSource = AccesoDatos.ObtieneListaMunicipios(lsbVeredas.SelectedItem.ToString());
                cbxMunicipios.DisplayMember = "nombre";
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
                unaSiembra.Fecha_Siembra = dtpFecha.Value.ToShortDateString();
                unaSiembra.Nombre_Vereda = lsbVeredas.SelectedItem.ToString();
                unaSiembra.Nombre_Municipio = cbxMunicipios.SelectedItem.ToString();
                unaSiembra.Nombre_Arbol = cbxArboles.SelectedItem.ToString();
                unaSiembra.Nombre_Contratista = cbxContratistas.SelectedItem.ToString();

                bool registroCorrecto = AccesoDatos.GuardarSiembra(unaSiembra, out mensajeError);

                if (registroCorrecto)
                {
                    MessageBox.Show("La siembra se registró correctamente");
                }
                else
                {
                    MessageBox.Show($"Se presentaron problemas con la siembra. {mensajeError}",
                        "Fallo al guardar la siembra",
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
