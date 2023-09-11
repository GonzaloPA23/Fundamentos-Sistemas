namespace TA4
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
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboBox2 = new ComboBox();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 387);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Location = new Point(12, 418);
            panel2.Name = "panel2";
            panel2.Size = new Size(576, 386);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCyan;
            panel3.Location = new Point(605, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(576, 387);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightCyan;
            panel4.Location = new Point(605, 418);
            panel4.Name = "panel4";
            panel4.Size = new Size(576, 387);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightCyan;
            panel5.Location = new Point(1198, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(370, 387);
            panel5.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightCyan;
            panel6.Location = new Point(1198, 418);
            panel6.Name = "panel6";
            panel6.Size = new Size(370, 387);
            panel6.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(240, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 29);
            label1.TabIndex = 0;
            label1.Text = "PELICULA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(66, 325);
            button1.Name = "button1";
            button1.Size = new Size(195, 39);
            button1.TabIndex = 2;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(181, 251);
            numericUpDown1.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 40, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(330, 27);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(107, 57);
            label2.Name = "label2";
            label2.Size = new Size(68, 24);
            label2.TabIndex = 0;
            label2.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(127, 160);
            label3.Name = "label3";
            label3.Size = new Size(45, 24);
            label3.TabIndex = 0;
            label3.Text = "País:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(330, 27);
            textBox2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(95, 112);
            label4.Name = "label4";
            label4.Size = new Size(80, 24);
            label4.TabIndex = 0;
            label4.Text = "Nombre:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(181, 109);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(330, 27);
            textBox3.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(66, 239);
            label5.Name = "label5";
            label5.Size = new Size(109, 48);
            label5.TabIndex = 0;
            label5.Text = "Duración en \r\nminutos:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(98, 203);
            label6.Name = "label6";
            label6.Size = new Size(74, 24);
            label6.TabIndex = 0;
            label6.Text = "Género:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(181, 203);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(330, 28);
            comboBox2.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(316, 325);
            button2.Name = "button2";
            button2.Size = new Size(195, 39);
            button2.TabIndex = 2;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1590, 817);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Cursor = Cursors.IBeam;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private ComboBox comboBox2;
        private Label label6;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private Button button2;
    }
}