namespace Lab03
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTipoAuto = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoServicio = new System.Windows.Forms.ComboBox();
            this.buttonRegistrarAtencion = new System.Windows.Forms.Button();
            this.buttonActualizarVista = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotalServicio1 = new System.Windows.Forms.Label();
            this.labelTotalServicio2 = new System.Windows.Forms.Label();
            this.labelTotalServicio3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelMontoPromedio = new System.Windows.Forms.Label();
            this.labelServicioMenorDemanda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIPO DE AUTO:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 147);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(788, 286);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tipo de Auto";
            this.columnHeader1.Width = 186;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo de Servicio";
            this.columnHeader2.Width = 177;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Monto a Pagar";
            this.columnHeader3.Width = 170;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "TIPO DE SERVICIO:";
            // 
            // comboBoxTipoAuto
            // 
            this.comboBoxTipoAuto.FormattingEnabled = true;
            this.comboBoxTipoAuto.Items.AddRange(new object[] {
            "A",
            "C"});
            this.comboBoxTipoAuto.Location = new System.Drawing.Point(152, 35);
            this.comboBoxTipoAuto.Name = "comboBoxTipoAuto";
            this.comboBoxTipoAuto.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTipoAuto.TabIndex = 3;
            // 
            // comboBoxTipoServicio
            // 
            this.comboBoxTipoServicio.FormattingEnabled = true;
            this.comboBoxTipoServicio.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxTipoServicio.Location = new System.Drawing.Point(638, 35);
            this.comboBoxTipoServicio.Name = "comboBoxTipoServicio";
            this.comboBoxTipoServicio.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTipoServicio.TabIndex = 4;
            // 
            // buttonRegistrarAtencion
            // 
            this.buttonRegistrarAtencion.BackColor = System.Drawing.Color.White;
            this.buttonRegistrarAtencion.Location = new System.Drawing.Point(41, 95);
            this.buttonRegistrarAtencion.Name = "buttonRegistrarAtencion";
            this.buttonRegistrarAtencion.Size = new System.Drawing.Size(166, 34);
            this.buttonRegistrarAtencion.TabIndex = 5;
            this.buttonRegistrarAtencion.Text = "Registrar Atención";
            this.buttonRegistrarAtencion.UseVisualStyleBackColor = false;
            this.buttonRegistrarAtencion.Click += new System.EventHandler(this.buttonRegistrarAtencion_Click);
            // 
            // buttonActualizarVista
            // 
            this.buttonActualizarVista.BackColor = System.Drawing.Color.White;
            this.buttonActualizarVista.Location = new System.Drawing.Point(231, 95);
            this.buttonActualizarVista.Name = "buttonActualizarVista";
            this.buttonActualizarVista.Size = new System.Drawing.Size(166, 34);
            this.buttonActualizarVista.TabIndex = 6;
            this.buttonActualizarVista.Text = "Actualizar Vista";
            this.buttonActualizarVista.UseVisualStyleBackColor = false;
            this.buttonActualizarVista.Click += new System.EventHandler(this.buttonActualizarVista_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "SERVICIO CON MENOR DEMANDA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "TOTAL SERVICIO 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 530);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "TOTAL SERVICIO 3:";
            // 
            // labelTotalServicio1
            // 
            this.labelTotalServicio1.AutoSize = true;
            this.labelTotalServicio1.Location = new System.Drawing.Point(173, 468);
            this.labelTotalServicio1.Name = "labelTotalServicio1";
            this.labelTotalServicio1.Size = new System.Drawing.Size(14, 16);
            this.labelTotalServicio1.TabIndex = 10;
            this.labelTotalServicio1.Text = "0";
            this.labelTotalServicio1.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelTotalServicio2
            // 
            this.labelTotalServicio2.AutoSize = true;
            this.labelTotalServicio2.Location = new System.Drawing.Point(173, 497);
            this.labelTotalServicio2.Name = "labelTotalServicio2";
            this.labelTotalServicio2.Size = new System.Drawing.Size(14, 16);
            this.labelTotalServicio2.TabIndex = 11;
            this.labelTotalServicio2.Text = "0";
            // 
            // labelTotalServicio3
            // 
            this.labelTotalServicio3.AutoSize = true;
            this.labelTotalServicio3.Location = new System.Drawing.Point(173, 530);
            this.labelTotalServicio3.Name = "labelTotalServicio3";
            this.labelTotalServicio3.Size = new System.Drawing.Size(14, 16);
            this.labelTotalServicio3.TabIndex = 11;
            this.labelTotalServicio3.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "TOTAL SERVICIO 1:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(433, 497);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(224, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "MONTO PROMEDIO RECAUDADO:";
            // 
            // labelMontoPromedio
            // 
            this.labelMontoPromedio.AutoSize = true;
            this.labelMontoPromedio.Location = new System.Drawing.Point(667, 497);
            this.labelMontoPromedio.Name = "labelMontoPromedio";
            this.labelMontoPromedio.Size = new System.Drawing.Size(14, 16);
            this.labelMontoPromedio.TabIndex = 11;
            this.labelMontoPromedio.Text = "0";
            // 
            // labelServicioMenorDemanda
            // 
            this.labelServicioMenorDemanda.AutoSize = true;
            this.labelServicioMenorDemanda.Location = new System.Drawing.Point(667, 468);
            this.labelServicioMenorDemanda.Name = "labelServicioMenorDemanda";
            this.labelServicioMenorDemanda.Size = new System.Drawing.Size(11, 16);
            this.labelServicioMenorDemanda.TabIndex = 11;
            this.labelServicioMenorDemanda.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 582);
            this.Controls.Add(this.labelServicioMenorDemanda);
            this.Controls.Add(this.labelMontoPromedio);
            this.Controls.Add(this.labelTotalServicio3);
            this.Controls.Add(this.labelTotalServicio2);
            this.Controls.Add(this.labelTotalServicio1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonActualizarVista);
            this.Controls.Add(this.buttonRegistrarAtencion);
            this.Controls.Add(this.comboBoxTipoServicio);
            this.Controls.Add(this.comboBoxTipoAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SERVICIO CON MENOR DEMANDA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTipoAuto;
        private System.Windows.Forms.ComboBox comboBoxTipoServicio;
        private System.Windows.Forms.Button buttonRegistrarAtencion;
        private System.Windows.Forms.Button buttonActualizarVista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTotalServicio1;
        private System.Windows.Forms.Label labelTotalServicio2;
        private System.Windows.Forms.Label labelTotalServicio3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelMontoPromedio;
        private System.Windows.Forms.Label labelServicioMenorDemanda;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

