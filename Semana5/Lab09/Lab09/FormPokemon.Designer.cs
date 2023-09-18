namespace Lab09
{
    partial class FormPokemon
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
            listViewPokemones = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label1 = new Label();
            checkBoxEsLegendario = new CheckBox();
            cbTipo = new ComboBox();
            tbCodigo = new TextBox();
            btnRegistrar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbNombre = new TextBox();
            tbApodo = new TextBox();
            tbPuertoSalud = new TextBox();
            btnSalir = new Button();
            label = new Label();
            label6 = new Label();
            lbTotalPokemons = new Label();
            lbTotalPSPokemons = new Label();
            SuspendLayout();
            // 
            // listViewPokemones
            // 
            listViewPokemones.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewPokemones.Location = new Point(446, 22);
            listViewPokemones.Name = "listViewPokemones";
            listViewPokemones.Size = new Size(439, 448);
            listViewPokemones.TabIndex = 0;
            listViewPokemones.UseCompatibleStateImageBehavior = false;
            listViewPokemones.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Codigo";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Apodo";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tipo";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Puerto Salud";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Legendario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 54);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Código:";
            // 
            // checkBoxEsLegendario
            // 
            checkBoxEsLegendario.AutoSize = true;
            checkBoxEsLegendario.Location = new Point(165, 262);
            checkBoxEsLegendario.Name = "checkBoxEsLegendario";
            checkBoxEsLegendario.Size = new Size(124, 24);
            checkBoxEsLegendario.TabIndex = 2;
            checkBoxEsLegendario.Text = "Es Legendario";
            checkBoxEsLegendario.UseVisualStyleBackColor = true;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Acero", "Agua", "Bicho", "Dragón", "Eléctrico", "Fantasma", "Fuego", "Hada", "Hielo", "Lucha", "Normal", "Planta", "Psíquico", "Roca", "Siniestro", "Tierra", "Veneno", "Volador" });
            cbTipo.Location = new Point(138, 164);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(236, 28);
            cbTipo.TabIndex = 3;
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(138, 51);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(236, 27);
            tbCodigo.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(155, 317);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(145, 29);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Registrar Pokémon";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 91);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 131);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 1;
            label3.Text = "Apodo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 167);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 1;
            label4.Text = "Tipo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 206);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 1;
            label5.Text = "Puerto Salud:";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(138, 88);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(236, 27);
            tbNombre.TabIndex = 4;
            // 
            // tbApodo
            // 
            tbApodo.Location = new Point(138, 128);
            tbApodo.Name = "tbApodo";
            tbApodo.Size = new Size(236, 27);
            tbApodo.TabIndex = 4;
            // 
            // tbPuertoSalud
            // 
            tbPuertoSalud.Location = new Point(138, 203);
            tbPuertoSalud.Name = "tbPuertoSalud";
            tbPuertoSalud.Size = new Size(236, 27);
            tbPuertoSalud.TabIndex = 4;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(155, 375);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(145, 29);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(612, 495);
            label.Name = "label";
            label.Size = new Size(137, 20);
            label.TabIndex = 1;
            label.Text = "Total de Pokemons:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(571, 524);
            label6.Name = "label6";
            label6.Size = new Size(178, 20);
            label6.TabIndex = 1;
            label6.Text = "Total de PS de Pokemons:";
            // 
            // lbTotalPokemons
            // 
            lbTotalPokemons.AutoSize = true;
            lbTotalPokemons.Location = new Point(771, 495);
            lbTotalPokemons.Name = "lbTotalPokemons";
            lbTotalPokemons.Size = new Size(17, 20);
            lbTotalPokemons.TabIndex = 1;
            lbTotalPokemons.Text = "0";
            // 
            // lbTotalPSPokemons
            // 
            lbTotalPSPokemons.AutoSize = true;
            lbTotalPSPokemons.Location = new Point(771, 524);
            lbTotalPSPokemons.Name = "lbTotalPSPokemons";
            lbTotalPSPokemons.Size = new Size(17, 20);
            lbTotalPSPokemons.TabIndex = 1;
            lbTotalPSPokemons.Text = "0";
            // 
            // FormPokemon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 563);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(tbPuertoSalud);
            Controls.Add(tbApodo);
            Controls.Add(tbNombre);
            Controls.Add(tbCodigo);
            Controls.Add(cbTipo);
            Controls.Add(checkBoxEsLegendario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbTotalPSPokemons);
            Controls.Add(lbTotalPokemons);
            Controls.Add(label6);
            Controls.Add(label);
            Controls.Add(label1);
            Controls.Add(listViewPokemones);
            Name = "FormPokemon";
            Text = "FormPokemon";
            Load += FormPokemon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewPokemones;
        private Label label1;
        private CheckBox checkBoxEsLegendario;
        private ComboBox cbTipo;
        private TextBox tbCodigo;
        private Button btnRegistrar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbNombre;
        private TextBox tbApodo;
        private TextBox tbPuertoSalud;
        private Button btnSalir;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label;
        private Label label6;
        private Label lbTotalPokemons;
        private Label lbTotalPSPokemons;
    }
}