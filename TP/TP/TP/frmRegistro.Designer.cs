namespace CapaPresentacion
{
    partial class frmRegistro
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
            label2 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label3 = new Label();
            txtDni = new TextBox();
            label4 = new Label();
            txtCorreo = new TextBox();
            label5 = new Label();
            txtClave = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnRegistrarse = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(260, 46);
            label1.Name = "label1";
            label1.Size = new Size(180, 54);
            label1.TabIndex = 8;
            label1.Text = "Registro";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(122, 146);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 9;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(105, 183);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "     Myke";
            txtNombre.Size = new Size(465, 27);
            txtNombre.TabIndex = 10;
            txtNombre.Tag = "";
            // 
            // txtApellido
            // 
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Location = new Point(105, 267);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "     Towers";
            txtApellido.Size = new Size(465, 27);
            txtApellido.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(122, 230);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 11;
            label3.Text = "Apellido";
            // 
            // txtDni
            // 
            txtDni.Cursor = Cursors.IBeam;
            txtDni.Location = new Point(105, 353);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "     73837288";
            txtDni.Size = new Size(465, 27);
            txtDni.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(122, 316);
            label4.Name = "label4";
            label4.Size = new Size(43, 25);
            label4.TabIndex = 13;
            label4.Text = "DNI";
            // 
            // txtCorreo
            // 
            txtCorreo.Cursor = Cursors.IBeam;
            txtCorreo.Location = new Point(105, 438);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "     myke23t@gmail.com";
            txtCorreo.Size = new Size(465, 27);
            txtCorreo.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(122, 401);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 15;
            label5.Text = "Correo";
            // 
            // txtClave
            // 
            txtClave.Cursor = Cursors.IBeam;
            txtClave.Location = new Point(105, 529);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.PlaceholderText = "     ***********";
            txtClave.Size = new Size(465, 27);
            txtClave.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(122, 492);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 17;
            label6.Text = "Clave";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(285, 686);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 17;
            label7.Text = "¿Estás registrado?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(284, 726);
            label8.Name = "label8";
            label8.Size = new Size(135, 28);
            label8.TabIndex = 17;
            label8.Text = "Iniciar sesión";
            label8.Click += label8_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrarse.AutoEllipsis = true;
            btnRegistrarse.BackColor = Color.FromArgb(222, 108, 148);
            btnRegistrarse.Cursor = Cursors.Hand;
            btnRegistrarse.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnRegistrarse.FlatAppearance.BorderSize = 0;
            btnRegistrarse.FlatAppearance.MouseDownBackColor = Color.FromArgb(206, 113, 142);
            btnRegistrarse.FlatStyle = FlatStyle.Flat;
            btnRegistrarse.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarse.ForeColor = Color.White;
            btnRegistrarse.Location = new Point(201, 602);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(306, 60);
            btnRegistrarse.TabIndex = 19;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 836);
            Controls.Add(btnRegistrarse);
            Controls.Add(txtClave);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtCorreo);
            Controls.Add(label5);
            Controls.Add(txtDni);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegistro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtDni;
        private Label label4;
        private TextBox txtCorreo;
        private Label label5;
        private TextBox txtClave;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnRegistrarse;
    }
}