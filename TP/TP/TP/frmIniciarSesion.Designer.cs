namespace CapaPresentacion
{
    partial class frmIniciarSesion
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
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            btnIniciarSesion = new Button();
            label8 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(215, 87);
            label1.Name = "label1";
            label1.Size = new Size(267, 54);
            label1.TabIndex = 9;
            label1.Text = "Iniciar sesión";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(172, 176);
            label3.Name = "label3";
            label3.Size = new Size(348, 56);
            label3.TabIndex = 10;
            label3.Text = "¡Ingrese a la plataforma exclusiva para \r\nnuestros usuarios!";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Location = new Point(105, 317);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "     73837288";
            textBox3.Size = new Size(465, 27);
            textBox3.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(122, 280);
            label4.Name = "label4";
            label4.Size = new Size(43, 25);
            label4.TabIndex = 15;
            label4.Text = "DNI";
            // 
            // textBox5
            // 
            textBox5.Cursor = Cursors.IBeam;
            textBox5.Location = new Point(105, 424);
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '*';
            textBox5.PlaceholderText = "     ***********";
            textBox5.Size = new Size(465, 27);
            textBox5.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(122, 387);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 19;
            label6.Text = "Clave";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnIniciarSesion.AutoEllipsis = true;
            btnIniciarSesion.BackColor = Color.FromArgb(222, 108, 148);
            btnIniciarSesion.Cursor = Cursors.Hand;
            btnIniciarSesion.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(206, 113, 142);
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.Location = new Point(188, 492);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(306, 60);
            btnIniciarSesion.TabIndex = 21;
            btnIniciarSesion.Text = "Iniciar sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(289, 610);
            label8.Name = "label8";
            label8.Size = new Size(117, 28);
            label8.TabIndex = 22;
            label8.Text = "Registrarse";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(274, 573);
            label7.Name = "label7";
            label7.Size = new Size(152, 20);
            label7.TabIndex = 23;
            label7.Text = "¿No estás registrado?";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.palmeras_inicio_sesion;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = Properties.Resources.palmeras_inicio_sesion;
            pictureBox1.Location = new Point(33, 665);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 134);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.palmeras_inicio_sesion;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.InitialImage = Properties.Resources.palmeras_inicio_sesion;
            pictureBox2.Location = new Point(511, 665);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(143, 134);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // frmIniciarSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 836);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnIniciarSesion);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmIniciarSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmIniciarSesion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox5;
        private Label label6;
        private Button btnIniciarSesion;
        private Label label8;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}