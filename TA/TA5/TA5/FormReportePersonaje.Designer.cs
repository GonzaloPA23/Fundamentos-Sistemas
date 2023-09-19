namespace TA5
{
    partial class FormReportePersonaje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblPersonajesMas40MinutosAparicion = new Label();
            label3 = new Label();
            btnBuscarXCodigoPelicula = new Button();
            label1 = new Label();
            btnBuscarXGeneroPersonaje = new Button();
            tbBuscarXCodigoPelicula = new TextBox();
            cbBuscarXGeneroPersonaje = new ComboBox();
            label2 = new Label();
            listViewPersonajes = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblPersonajesMas40MinutosAparicion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnBuscarXCodigoPelicula);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBuscarXGeneroPersonaje);
            panel1.Controls.Add(tbBuscarXCodigoPelicula);
            panel1.Controls.Add(cbBuscarXGeneroPersonaje);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(31, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 573);
            panel1.TabIndex = 4;
            // 
            // lblPersonajesMas40MinutosAparicion
            // 
            lblPersonajesMas40MinutosAparicion.AutoSize = true;
            lblPersonajesMas40MinutosAparicion.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPersonajesMas40MinutosAparicion.Location = new Point(214, 507);
            lblPersonajesMas40MinutosAparicion.Name = "lblPersonajesMas40MinutosAparicion";
            lblPersonajesMas40MinutosAparicion.Size = new Size(28, 31);
            lblPersonajesMas40MinutosAparicion.TabIndex = 16;
            lblPersonajesMas40MinutosAparicion.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(61, 386);
            label3.Name = "label3";
            label3.Size = new Size(371, 93);
            label3.TabIndex = 16;
            label3.Text = "Personajes que tienen más de 40 \r\nminutos de aparación en pantalla \r\nsegún el código especificado es:";
            // 
            // btnBuscarXCodigoPelicula
            // 
            btnBuscarXCodigoPelicula.BackColor = Color.FromArgb(229, 62, 62);
            btnBuscarXCodigoPelicula.FlatAppearance.BorderSize = 0;
            btnBuscarXCodigoPelicula.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btnBuscarXCodigoPelicula.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnBuscarXCodigoPelicula.FlatStyle = FlatStyle.Flat;
            btnBuscarXCodigoPelicula.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBuscarXCodigoPelicula.ForeColor = Color.Transparent;
            btnBuscarXCodigoPelicula.Location = new Point(161, 316);
            btnBuscarXCodigoPelicula.Name = "btnBuscarXCodigoPelicula";
            btnBuscarXCodigoPelicula.Size = new Size(177, 40);
            btnBuscarXCodigoPelicula.TabIndex = 15;
            btnBuscarXCodigoPelicula.Text = "Buscar";
            btnBuscarXCodigoPelicula.UseVisualStyleBackColor = false;
            btnBuscarXCodigoPelicula.Click += btnBuscarXCodigoPelicula_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(78, 221);
            label1.Name = "label1";
            label1.Size = new Size(331, 31);
            label1.TabIndex = 13;
            label1.Text = "Buscar por código de película:";
            // 
            // btnBuscarXGeneroPersonaje
            // 
            btnBuscarXGeneroPersonaje.BackColor = Color.FromArgb(229, 62, 62);
            btnBuscarXGeneroPersonaje.FlatAppearance.BorderSize = 0;
            btnBuscarXGeneroPersonaje.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btnBuscarXGeneroPersonaje.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnBuscarXGeneroPersonaje.FlatStyle = FlatStyle.Flat;
            btnBuscarXGeneroPersonaje.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBuscarXGeneroPersonaje.ForeColor = Color.Transparent;
            btnBuscarXGeneroPersonaje.Location = new Point(161, 161);
            btnBuscarXGeneroPersonaje.Name = "btnBuscarXGeneroPersonaje";
            btnBuscarXGeneroPersonaje.Size = new Size(177, 40);
            btnBuscarXGeneroPersonaje.TabIndex = 12;
            btnBuscarXGeneroPersonaje.Text = "Buscar";
            btnBuscarXGeneroPersonaje.UseVisualStyleBackColor = false;
            btnBuscarXGeneroPersonaje.Click += btnBuscarXGeneroPersonaje_Click;
            // 
            // tbBuscarXCodigoPelicula
            // 
            tbBuscarXCodigoPelicula.Location = new Point(82, 272);
            tbBuscarXCodigoPelicula.Name = "tbBuscarXCodigoPelicula";
            tbBuscarXCodigoPelicula.Size = new Size(327, 27);
            tbBuscarXCodigoPelicula.TabIndex = 11;
            // 
            // cbBuscarXGeneroPersonaje
            // 
            cbBuscarXGeneroPersonaje.FormattingEnabled = true;
            cbBuscarXGeneroPersonaje.Items.AddRange(new object[] { "Femenino", "Masculino", "No definido" });
            cbBuscarXGeneroPersonaje.Location = new Point(80, 111);
            cbBuscarXGeneroPersonaje.Name = "cbBuscarXGeneroPersonaje";
            cbBuscarXGeneroPersonaje.Size = new Size(327, 28);
            cbBuscarXGeneroPersonaje.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(70, 61);
            label2.Name = "label2";
            label2.Size = new Size(362, 31);
            label2.TabIndex = 7;
            label2.Text = "Buscar por género de personaje:";
            // 
            // listViewPersonajes
            // 
            listViewPersonajes.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewPersonajes.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listViewPersonajes.Location = new Point(543, 55);
            listViewPersonajes.Name = "listViewPersonajes";
            listViewPersonajes.Size = new Size(838, 612);
            listViewPersonajes.TabIndex = 5;
            listViewPersonajes.UseCompatibleStateImageBehavior = false;
            listViewPersonajes.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre personaje";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Nombre actor";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Sexo";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Minutos de aparición";
            columnHeader5.Width = 160;
            // 
            // FormReportePersonaje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1400, 713);
            Controls.Add(listViewPersonajes);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormReportePersonaje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReportePersonaje";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnBuscarXCodigoPelicula;
        private Label label1;
        private Button btnBuscarXGeneroPersonaje;
        private TextBox tbBuscarXCodigoPelicula;
        private ComboBox cbBuscarXGeneroPersonaje;
        private Label label2;
        private Label lblPersonajesMas40MinutosAparicion;
        private Label label3;
        private ListView listViewPersonajes;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}