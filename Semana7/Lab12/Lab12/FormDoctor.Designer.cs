namespace Lab12
{
    partial class FormDoctor
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
            btnRegistrar = new Button();
            btnVerPacientes = new Button();
            btnReportes = new Button();
            btnSalir = new Button();
            tbNroColegiatura = new TextBox();
            tbEspecialidad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listViewDoctores = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            tbNombreCompleto = new TextBox();
            nupAniosExperiencia = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)nupAniosExperiencia).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.Desktop;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(157, 247);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(132, 31);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVerPacientes
            // 
            btnVerPacientes.BackColor = SystemColors.Desktop;
            btnVerPacientes.FlatAppearance.BorderSize = 0;
            btnVerPacientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnVerPacientes.FlatStyle = FlatStyle.Flat;
            btnVerPacientes.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerPacientes.ForeColor = Color.White;
            btnVerPacientes.Location = new Point(157, 286);
            btnVerPacientes.Margin = new Padding(3, 4, 3, 4);
            btnVerPacientes.Name = "btnVerPacientes";
            btnVerPacientes.Size = new Size(132, 31);
            btnVerPacientes.TabIndex = 1;
            btnVerPacientes.Text = "Ver Pacientes";
            btnVerPacientes.UseVisualStyleBackColor = false;
            btnVerPacientes.Click += btnVerPacientes_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = SystemColors.Desktop;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(157, 325);
            btnReportes.Margin = new Padding(3, 4, 3, 4);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(132, 31);
            btnReportes.TabIndex = 2;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.Desktop;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(157, 364);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(132, 31);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // tbNroColegiatura
            // 
            tbNroColegiatura.Location = new Point(171, 45);
            tbNroColegiatura.Margin = new Padding(3, 4, 3, 4);
            tbNroColegiatura.Name = "tbNroColegiatura";
            tbNroColegiatura.Size = new Size(220, 27);
            tbNroColegiatura.TabIndex = 5;
            // 
            // tbEspecialidad
            // 
            tbEspecialidad.Location = new Point(171, 122);
            tbEspecialidad.Margin = new Padding(3, 4, 3, 4);
            tbEspecialidad.Name = "tbEspecialidad";
            tbEspecialidad.Size = new Size(220, 27);
            tbEspecialidad.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 48);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 8;
            label1.Text = "Nro. Colegiatura:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 86);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 9;
            label2.Text = "Nombre Completo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(69, 125);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 10;
            label3.Text = "Especialidad:";
            // 
            // listViewDoctores
            // 
            listViewDoctores.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewDoctores.Location = new Point(434, 35);
            listViewDoctores.Margin = new Padding(3, 4, 3, 4);
            listViewDoctores.Name = "listViewDoctores";
            listViewDoctores.Size = new Size(622, 367);
            listViewDoctores.TabIndex = 12;
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
            // columnHeader4
            // 
            columnHeader4.Text = "Años de experiencia";
            columnHeader4.Width = 160;
            // 
            // tbNombreCompleto
            // 
            tbNombreCompleto.Location = new Point(170, 83);
            tbNombreCompleto.Margin = new Padding(3, 4, 3, 4);
            tbNombreCompleto.Name = "tbNombreCompleto";
            tbNombreCompleto.Size = new Size(221, 27);
            tbNombreCompleto.TabIndex = 13;
            // 
            // nupAniosExperiencia
            // 
            nupAniosExperiencia.Location = new Point(171, 173);
            nupAniosExperiencia.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nupAniosExperiencia.Name = "nupAniosExperiencia";
            nupAniosExperiencia.Size = new Size(71, 27);
            nupAniosExperiencia.TabIndex = 14;
            nupAniosExperiencia.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(72, 166);
            label4.Name = "label4";
            label4.Size = new Size(88, 40);
            label4.TabIndex = 10;
            label4.Text = "     Años de \r\nexperiencia:";
            // 
            // FormDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1104, 428);
            Controls.Add(nupAniosExperiencia);
            Controls.Add(tbNombreCompleto);
            Controls.Add(listViewDoctores);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbEspecialidad);
            Controls.Add(tbNroColegiatura);
            Controls.Add(btnSalir);
            Controls.Add(btnReportes);
            Controls.Add(btnVerPacientes);
            Controls.Add(btnRegistrar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormDoctor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDoctor";
            ((System.ComponentModel.ISupportInitialize)nupAniosExperiencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnVerPacientes;
        private Button btnReportes;
        private Button btnSalir;
        private TextBox tbNroColegiatura;
        private TextBox tbEspecialidad;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView listViewDoctores;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox tbNombreCompleto;
        private NumericUpDown nupAniosExperiencia;
        private Label label4;
        private ColumnHeader columnHeader4;
    }
}