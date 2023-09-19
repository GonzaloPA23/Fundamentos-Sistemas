namespace TA5
{
    partial class FormReporte
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
            btnBuscarMenorCantidadPersonajesFemenino = new Button();
            btnBuscarXNombreActor = new Button();
            label1 = new Label();
            btnBuscarXGeneroPelicula = new Button();
            tbBuscarXNombreActor = new TextBox();
            cbBuscarXGeneroPelicula = new ComboBox();
            label2 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label8 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnBuscarMenorCantidadPersonajesFemenino);
            panel1.Controls.Add(btnBuscarXNombreActor);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBuscarXGeneroPelicula);
            panel1.Controls.Add(tbBuscarXNombreActor);
            panel1.Controls.Add(cbBuscarXGeneroPelicula);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(27, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 573);
            panel1.TabIndex = 0;
            // 
            // btnBuscarMenorCantidadPersonajesFemenino
            // 
            btnBuscarMenorCantidadPersonajesFemenino.BackColor = Color.FromArgb(229, 62, 62);
            btnBuscarMenorCantidadPersonajesFemenino.FlatAppearance.BorderSize = 0;
            btnBuscarMenorCantidadPersonajesFemenino.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btnBuscarMenorCantidadPersonajesFemenino.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnBuscarMenorCantidadPersonajesFemenino.FlatStyle = FlatStyle.Flat;
            btnBuscarMenorCantidadPersonajesFemenino.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBuscarMenorCantidadPersonajesFemenino.ForeColor = Color.Transparent;
            btnBuscarMenorCantidadPersonajesFemenino.Location = new Point(39, 371);
            btnBuscarMenorCantidadPersonajesFemenino.Name = "btnBuscarMenorCantidadPersonajesFemenino";
            btnBuscarMenorCantidadPersonajesFemenino.Size = new Size(411, 110);
            btnBuscarMenorCantidadPersonajesFemenino.TabIndex = 15;
            btnBuscarMenorCantidadPersonajesFemenino.Text = "Buscar los que tienen menor cantidad de personajes de Sexo Femenino";
            btnBuscarMenorCantidadPersonajesFemenino.UseVisualStyleBackColor = false;
            btnBuscarMenorCantidadPersonajesFemenino.Click += btnBuscarMenorCantidadPersonajesFemenino_Click;
            // 
            // btnBuscarXNombreActor
            // 
            btnBuscarXNombreActor.BackColor = Color.FromArgb(229, 62, 62);
            btnBuscarXNombreActor.FlatAppearance.BorderSize = 0;
            btnBuscarXNombreActor.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btnBuscarXNombreActor.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnBuscarXNombreActor.FlatStyle = FlatStyle.Flat;
            btnBuscarXNombreActor.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBuscarXNombreActor.ForeColor = Color.Transparent;
            btnBuscarXNombreActor.Location = new Point(161, 316);
            btnBuscarXNombreActor.Name = "btnBuscarXNombreActor";
            btnBuscarXNombreActor.Size = new Size(177, 40);
            btnBuscarXNombreActor.TabIndex = 15;
            btnBuscarXNombreActor.Text = "Buscar";
            btnBuscarXNombreActor.UseVisualStyleBackColor = false;
            btnBuscarXNombreActor.Click += btnBuscarXNombreActor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(82, 222);
            label1.Name = "label1";
            label1.Size = new Size(321, 31);
            label1.TabIndex = 13;
            label1.Text = "Buscar por nombre de actor:";
            // 
            // btnBuscarXGeneroPelicula
            // 
            btnBuscarXGeneroPelicula.BackColor = Color.FromArgb(229, 62, 62);
            btnBuscarXGeneroPelicula.FlatAppearance.BorderSize = 0;
            btnBuscarXGeneroPelicula.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btnBuscarXGeneroPelicula.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnBuscarXGeneroPelicula.FlatStyle = FlatStyle.Flat;
            btnBuscarXGeneroPelicula.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBuscarXGeneroPelicula.ForeColor = Color.Transparent;
            btnBuscarXGeneroPelicula.Location = new Point(161, 161);
            btnBuscarXGeneroPelicula.Name = "btnBuscarXGeneroPelicula";
            btnBuscarXGeneroPelicula.Size = new Size(177, 40);
            btnBuscarXGeneroPelicula.TabIndex = 12;
            btnBuscarXGeneroPelicula.Text = "Buscar";
            btnBuscarXGeneroPelicula.UseVisualStyleBackColor = false;
            btnBuscarXGeneroPelicula.Click += btnBuscarXGeneroPelicula_Click;
            // 
            // tbBuscarXNombreActor
            // 
            tbBuscarXNombreActor.Location = new Point(82, 272);
            tbBuscarXNombreActor.Name = "tbBuscarXNombreActor";
            tbBuscarXNombreActor.Size = new Size(327, 27);
            tbBuscarXNombreActor.TabIndex = 11;
            // 
            // cbBuscarXGeneroPelicula
            // 
            cbBuscarXGeneroPelicula.FormattingEnabled = true;
            cbBuscarXGeneroPelicula.Items.AddRange(new object[] { "Comedia", "Drama", "Ciencia Ficción", "Terror", "Anime" });
            cbBuscarXGeneroPelicula.Location = new Point(80, 111);
            cbBuscarXGeneroPelicula.Name = "cbBuscarXGeneroPelicula";
            cbBuscarXGeneroPelicula.Size = new Size(327, 28);
            cbBuscarXGeneroPelicula.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 58);
            label2.Name = "label2";
            label2.Size = new Size(336, 31);
            label2.TabIndex = 7;
            label2.Text = "Buscar por género de película:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.Location = new Point(549, 45);
            listView1.Name = "listView1";
            listView1.Size = new Size(689, 647);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "País";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Género";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Duración en minutos";
            columnHeader5.Width = 160;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(1207, 712);
            label8.Name = "label8";
            label8.Size = new Size(28, 31);
            label8.TabIndex = 2;
            label8.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(983, 712);
            label7.Name = "label7";
            label7.Size = new Size(208, 31);
            label7.TabIndex = 3;
            label7.Text = "Total de Peliculas:";
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1272, 763);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(listView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormReporte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReporte";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox tbBuscarXNombreActor;
        private ComboBox cbBuscarXGeneroPelicula;
        private Label label2;
        private Button btnBuscarMenorCantidadPersonajesFemenino;
        private Button btnBuscarXNombreActor;
        private Label label1;
        private Button btnBuscarXGeneroPelicula;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label8;
        private Label label7;
    }
}