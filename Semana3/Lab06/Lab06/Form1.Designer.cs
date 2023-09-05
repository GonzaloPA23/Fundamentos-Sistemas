namespace Lab06
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
            listViewAlbum = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            listViewHeroe = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCodigoAlbum = new TextBox();
            txtNombreAlbum = new TextBox();
            btnLimpiarAlbum = new Button();
            btnRegistrarAlbum = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCodigoHeroe = new TextBox();
            txtCaracteristicasHeroe = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtNombreHeroe = new TextBox();
            txtPoderHeroe = new TextBox();
            btnLimpiarHeroe = new Button();
            bntRegistrarHeroe = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label1HeroeMasPoder = new Label();
            labelHeroeMenosPoder = new Label();
            labelAlbumMasHeroes = new Label();
            SuspendLayout();
            // 
            // listViewAlbum
            // 
            listViewAlbum.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewAlbum.Location = new Point(12, 241);
            listViewAlbum.Name = "listViewAlbum";
            listViewAlbum.Size = new Size(323, 253);
            listViewAlbum.TabIndex = 0;
            listViewAlbum.UseCompatibleStateImageBehavior = false;
            listViewAlbum.View = View.Details;
            listViewAlbum.SelectedIndexChanged += listViewAlbum_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            // 
            // listViewHeroe
            // 
            listViewHeroe.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewHeroe.Location = new Point(356, 241);
            listViewHeroe.Name = "listViewHeroe";
            listViewHeroe.Size = new Size(647, 253);
            listViewHeroe.TabIndex = 0;
            listViewHeroe.UseCompatibleStateImageBehavior = false;
            listViewHeroe.View = View.Details;
            listViewHeroe.SelectedIndexChanged += listViewHeroe_SelectedIndexChanged;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Código";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nombre";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Caracteristicas";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Poder";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(137, 19);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 1;
            label1.Text = "ÁLBUM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 62);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 119);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // txtCodigoAlbum
            // 
            txtCodigoAlbum.Location = new Point(107, 59);
            txtCodigoAlbum.Name = "txtCodigoAlbum";
            txtCodigoAlbum.Size = new Size(202, 27);
            txtCodigoAlbum.TabIndex = 3;
            // 
            // txtNombreAlbum
            // 
            txtNombreAlbum.Location = new Point(107, 119);
            txtNombreAlbum.Name = "txtNombreAlbum";
            txtNombreAlbum.Size = new Size(202, 27);
            txtNombreAlbum.TabIndex = 3;
            // 
            // btnLimpiarAlbum
            // 
            btnLimpiarAlbum.BackColor = Color.White;
            btnLimpiarAlbum.Location = new Point(185, 186);
            btnLimpiarAlbum.Name = "btnLimpiarAlbum";
            btnLimpiarAlbum.Size = new Size(94, 29);
            btnLimpiarAlbum.TabIndex = 4;
            btnLimpiarAlbum.Text = "Limpiar";
            btnLimpiarAlbum.UseVisualStyleBackColor = false;
            btnLimpiarAlbum.Click += btnLimpiarAlbum_Click;
            // 
            // btnRegistrarAlbum
            // 
            btnRegistrarAlbum.BackColor = Color.White;
            btnRegistrarAlbum.Location = new Point(61, 186);
            btnRegistrarAlbum.Name = "btnRegistrarAlbum";
            btnRegistrarAlbum.Size = new Size(94, 29);
            btnRegistrarAlbum.TabIndex = 4;
            btnRegistrarAlbum.Text = "Registrar";
            btnRegistrarAlbum.UseVisualStyleBackColor = false;
            btnRegistrarAlbum.Click += btnRegistrarAlbum_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(685, 19);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 1;
            label4.Text = "HÉROE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(429, 62);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 2;
            label5.Text = "Código:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(392, 119);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 2;
            label6.Text = "Caracteristicas:";
            // 
            // txtCodigoHeroe
            // 
            txtCodigoHeroe.Location = new Point(505, 59);
            txtCodigoHeroe.Name = "txtCodigoHeroe";
            txtCodigoHeroe.Size = new Size(202, 27);
            txtCodigoHeroe.TabIndex = 3;
            // 
            // txtCaracteristicasHeroe
            // 
            txtCaracteristicasHeroe.Location = new Point(505, 119);
            txtCaracteristicasHeroe.Name = "txtCaracteristicasHeroe";
            txtCaracteristicasHeroe.Size = new Size(202, 27);
            txtCaracteristicasHeroe.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(728, 62);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 2;
            label7.Text = "Nombre:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(745, 119);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 2;
            label8.Text = "Poder:";
            // 
            // txtNombreHeroe
            // 
            txtNombreHeroe.Location = new Point(801, 59);
            txtNombreHeroe.Name = "txtNombreHeroe";
            txtNombreHeroe.Size = new Size(202, 27);
            txtNombreHeroe.TabIndex = 3;
            // 
            // txtPoderHeroe
            // 
            txtPoderHeroe.Location = new Point(801, 119);
            txtPoderHeroe.Name = "txtPoderHeroe";
            txtPoderHeroe.Size = new Size(202, 27);
            txtPoderHeroe.TabIndex = 3;
            // 
            // btnLimpiarHeroe
            // 
            btnLimpiarHeroe.BackColor = Color.White;
            btnLimpiarHeroe.Location = new Point(722, 186);
            btnLimpiarHeroe.Name = "btnLimpiarHeroe";
            btnLimpiarHeroe.Size = new Size(94, 29);
            btnLimpiarHeroe.TabIndex = 4;
            btnLimpiarHeroe.Text = "Limpiar";
            btnLimpiarHeroe.UseVisualStyleBackColor = false;
            btnLimpiarHeroe.Click += btnLimpiarHeroe_Click;
            // 
            // bntRegistrarHeroe
            // 
            bntRegistrarHeroe.BackColor = Color.White;
            bntRegistrarHeroe.Location = new Point(598, 186);
            bntRegistrarHeroe.Name = "bntRegistrarHeroe";
            bntRegistrarHeroe.Size = new Size(94, 29);
            bntRegistrarHeroe.TabIndex = 4;
            bntRegistrarHeroe.Text = "Registrar";
            bntRegistrarHeroe.UseVisualStyleBackColor = false;
            bntRegistrarHeroe.Click += bntRegistrarHeroe_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 545);
            label9.Name = "label9";
            label9.Size = new Size(163, 20);
            label9.TabIndex = 2;
            label9.Text = "Álbum con más héroes:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(392, 539);
            label10.Name = "label10";
            label10.Size = new Size(171, 20);
            label10.TabIndex = 2;
            label10.Text = "Héroe con mayor poder:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(392, 580);
            label11.Name = "label11";
            label11.Size = new Size(172, 20);
            label11.TabIndex = 2;
            label11.Text = "Héroe con menor poder:";
            // 
            // label1HeroeMasPoder
            // 
            label1HeroeMasPoder.AutoSize = true;
            label1HeroeMasPoder.Location = new Point(569, 539);
            label1HeroeMasPoder.Name = "label1HeroeMasPoder";
            label1HeroeMasPoder.Size = new Size(15, 20);
            label1HeroeMasPoder.TabIndex = 2;
            label1HeroeMasPoder.Text = "-";
            // 
            // labelHeroeMenosPoder
            // 
            labelHeroeMenosPoder.AutoSize = true;
            labelHeroeMenosPoder.Location = new Point(570, 580);
            labelHeroeMenosPoder.Name = "labelHeroeMenosPoder";
            labelHeroeMenosPoder.Size = new Size(15, 20);
            labelHeroeMenosPoder.TabIndex = 2;
            labelHeroeMenosPoder.Text = "-";
            // 
            // labelAlbumMasHeroes
            // 
            labelAlbumMasHeroes.AutoSize = true;
            labelAlbumMasHeroes.Location = new Point(216, 545);
            labelAlbumMasHeroes.Name = "labelAlbumMasHeroes";
            labelAlbumMasHeroes.Size = new Size(15, 20);
            labelAlbumMasHeroes.TabIndex = 2;
            labelAlbumMasHeroes.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 654);
            Controls.Add(bntRegistrarHeroe);
            Controls.Add(btnLimpiarHeroe);
            Controls.Add(btnRegistrarAlbum);
            Controls.Add(btnLimpiarAlbum);
            Controls.Add(txtPoderHeroe);
            Controls.Add(txtCaracteristicasHeroe);
            Controls.Add(txtNombreAlbum);
            Controls.Add(txtNombreHeroe);
            Controls.Add(label8);
            Controls.Add(txtCodigoHeroe);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtCodigoAlbum);
            Controls.Add(label5);
            Controls.Add(labelAlbumMasHeroes);
            Controls.Add(labelHeroeMenosPoder);
            Controls.Add(label11);
            Controls.Add(label1HeroeMasPoder);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(listViewHeroe);
            Controls.Add(listViewAlbum);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listViewAlbum;
        private ListView listViewHeroe;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCodigoAlbum;
        private TextBox txtNombreAlbum;
        private Button btnLimpiarAlbum;
        private Button btnRegistrarAlbum;
        private Label label4;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label5;
        private Label label6;
        private TextBox txtCodigoHeroe;
        private TextBox txtCaracteristicasHeroe;
        private Label label7;
        private Label label8;
        private TextBox txtNombreHeroe;
        private TextBox txtPoderHeroe;
        private Button btnLimpiarHeroe;
        private Button bntRegistrarHeroe;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label1HeroeMasPoder;
        private Label labelHeroeMenosPoder;
        private Label labelAlbumMasHeroes;
    }
}