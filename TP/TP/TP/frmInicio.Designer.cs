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
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            menuchoferes = new FontAwesome.Sharp.IconMenuItem();
            menubuses = new FontAwesome.Sharp.IconMenuItem();
            menupasajes = new FontAwesome.Sharp.IconMenuItem();
            menuencomiendas = new FontAwesome.Sharp.IconMenuItem();
            menureportes = new FontAwesome.Sharp.IconMenuItem();
            historialDePasajesToolStripMenuItem = new ToolStripMenuItem();
            historialDeEncomiendasToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(222, 108, 148);
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 14);
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
            menuTitulo.Size = new Size(1311, 59);
            menuTitulo.TabIndex = 3;
            menuTitulo.Text = "menuStrip1";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(222, 108, 148);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(973, 13);
            label2.Name = "label2";
            label2.Size = new Size(107, 31);
            label2.TabIndex = 4;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(222, 108, 148);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1067, 13);
            label3.Name = "label3";
            label3.Size = new Size(179, 31);
            label3.TabIndex = 5;
            label3.Text = "Javier Mendoza";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuchoferes, menubuses, menupasajes, menuencomiendas, menureportes });
            menuStrip1.Location = new Point(0, 59);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1311, 99);
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
            // 
            // menureportes
            // 
            menureportes.AutoSize = false;
            menureportes.DropDownItems.AddRange(new ToolStripItem[] { historialDePasajesToolStripMenuItem, historialDeEncomiendasToolStripMenuItem });
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
            // historialDePasajesToolStripMenuItem
            // 
            historialDePasajesToolStripMenuItem.Name = "historialDePasajesToolStripMenuItem";
            historialDePasajesToolStripMenuItem.Size = new Size(261, 26);
            historialDePasajesToolStripMenuItem.Text = "Historial de pasajes";
            // 
            // historialDeEncomiendasToolStripMenuItem
            // 
            historialDeEncomiendasToolStripMenuItem.Name = "historialDeEncomiendasToolStripMenuItem";
            historialDeEncomiendasToolStripMenuItem.Size = new Size(261, 26);
            historialDeEncomiendasToolStripMenuItem.Text = "Historial de encomiendas";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(1311, 550);
            panel1.TabIndex = 7;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 233);
            ClientSize = new Size(1311, 708);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(menuTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "/";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private MenuStrip menuTitulo;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem menuchoferes;
        private FontAwesome.Sharp.IconMenuItem menubuses;
        private FontAwesome.Sharp.IconMenuItem menupasajes;
        private FontAwesome.Sharp.IconMenuItem menuencomiendas;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private ToolStripMenuItem historialDePasajesToolStripMenuItem;
        private ToolStripMenuItem historialDeEncomiendasToolStripMenuItem;
        private Panel panel1;
    }
}