namespace Lab12
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
            label3 = new Label();
            tbEspecialidad = new TextBox();
            listViewDoctores = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            listViewPacientes = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            btnBuscarDoctoresConPacientesConMayorEdad = new Button();
            btnBuscarDoctoresConMenosPacientes = new Button();
            btnBuscarPacientesPorEspecialidadDelDoctor = new Button();
            btnSalir = new Button();
            nupAniosExperiencia = new NumericUpDown();
            label4 = new Label();
            btnListarMenosIgualAniosExperienciaEspecificado = new Button();
            label1 = new Label();
            lblCantidadDoctores = new Label();
            btnOrdenarDeMayorAMenorSegunAniosExperiencia = new Button();
            cbBusqueda = new ComboBox();
            label2 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)nupAniosExperiencia).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 637);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 13;
            label3.Text = "Especialidad:";
            // 
            // tbEspecialidad
            // 
            tbEspecialidad.Location = new Point(125, 637);
            tbEspecialidad.Margin = new Padding(3, 4, 3, 4);
            tbEspecialidad.Name = "tbEspecialidad";
            tbEspecialidad.Size = new Size(241, 27);
            tbEspecialidad.TabIndex = 12;
            // 
            // listViewDoctores
            // 
            listViewDoctores.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader7 });
            listViewDoctores.Location = new Point(383, 38);
            listViewDoctores.Margin = new Padding(3, 4, 3, 4);
            listViewDoctores.Name = "listViewDoctores";
            listViewDoctores.Size = new Size(634, 316);
            listViewDoctores.TabIndex = 11;
            listViewDoctores.UseCompatibleStateImageBehavior = false;
            listViewDoctores.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nro Colegiatura";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre Completo";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Especialidad";
            columnHeader3.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Años de experiencia";
            columnHeader7.Width = 150;
            // 
            // listViewPacientes
            // 
            listViewPacientes.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader8 });
            listViewPacientes.Location = new Point(383, 410);
            listViewPacientes.Margin = new Padding(3, 4, 3, 4);
            listViewPacientes.Name = "listViewPacientes";
            listViewPacientes.Size = new Size(634, 372);
            listViewPacientes.TabIndex = 14;
            listViewPacientes.UseCompatibleStateImageBehavior = false;
            listViewPacientes.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Dni";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Nombre Completo";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Edad";
            columnHeader6.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Fecha de cita";
            columnHeader8.Width = 140;
            // 
            // btnBuscarDoctoresConPacientesConMayorEdad
            // 
            btnBuscarDoctoresConPacientesConMayorEdad.BackColor = SystemColors.Desktop;
            btnBuscarDoctoresConPacientesConMayorEdad.FlatAppearance.BorderSize = 0;
            btnBuscarDoctoresConPacientesConMayorEdad.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnBuscarDoctoresConPacientesConMayorEdad.FlatStyle = FlatStyle.Flat;
            btnBuscarDoctoresConPacientesConMayorEdad.ForeColor = Color.White;
            btnBuscarDoctoresConPacientesConMayorEdad.Location = new Point(25, 233);
            btnBuscarDoctoresConPacientesConMayorEdad.Margin = new Padding(3, 4, 3, 4);
            btnBuscarDoctoresConPacientesConMayorEdad.Name = "btnBuscarDoctoresConPacientesConMayorEdad";
            btnBuscarDoctoresConPacientesConMayorEdad.Size = new Size(334, 39);
            btnBuscarDoctoresConPacientesConMayorEdad.TabIndex = 15;
            btnBuscarDoctoresConPacientesConMayorEdad.Text = "Buscar Doctores con Pacientes con mayor edad";
            btnBuscarDoctoresConPacientesConMayorEdad.UseVisualStyleBackColor = false;
            btnBuscarDoctoresConPacientesConMayorEdad.Click += btnBuscarDoctoresConPacientesConMayorEdad_Click;
            // 
            // btnBuscarDoctoresConMenosPacientes
            // 
            btnBuscarDoctoresConMenosPacientes.BackColor = SystemColors.Desktop;
            btnBuscarDoctoresConMenosPacientes.FlatAppearance.BorderSize = 0;
            btnBuscarDoctoresConMenosPacientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnBuscarDoctoresConMenosPacientes.FlatStyle = FlatStyle.Flat;
            btnBuscarDoctoresConMenosPacientes.ForeColor = Color.White;
            btnBuscarDoctoresConMenosPacientes.Location = new Point(25, 180);
            btnBuscarDoctoresConMenosPacientes.Margin = new Padding(3, 4, 3, 4);
            btnBuscarDoctoresConMenosPacientes.Name = "btnBuscarDoctoresConMenosPacientes";
            btnBuscarDoctoresConMenosPacientes.Size = new Size(334, 39);
            btnBuscarDoctoresConMenosPacientes.TabIndex = 16;
            btnBuscarDoctoresConMenosPacientes.Text = "Buscar Doctores con Menos Pacientes";
            btnBuscarDoctoresConMenosPacientes.UseVisualStyleBackColor = false;
            btnBuscarDoctoresConMenosPacientes.Click += btnBuscarDoctoresConMenosPacientes_Click;
            // 
            // btnBuscarPacientesPorEspecialidadDelDoctor
            // 
            btnBuscarPacientesPorEspecialidadDelDoctor.BackColor = SystemColors.Desktop;
            btnBuscarPacientesPorEspecialidadDelDoctor.FlatAppearance.BorderSize = 0;
            btnBuscarPacientesPorEspecialidadDelDoctor.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnBuscarPacientesPorEspecialidadDelDoctor.FlatStyle = FlatStyle.Flat;
            btnBuscarPacientesPorEspecialidadDelDoctor.ForeColor = Color.White;
            btnBuscarPacientesPorEspecialidadDelDoctor.Location = new Point(23, 679);
            btnBuscarPacientesPorEspecialidadDelDoctor.Margin = new Padding(3, 4, 3, 4);
            btnBuscarPacientesPorEspecialidadDelDoctor.Name = "btnBuscarPacientesPorEspecialidadDelDoctor";
            btnBuscarPacientesPorEspecialidadDelDoctor.Size = new Size(343, 38);
            btnBuscarPacientesPorEspecialidadDelDoctor.TabIndex = 17;
            btnBuscarPacientesPorEspecialidadDelDoctor.Text = "Buscar Pacientes por Especialidad del Doctor";
            btnBuscarPacientesPorEspecialidadDelDoctor.UseVisualStyleBackColor = false;
            btnBuscarPacientesPorEspecialidadDelDoctor.Click += btnBuscarPacientesPorEspecialidadDelDoctor_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.Desktop;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(118, 751);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 31);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // nupAniosExperiencia
            // 
            nupAniosExperiencia.Location = new Point(203, 44);
            nupAniosExperiencia.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nupAniosExperiencia.Name = "nupAniosExperiencia";
            nupAniosExperiencia.Size = new Size(96, 27);
            nupAniosExperiencia.TabIndex = 20;
            nupAniosExperiencia.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(86, 38);
            label4.Name = "label4";
            label4.Size = new Size(88, 40);
            label4.TabIndex = 19;
            label4.Text = "     Años de \r\nexperiencia:";
            // 
            // btnListarMenosIgualAniosExperienciaEspecificado
            // 
            btnListarMenosIgualAniosExperienciaEspecificado.BackColor = SystemColors.Desktop;
            btnListarMenosIgualAniosExperienciaEspecificado.FlatAppearance.BorderSize = 0;
            btnListarMenosIgualAniosExperienciaEspecificado.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnListarMenosIgualAniosExperienciaEspecificado.FlatStyle = FlatStyle.Flat;
            btnListarMenosIgualAniosExperienciaEspecificado.ForeColor = Color.White;
            btnListarMenosIgualAniosExperienciaEspecificado.Location = new Point(25, 105);
            btnListarMenosIgualAniosExperienciaEspecificado.Name = "btnListarMenosIgualAniosExperienciaEspecificado";
            btnListarMenosIgualAniosExperienciaEspecificado.Size = new Size(334, 58);
            btnListarMenosIgualAniosExperienciaEspecificado.TabIndex = 21;
            btnListarMenosIgualAniosExperienciaEspecificado.Text = "Buscar Doctores con menos o igual de años de \r\nexperiencia especificado\r\n";
            btnListarMenosIgualAniosExperienciaEspecificado.UseVisualStyleBackColor = false;
            btnListarMenosIgualAniosExperienciaEspecificado.Click += btnListarMenosIgualAniosExperienciaEspecificado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(749, 369);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 13;
            label1.Text = "Total de Doctores:";
            // 
            // lblCantidadDoctores
            // 
            lblCantidadDoctores.AutoSize = true;
            lblCantidadDoctores.ForeColor = Color.White;
            lblCantidadDoctores.Location = new Point(894, 369);
            lblCantidadDoctores.Name = "lblCantidadDoctores";
            lblCantidadDoctores.Size = new Size(17, 20);
            lblCantidadDoctores.TabIndex = 13;
            lblCantidadDoctores.Text = "0";
            // 
            // btnOrdenarDeMayorAMenorSegunAniosExperiencia
            // 
            btnOrdenarDeMayorAMenorSegunAniosExperiencia.BackColor = SystemColors.Desktop;
            btnOrdenarDeMayorAMenorSegunAniosExperiencia.FlatAppearance.BorderSize = 0;
            btnOrdenarDeMayorAMenorSegunAniosExperiencia.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnOrdenarDeMayorAMenorSegunAniosExperiencia.FlatStyle = FlatStyle.Flat;
            btnOrdenarDeMayorAMenorSegunAniosExperiencia.ForeColor = Color.White;
            btnOrdenarDeMayorAMenorSegunAniosExperiencia.Location = new Point(25, 297);
            btnOrdenarDeMayorAMenorSegunAniosExperiencia.Name = "btnOrdenarDeMayorAMenorSegunAniosExperiencia";
            btnOrdenarDeMayorAMenorSegunAniosExperiencia.Size = new Size(334, 57);
            btnOrdenarDeMayorAMenorSegunAniosExperiencia.TabIndex = 22;
            btnOrdenarDeMayorAMenorSegunAniosExperiencia.Text = "Ordenar de mayor a menor según los años de \r\nexperiencia";
            btnOrdenarDeMayorAMenorSegunAniosExperiencia.UseVisualStyleBackColor = false;
            btnOrdenarDeMayorAMenorSegunAniosExperiencia.Click += btnOrdenarDeMayorAMenorSegunAniosExperiencia_Click;
            // 
            // cbBusqueda
            // 
            cbBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Items.AddRange(new object[] { "Dni", "Nombre", "Mes de cita" });
            cbBusqueda.Location = new Point(12, 494);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(135, 28);
            cbBusqueda.TabIndex = 23;
            cbBusqueda.SelectedIndexChanged += cbBusqueda_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 450);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 13;
            label2.Text = "Buscar por:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(162, 494);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Inserte aquí datos";
            txtBuscar.Size = new Size(204, 27);
            txtBuscar.TabIndex = 24;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.Desktop;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(108, 545);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(144, 38);
            btnBuscar.TabIndex = 25;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1047, 795);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(cbBusqueda);
            Controls.Add(btnOrdenarDeMayorAMenorSegunAniosExperiencia);
            Controls.Add(btnListarMenosIgualAniosExperienciaEspecificado);
            Controls.Add(nupAniosExperiencia);
            Controls.Add(label4);
            Controls.Add(btnSalir);
            Controls.Add(btnBuscarPacientesPorEspecialidadDelDoctor);
            Controls.Add(btnBuscarDoctoresConMenosPacientes);
            Controls.Add(btnBuscarDoctoresConPacientesConMayorEdad);
            Controls.Add(listViewPacientes);
            Controls.Add(lblCantidadDoctores);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(tbEspecialidad);
            Controls.Add(listViewDoctores);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormReporte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReporte";
            ((System.ComponentModel.ISupportInitialize)nupAniosExperiencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox tbEspecialidad;
        private ListView listViewDoctores;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView listViewPacientes;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnBuscarDoctoresConPacientesConMayorEdad;
        private Button btnBuscarDoctoresConMenosPacientes;
        private Button btnBuscarPacientesPorEspecialidadDelDoctor;
        private Button btnSalir;
        private ColumnHeader columnHeader7;
        private NumericUpDown nupAniosExperiencia;
        private Label label4;
        private Button btnListarMenosIgualAniosExperienciaEspecificado;
        private Label label1;
        private Label lblCantidadDoctores;
        private Button btnOrdenarDeMayorAMenorSegunAniosExperiencia;
        private ColumnHeader columnHeader8;
        private ComboBox cbBusqueda;
        private Label label2;
        private TextBox txtBuscar;
        private Button btnBuscar;
    }
}