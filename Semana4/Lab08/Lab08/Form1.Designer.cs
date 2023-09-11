namespace Lab08
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
            label6 = new Label();
            tbTelefonoAgencia = new TextBox();
            label5 = new Label();
            tbCiudadAgencia = new TextBox();
            label4 = new Label();
            tbDireccionAgencia = new TextBox();
            label3 = new Label();
            tbCodigoAgencia = new TextBox();
            btnLimpiarAgencia = new Button();
            btnAgregarAgencia = new Button();
            label1 = new Label();
            panel2 = new Panel();
            cbCondicionInmueble = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label2 = new Label();
            tbPrecioInmueble = new TextBox();
            label8 = new Label();
            label9 = new Label();
            btnAgregarInmueble = new Button();
            tbSuperficieInmueble = new TextBox();
            btnLimpiarInmueble = new Button();
            tbCodigoInmueble = new TextBox();
            tbDireccionInmueble = new TextBox();
            label7 = new Label();
            listViewAgencia = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            listViewInmueble = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            panel3 = new Panel();
            btnTienenMásInmueblesEnVenta = new Button();
            btnAlquilanInmueblesConMayorFrecuencia = new Button();
            panel4 = new Panel();
            label13 = new Label();
            lbMontoTotalAlquiler = new Label();
            label12 = new Label();
            tbBuscarPorAgencia = new TextBox();
            btnBuscarVenta = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(tbTelefonoAgencia);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbCiudadAgencia);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbDireccionAgencia);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbCodigoAgencia);
            panel1.Controls.Add(btnLimpiarAgencia);
            panel1.Controls.Add(btnAgregarAgencia);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(22, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 331);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(37, 193);
            label6.Name = "label6";
            label6.Size = new Size(90, 24);
            label6.TabIndex = 3;
            label6.Text = "Teléfono:";
            // 
            // tbTelefonoAgencia
            // 
            tbTelefonoAgencia.Location = new Point(133, 193);
            tbTelefonoAgencia.Name = "tbTelefonoAgencia";
            tbTelefonoAgencia.Size = new Size(241, 27);
            tbTelefonoAgencia.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(60, 149);
            label5.Name = "label5";
            label5.Size = new Size(67, 24);
            label5.TabIndex = 3;
            label5.Text = "Ciudad:";
            // 
            // tbCiudadAgencia
            // 
            tbCiudadAgencia.Location = new Point(133, 149);
            tbCiudadAgencia.Name = "tbCiudadAgencia";
            tbCiudadAgencia.Size = new Size(241, 27);
            tbCiudadAgencia.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(37, 105);
            label4.Name = "label4";
            label4.Size = new Size(90, 24);
            label4.TabIndex = 3;
            label4.Text = "Dirección:";
            // 
            // tbDireccionAgencia
            // 
            tbDireccionAgencia.Location = new Point(133, 105);
            tbDireccionAgencia.Name = "tbDireccionAgencia";
            tbDireccionAgencia.Size = new Size(241, 27);
            tbDireccionAgencia.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(59, 64);
            label3.Name = "label3";
            label3.Size = new Size(68, 24);
            label3.TabIndex = 3;
            label3.Text = "Código:";
            // 
            // tbCodigoAgencia
            // 
            tbCodigoAgencia.Location = new Point(133, 64);
            tbCodigoAgencia.Name = "tbCodigoAgencia";
            tbCodigoAgencia.Size = new Size(241, 27);
            tbCodigoAgencia.TabIndex = 2;
            // 
            // btnLimpiarAgencia
            // 
            btnLimpiarAgencia.BackColor = Color.White;
            btnLimpiarAgencia.Location = new Point(37, 280);
            btnLimpiarAgencia.Name = "btnLimpiarAgencia";
            btnLimpiarAgencia.Size = new Size(337, 35);
            btnLimpiarAgencia.TabIndex = 1;
            btnLimpiarAgencia.Text = "Limpiar";
            btnLimpiarAgencia.UseVisualStyleBackColor = false;
            btnLimpiarAgencia.Click += btnLimpiarAgencia_Click;
            // 
            // btnAgregarAgencia
            // 
            btnAgregarAgencia.BackColor = Color.White;
            btnAgregarAgencia.Location = new Point(37, 237);
            btnAgregarAgencia.Name = "btnAgregarAgencia";
            btnAgregarAgencia.Size = new Size(337, 37);
            btnAgregarAgencia.TabIndex = 1;
            btnAgregarAgencia.Text = "Agregar";
            btnAgregarAgencia.UseVisualStyleBackColor = false;
            btnAgregarAgencia.Click += btnAgregarAgencia_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(175, 16);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "AGENCIA";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(cbCondicionInmueble);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tbPrecioInmueble);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(btnAgregarInmueble);
            panel2.Controls.Add(tbSuperficieInmueble);
            panel2.Controls.Add(btnLimpiarInmueble);
            panel2.Controls.Add(tbCodigoInmueble);
            panel2.Controls.Add(tbDireccionInmueble);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(471, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(636, 384);
            panel2.TabIndex = 0;
            // 
            // cbCondicionInmueble
            // 
            cbCondicionInmueble.FormattingEnabled = true;
            cbCondicionInmueble.Items.AddRange(new object[] { "Venta", "Alquiler" });
            cbCondicionInmueble.Location = new Point(179, 233);
            cbCondicionInmueble.Name = "cbCondicionInmueble";
            cbCondicionInmueble.Size = new Size(393, 28);
            cbCondicionInmueble.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(88, 233);
            label11.Name = "label11";
            label11.Size = new Size(85, 24);
            label11.TabIndex = 3;
            label11.Text = "Condición";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(105, 196);
            label10.Name = "label10";
            label10.Size = new Size(65, 24);
            label10.TabIndex = 3;
            label10.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(293, 16);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 0;
            label2.Text = "INMUEBLE";
            // 
            // tbPrecioInmueble
            // 
            tbPrecioInmueble.Location = new Point(179, 193);
            tbPrecioInmueble.Name = "tbPrecioInmueble";
            tbPrecioInmueble.Size = new Size(393, 27);
            tbPrecioInmueble.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(83, 105);
            label8.Name = "label8";
            label8.Size = new Size(90, 24);
            label8.TabIndex = 3;
            label8.Text = "Dirección:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(74, 149);
            label9.Name = "label9";
            label9.Size = new Size(99, 24);
            label9.TabIndex = 3;
            label9.Text = "Superficie:";
            // 
            // btnAgregarInmueble
            // 
            btnAgregarInmueble.BackColor = Color.White;
            btnAgregarInmueble.Location = new Point(83, 284);
            btnAgregarInmueble.Name = "btnAgregarInmueble";
            btnAgregarInmueble.Size = new Size(489, 37);
            btnAgregarInmueble.TabIndex = 1;
            btnAgregarInmueble.Text = "Agregar";
            btnAgregarInmueble.UseVisualStyleBackColor = false;
            btnAgregarInmueble.Click += btnAgregarInmueble_Click;
            // 
            // tbSuperficieInmueble
            // 
            tbSuperficieInmueble.Location = new Point(179, 149);
            tbSuperficieInmueble.Name = "tbSuperficieInmueble";
            tbSuperficieInmueble.Size = new Size(393, 27);
            tbSuperficieInmueble.TabIndex = 2;
            // 
            // btnLimpiarInmueble
            // 
            btnLimpiarInmueble.BackColor = Color.White;
            btnLimpiarInmueble.Location = new Point(83, 327);
            btnLimpiarInmueble.Name = "btnLimpiarInmueble";
            btnLimpiarInmueble.Size = new Size(489, 35);
            btnLimpiarInmueble.TabIndex = 1;
            btnLimpiarInmueble.Text = "Limpiar";
            btnLimpiarInmueble.UseVisualStyleBackColor = false;
            btnLimpiarInmueble.Click += btnLimpiarInmueble_Click;
            // 
            // tbCodigoInmueble
            // 
            tbCodigoInmueble.Location = new Point(179, 64);
            tbCodigoInmueble.Name = "tbCodigoInmueble";
            tbCodigoInmueble.Size = new Size(393, 27);
            tbCodigoInmueble.TabIndex = 2;
            // 
            // tbDireccionInmueble
            // 
            tbDireccionInmueble.Location = new Point(179, 105);
            tbDireccionInmueble.Name = "tbDireccionInmueble";
            tbDireccionInmueble.Size = new Size(393, 27);
            tbDireccionInmueble.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(105, 64);
            label7.Name = "label7";
            label7.Size = new Size(68, 24);
            label7.TabIndex = 3;
            label7.Text = "Código:";
            // 
            // listViewAgencia
            // 
            listViewAgencia.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewAgencia.Location = new Point(22, 378);
            listViewAgencia.Name = "listViewAgencia";
            listViewAgencia.Size = new Size(420, 301);
            listViewAgencia.TabIndex = 1;
            listViewAgencia.UseCompatibleStateImageBehavior = false;
            listViewAgencia.View = View.Details;
            listViewAgencia.SelectedIndexChanged += listViewAgencia_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Dirección";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ciudad";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Teléfono";
            columnHeader4.Width = 100;
            // 
            // listViewInmueble
            // 
            listViewInmueble.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            listViewInmueble.Location = new Point(471, 424);
            listViewInmueble.Name = "listViewInmueble";
            listViewInmueble.Size = new Size(636, 299);
            listViewInmueble.TabIndex = 1;
            listViewInmueble.UseCompatibleStateImageBehavior = false;
            listViewInmueble.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Código";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Dirección";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Superficie";
            columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Precio";
            columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Condición";
            columnHeader9.Width = 120;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(btnTienenMásInmueblesEnVenta);
            panel3.Controls.Add(btnAlquilanInmueblesConMayorFrecuencia);
            panel3.Location = new Point(22, 703);
            panel3.Name = "panel3";
            panel3.Size = new Size(420, 169);
            panel3.TabIndex = 0;
            // 
            // btnTienenMásInmueblesEnVenta
            // 
            btnTienenMásInmueblesEnVenta.BackColor = Color.White;
            btnTienenMásInmueblesEnVenta.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnTienenMásInmueblesEnVenta.Location = new Point(15, 86);
            btnTienenMásInmueblesEnVenta.Name = "btnTienenMásInmueblesEnVenta";
            btnTienenMásInmueblesEnVenta.Size = new Size(387, 61);
            btnTienenMásInmueblesEnVenta.TabIndex = 1;
            btnTienenMásInmueblesEnVenta.Text = "Buscar las que tienen más inmuebles en venta";
            btnTienenMásInmueblesEnVenta.UseVisualStyleBackColor = false;
            btnTienenMásInmueblesEnVenta.Click += btnTienenMásInmueblesEnVenta_Click;
            // 
            // btnAlquilanInmueblesConMayorFrecuencia
            // 
            btnAlquilanInmueblesConMayorFrecuencia.BackColor = Color.White;
            btnAlquilanInmueblesConMayorFrecuencia.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlquilanInmueblesConMayorFrecuencia.Location = new Point(15, 19);
            btnAlquilanInmueblesConMayorFrecuencia.Name = "btnAlquilanInmueblesConMayorFrecuencia";
            btnAlquilanInmueblesConMayorFrecuencia.Size = new Size(387, 61);
            btnAlquilanInmueblesConMayorFrecuencia.TabIndex = 1;
            btnAlquilanInmueblesConMayorFrecuencia.Text = "Buscar las que alquilan inmuebles con \r\nmayor superficie";
            btnAlquilanInmueblesConMayorFrecuencia.UseVisualStyleBackColor = false;
            btnAlquilanInmueblesConMayorFrecuencia.Click += btnAlquilanInmueblesConMayorFrecuencia_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(label13);
            panel4.Controls.Add(lbMontoTotalAlquiler);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(tbBuscarPorAgencia);
            panel4.Controls.Add(btnBuscarVenta);
            panel4.Location = new Point(471, 743);
            panel4.Name = "panel4";
            panel4.Size = new Size(636, 129);
            panel4.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(10, 83);
            label13.Name = "label13";
            label13.Size = new Size(176, 24);
            label13.TabIndex = 3;
            label13.Text = "Monto total alquiler:";
            // 
            // lbMontoTotalAlquiler
            // 
            lbMontoTotalAlquiler.AutoSize = true;
            lbMontoTotalAlquiler.BackColor = Color.White;
            lbMontoTotalAlquiler.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbMontoTotalAlquiler.Location = new Point(202, 83);
            lbMontoTotalAlquiler.Name = "lbMontoTotalAlquiler";
            lbMontoTotalAlquiler.Size = new Size(20, 24);
            lbMontoTotalAlquiler.TabIndex = 3;
            lbMontoTotalAlquiler.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(21, 26);
            label12.Name = "label12";
            label12.Size = new Size(165, 24);
            label12.TabIndex = 3;
            label12.Text = "Buscar por agencia:";
            // 
            // tbBuscarPorAgencia
            // 
            tbBuscarPorAgencia.Location = new Point(192, 26);
            tbBuscarPorAgencia.Name = "tbBuscarPorAgencia";
            tbBuscarPorAgencia.Size = new Size(280, 27);
            tbBuscarPorAgencia.TabIndex = 2;
            // 
            // btnBuscarVenta
            // 
            btnBuscarVenta.BackColor = Color.White;
            btnBuscarVenta.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarVenta.Location = new Point(478, 26);
            btnBuscarVenta.Name = "btnBuscarVenta";
            btnBuscarVenta.Size = new Size(122, 30);
            btnBuscarVenta.TabIndex = 1;
            btnBuscarVenta.Text = "Buscar Venta";
            btnBuscarVenta.UseVisualStyleBackColor = false;
            btnBuscarVenta.Click += btnBuscarVenta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 884);
            Controls.Add(listViewInmueble);
            Controls.Add(listViewAgencia);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ListView listViewAgencia;
        private ListView listViewInmueble;
        private Panel panel3;
        private Panel panel4;
        private TextBox tbCodigoAgencia;
        private Button btnAgregarAgencia;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label6;
        private TextBox tbTelefonoAgencia;
        private Label label5;
        private TextBox tbCiudadAgencia;
        private Label label4;
        private TextBox tbDireccionAgencia;
        private Button btnLimpiarAgencia;
        private ComboBox cbCondicionInmueble;
        private Label label11;
        private Label label10;
        private TextBox tbPrecioInmueble;
        private Label label8;
        private Label label9;
        private Button btnAgregarInmueble;
        private TextBox tbSuperficieInmueble;
        private Button btnLimpiarInmueble;
        private TextBox tbCodigoInmueble;
        private TextBox tbDireccionInmueble;
        private Label label7;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Button btnTienenMásInmueblesEnVenta;
        private Button btnAlquilanInmueblesConMayorFrecuencia;
        private Label label13;
        private Label label12;
        private TextBox tbBuscarPorAgencia;
        private Button btnBuscarVenta;
        private Label lbMontoTotalAlquiler;
    }
}