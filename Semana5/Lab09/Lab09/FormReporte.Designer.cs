namespace Lab09
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
            btnBuscarXNombrePokemon = new Button();
            cbRegion = new ComboBox();
            tbNombre = new TextBox();
            label4 = new Label();
            label2 = new Label();
            lblTotalEntrenadores = new Label();
            label5 = new Label();
            listViewEntrenador = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnBuscarPorRegion = new Button();
            btnBuscarEntrenadoresPorMenosPokemons = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnBuscarXNombrePokemon
            // 
            btnBuscarXNombrePokemon.Location = new Point(74, 120);
            btnBuscarXNombrePokemon.Name = "btnBuscarXNombrePokemon";
            btnBuscarXNombrePokemon.Size = new Size(246, 29);
            btnBuscarXNombrePokemon.TabIndex = 19;
            btnBuscarXNombrePokemon.Text = "Buscar por nombre Pokémon";
            btnBuscarXNombrePokemon.UseVisualStyleBackColor = true;
            btnBuscarXNombrePokemon.Click += btnBuscarXNombrePokemon_Click;
            // 
            // cbRegion
            // 
            cbRegion.FormattingEnabled = true;
            cbRegion.Location = new Point(148, 168);
            cbRegion.Name = "cbRegion";
            cbRegion.Size = new Size(186, 28);
            cbRegion.TabIndex = 15;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(148, 78);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(186, 27);
            tbNombre.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 171);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 6;
            label4.Text = "Región:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 85);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // lblTotalEntrenadores
            // 
            lblTotalEntrenadores.AutoSize = true;
            lblTotalEntrenadores.Location = new Point(765, 466);
            lblTotalEntrenadores.Name = "lblTotalEntrenadores";
            lblTotalEntrenadores.Size = new Size(17, 20);
            lblTotalEntrenadores.TabIndex = 9;
            lblTotalEntrenadores.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(623, 466);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 10;
            label5.Text = "Total entrenadores:";
            // 
            // listViewEntrenador
            // 
            listViewEntrenador.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewEntrenador.Location = new Point(463, 36);
            listViewEntrenador.Name = "listViewEntrenador";
            listViewEntrenador.Size = new Size(337, 403);
            listViewEntrenador.TabIndex = 5;
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
            // btnBuscarPorRegion
            // 
            btnBuscarPorRegion.Location = new Point(74, 216);
            btnBuscarPorRegion.Name = "btnBuscarPorRegion";
            btnBuscarPorRegion.Size = new Size(246, 29);
            btnBuscarPorRegion.TabIndex = 19;
            btnBuscarPorRegion.Text = "Buscar por Región";
            btnBuscarPorRegion.UseVisualStyleBackColor = true;
            btnBuscarPorRegion.Click += btnBuscarPorRegion_Click;
            // 
            // btnBuscarEntrenadoresPorMenosPokemons
            // 
            btnBuscarEntrenadoresPorMenosPokemons.Location = new Point(60, 284);
            btnBuscarEntrenadoresPorMenosPokemons.Name = "btnBuscarEntrenadoresPorMenosPokemons";
            btnBuscarEntrenadoresPorMenosPokemons.Size = new Size(308, 29);
            btnBuscarEntrenadoresPorMenosPokemons.TabIndex = 19;
            btnBuscarEntrenadoresPorMenosPokemons.Text = "Buscar los que tienen menos Pokemons";
            btnBuscarEntrenadoresPorMenosPokemons.UseVisualStyleBackColor = true;
            btnBuscarEntrenadoresPorMenosPokemons.Click += btnBuscarEntrenadoresPorMenosPokemons_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(118, 333);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(202, 29);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 510);
            Controls.Add(btnBuscarEntrenadoresPorMenosPokemons);
            Controls.Add(btnSalir);
            Controls.Add(btnBuscarPorRegion);
            Controls.Add(btnBuscarXNombrePokemon);
            Controls.Add(cbRegion);
            Controls.Add(tbNombre);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(lblTotalEntrenadores);
            Controls.Add(label5);
            Controls.Add(listViewEntrenador);
            Name = "FormReporte";
            Text = "FormReporte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBuscarXNombrePokemon;
        private ComboBox cbRegion;
        private TextBox tbNombre;
        private Label label4;
        private Label label2;
        private Label lblTotalEntrenadores;
        private Label label5;
        private ListView listViewEntrenador;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnBuscarPorRegion;
        private Button btnBuscarEntrenadoresPorMenosPokemons;
        private Button btnSalir;
    }
}