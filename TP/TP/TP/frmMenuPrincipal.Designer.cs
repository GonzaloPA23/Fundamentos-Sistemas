namespace CapaPresentacion
{
    partial class frmMenuPrincipal
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
            btnRegistrarseMP = new Button();
            btnIniciarSesionMP = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrarseMP
            // 
            btnRegistrarseMP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrarseMP.AutoEllipsis = true;
            btnRegistrarseMP.BackColor = Color.FromArgb(182, 113, 137);
            btnRegistrarseMP.Cursor = Cursors.Hand;
            btnRegistrarseMP.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnRegistrarseMP.FlatAppearance.BorderSize = 0;
            btnRegistrarseMP.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 100, 122);
            btnRegistrarseMP.FlatStyle = FlatStyle.Flat;
            btnRegistrarseMP.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarseMP.ForeColor = Color.White;
            btnRegistrarseMP.Location = new Point(164, 709);
            btnRegistrarseMP.Name = "btnRegistrarseMP";
            btnRegistrarseMP.Size = new Size(345, 58);
            btnRegistrarseMP.TabIndex = 8;
            btnRegistrarseMP.Text = "Registrarse";
            btnRegistrarseMP.UseVisualStyleBackColor = false;
            btnRegistrarseMP.Click += btnRegistrarse_Click;
            // 
            // btnIniciarSesionMP
            // 
            btnIniciarSesionMP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnIniciarSesionMP.AutoEllipsis = true;
            btnIniciarSesionMP.BackColor = Color.FromArgb(222, 108, 148);
            btnIniciarSesionMP.Cursor = Cursors.Hand;
            btnIniciarSesionMP.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnIniciarSesionMP.FlatAppearance.BorderSize = 0;
            btnIniciarSesionMP.FlatAppearance.MouseDownBackColor = Color.FromArgb(206, 113, 142);
            btnIniciarSesionMP.FlatStyle = FlatStyle.Flat;
            btnIniciarSesionMP.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciarSesionMP.ForeColor = Color.White;
            btnIniciarSesionMP.Location = new Point(164, 630);
            btnIniciarSesionMP.Name = "btnIniciarSesionMP";
            btnIniciarSesionMP.Size = new Size(345, 60);
            btnIniciarSesionMP.TabIndex = 9;
            btnIniciarSesionMP.Text = "Iniciar sesión";
            btnIniciarSesionMP.UseVisualStyleBackColor = false;
            btnIniciarSesionMP.Click += btnIniciarSesion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(225, 261);
            label3.Name = "label3";
            label3.Size = new Size(246, 28);
            label3.TabIndex = 5;
            label3.Text = "Chiclayo - Lima y Viceversa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(270, 237);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 6;
            label2.Text = "SALIDAS DIARIAS:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(118, 118);
            label1.Name = "label1";
            label1.Size = new Size(437, 108);
            label1.TabIndex = 7;
            label1.Text = "Bienvenido a La Perla \r\ndel Altomayo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Image = Properties.Resources.bus_menu;
            pictureBox2.Location = new Point(144, 328);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(381, 258);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.logo_perla_del_altomayo;
            pictureBox1.Location = new Point(246, -28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 233);
            ClientSize = new Size(691, 836);
            Controls.Add(btnRegistrarseMP);
            Controls.Add(btnIniciarSesionMP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmMenuPrincipal";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarseMP;
        private Button btnIniciarSesionMP;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}