namespace Lab12
{
    partial class FormPrincipal
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
            btnVerDoctores = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnVerDoctores
            // 
            btnVerDoctores.BackColor = SystemColors.Desktop;
            btnVerDoctores.FlatAppearance.BorderSize = 0;
            btnVerDoctores.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnVerDoctores.FlatStyle = FlatStyle.Flat;
            btnVerDoctores.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerDoctores.ForeColor = Color.Transparent;
            btnVerDoctores.Location = new Point(69, 55);
            btnVerDoctores.Margin = new Padding(3, 4, 3, 4);
            btnVerDoctores.Name = "btnVerDoctores";
            btnVerDoctores.Size = new Size(225, 53);
            btnVerDoctores.TabIndex = 0;
            btnVerDoctores.Text = "Ver Doctores";
            btnVerDoctores.UseVisualStyleBackColor = false;
            btnVerDoctores.Click += btnVerDoctores_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.Desktop;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Transparent;
            btnSalir.Location = new Point(69, 139);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(225, 53);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(362, 240);
            Controls.Add(btnSalir);
            Controls.Add(btnVerDoctores);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVerDoctores;
        private Button btnSalir;
    }
}