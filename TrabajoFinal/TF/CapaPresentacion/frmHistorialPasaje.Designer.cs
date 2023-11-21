using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class frmHistorialPasaje
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
            button4 = new Button();
            button2 = new Button();
            label16 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label11 = new Label();
            label10 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label12 = new Label();
            button6 = new Button();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(222, 108, 148);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(748, 82);
            button4.Name = "button4";
            button4.Size = new Size(100, 30);
            button4.TabIndex = 16;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(890, 82);
            button2.Name = "button2";
            button2.Size = new Size(100, 30);
            button2.TabIndex = 17;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ButtonShadow;
            label16.Location = new Point(1202, 676);
            label16.Name = "label16";
            label16.Size = new Size(0, 17);
            label16.TabIndex = 7;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            listView1.Location = new Point(12, 124);
            listView1.Name = "listView1";
            listView1.Size = new Size(1040, 590);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "N° de orden";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Matricula";
            columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tipo de bus";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Fecha de salida";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Punto de salida";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Destino";
            columnHeader6.Width = 80;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(973, 41);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 8;
            label11.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(834, 41);
            label10.Name = "label10";
            label10.Size = new Size(119, 20);
            label10.TabIndex = 9;
            label10.Text = "Total de pasajes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(90, 80);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 10;
            label2.Text = "Buscar por:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(219, 28);
            label1.TabIndex = 11;
            label1.Text = "Historial de mis pasajes:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Economico", "Vip", "Primera Clase", "Negocio" });
            comboBox1.Location = new Point(482, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 28);
            comboBox1.TabIndex = 21;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Tipo de bus", "Punto de salida", "Destino" });
            comboBox2.Location = new Point(228, 80);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(211, 28);
            comboBox2.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(14, 9);
            label12.Name = "label12";
            label12.Size = new Size(93, 25);
            label12.TabIndex = 0;
            label12.Text = "Filtrar por:";
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(222, 108, 148);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(102, 130);
            button6.Name = "button6";
            button6.Size = new Size(148, 37);
            button6.TabIndex = 4;
            button6.Text = "Aplicar";
            button6.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(label12);
            panel2.Location = new Point(1071, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(317, 193);
            panel2.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(34, 83);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(261, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(14, 47);
            label9.Name = "label9";
            label9.Size = new Size(127, 20);
            label9.TabIndex = 7;
            label9.Text = "    Fecha de salida\r\n";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Fecha de llegada";
            columnHeader7.Width = 140;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Asiento";
            columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Precio";
            columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Fecha de compra";
            columnHeader10.Width = 150;
            // 
            // frmHistorialPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 726);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHistorialPasaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHistorialPasaje";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button4;
        private Button button2;
        private Label label16;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label11;
        private Label label10;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Label label12;
        private Button button6;
        private Panel panel2;
        private DateTimePicker dateTimePicker1;
        private Label label9;
    }
}