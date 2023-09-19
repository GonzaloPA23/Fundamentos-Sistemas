namespace TA5
{
    partial class FormPersonaje
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
            listViewPersonajes = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            panel2 = new Panel();
            button4 = new Button();
            panel1 = new Panel();
            btnRegistrar = new Button();
            nudMinutosAparicion = new NumericUpDown();
            tbNombreActor = new TextBox();
            tbNombrePersonaje = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tbCodigo = new TextBox();
            label3 = new Label();
            cbSexo = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            lblTotalPersonajes = new Label();
            label7 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinutosAparicion).BeginInit();
            SuspendLayout();
            // 
            // listViewPersonajes
            // 
            listViewPersonajes.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewPersonajes.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listViewPersonajes.Location = new Point(49, 528);
            listViewPersonajes.Name = "listViewPersonajes";
            listViewPersonajes.Size = new Size(1163, 400);
            listViewPersonajes.TabIndex = 1;
            listViewPersonajes.UseCompatibleStateImageBehavior = false;
            listViewPersonajes.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre personaje";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Nombre actor";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Sexo";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Minutos de aparición";
            columnHeader5.Width = 160;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImage = Properties.Resources.Shrek;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(button4);
            panel2.Location = new Point(823, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 470);
            panel2.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(229, 62, 62);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(0, 416);
            button4.Name = "button4";
            button4.Size = new Size(389, 54);
            button4.TabIndex = 5;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(nudMinutosAparicion);
            panel1.Controls.Add(tbNombreActor);
            panel1.Controls.Add(tbNombrePersonaje);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbCodigo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbSexo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(49, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 470);
            panel1.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(229, 62, 62);
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.Transparent;
            btnRegistrar.Location = new Point(283, 375);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(228, 54);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // nudMinutosAparicion
            // 
            nudMinutosAparicion.Location = new Point(315, 316);
            nudMinutosAparicion.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudMinutosAparicion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMinutosAparicion.Name = "nudMinutosAparicion";
            nudMinutosAparicion.Size = new Size(61, 27);
            nudMinutosAparicion.TabIndex = 4;
            nudMinutosAparicion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tbNombreActor
            // 
            tbNombreActor.Location = new Point(315, 210);
            tbNombreActor.Name = "tbNombreActor";
            tbNombreActor.Size = new Size(327, 27);
            tbNombreActor.TabIndex = 3;
            // 
            // tbNombrePersonaje
            // 
            tbNombrePersonaje.Location = new Point(315, 160);
            tbNombrePersonaje.Name = "tbNombrePersonaje";
            tbNombrePersonaje.Size = new Size(327, 27);
            tbNombrePersonaje.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(49, 312);
            label6.Name = "label6";
            label6.Size = new Size(246, 31);
            label6.TabIndex = 0;
            label6.Text = "Minutos de aparación:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(216, 264);
            label5.Name = "label5";
            label5.Size = new Size(76, 31);
            label5.TabIndex = 0;
            label5.Text = "Sexo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(124, 210);
            label4.Name = "label4";
            label4.Size = new Size(171, 31);
            label4.TabIndex = 0;
            label4.Text = "Nombre actor:";
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(315, 108);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(327, 27);
            tbCodigo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(74, 155);
            label3.Name = "label3";
            label3.Size = new Size(219, 31);
            label3.TabIndex = 0;
            label3.Text = "Nombre Personaje:";
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Masculino", "Femenino", "No definido" });
            cbSexo.Location = new Point(315, 264);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(327, 28);
            cbSexo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(202, 103);
            label2.Name = "label2";
            label2.Size = new Size(91, 31);
            label2.TabIndex = 0;
            label2.Text = "Código:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(217, 14);
            label1.Name = "label1";
            label1.Size = new Size(346, 48);
            label1.TabIndex = 0;
            label1.Text = "Registrar Personaje";
            // 
            // lblTotalPersonajes
            // 
            lblTotalPersonajes.AutoSize = true;
            lblTotalPersonajes.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPersonajes.ForeColor = Color.White;
            lblTotalPersonajes.Location = new Point(1168, 943);
            lblTotalPersonajes.Name = "lblTotalPersonajes";
            lblTotalPersonajes.Size = new Size(28, 31);
            lblTotalPersonajes.TabIndex = 4;
            lblTotalPersonajes.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(936, 941);
            label7.Name = "label7";
            label7.Size = new Size(234, 31);
            label7.TabIndex = 5;
            label7.Text = "Total de Personajes:";
            // 
            // FormPersonaje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1261, 992);
            Controls.Add(lblTotalPersonajes);
            Controls.Add(label7);
            Controls.Add(listViewPersonajes);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormPersonaje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPersonaje";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinutosAparicion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewPersonajes;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Panel panel2;
        private Button button4;
        private Panel panel1;
        private Button btnRegistrar;
        private NumericUpDown nudMinutosAparicion;
        private TextBox tbNombreActor;
        private TextBox tbNombrePersonaje;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tbCodigo;
        private Label label3;
        private ComboBox cbSexo;
        private Label label2;
        private Label label1;
        private Label lblTotalPersonajes;
        private Label label7;
    }
}