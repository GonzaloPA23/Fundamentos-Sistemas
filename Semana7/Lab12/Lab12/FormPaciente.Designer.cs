using static System.Net.Mime.MediaTypeNames;

namespace Lab12
{
    partial class FormPaciente
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
            tbDni = new TextBox();
            tbNombreCompleto = new TextBox();
            tbEdad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRegistrar = new Button();
            btnSalir = new Button();
            listViewPacientes = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            dtpFechaCita = new DateTimePicker();
            label4 = new Label();
            SuspendLayout();
            // 
            // tbDni
            // 
            tbDni.Location = new Point(171, 57);
            tbDni.Margin = new Padding(3, 4, 3, 4);
            tbDni.Name = "tbDni";
            tbDni.Size = new Size(187, 27);
            tbDni.TabIndex = 0;
            // 
            // tbNombreCompleto
            // 
            tbNombreCompleto.Location = new Point(171, 100);
            tbNombreCompleto.Margin = new Padding(3, 4, 3, 4);
            tbNombreCompleto.Name = "tbNombreCompleto";
            tbNombreCompleto.Size = new Size(187, 27);
            tbNombreCompleto.TabIndex = 1;
            // 
            // tbEdad
            // 
            tbEdad.Location = new Point(171, 146);
            tbEdad.Margin = new Padding(3, 4, 3, 4);
            tbEdad.Name = "tbEdad";
            tbEdad.Size = new Size(187, 27);
            tbEdad.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(123, 61);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 4;
            label1.Text = "Dni:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 100);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 5;
            label2.Text = "Nombre Completo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(113, 146);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Edad:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.Desktop;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(138, 256);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(140, 39);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.Desktop;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(138, 319);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 39);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // listViewPacientes
            // 
            listViewPacientes.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader1 });
            listViewPacientes.Location = new Point(401, 33);
            listViewPacientes.Margin = new Padding(3, 4, 3, 4);
            listViewPacientes.Name = "listViewPacientes";
            listViewPacientes.Size = new Size(599, 349);
            listViewPacientes.TabIndex = 15;
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
            // columnHeader1
            // 
            columnHeader1.Text = "Fecha de cita";
            columnHeader1.Width = 120;
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.CustomFormat = "dd/MM/yyyy";
            dtpFechaCita.Format = DateTimePickerFormat.Custom;
            dtpFechaCita.Location = new Point(171, 195);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(187, 27);
            dtpFechaCita.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(59, 196);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 5;
            label4.Text = "Fecha de cita:";
            // 
            // FormPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1022, 408);
            Controls.Add(dtpFechaCita);
            Controls.Add(listViewPacientes);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbEdad);
            Controls.Add(tbNombreCompleto);
            Controls.Add(tbDni);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPaciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDni;
        private TextBox tbNombreCompleto;
        private TextBox tbEdad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnRegistrar;
        private Button btnSalir;
        private ListView listViewPacientes;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private DateTimePicker dtpFechaCita;
        private ColumnHeader columnHeader1;
        private Label label4;
    }
}