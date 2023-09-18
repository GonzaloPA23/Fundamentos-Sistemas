namespace Lab09
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
            btnRegistrarEntrenador = new Button();
            btnSalir = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnRegistrarEntrenador
            // 
            btnRegistrarEntrenador.Location = new Point(117, 126);
            btnRegistrarEntrenador.Name = "btnRegistrarEntrenador";
            btnRegistrarEntrenador.Size = new Size(182, 40);
            btnRegistrarEntrenador.TabIndex = 0;
            btnRegistrarEntrenador.Text = "Registrar Entrenador";
            btnRegistrarEntrenador.UseVisualStyleBackColor = true;
            btnRegistrarEntrenador.Click += btnRegistrarEntrenador_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(142, 197);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(131, 32);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 39);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 1;
            label1.Text = "LIGA POKEMON";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 339);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrarEntrenador);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarEntrenador;
        private Button btnSalir;
        private Label label1;
    }
}