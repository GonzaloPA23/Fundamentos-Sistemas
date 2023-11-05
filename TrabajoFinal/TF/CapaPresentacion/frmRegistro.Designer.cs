using System.Drawing;
using System.Windows.Forms;

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
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarse.AutoEllipsis = true;
            this.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(108)))), ((int)(((byte)(148)))));
            this.btnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(113)))), ((int)(((byte)(142)))));
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarse.Location = new System.Drawing.Point(201, 602);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(306, 60);
            this.btnRegistrarse.TabIndex = 33;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            // 
            // txtClave
            // 
            this.txtClave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClave.Location = new System.Drawing.Point(105, 529);
            this.txtClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(465, 22);
            this.txtClave.TabIndex = 32;
            this.txtClave.Text = "holaquehace";
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(284, 726);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "Iniciar sesión";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label7.Location = new System.Drawing.Point(285, 686);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "¿Estás registrado?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label6.Location = new System.Drawing.Point(122, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Clave";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.Location = new System.Drawing.Point(105, 438);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(465, 22);
            this.txtCorreo.TabIndex = 28;
            this.txtCorreo.Text = "myke23t@gmail.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label5.Location = new System.Drawing.Point(122, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Correo";
            // 
            // txtDni
            // 
            this.txtDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDni.Location = new System.Drawing.Point(105, 353);
            this.txtDni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(465, 22);
            this.txtDni.TabIndex = 26;
            this.txtDni.Text = "73837288";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label4.Location = new System.Drawing.Point(122, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "DNI";
            // 
            // txtApellido
            // 
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.Location = new System.Drawing.Point(105, 267);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(465, 22);
            this.txtApellido.TabIndex = 24;
            this.txtApellido.Text = "Towers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label3.Location = new System.Drawing.Point(122, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Location = new System.Drawing.Point(105, 183);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(465, 22);
            this.txtNombre.TabIndex = 22;
            this.txtNombre.Tag = "";
            this.txtNombre.Text = "Myke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label2.Location = new System.Drawing.Point(122, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(260, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 55);
            this.label1.TabIndex = 20;
            this.label1.Text = "Registro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 836);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegistrarse;
        private TextBox txtClave;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtCorreo;
        private Label label5;
        private TextBox txtDni;
        private Label label4;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
    }
}