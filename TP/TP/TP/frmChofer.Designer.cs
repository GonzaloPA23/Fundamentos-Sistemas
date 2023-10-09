namespace CapaPresentacion
{
    partial class frmChofer
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
            label1 = new Label();
            cbBusqueda = new ComboBox();
            listViewChoferes = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            panel1 = new Panel();
            dtpFechaNacimiento = new DateTimePicker();
            btnRegistrarChofer = new Button();
            txtApellido = new TextBox();
            btnCancelarChofer = new Button();
            txtCelular = new TextBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            txtDni = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtBusqueda = new TextBox();
            label2 = new Label();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            label10 = new Label();
            lblTotalChoferes = new Label();
            panel2 = new Panel();
            txtActualizarCelular = new TextBox();
            btnActualizar = new Button();
            txtActualizarCorreo = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label12 = new Label();
            label15 = new Label();
            btnEliminarChofer = new Button();
            label16 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 22);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 0;
            label1.Text = "Lista de choferes: ";
            // 
            // cbBusqueda
            // 
            cbBusqueda.Cursor = Cursors.Hand;
            cbBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Items.AddRange(new object[] { "DNI", "Nombre", "Apellido", "Celular", "Correo" });
            cbBusqueda.Location = new Point(158, 75);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(195, 28);
            cbBusqueda.TabIndex = 1;
            cbBusqueda.SelectedIndex = 0;
            // 
            // listViewChoferes
            // 
            listViewChoferes.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewChoferes.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listViewChoferes.Location = new Point(22, 116);
            listViewChoferes.MultiSelect = false;
            listViewChoferes.Name = "listViewChoferes";
            listViewChoferes.Size = new Size(868, 590);
            listViewChoferes.TabIndex = 2;
            listViewChoferes.UseCompatibleStateImageBehavior = false;
            listViewChoferes.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "DNI";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Apellido";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Celular";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Correo";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 180;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Fecha de Nacimiento";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 170;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dtpFechaNacimiento);
            panel1.Controls.Add(btnRegistrarChofer);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(btnCancelarChofer);
            panel1.Controls.Add(txtCelular);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtDni);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(935, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 435);
            panel1.TabIndex = 3;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.Location = new Point(137, 317);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(251, 27);
            dtpFechaNacimiento.TabIndex = 6;
            // 
            // btnRegistrarChofer
            // 
            btnRegistrarChofer.BackColor = Color.FromArgb(222, 108, 148);
            btnRegistrarChofer.FlatAppearance.BorderSize = 0;
            btnRegistrarChofer.FlatStyle = FlatStyle.Flat;
            btnRegistrarChofer.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarChofer.ForeColor = Color.White;
            btnRegistrarChofer.Location = new Point(218, 373);
            btnRegistrarChofer.Name = "btnRegistrarChofer";
            btnRegistrarChofer.Size = new Size(200, 37);
            btnRegistrarChofer.TabIndex = 4;
            btnRegistrarChofer.Text = "Registrar chofer";
            btnRegistrarChofer.UseVisualStyleBackColor = false;
            btnRegistrarChofer.Click += btnRegistrarChofer_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(137, 175);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "    Ruiz";
            txtApellido.Size = new Size(251, 27);
            txtApellido.TabIndex = 5;
            // 
            // btnCancelarChofer
            // 
            btnCancelarChofer.BackColor = SystemColors.ControlDarkDark;
            btnCancelarChofer.FlatAppearance.BorderSize = 0;
            btnCancelarChofer.FlatStyle = FlatStyle.Flat;
            btnCancelarChofer.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarChofer.ForeColor = Color.White;
            btnCancelarChofer.Location = new Point(13, 374);
            btnCancelarChofer.Name = "btnCancelarChofer";
            btnCancelarChofer.Size = new Size(198, 37);
            btnCancelarChofer.TabIndex = 4;
            btnCancelarChofer.Text = "Cancelar chofer";
            btnCancelarChofer.UseVisualStyleBackColor = false;
            btnCancelarChofer.Click += btnCancelarChofer_Click;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(137, 220);
            txtCelular.Name = "txtCelular";
            txtCelular.PlaceholderText = "    999345283";
            txtCelular.Size = new Size(251, 27);
            txtCelular.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(137, 266);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "    rafael.ruiz@gmail.com";
            txtCorreo.Size = new Size(251, 27);
            txtCorreo.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(137, 127);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "    Rafael";
            txtNombre.Size = new Size(251, 27);
            txtNombre.TabIndex = 5;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(137, 76);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "    5933929";
            txtDni.Size = new Size(251, 27);
            txtDni.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(26, 309);
            label9.Name = "label9";
            label9.Size = new Size(86, 40);
            label9.TabIndex = 0;
            label9.Text = "    Fecha de\r\nNacimiento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(58, 267);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 0;
            label8.Text = "Correo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(55, 223);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 0;
            label7.Text = "Celular";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(46, 177);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 0;
            label6.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(48, 127);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 0;
            label5.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(77, 76);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 0;
            label4.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 24);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 0;
            label3.Text = "Detalles del chofer:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(373, 76);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "    5933929";
            txtBusqueda.Size = new Size(256, 27);
            txtBusqueda.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 77);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 0;
            label2.Text = "Buscar por:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ControlDarkDark;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(770, 76);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 30);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(222, 108, 148);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(657, 75);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 30);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(697, 37);
            label10.Name = "label10";
            label10.Size = new Size(130, 20);
            label10.TabIndex = 0;
            label10.Text = "Total de choferes: ";
            // 
            // lblTotalChoferes
            // 
            lblTotalChoferes.AutoSize = true;
            lblTotalChoferes.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalChoferes.Location = new Point(833, 37);
            lblTotalChoferes.Name = "lblTotalChoferes";
            lblTotalChoferes.Size = new Size(17, 20);
            lblTotalChoferes.TabIndex = 0;
            lblTotalChoferes.Text = "0";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtActualizarCelular);
            panel2.Controls.Add(btnActualizar);
            panel2.Controls.Add(txtActualizarCorreo);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label15);
            panel2.Location = new Point(935, 459);
            panel2.Name = "panel2";
            panel2.Size = new Size(436, 193);
            panel2.TabIndex = 6;
            // 
            // txtActualizarCelular
            // 
            txtActualizarCelular.Location = new Point(134, 47);
            txtActualizarCelular.Name = "txtActualizarCelular";
            txtActualizarCelular.PlaceholderText = "    999345283";
            txtActualizarCelular.Size = new Size(251, 27);
            txtActualizarCelular.TabIndex = 8;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(222, 108, 148);
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(138, 142);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(200, 37);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // txtActualizarCorreo
            // 
            txtActualizarCorreo.Location = new Point(134, 93);
            txtActualizarCorreo.Name = "txtActualizarCorreo";
            txtActualizarCorreo.PlaceholderText = "    rafael.ruiz@gmail.com";
            txtActualizarCorreo.Size = new Size(251, 27);
            txtActualizarCorreo.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(55, 94);
            label13.Name = "label13";
            label13.Size = new Size(54, 20);
            label13.TabIndex = 6;
            label13.Text = "Correo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(52, 50);
            label14.Name = "label14";
            label14.Size = new Size(55, 20);
            label14.TabIndex = 7;
            label14.Text = "Celular";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(14, 9);
            label12.Name = "label12";
            label12.Size = new Size(241, 25);
            label12.TabIndex = 0;
            label12.Text = "Actualizar datos de contacto:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ButtonShadow;
            label15.Location = new Point(284, 15);
            label15.Name = "label15";
            label15.Size = new Size(135, 17);
            label15.TabIndex = 0;
            label15.Text = "Elija el dni del chofer*";
            // 
            // btnEliminarChofer
            // 
            btnEliminarChofer.BackColor = Color.FromArgb(182, 113, 137);
            btnEliminarChofer.FlatAppearance.BorderSize = 0;
            btnEliminarChofer.FlatStyle = FlatStyle.Flat;
            btnEliminarChofer.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarChofer.ForeColor = Color.White;
            btnEliminarChofer.Location = new Point(962, 672);
            btnEliminarChofer.Name = "btnEliminarChofer";
            btnEliminarChofer.Size = new Size(200, 37);
            btnEliminarChofer.TabIndex = 4;
            btnEliminarChofer.Text = "Eliminar chofer";
            btnEliminarChofer.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ButtonShadow;
            label16.Location = new Point(1198, 673);
            label16.Name = "label16";
            label16.Size = new Size(144, 34);
            label16.TabIndex = 0;
            label16.Text = "Elija el dni del chofer y \r\nconfirme su acción *";
            // 
            // frmChofer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 726);
            Controls.Add(btnEliminarChofer);
            Controls.Add(panel2);
            Controls.Add(txtBusqueda);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(panel1);
            Controls.Add(label16);
            Controls.Add(listViewChoferes);
            Controls.Add(cbBusqueda);
            Controls.Add(lblTotalChoferes);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmChofer";
            Text = "frmChofer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbBusqueda;
        private ListView listViewChoferes;
        private Panel panel1;
        private TextBox txtBusqueda;
        private Label label2;
        private Button btnLimpiar;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtApellido;
        private TextBox txtCelular;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private TextBox txtDni;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnCancelarChofer;
        private Button btnRegistrarChofer;
        private Button btnBuscar;
        private Label label10;
        private Label lblTotalChoferes;
        private Panel panel2;
        private Button btnEliminarChofer;
        private TextBox txtActualizarCelular;
        private Button btnActualizar;
        private TextBox txtActualizarCorreo;
        private Label label13;
        private Label label14;
        private Label label12;
        private Label label15;
        private Label label16;
    }
}