﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using CapaDatos;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class frmInicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem menuActivo = null;
        private static Form formularioActivo = null;

        public frmInicio(Usuario usuario)
        {
            usuarioActual = usuario;
            InitializeComponent();
        }

        private void frmInicio_Load_1(object sender, EventArgs e)
        {
            List<Permiso> permisos = new NPermiso().ListarPermisos(usuarioActual.Id);
            foreach (IconMenuItem iconMenu in menuStrip1.Items)
            {
                bool encontrado = permisos.Any(m => m.NombreMenu.Equals(iconMenu.Name));
                if (!encontrado) { iconMenu.Visible = false; }
            }
            lblNombreUsuarioIngresado.Text = usuarioActual.Nombre + " " + usuarioActual.Apellido;
        }

        private void AbrirFormularioHijo(IconMenuItem iconMenuItem, Form form)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }
            iconMenuItem.BackColor = Color.FromArgb(245, 210, 222);
            menuActivo = iconMenuItem;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BackColor = Color.FromArgb(235, 235, 233);
            panelContenedor.Controls.Add(form);
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void menuchoferes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo((IconMenuItem)sender, new frmChofer());
        }

        private void menubuses_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo((IconMenuItem)sender, new frmBus());
        }

        private void menupasajes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo((IconMenuItem)sender, new frmPasaje());
        }

        private void menuencomiendas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo((IconMenuItem)sender, new frmEncomienda(usuarioActual));
        }

        private void subMenuHistorialPasajes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(menureportes, new frmHistorialPasaje());
        }

        private void subMenuHistorialEncomiendas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(menureportes, new frmHistorialEncomienda(usuarioActual));
        }    
    }
}
