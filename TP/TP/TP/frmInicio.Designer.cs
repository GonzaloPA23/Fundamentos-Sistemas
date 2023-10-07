namespace TP
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
            label1 = new Label();
            menuTitulo = new MenuStrip();
            label2 = new Label();
            lblNombreUsuarioIngresado = new Label();
            menuStrip1 = new MenuStrip();
            menuchoferes = new FontAwesome.Sharp.IconMenuItem();
            menubuses = new FontAwesome.Sharp.IconMenuItem();
            menupasajes = new FontAwesome.Sharp.IconMenuItem();
            menuencomiendas = new FontAwesome.Sharp.IconMenuItem();
            menureportes = new FontAwesome.Sharp.IconMenuItem();
            subMenuHistorialPasajes = new ToolStripMenuItem();
            subMenuHistorialEncomiendas = new ToolStripMenuItem();
            panelContenedor = new Panel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(222, 108, 148);
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 17);
            label1.Name = "label1";
            label1.Size = new Size(293, 31);
            label1.TabIndex = 2;
            label1.Text = "La Perla Del Altomayo";
            // 
            // menuTitulo
            // 
            menuTitulo.AutoSize = false;
            menuTitulo.BackColor = Color.FromArgb(222, 108, 148);
            menuTitulo.ImageScalingSize = new Size(20, 20);
            menuTitulo.Location = new Point(0, 0);
            menuTitulo.Name = "menuTitulo";
            menuTitulo.RightToLeft = RightToLeft.Yes;
            menuTitulo.Size = new Size(1321, 70);
            menuTitulo.TabIndex = 3;
            menuTitulo.Text = "menuStrip1";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(222, 108, 148);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(828, 17);
            label2.Name = "label2";
            label2.Size = new Size(107, 31);
            label2.TabIndex = 4;
            label2.Text = "Usuario:";
            // 
            // lblNombreUsuarioIngresado
            // 
            lblNombreUsuarioIngresado.BackColor = Color.FromArgb(222, 108, 148);
            lblNombreUsuarioIngresado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsuarioIngresado.ForeColor = Color.White;
            lblNombreUsuarioIngresado.Location = new Point(915, 18);
            lblNombreUsuarioIngresado.Name = "lblNombreUsuarioIngresado";
            lblNombreUsuarioIngresado.Size = new Size(179, 31);
            lblNombreUsuarioIngresado.TabIndex = 5;
            lblNombreUsuarioIngresado.Text = "Javier Mendoza";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuchoferes, menubuses, menupasajes, menuencomiendas, menureportes });
            menuStrip1.Location = new Point(0, 70);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1321, 99);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuchoferes
            // 
            menuchoferes.AutoSize = false;
            menuchoferes.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            menuchoferes.IconColor = Color.Black;
            menuchoferes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuchoferes.IconSize = 45;
            menuchoferes.ImageScaling = ToolStripItemImageScaling.None;
            menuchoferes.Margin = new Padding(5);
            menuchoferes.Name = "menuchoferes";
            menuchoferes.Size = new Size(120, 85);
            menuchoferes.Text = "Choferes";
            menuchoferes.TextImageRelation = TextImageRelation.ImageAboveText;
            menuchoferes.Click += menuchoferes_Click;
            // 
            // menubuses
            // 
            menubuses.AutoSize = false;
            menubuses.IconChar = FontAwesome.Sharp.IconChar.BusAlt;
            menubuses.IconColor = Color.Black;
            menubuses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menubuses.ImageScaling = ToolStripItemImageScaling.None;
            menubuses.Name = "menubuses";
            menubuses.Size = new Size(120, 85);
            menubuses.Text = "Buses";
            menubuses.TextImageRelation = TextImageRelation.ImageAboveText;
            menubuses.Click += menubuses_Click;
            // 
            // menupasajes
            // 
            menupasajes.AutoSize = false;
            menupasajes.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            menupasajes.IconColor = Color.Black;
            menupasajes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menupasajes.ImageScaling = ToolStripItemImageScaling.None;
            menupasajes.Name = "menupasajes";
            menupasajes.Size = new Size(120, 85);
            menupasajes.Text = "Pasajes";
            menupasajes.TextImageRelation = TextImageRelation.ImageAboveText;
            menupasajes.Click += menupasajes_Click;
            // 
            // menuencomiendas
            // 
            menuencomiendas.AutoSize = false;
            menuencomiendas.IconChar = FontAwesome.Sharp.IconChar.Box;
            menuencomiendas.IconColor = Color.Black;
            menuencomiendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuencomiendas.ImageScaling = ToolStripItemImageScaling.None;
            menuencomiendas.Margin = new Padding(5, 0, 0, 0);
            menuencomiendas.Name = "menuencomiendas";
            menuencomiendas.Size = new Size(120, 85);
            menuencomiendas.Text = "Encomiendas";
            menuencomiendas.TextImageRelation = TextImageRelation.ImageAboveText;
            menuencomiendas.Click += menuencomiendas_Click;
            // 
            // menureportes
            // 
            menureportes.AutoSize = false;
            menureportes.DropDownItems.AddRange(new ToolStripItem[] { subMenuHistorialPasajes, subMenuHistorialEncomiendas });
            menureportes.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            menureportes.IconColor = Color.Black;
            menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menureportes.ImageScaling = ToolStripItemImageScaling.None;
            menureportes.Margin = new Padding(5, 0, 0, 0);
            menureportes.Name = "menureportes";
            menureportes.Size = new Size(120, 85);
            menureportes.Text = "Reportes";
            menureportes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // subMenuHistorialPasajes
            // 
            subMenuHistorialPasajes.Name = "subMenuHistorialPasajes";
            subMenuHistorialPasajes.Size = new Size(261, 26);
            subMenuHistorialPasajes.Text = "Historial de pasajes";
            subMenuHistorialPasajes.Click += subMenuHistorialPasajes_Click;
            // 
            // subMenuHistorialEncomiendas
            // 
            subMenuHistorialEncomiendas.Name = "subMenuHistorialEncomiendas";
            subMenuHistorialEncomiendas.Size = new Size(261, 26);
            subMenuHistorialEncomiendas.Text = "Historial de encomiendas";
            subMenuHistorialEncomiendas.Click += subMenuHistorialEncomiendas_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(235, 235, 233);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 169);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1321, 721);
            panelContenedor.TabIndex = 7;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(222, 108, 148);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderColor = Color.White;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(206, 113, 142);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.White;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnSalir.IconColor = Color.White;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 55;
            btnSalir.Location = new Point(1175, 8);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(78, 52);
            btnSalir.TabIndex = 0;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 233);
            ClientSize = new Size(1321, 890);
            Controls.Add(btnSalir);
            Controls.Add(panelContenedor);
            Controls.Add(lblNombreUsuarioIngresado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(menuTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "/";
            Load += frmInicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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