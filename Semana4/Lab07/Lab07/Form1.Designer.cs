namespace Lab07
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
            textBoxDni = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxNombre = new TextBox();
            textBoxEdad = new TextBox();
            button1 = new Button();
            button2 = new Button();
            listViewAlumnos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 29);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 67);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 0;
            label2.Text = "DNI:";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(119, 29);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(201, 27);
            textBoxCodigo.TabIndex = 1;
            // 
            // textBoxDni
            // 
            textBoxDni.Location = new Point(119, 67);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(201, 27);
            textBoxDni.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(463, 29);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 0;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 67);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 0;
            label4.Text = "Edad:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(536, 29);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(201, 27);
            textBoxNombre.TabIndex = 1;
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(536, 67);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(201, 27);
            textBoxEdad.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(52, 131);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonAgregar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(184, 131);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonEliminar_Click;
            // 
            // listViewAlumnos
            // 
            listViewAlumnos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewAlumnos.Location = new Point(22, 179);
            listViewAlumnos.Name = "listViewAlumnos";
            listViewAlumnos.Size = new Size(758, 259);
            listViewAlumnos.TabIndex = 3;
            listViewAlumnos.UseCompatibleStateImageBehavior = false;
            listViewAlumnos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "DNI";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Edad";
            columnHeader4.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewAlumnos);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxEdad);
            Controls.Add(textBoxDni);
            Controls.Add(textBoxNombre);
            Controls.Add(label4);
            Controls.Add(textBoxCodigo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxCodigo;
        private TextBox textBoxDni;
        private Label label3;
        private Label label4;
        private TextBox textBoxNombre;
        private TextBox textBoxEdad;
        private Button button1;
        private Button button2;
        private ListView listViewAlumnos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}