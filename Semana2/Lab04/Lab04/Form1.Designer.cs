namespace Lab04
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxPromedio = new System.Windows.Forms.TextBox();
            this.textBoxNombreCompleto = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÓDIGO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOMBRE COMPLETO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "PROMEDIO:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(201, 22);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(230, 22);
            this.textBoxCodigo.TabIndex = 1;
            // 
            // textBoxPromedio
            // 
            this.textBoxPromedio.Location = new System.Drawing.Point(201, 89);
            this.textBoxPromedio.Name = "textBoxPromedio";
            this.textBoxPromedio.Size = new System.Drawing.Size(230, 22);
            this.textBoxPromedio.TabIndex = 1;
            // 
            // textBoxNombreCompleto
            // 
            this.textBoxNombreCompleto.Location = new System.Drawing.Point(201, 59);
            this.textBoxNombreCompleto.Name = "textBoxNombreCompleto";
            this.textBoxNombreCompleto.Size = new System.Drawing.Size(557, 22);
            this.textBoxNombreCompleto.TabIndex = 1;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.White;
            this.buttonAgregar.Location = new System.Drawing.Point(34, 151);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(103, 31);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(273, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Mostrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(155, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(392, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 31);
            this.button4.TabIndex = 2;
            this.button4.Text = "Ordenar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "BUSCAR POR CÓDIGO:";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(201, 212);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(230, 22);
            this.textBoxBuscar.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(457, 208);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 31);
            this.button5.TabIndex = 2;
            this.button5.Text = "BUSCAR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 259);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(782, 342);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 199;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre Completo";
            this.columnHeader2.Width = 274;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Promedio";
            this.columnHeader3.Width = 232;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(810, 613);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.textBoxNombreCompleto);
            this.Controls.Add(this.textBoxPromedio);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxPromedio;
        private System.Windows.Forms.TextBox textBoxNombreCompleto;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

