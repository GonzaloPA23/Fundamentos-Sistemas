﻿using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CapaPresentacion
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreUsuarioIngresado = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuchoferes = new FontAwesome.Sharp.IconMenuItem();
            this.menubuses = new FontAwesome.Sharp.IconMenuItem();
            this.menupasajes = new FontAwesome.Sharp.IconMenuItem();
            this.menuencomiendas = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuHistorialPasajes = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuHistorialEncomiendas = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(108)))), ((int)(((byte)(148)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "La Perla Del Altomayo";
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(108)))), ((int)(((byte)(148)))));
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1400, 70);
            this.menuTitulo.TabIndex = 3;
            this.menuTitulo.Text = "menuStrip1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(108)))), ((int)(((byte)(148)))));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(876, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // lblNombreUsuarioIngresado
            // 
            this.lblNombreUsuarioIngresado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(108)))), ((int)(((byte)(148)))));
            this.lblNombreUsuarioIngresado.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblNombreUsuarioIngresado.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuarioIngresado.Location = new System.Drawing.Point(968, 17);
            this.lblNombreUsuarioIngresado.Name = "lblNombreUsuarioIngresado";
            this.lblNombreUsuarioIngresado.Size = new System.Drawing.Size(179, 25);
            this.lblNombreUsuarioIngresado.TabIndex = 5;
            this.lblNombreUsuarioIngresado.Text = "Javier Mendoza";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuchoferes,
            this.menubuses,
            this.menupasajes,
            this.menuencomiendas,
            this.menureportes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 70);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1400, 99);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuchoferes
            // 
            this.menuchoferes.AutoSize = false;
            this.menuchoferes.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.menuchoferes.IconColor = System.Drawing.Color.Black;
            this.menuchoferes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuchoferes.IconSize = 45;
            this.menuchoferes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuchoferes.Margin = new System.Windows.Forms.Padding(5);
            this.menuchoferes.Name = "menuchoferes";
            this.menuchoferes.Size = new System.Drawing.Size(120, 85);
            this.menuchoferes.Text = "Choferes";
            this.menuchoferes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menubuses
            // 
            this.menubuses.AutoSize = false;
            this.menubuses.IconChar = FontAwesome.Sharp.IconChar.BusAlt;
            this.menubuses.IconColor = System.Drawing.Color.Black;
            this.menubuses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menubuses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menubuses.Name = "menubuses";
            this.menubuses.Size = new System.Drawing.Size(120, 85);
            this.menubuses.Text = "Buses";
            this.menubuses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menupasajes
            // 
            this.menupasajes.AutoSize = false;
            this.menupasajes.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.menupasajes.IconColor = System.Drawing.Color.Black;
            this.menupasajes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menupasajes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menupasajes.Name = "menupasajes";
            this.menupasajes.Size = new System.Drawing.Size(120, 85);
            this.menupasajes.Text = "Pasajes";
            this.menupasajes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuencomiendas
            // 
            this.menuencomiendas.AutoSize = false;
            this.menuencomiendas.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.menuencomiendas.IconColor = System.Drawing.Color.Black;
            this.menuencomiendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuencomiendas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuencomiendas.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.menuencomiendas.Name = "menuencomiendas";
            this.menuencomiendas.Size = new System.Drawing.Size(120, 85);
            this.menuencomiendas.Text = "Encomiendas";
            this.menuencomiendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menureportes
            // 
            this.menureportes.AutoSize = false;
            this.menureportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuHistorialPasajes,
            this.subMenuHistorialEncomiendas});
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            this.menureportes.IconColor = System.Drawing.Color.Black;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(120, 85);
            this.menureportes.Text = "Reportes";
            this.menureportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuHistorialPasajes
            // 
            this.subMenuHistorialPasajes.Name = "subMenuHistorialPasajes";
            this.subMenuHistorialPasajes.Size = new System.Drawing.Size(261, 26);
            this.subMenuHistorialPasajes.Text = "Historial de pasajes";
            // 
            // subMenuHistorialEncomiendas
            // 
            this.subMenuHistorialEncomiendas.Name = "subMenuHistorialEncomiendas";
            this.subMenuHistorialEncomiendas.Size = new System.Drawing.Size(261, 26);
            this.subMenuHistorialEncomiendas.Text = "Historial de encomiendas";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(233)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 169);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1400, 721);
            this.panelContenedor.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(108)))), ((int)(((byte)(148)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(113)))), ((int)(((byte)(142)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 55;
            this.btnSalir.Location = new System.Drawing.Point(1243, 6);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 52);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1400, 890);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.lblNombreUsuarioIngresado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private MenuStrip menuTitulo;
        private Label label2;
        private Label lblNombreUsuarioIngresado;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem menuchoferes;
        private FontAwesome.Sharp.IconMenuItem menubuses;
        private FontAwesome.Sharp.IconMenuItem menupasajes;
        private FontAwesome.Sharp.IconMenuItem menuencomiendas;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private ToolStripMenuItem subMenuHistorialPasajes;
        private ToolStripMenuItem subMenuHistorialEncomiendas;
        private Panel panelContenedor;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}