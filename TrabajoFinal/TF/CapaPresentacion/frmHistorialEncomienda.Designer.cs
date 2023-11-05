using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class frmHistorialEncomienda
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
            comboBox1 = new ComboBox();
            button4 = new Button();
            button2 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            label11 = new Label();
            label10 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(241, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(239, 28);
            comboBox1.TabIndex = 30;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(222, 108, 148);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1051, 67);
            button4.Name = "button4";
            button4.Size = new Size(128, 30);
            button4.TabIndex = 27;
            button4.Text = "Filtrar";
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1193, 67);
            button2.Name = "button2";
            button2.Size = new Size(128, 30);
            button2.TabIndex = 28;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            listView1.Location = new Point(24, 124);
            listView1.Name = "listView1";
            listView1.Size = new Size(1350, 590);
            listView1.TabIndex = 26;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "N° de orden";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Punto de salida";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Fecha de envío";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Destino";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Fecha de llegada";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tipo de producto";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 130;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Peso en kg";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Ancho en cm";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Largo en cm";
            columnHeader9.TextAlign = HorizontalAlignment.Center;
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Alto en cm";
            columnHeader10.TextAlign = HorizontalAlignment.Center;
            columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Precio estimado";
            columnHeader11.Width = 120;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Fecha de pedido";
            columnHeader12.Width = 130;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(1276, 26);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 22;
            label11.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(1112, 25);
            label10.Name = "label10";
            label10.Size = new Size(158, 20);
            label10.TabIndex = 23;
            label10.Text = "Total de encomiendas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(80, 75);
            label2.Name = "label2";
            label2.Size = new Size(156, 23);
            label2.TabIndex = 24;
            label2.Text = "Buscar por destino:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 18);
            label1.Name = "label1";
            label1.Size = new Size(271, 28);
            label1.TabIndex = 25;
            label1.Text = "Historial de mis encomiendas:";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Más recientes", "Más antiguos" });
            comboBox2.Location = new Point(684, 69);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(239, 28);
            comboBox2.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(532, 72);
            label3.Name = "label3";
            label3.Size = new Size(140, 23);
            label3.TabIndex = 31;
            label3.Text = "Fecha de pedido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(532, 38);
            label4.Name = "label4";
            label4.Size = new Size(108, 23);
            label4.TabIndex = 31;
            label4.Text = "Ordenar por:";
            // 
            // frmHistorialEncomienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 726);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHistorialEncomienda";
            this.Text = "frmHistorialEncomienda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox comboBox1;
        private Button button4;
        private Button button2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Label label11;
        private Label label10;
        private Label label2;
        private Label label1;
        private ComboBox comboBox2;
        private Label label3;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private Label label4;
    }
}