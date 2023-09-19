namespace TA5
{
    partial class FormPelicula
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
            btnRegistrar = new Button();
            nudDuracionEnMinutos = new NumericUpDown();
            tbPais = new TextBox();
            tbNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tbCodigo = new TextBox();
            label3 = new Label();
            cbGenero = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnSalir = new Button();
            btnReportes = new Button();
            btnVerPersonajes = new Button();
            listViewPeliculas = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label7 = new Label();
            lblTotalPeliculas = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuracionEnMinutos).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(nudDuracionEnMinutos);
            panel1.Controls.Add(tbPais);
            panel1.Controls.Add(tbNombre);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbCodigo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbGenero);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(49, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 470);
            panel1.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(229, 62, 62);
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.Transparent;
            btnRegistrar.Location = new Point(273, 373);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(228, 54);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // nudDuracionEnMinutos
            // 
            nudDuracionEnMinutos.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nudDuracionEnMinutos.Location = new Point(237, 320);
            nudDuracionEnMinutos.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudDuracionEnMinutos.Minimum = new decimal(new int[] { 40, 0, 0, 0 });
            nudDuracionEnMinutos.Name = "nudDuracionEnMinutos";
            nudDuracionEnMinutos.Size = new Size(327, 27);
            nudDuracionEnMinutos.TabIndex = 4;
            nudDuracionEnMinutos.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // tbPais
            // 
            tbPais.Location = new Point(237, 205);
            tbPais.Name = "tbPais";
            tbPais.Size = new Size(327, 27);
            tbPais.TabIndex = 3;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(237, 155);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(327, 27);
            tbNombre.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(75, 301);
            label6.Name = "label6";
            label6.Size = new Size(140, 62);
            label6.TabIndex = 0;
            label6.Text = "Duración en\r\nminutos:\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(117, 256);
            label5.Name = "label5";
            label5.Size = new Size(98, 31);
            label5.TabIndex = 0;
            label5.Text = "Género:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(155, 200);
            label4.Name = "label4";
            label4.Size = new Size(62, 31);
            label4.TabIndex = 0;
            label4.Text = "País:";
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(237, 103);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(327, 27);
            tbCodigo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(110, 150);
            label3.Name = "label3";
            label3.Size = new Size(107, 31);
            label3.TabIndex = 0;
            label3.Text = "Nombre:";
            // 
            // cbGenero
            // 
            cbGenero.FormattingEnabled = true;
            cbGenero.Items.AddRange(new object[] { "Comedia", "Drama", "Ciencia Ficcion", "Terror", "Anime" });
            cbGenero.Location = new Point(237, 259);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(327, 28);
            cbGenero.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(126, 99);
            label2.Name = "label2";
            label2.Size = new Size(91, 31);
            label2.TabIndex = 0;
            label2.Text = "Código:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(237, 10);
            label1.Name = "label1";
            label1.Size = new Size(307, 48);
            label1.TabIndex = 0;
            label1.Text = "Registrar Pelicula";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImage = Properties.Resources.FondoPelicula;
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(btnReportes);
            panel2.Controls.Add(btnVerPersonajes);
            panel2.Location = new Point(823, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 470);
            panel2.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(229, 62, 62);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Transparent;
            btnSalir.Location = new Point(45, 309);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(228, 54);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += button4_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(229, 62, 62);
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnReportes.ForeColor = Color.Transparent;
            btnReportes.Location = new Point(45, 233);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(228, 54);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += button3_Click;
            // 
            // btnVerPersonajes
            // 
            btnVerPersonajes.BackColor = Color.FromArgb(229, 62, 62);
            btnVerPersonajes.FlatAppearance.BorderSize = 0;
            btnVerPersonajes.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btnVerPersonajes.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnVerPersonajes.FlatStyle = FlatStyle.Flat;
            btnVerPersonajes.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnVerPersonajes.ForeColor = Color.Transparent;
            btnVerPersonajes.Location = new Point(45, 155);
            btnVerPersonajes.Name = "btnVerPersonajes";
            btnVerPersonajes.Size = new Size(228, 54);
            btnVerPersonajes.TabIndex = 5;
            btnVerPersonajes.Text = "Ver Personajes";
            btnVerPersonajes.UseVisualStyleBackColor = false;
            btnVerPersonajes.Click += button2_Click;
            // 
            // listViewPeliculas
            // 
            listViewPeliculas.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewPeliculas.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listViewPeliculas.Location = new Point(49, 516);
            listViewPeliculas.Name = "listViewPeliculas";
            listViewPeliculas.Size = new Size(1163, 400);
            listViewPeliculas.TabIndex = 0;
            listViewPeliculas.UseCompatibleStateImageBehavior = false;
            listViewPeliculas.View = View.Details;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(947, 939);
            label7.Name = "label7";
            label7.Size = new Size(208, 31);
            label7.TabIndex = 1;
            label7.Text = "Total de Peliculas:";
            // 
            // lblTotalPeliculas
            // 
            lblTotalPeliculas.AutoSize = true;
            lblTotalPeliculas.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPeliculas.ForeColor = Color.White;
            lblTotalPeliculas.Location = new Point(1171, 939);
            lblTotalPeliculas.Name = "lblTotalPeliculas";
            lblTotalPeliculas.Size = new Size(28, 31);
            lblTotalPeliculas.TabIndex = 1;
            lblTotalPeliculas.Text = "0";
            // 
            // FormPelicula
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1261, 988);
            Controls.Add(lblTotalPeliculas);
            Controls.Add(label7);
            Controls.Add(listViewPeliculas);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormPelicula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPelicula";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuracionEnMinutos).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ListView listViewPeliculas;
        private NumericUpDown nudDuracionEnMinutos;
        private TextBox tbCodigo;
        private ComboBox cbGenero;
        private Label label2;
        private TextBox tbPais;
        private TextBox tbNombre;
        private Label label6;
        private Label label4;
        private Label label3;
        private Button btnRegistrar;
        private Button btnSalir;
        private Button btnReportes;
        private Button btnVerPersonajes;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label5;
        private Label label7;
        private Label lblTotalPeliculas;
    }
}