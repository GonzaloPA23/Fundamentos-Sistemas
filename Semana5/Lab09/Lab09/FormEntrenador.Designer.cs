namespace Lab09
{
    partial class FormEntrenador
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
            listViewEntrenador = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbCodigo = new TextBox();
            cbRegion = new ComboBox();
            tbNombre = new TextBox();
            tbEdad = new TextBox();
            btnRegistrar = new Button();
            btnVerPokemons = new Button();
            btnReportes = new Button();
            btnSalir = new Button();
            lblTotalEntrenadores = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // listViewEntrenador
            // 
            listViewEntrenador.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewEntrenador.Location = new Point(451, 29);
            listViewEntrenador.Name = "listViewEntrenador";
            listViewEntrenador.Size = new Size(337, 403);
            listViewEntrenador.TabIndex = 0;
            listViewEntrenador.UseCompatibleStateImageBehavior = false;
            listViewEntrenador.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Edad";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Región";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 48);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 98);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 146);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 1;
            label3.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 189);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 1;
            label4.Text = "Región:";
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(137, 45);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(186, 27);
            tbCodigo.TabIndex = 2;
            // 
            // cbRegion
            // 
            cbRegion.FormattingEnabled = true;
            cbRegion.Items.AddRange(new object[] { "Kanto", "Johto", "Hoenn", "Sinnoh", "Teselia/Unova", "Kalos", "Alola", "Galar", "Paldea" });
            cbRegion.Location = new Point(137, 186);
            cbRegion.Name = "cbRegion";
            cbRegion.Size = new Size(186, 28);
            cbRegion.TabIndex = 3;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(137, 91);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(186, 27);
            tbNombre.TabIndex = 2;
            // 
            // tbEdad
            // 
            tbEdad.Location = new Point(137, 139);
            tbEdad.Name = "tbEdad";
            tbEdad.Size = new Size(186, 27);
            tbEdad.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(152, 254);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVerPokemons
            // 
            btnVerPokemons.Location = new Point(137, 299);
            btnVerPokemons.Name = "btnVerPokemons";
            btnVerPokemons.Size = new Size(122, 29);
            btnVerPokemons.TabIndex = 4;
            btnVerPokemons.Text = "Ver Pokemons";
            btnVerPokemons.UseVisualStyleBackColor = true;
            btnVerPokemons.Click += btnVerPokemons_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(152, 345);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(94, 29);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(152, 388);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblTotalEntrenadores
            // 
            lblTotalEntrenadores.AutoSize = true;
            lblTotalEntrenadores.Location = new Point(753, 459);
            lblTotalEntrenadores.Name = "lblTotalEntrenadores";
            lblTotalEntrenadores.Size = new Size(17, 20);
            lblTotalEntrenadores.TabIndex = 1;
            lblTotalEntrenadores.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(611, 459);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 1;
            label5.Text = "Total entrenadores:";
            // 
            // FormEntrenador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 514);
            Controls.Add(btnSalir);
            Controls.Add(btnReportes);
            Controls.Add(btnVerPokemons);
            Controls.Add(btnRegistrar);
            Controls.Add(cbRegion);
            Controls.Add(tbEdad);
            Controls.Add(tbNombre);
            Controls.Add(tbCodigo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTotalEntrenadores);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(listViewEntrenador);
            Name = "FormEntrenador";
            Text = "FormEntrenador";
            Load += FormEntrenador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewEntrenador;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbCodigo;
        private ComboBox cbRegion;
        private TextBox tbNombre;
        private TextBox tbEdad;
        private Button btnRegistrar;
        private Button btnVerPokemons;
        private Button btnReportes;
        private Button btnSalir;
        private Label lblTotalEntrenadores;
        private Label label5;
    }
}