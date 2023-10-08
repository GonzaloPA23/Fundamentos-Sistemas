namespace CapaPresentacion
{
    partial class frmPasaje
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
            listView2 = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label17 = new Label();
            panel1 = new Panel();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            label6 = new Label();
            label12 = new Label();
            label2 = new Label();
            button3 = new Button();
            button1 = new Button();
            label3 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            label4 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14 });
            listView2.Location = new Point(22, 68);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(882, 633);
            listView2.TabIndex = 22;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Matricula";
            columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Asientos disponibles";
            columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Tipo de bus";
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Fecha de salida";
            columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Punto de salida";
            columnHeader11.Width = 120;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Destino";
            columnHeader12.Width = 90;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Fecha de llegada";
            columnHeader13.Width = 130;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Precio";
            columnHeader14.Width = 70;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(849, 31);
            label13.Name = "label13";
            label13.Size = new Size(17, 20);
            label13.TabIndex = 19;
            label13.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(728, 30);
            label14.Name = "label14";
            label14.Size = new Size(111, 20);
            label14.TabIndex = 20;
            label14.Text = "Total de buses: ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(22, 23);
            label15.Name = "label15";
            label15.Size = new Size(111, 28);
            label15.TabIndex = 21;
            label15.Text = "Elija su bus:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ButtonShadow;
            label17.Location = new Point(469, 30);
            label17.Name = "label17";
            label17.Size = new Size(223, 17);
            label17.TabIndex = 23;
            label17.Text = "Elija la matricula y confirme su viaje *";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(936, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 228);
            panel1.TabIndex = 24;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Chiclayo", "Tumbes", "Piura" });
            comboBox3.Location = new Point(158, 87);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(251, 28);
            comboBox3.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Economico", "Vip", "Primera Clase", "Negocio" });
            comboBox2.Location = new Point(158, 41);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(251, 28);
            comboBox2.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Economico", "Vip", "Primera Clase", "Negocio" });
            comboBox1.Location = new Point(158, 130);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 28);
            comboBox1.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(158, 177);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(251, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(18, 181);
            label9.Name = "label9";
            label9.Size = new Size(127, 20);
            label9.TabIndex = 9;
            label9.Text = "    Fecha de salida\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(56, 134);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 10;
            label6.Text = "Tipo de bus";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(83, 90);
            label12.Name = "label12";
            label12.Size = new Size(60, 20);
            label12.TabIndex = 11;
            label12.Text = "Destino";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 44);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 12;
            label2.Text = "Punto de salida";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(222, 108, 148);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1172, 654);
            button3.Name = "button3";
            button3.Size = new Size(200, 37);
            button3.TabIndex = 4;
            button3.Text = "Confirmar viaje";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(936, 654);
            button1.Name = "button1";
            button1.Size = new Size(198, 37);
            button1.TabIndex = 4;
            button1.Text = "Cancelar viaje";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 7);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 0;
            label3.Text = "Detalles del pasaje:\r\n";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(936, 257);
            panel2.Name = "panel2";
            panel2.Size = new Size(436, 377);
            panel2.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(14, 7);
            label8.Name = "label8";
            label8.Size = new Size(152, 25);
            label8.TabIndex = 0;
            label8.Text = "Elige tus asientos:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(79, 46);
            numericUpDown1.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(97, 27);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 48);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 11;
            label5.Text = "Piso:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(14, 102);
            panel3.Name = "panel3";
            panel3.Size = new Size(406, 233);
            panel3.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(337, 345);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 16;
            label1.Text = "20.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(314, 344);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 14;
            label4.Text = "S/";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(255, 344);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 15;
            label7.Text = "Precio:";
            // 
            // frmPasaje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 726);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label17);
            Controls.Add(listView2);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(button1);
            Controls.Add(button3);
            Name = "frmPasaje";
            Text = "frmPasaje";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView2;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label17;
        private Panel panel1;
        private Button button3;
        private Button button1;
        private Label label3;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private Label label6;
        private Label label12;
        private Label label2;
        private Panel panel2;
        private Label label8;
        private Panel panel3;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Label label1;
        private Label label4;
        private Label label7;
    }
}