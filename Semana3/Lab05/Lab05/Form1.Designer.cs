namespace Lab05
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
            label1 = new Label();
            label2 = new Label();
            textBoxCodigo = new TextBox();
            label3 = new Label();
            textBoxNombre = new TextBox();
            label4 = new Label();
            textBoxPrecio = new TextBox();
            numericUpDownStock = new NumericUpDown();
            buttonRegistrar = new Button();
            buttonEliminar = new Button();
            buttonEliminarTodo = new Button();
            buttonOrdenar = new Button();
            label5 = new Label();
            textBoxBuscarXNombre = new TextBox();
            buttonBuscar = new Button();
            buttonLimpiar = new Button();
            label6 = new Label();
            label7 = new Label();
            labelTotalRegistros = new Label();
            labelTotalStock = new Label();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            listViewDatabase = new ListView();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 30);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "CÓDIGO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 80);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 0;
            label2.Text = "STOCK:";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(132, 27);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(246, 27);
            textBoxCodigo.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(490, 30);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 0;
            label3.Text = "NOMBRE:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(569, 27);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(417, 27);
            textBoxNombre.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(490, 80);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 0;
            label4.Text = "PRECIO:";
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(569, 80);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(191, 27);
            textBoxPrecio.TabIndex = 1;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(132, 81);
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(150, 27);
            numericUpDownStock.TabIndex = 3;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.BackColor = Color.White;
            buttonRegistrar.Location = new Point(41, 152);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(94, 29);
            buttonRegistrar.TabIndex = 4;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = false;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.White;
            buttonEliminar.Location = new Point(167, 152);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(94, 29);
            buttonEliminar.TabIndex = 4;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonEliminarTodo
            // 
            buttonEliminarTodo.BackColor = Color.White;
            buttonEliminarTodo.Location = new Point(300, 152);
            buttonEliminarTodo.Name = "buttonEliminarTodo";
            buttonEliminarTodo.Size = new Size(131, 29);
            buttonEliminarTodo.TabIndex = 4;
            buttonEliminarTodo.Text = "Eliminar Todo";
            buttonEliminarTodo.UseVisualStyleBackColor = false;
            buttonEliminarTodo.Click += buttonEliminarTodo_Click;
            // 
            // buttonOrdenar
            // 
            buttonOrdenar.BackColor = Color.White;
            buttonOrdenar.Location = new Point(457, 152);
            buttonOrdenar.Name = "buttonOrdenar";
            buttonOrdenar.Size = new Size(94, 29);
            buttonOrdenar.TabIndex = 4;
            buttonOrdenar.Text = "Ordenar";
            buttonOrdenar.UseVisualStyleBackColor = false;
            buttonOrdenar.Click += buttonOrdenar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 221);
            label5.Name = "label5";
            label5.Size = new Size(164, 20);
            label5.TabIndex = 0;
            label5.Text = "BUSCAR POR NOMBRE:";
            // 
            // textBoxBuscarXNombre
            // 
            textBoxBuscarXNombre.Location = new Point(211, 218);
            textBoxBuscarXNombre.Name = "textBoxBuscarXNombre";
            textBoxBuscarXNombre.Size = new Size(299, 27);
            textBoxBuscarXNombre.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.White;
            buttonBuscar.Location = new Point(550, 216);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 29);
            buttonBuscar.TabIndex = 4;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.White;
            buttonLimpiar.Location = new Point(650, 217);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(94, 29);
            buttonLimpiar.TabIndex = 4;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(736, 663);
            label6.Name = "label6";
            label6.Size = new Size(155, 20);
            label6.TabIndex = 6;
            label6.Text = "TOTAL DE REGISTROS:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(767, 705);
            label7.Name = "label7";
            label7.Size = new Size(124, 20);
            label7.TabIndex = 6;
            label7.Text = "TOTAL EN STOCK:";
            // 
            // labelTotalRegistros
            // 
            labelTotalRegistros.AutoSize = true;
            labelTotalRegistros.Location = new Point(904, 663);
            labelTotalRegistros.Name = "labelTotalRegistros";
            labelTotalRegistros.Size = new Size(17, 20);
            labelTotalRegistros.TabIndex = 6;
            labelTotalRegistros.Text = "0";
            // 
            // labelTotalStock
            // 
            labelTotalStock.AutoSize = true;
            labelTotalStock.Location = new Point(904, 705);
            labelTotalStock.Name = "labelTotalStock";
            labelTotalStock.Size = new Size(17, 20);
            labelTotalStock.TabIndex = 6;
            labelTotalStock.Text = "0";
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
            columnHeader3.Text = "Stock";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Precio";
            // 
            // listViewDatabase
            // 
            listViewDatabase.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewDatabase.Location = new Point(41, 279);
            listViewDatabase.Name = "listViewDatabase";
            listViewDatabase.Size = new Size(945, 365);
            listViewDatabase.TabIndex = 5;
            listViewDatabase.UseCompatibleStateImageBehavior = false;
            listViewDatabase.View = View.Details;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 757);
            Controls.Add(listViewDatabase);
            Controls.Add(labelTotalStock);
            Controls.Add(label7);
            Controls.Add(labelTotalRegistros);
            Controls.Add(label6);
            Controls.Add(buttonOrdenar);
            Controls.Add(buttonEliminarTodo);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonRegistrar);
            Controls.Add(numericUpDownStock);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxPrecio);
            Controls.Add(textBoxBuscarXNombre);
            Controls.Add(textBoxCodigo);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxCodigo;
        private Label label3;
        private TextBox textBoxNombre;
        private Label label4;
        private TextBox textBoxPrecio;
        private NumericUpDown numericUpDownStock;
        private Button buttonRegistrar;
        private Button buttonEliminar;
        private Button buttonEliminarTodo;
        private Button buttonOrdenar;
        private Label label5;
        private TextBox textBoxBuscarXNombre;
        private Button buttonBuscar;
        private Button buttonLimpiar;
        private Label label6;
        private Label label7;
        private Label labelTotalRegistros;
        private Label labelTotalStock;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView listViewDatabase;
    }
}