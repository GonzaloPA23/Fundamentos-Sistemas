using System.Drawing;
using System.Windows.Forms;

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
            this.label1 = new System.Windows.Forms.Label();
            this.cbBusqueda = new System.Windows.Forms.ComboBox();
            this.listViewChoferes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarChofer = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnCancelarChofer = new System.Windows.Forms.Button();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalChoferes = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtActualizarCelular = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtActualizarCorreo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnEliminarChofer = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de choferes: ";
            // 
            // cbBusqueda
            // 
            this.cbBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusqueda.FormattingEnabled = true;
            this.cbBusqueda.Items.AddRange(new object[] {
            "DNI",
            "Nombre",
            "Apellido",
            "Celular",
            "Correo"});
            this.cbBusqueda.Location = new System.Drawing.Point(158, 75);
            this.cbBusqueda.Name = "cbBusqueda";
            this.cbBusqueda.Size = new System.Drawing.Size(195, 24);
            this.cbBusqueda.TabIndex = 1;
            // 
            // listViewChoferes
            // 
            this.listViewChoferes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewChoferes.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.listViewChoferes.HideSelection = false;
            this.listViewChoferes.Location = new System.Drawing.Point(22, 116);
            this.listViewChoferes.MultiSelect = false;
            this.listViewChoferes.Name = "listViewChoferes";
            this.listViewChoferes.Size = new System.Drawing.Size(868, 590);
            this.listViewChoferes.TabIndex = 2;
            this.listViewChoferes.UseCompatibleStateImageBehavior = false;
            this.listViewChoferes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DNI";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellido";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Celular";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Correo";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 180;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fecha de Nacimiento";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 170;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpFechaNacimiento);
            this.panel1.Controls.Add(this.btnRegistrarChofer);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.btnCancelarChofer);
            this.panel1.Controls.Add(this.txtCelular);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtDni);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(935, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 435);
            this.panel1.TabIndex = 3;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(162, 312);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(251, 22);
            this.dtpFechaNacimiento.TabIndex = 6;
            // 
            // btnRegistrarChofer
            // 
            this.btnRegistrarChofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(108)))), ((int)(((byte)(148)))));
            this.btnRegistrarChofer.FlatAppearance.BorderSize = 0;
            this.btnRegistrarChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarChofer.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.btnRegistrarChofer.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarChofer.Location = new System.Drawing.Point(243, 368);
            this.btnRegistrarChofer.Name = "btnRegistrarChofer";
            this.btnRegistrarChofer.Size = new System.Drawing.Size(200, 37);
            this.btnRegistrarChofer.TabIndex = 4;
            this.btnRegistrarChofer.Text = "Registrar chofer";
            this.btnRegistrarChofer.UseVisualStyleBackColor = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(162, 170);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(251, 22);
            this.txtApellido.TabIndex = 5;
            // 
            // btnCancelarChofer
            // 
            this.btnCancelarChofer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelarChofer.FlatAppearance.BorderSize = 0;
            this.btnCancelarChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarChofer.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelarChofer.ForeColor = System.Drawing.Color.White;
            this.btnCancelarChofer.Location = new System.Drawing.Point(38, 369);
            this.btnCancelarChofer.Name = "btnCancelarChofer";
            this.btnCancelarChofer.Size = new System.Drawing.Size(198, 37);
            this.btnCancelarChofer.TabIndex = 4;
            this.btnCancelarChofer.Text = "Cancelar chofer";
            this.btnCancelarChofer.UseVisualStyleBackColor = false;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(162, 215);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(251, 22);
            this.txtCelular.TabIndex = 5;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(162, 261);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(251, 22);
            this.txtCorreo.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(162, 122);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(251, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(162, 71);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(251, 22);
            this.txtDni.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label9.Location = new System.Drawing.Point(51, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 40);
            this.label9.TabIndex = 0;
            this.label9.Text = "    Fecha de\r\nNacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label8.Location = new System.Drawing.Point(83, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Correo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label7.Location = new System.Drawing.Point(80, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label6.Location = new System.Drawing.Point(71, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label5.Location = new System.Drawing.Point(73, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label4.Location = new System.Drawing.Point(102, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label3.Location = new System.Drawing.Point(16, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Detalles del chofer:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(373, 76);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(256, 22);
            this.txtBusqueda.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.label2.Location = new System.Drawing.Point(50, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar por:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(770, 76);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(108)))), ((int)(((byte)(148)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(657, 75);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label10.Location = new System.Drawing.Point(697, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total de choferes: ";
            // 
            // lblTotalChoferes
            // 
            this.lblTotalChoferes.AutoSize = true;
            this.lblTotalChoferes.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.lblTotalChoferes.Location = new System.Drawing.Point(833, 37);
            this.lblTotalChoferes.Name = "lblTotalChoferes";
            this.lblTotalChoferes.Size = new System.Drawing.Size(18, 20);
            this.lblTotalChoferes.TabIndex = 0;
            this.lblTotalChoferes.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtActualizarCelular);
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.txtActualizarCorreo);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(935, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 193);
            this.panel2.TabIndex = 6;
            // 
            // txtActualizarCelular
            // 
            this.txtActualizarCelular.Location = new System.Drawing.Point(158, 46);
            this.txtActualizarCelular.Name = "txtActualizarCelular";
            this.txtActualizarCelular.Size = new System.Drawing.Size(251, 22);
            this.txtActualizarCelular.TabIndex = 8;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(108)))), ((int)(((byte)(148)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(162, 141);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(200, 37);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // txtActualizarCorreo
            // 
            this.txtActualizarCorreo.Location = new System.Drawing.Point(158, 92);
            this.txtActualizarCorreo.Name = "txtActualizarCorreo";
            this.txtActualizarCorreo.Size = new System.Drawing.Size(251, 22);
            this.txtActualizarCorreo.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label13.Location = new System.Drawing.Point(79, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Correo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label14.Location = new System.Drawing.Point(76, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "Celular";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label12.Location = new System.Drawing.Point(14, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(252, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Actualizar datos de contacto:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label15.Location = new System.Drawing.Point(321, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 18);
            this.label15.TabIndex = 0;
            this.label15.Text = "Elija el dni del chofer*";
            // 
            // btnEliminarChofer
            // 
            this.btnEliminarChofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(113)))), ((int)(((byte)(137)))));
            this.btnEliminarChofer.FlatAppearance.BorderSize = 0;
            this.btnEliminarChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarChofer.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarChofer.ForeColor = System.Drawing.Color.White;
            this.btnEliminarChofer.Location = new System.Drawing.Point(962, 672);
            this.btnEliminarChofer.Name = "btnEliminarChofer";
            this.btnEliminarChofer.Size = new System.Drawing.Size(200, 37);
            this.btnEliminarChofer.TabIndex = 4;
            this.btnEliminarChofer.Text = "Eliminar chofer";
            this.btnEliminarChofer.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label16.Location = new System.Drawing.Point(1198, 673);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(157, 36);
            this.label16.TabIndex = 0;
            this.label16.Text = "Elija el dni del chofer y \r\nconfirme su acción *";
            // 
            // frmChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 726);
            this.Controls.Add(this.btnEliminarChofer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.listViewChoferes);
            this.Controls.Add(this.cbBusqueda);
            this.Controls.Add(this.lblTotalChoferes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmChofer";
            this.Text = "frmChofer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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