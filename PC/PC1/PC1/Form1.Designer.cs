namespace PC1
{
    partial class Form1
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
            panel1 = new Panel();
            dtpFechaRegresoViaje = new DateTimePicker();
            dtpFechaSalidaViaje = new DateTimePicker();
            tbCodigoViaje = new TextBox();
            tbPrecioViaje = new TextBox();
            tbDestinoViaje = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLimpiarViaje = new Button();
            btnAgregarViaje = new Button();
            panel2 = new Panel();
            tbCodigoCliente = new TextBox();
            tbNombreCliente = new TextBox();
            tbNumeroTelefonoCliente = new TextBox();
            tbCorreoCliente = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            btnLimpiarCliente = new Button();
            btnAgregarCliente = new Button();
            listViewDatabaseViajes = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            listViewDatabaseClientes = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            panel3 = new Panel();
            tbBuscarDestino = new TextBox();
            label13 = new Label();
            btnBuscarViajesXDestino = new Button();
            panel4 = new Panel();
            tbBuscarClienteXCorreo = new TextBox();
            label14 = new Label();
            button6 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dtpFechaRegresoViaje);
            panel1.Controls.Add(dtpFechaSalidaViaje);
            panel1.Controls.Add(tbCodigoViaje);
            panel1.Controls.Add(tbPrecioViaje);
            panel1.Controls.Add(tbDestinoViaje);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLimpiarViaje);
            panel1.Controls.Add(btnAgregarViaje);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 398);
            panel1.TabIndex = 0;
            // 
            // dtpFechaRegresoViaje
            // 
            dtpFechaRegresoViaje.Location = new Point(267, 243);
            dtpFechaRegresoViaje.Name = "dtpFechaRegresoViaje";
            dtpFechaRegresoViaje.Size = new Size(250, 27);
            dtpFechaRegresoViaje.TabIndex = 5;
            // 
            // dtpFechaSalidaViaje
            // 
            dtpFechaSalidaViaje.Location = new Point(269, 197);
            dtpFechaSalidaViaje.Name = "dtpFechaSalidaViaje";
            dtpFechaSalidaViaje.Size = new Size(250, 27);
            dtpFechaSalidaViaje.TabIndex = 5;
            // 
            // tbCodigoViaje
            // 
            tbCodigoViaje.Location = new Point(269, 92);
            tbCodigoViaje.Name = "tbCodigoViaje";
            tbCodigoViaje.Size = new Size(248, 27);
            tbCodigoViaje.TabIndex = 2;
            // 
            // tbPrecioViaje
            // 
            tbPrecioViaje.Location = new Point(267, 295);
            tbPrecioViaje.Name = "tbPrecioViaje";
            tbPrecioViaje.Size = new Size(248, 27);
            tbPrecioViaje.TabIndex = 2;
            // 
            // tbDestinoViaje
            // 
            tbDestinoViaje.Location = new Point(269, 148);
            tbDestinoViaje.Name = "tbDestinoViaje";
            tbDestinoViaje.Size = new Size(248, 27);
            tbDestinoViaje.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(99, 294);
            label6.Name = "label6";
            label6.Size = new Size(164, 28);
            label6.TabIndex = 1;
            label6.Text = "Precio del Viaje:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(79, 239);
            label5.Name = "label5";
            label5.Size = new Size(182, 28);
            label5.TabIndex = 1;
            label5.Text = "Fecha de regreso:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(99, 196);
            label4.Name = "label4";
            label4.Size = new Size(161, 28);
            label4.TabIndex = 1;
            label4.Text = "Fecha de salida:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(79, 145);
            label3.Name = "label3";
            label3.Size = new Size(171, 28);
            label3.TabIndex = 1;
            label3.Text = "Destino de Viaje:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(180, 89);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 1;
            label2.Text = "Código:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(189, 17);
            label1.Name = "label1";
            label1.Size = new Size(269, 39);
            label1.TabIndex = 1;
            label1.Text = "Registro de Viajes";
            // 
            // btnLimpiarViaje
            // 
            btnLimpiarViaje.BackColor = Color.MediumBlue;
            btnLimpiarViaje.FlatAppearance.BorderSize = 0;
            btnLimpiarViaje.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
            btnLimpiarViaje.FlatAppearance.MouseOverBackColor = Color.Navy;
            btnLimpiarViaje.FlatStyle = FlatStyle.Flat;
            btnLimpiarViaje.ForeColor = Color.White;
            btnLimpiarViaje.Location = new Point(325, 344);
            btnLimpiarViaje.Name = "btnLimpiarViaje";
            btnLimpiarViaje.Size = new Size(133, 39);
            btnLimpiarViaje.TabIndex = 0;
            btnLimpiarViaje.Text = "Limpiar";
            btnLimpiarViaje.UseVisualStyleBackColor = false;
            btnLimpiarViaje.Click += btnLimpiarViaje_Click;
            // 
            // btnAgregarViaje
            // 
            btnAgregarViaje.BackColor = Color.MediumBlue;
            btnAgregarViaje.FlatAppearance.BorderSize = 0;
            btnAgregarViaje.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
            btnAgregarViaje.FlatAppearance.MouseOverBackColor = Color.Navy;
            btnAgregarViaje.FlatStyle = FlatStyle.Flat;
            btnAgregarViaje.ForeColor = Color.White;
            btnAgregarViaje.Location = new Point(143, 344);
            btnAgregarViaje.Name = "btnAgregarViaje";
            btnAgregarViaje.Size = new Size(133, 39);
            btnAgregarViaje.TabIndex = 0;
            btnAgregarViaje.Text = "Agregar";
            btnAgregarViaje.UseVisualStyleBackColor = false;
            btnAgregarViaje.Click += btnAgregarViaje_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(tbCodigoCliente);
            panel2.Controls.Add(tbNombreCliente);
            panel2.Controls.Add(tbNumeroTelefonoCliente);
            panel2.Controls.Add(tbCorreoCliente);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(btnLimpiarCliente);
            panel2.Controls.Add(btnAgregarCliente);
            panel2.Location = new Point(12, 434);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 415);
            panel2.TabIndex = 0;
            // 
            // tbCodigoCliente
            // 
            tbCodigoCliente.Location = new Point(288, 103);
            tbCodigoCliente.Name = "tbCodigoCliente";
            tbCodigoCliente.Size = new Size(211, 27);
            tbCodigoCliente.TabIndex = 13;
            // 
            // tbNombreCliente
            // 
            tbNombreCliente.Location = new Point(288, 159);
            tbNombreCliente.Name = "tbNombreCliente";
            tbNombreCliente.Size = new Size(211, 27);
            tbNombreCliente.TabIndex = 14;
            // 
            // tbNumeroTelefonoCliente
            // 
            tbNumeroTelefonoCliente.Location = new Point(288, 250);
            tbNumeroTelefonoCliente.Name = "tbNumeroTelefonoCliente";
            tbNumeroTelefonoCliente.Size = new Size(211, 27);
            tbNumeroTelefonoCliente.TabIndex = 15;
            // 
            // tbCorreoCliente
            // 
            tbCorreoCliente.Location = new Point(288, 202);
            tbCorreoCliente.Name = "tbCorreoCliente";
            tbCorreoCliente.Size = new Size(211, 27);
            tbCorreoCliente.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(62, 250);
            label8.Name = "label8";
            label8.Size = new Size(203, 28);
            label8.TabIndex = 8;
            label8.Text = "Número de teléfono:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(73, 202);
            label9.Name = "label9";
            label9.Size = new Size(192, 28);
            label9.TabIndex = 9;
            label9.Text = "Correo electrónico:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(172, 156);
            label10.Name = "label10";
            label10.Size = new Size(93, 28);
            label10.TabIndex = 10;
            label10.Text = "Nombre:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(184, 100);
            label11.Name = "label11";
            label11.Size = new Size(81, 28);
            label11.TabIndex = 11;
            label11.Text = "Código:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(188, 38);
            label12.Name = "label12";
            label12.Size = new Size(292, 39);
            label12.TabIndex = 12;
            label12.Text = "Registro de Clientes";
            // 
            // btnLimpiarCliente
            // 
            btnLimpiarCliente.BackColor = Color.MediumBlue;
            btnLimpiarCliente.FlatAppearance.BorderSize = 0;
            btnLimpiarCliente.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
            btnLimpiarCliente.FlatAppearance.MouseOverBackColor = Color.Navy;
            btnLimpiarCliente.FlatStyle = FlatStyle.Flat;
            btnLimpiarCliente.ForeColor = Color.White;
            btnLimpiarCliente.Location = new Point(325, 321);
            btnLimpiarCliente.Name = "btnLimpiarCliente";
            btnLimpiarCliente.Size = new Size(133, 39);
            btnLimpiarCliente.TabIndex = 5;
            btnLimpiarCliente.Text = "Limpiar";
            btnLimpiarCliente.UseVisualStyleBackColor = false;
            btnLimpiarCliente.Click += btnLimpiarCliente_Click;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.BackColor = Color.MediumBlue;
            btnAgregarCliente.FlatAppearance.BorderSize = 0;
            btnAgregarCliente.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
            btnAgregarCliente.FlatAppearance.MouseOverBackColor = Color.Navy;
            btnAgregarCliente.FlatStyle = FlatStyle.Flat;
            btnAgregarCliente.ForeColor = Color.White;
            btnAgregarCliente.Location = new Point(143, 321);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(133, 39);
            btnAgregarCliente.TabIndex = 6;
            btnAgregarCliente.Text = "Agregar";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // listViewDatabaseViajes
            // 
            listViewDatabaseViajes.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewDatabaseViajes.Location = new Point(627, 12);
            listViewDatabaseViajes.Name = "listViewDatabaseViajes";
            listViewDatabaseViajes.Size = new Size(650, 398);
            listViewDatabaseViajes.TabIndex = 1;
            listViewDatabaseViajes.UseCompatibleStateImageBehavior = false;
            listViewDatabaseViajes.View = View.Details;
            listViewDatabaseViajes.SelectedIndexChanged += listViewDatabaseViajes_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Destino de Viaje";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Fecha de salida";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Fecha de regreso";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Precio";
            columnHeader5.Width = 100;
            // 
            // listViewDatabaseClientes
            // 
            listViewDatabaseClientes.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            listViewDatabaseClientes.Location = new Point(627, 434);
            listViewDatabaseClientes.Name = "listViewDatabaseClientes";
            listViewDatabaseClientes.Size = new Size(646, 415);
            listViewDatabaseClientes.TabIndex = 1;
            listViewDatabaseClientes.UseCompatibleStateImageBehavior = false;
            listViewDatabaseClientes.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Código";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Nombre";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Correo electrónico";
            columnHeader9.Width = 140;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Número de teléfono";
            columnHeader10.Width = 150;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(tbBuscarDestino);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(btnBuscarViajesXDestino);
            panel3.Location = new Point(1294, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(416, 398);
            panel3.TabIndex = 0;
            // 
            // tbBuscarDestino
            // 
            tbBuscarDestino.Location = new Point(35, 188);
            tbBuscarDestino.Name = "tbBuscarDestino";
            tbBuscarDestino.Size = new Size(337, 27);
            tbBuscarDestino.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(35, 145);
            label13.Name = "label13";
            label13.Size = new Size(276, 56);
            label13.TabIndex = 3;
            label13.Text = "Buscar por destino de Viaje:\r\n\r\n";
            // 
            // btnBuscarViajesXDestino
            // 
            btnBuscarViajesXDestino.BackColor = Color.MediumBlue;
            btnBuscarViajesXDestino.FlatAppearance.BorderSize = 0;
            btnBuscarViajesXDestino.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
            btnBuscarViajesXDestino.FlatAppearance.MouseOverBackColor = Color.Navy;
            btnBuscarViajesXDestino.FlatStyle = FlatStyle.Flat;
            btnBuscarViajesXDestino.ForeColor = Color.White;
            btnBuscarViajesXDestino.Location = new Point(154, 221);
            btnBuscarViajesXDestino.Name = "btnBuscarViajesXDestino";
            btnBuscarViajesXDestino.Size = new Size(133, 39);
            btnBuscarViajesXDestino.TabIndex = 0;
            btnBuscarViajesXDestino.Text = "Buscar";
            btnBuscarViajesXDestino.UseVisualStyleBackColor = false;
            btnBuscarViajesXDestino.Click += btnBuscarViajesXDestino_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(tbBuscarClienteXCorreo);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(button6);
            panel4.Location = new Point(1294, 434);
            panel4.Name = "panel4";
            panel4.Size = new Size(416, 415);
            panel4.TabIndex = 0;
            // 
            // tbBuscarClienteXCorreo
            // 
            tbBuscarClienteXCorreo.Location = new Point(35, 178);
            tbBuscarClienteXCorreo.Name = "tbBuscarClienteXCorreo";
            tbBuscarClienteXCorreo.Size = new Size(337, 27);
            tbBuscarClienteXCorreo.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(35, 133);
            label14.Name = "label14";
            label14.Size = new Size(297, 28);
            label14.TabIndex = 7;
            label14.Text = "Buscar por correo electrónico:";
            // 
            // button6
            // 
            button6.BackColor = Color.MediumBlue;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
            button6.FlatAppearance.MouseOverBackColor = Color.Navy;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(154, 226);
            button6.Name = "button6";
            button6.Size = new Size(133, 39);
            button6.TabIndex = 6;
            button6.Text = "Buscar";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1722, 861);
            Controls.Add(listViewDatabaseClientes);
            Controls.Add(listViewDatabaseViajes);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ListView listViewDatabaseViajes;
        private ListView listViewDatabaseClientes;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private TextBox tbCodigoViaje;
        private TextBox tbDestinoViaje;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAgregarViaje;
        private Button btnLimpiarViaje;
        private TextBox tbCodigoCliente;
        private TextBox tbNombreCliente;
        private TextBox tbCorreoCliente;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btnLimpiarCliente;
        private Button btnAgregarCliente;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private TextBox tbBuscarDestino;
        private Label label13;
        private Button btnBuscarViajesXDestino;
        private TextBox tbBuscarClienteXCorreo;
        private Label label14;
        private Button button6;
        private DateTimePicker dtpFechaRegresoViaje;
        private DateTimePicker dtpFechaSalidaViaje;
        private TextBox tbNumeroTelefonoCliente;
        private TextBox tbPrecioViaje;
    }
}