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
            comboBox1 = new ComboBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            textBox6 = new TextBox();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button4 = new Button();
            label10 = new Label();
            label11 = new Label();
            panel2 = new Panel();
            textBox7 = new TextBox();
            button6 = new Button();
            textBox8 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label12 = new Label();
            label15 = new Label();
            button5 = new Button();
            label16 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 22);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 0;
            label1.Text = "Lista de choferes: ";
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DNI", "Nombre", "Apellido", "Celular", "Correo" });
            comboBox1.Location = new Point(158, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 28);
            comboBox1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Location = new Point(22, 116);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(868, 590);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "DNI";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Apellido";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Celular";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Correo";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Fecha de Nacimiento";
            columnHeader6.Width = 170;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(137, 317);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(251, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(222, 108, 148);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(218, 373);
            button3.Name = "button3";
            button3.Size = new Size(200, 37);
            button3.TabIndex = 4;
            button3.Text = "Registrar chofer";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(137, 175);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "    Ruiz";
            textBox6.Size = new Size(251, 27);
            textBox6.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(13, 374);
            button1.Name = "button1";
            button1.Size = new Size(198, 37);
            button1.TabIndex = 4;
            button1.Text = "Cancelar chofer";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(137, 220);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "    999345283";
            textBox5.Size = new Size(251, 27);
            textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(137, 266);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "    rafael.ruiz@gmail.com";
            textBox4.Size = new Size(251, 27);
            textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(137, 127);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "    Rafael";
            textBox3.Size = new Size(251, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 76);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "    5933929";
            textBox2.Size = new Size(251, 27);
            textBox2.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(26, 309);
            label9.Name = "label9";
            label9.Size = new Size(86, 40);
            label9.TabIndex = 0;
            label9.Text = "    Fecha de\r\nNacimiento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(58, 267);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 0;
            label8.Text = "Correo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(55, 223);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 0;
            label7.Text = "Celular";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(46, 177);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 0;
            label6.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(48, 127);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 0;
            label5.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(77, 76);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 0;
            label4.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 24);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 0;
            label3.Text = "Detalles del chofer:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(373, 76);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "    5933929";
            textBox1.Size = new Size(256, 27);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 77);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 0;
            label2.Text = "Buscar por:";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(770, 76);
            button2.Name = "button2";
            button2.Size = new Size(100, 30);
            button2.TabIndex = 4;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(222, 108, 148);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(657, 75);
            button4.Name = "button4";
            button4.Size = new Size(100, 30);
            button4.TabIndex = 4;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(697, 37);
            label10.Name = "label10";
            label10.Size = new Size(130, 20);
            label10.TabIndex = 0;
            label10.Text = "Total de choferes: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(833, 37);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 0;
            label11.Text = "0";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label15);
            panel2.Location = new Point(935, 459);
            panel2.Name = "panel2";
            panel2.Size = new Size(436, 193);
            panel2.TabIndex = 6;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(134, 47);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "    999345283";
            textBox7.Size = new Size(251, 27);
            textBox7.TabIndex = 8;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(222, 108, 148);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(138, 142);
            button6.Name = "button6";
            button6.Size = new Size(200, 37);
            button6.TabIndex = 4;
            button6.Text = "Actualizar";
            button6.UseVisualStyleBackColor = false;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(134, 93);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "    rafael.ruiz@gmail.com";
            textBox8.Size = new Size(251, 27);
            textBox8.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(55, 94);
            label13.Name = "label13";
            label13.Size = new Size(54, 20);
            label13.TabIndex = 6;
            label13.Text = "Correo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(52, 50);
            label14.Name = "label14";
            label14.Size = new Size(55, 20);
            label14.TabIndex = 7;
            label14.Text = "Celular";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(14, 9);
            label12.Name = "label12";
            label12.Size = new Size(241, 25);
            label12.TabIndex = 0;
            label12.Text = "Actualizar datos de contacto:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ButtonShadow;
            label15.Location = new Point(284, 15);
            label15.Name = "label15";
            label15.Size = new Size(135, 17);
            label15.TabIndex = 0;
            label15.Text = "Elija el dni del chofer*";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(182, 113, 137);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(962, 672);
            button5.Name = "button5";
            button5.Size = new Size(200, 37);
            button5.TabIndex = 4;
            button5.Text = "Eliminar chofer";
            button5.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
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
            Controls.Add(button5);
            Controls.Add(panel2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(label16);
            Controls.Add(listView1);
            Controls.Add(comboBox1);
            Controls.Add(label11);
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
        private ComboBox comboBox1;
        private ListView listView1;
        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
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
        private Button button1;
        private Button button3;
        private Button button4;
        private Label label10;
        private Label label11;
        private Panel panel2;
        private Button button5;
        private TextBox textBox7;
        private Button button6;
        private TextBox textBox8;
        private Label label13;
        private Label label14;
        private Label label12;
        private Label label15;
        private Label label16;
    }
}