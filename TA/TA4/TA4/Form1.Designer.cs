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
            nupDurationMinutesMovie = new NumericUpDown();
            cbGenreMovie = new ComboBox();
            btnCleanMovie = new Button();
            btnAddMovie = new Button();
            label6 = new Label();
            label5 = new Label();
            tbNameMovie = new TextBox();
            label4 = new Label();
            tbCountryMovie = new TextBox();
            label3 = new Label();
            tbUuidMovie = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            nupMinutesApparitionCharacter = new NumericUpDown();
            label10 = new Label();
            cbGenderCharacter = new ComboBox();
            label7 = new Label();
            btnCleanCharacter = new Button();
            tbUuidCharacter = new TextBox();
            btnAddCharacter = new Button();
            label8 = new Label();
            label11 = new Label();
            tbNameActorCharacter = new TextBox();
            label9 = new Label();
            tbNameCharacter = new TextBox();
            label12 = new Label();
            panel5 = new Panel();
            btnSearchMovieWithLeastCharactersGenderFemale = new Button();
            cbSearchGenreMovie = new ComboBox();
            btnSearchGenreMovie = new Button();
            label13 = new Label();
            panel6 = new Panel();
            btnSearchUuidMovieForCharacter = new Button();
            tbSearchUuidMovie = new TextBox();
            lbCharactersMinutesApparition = new Label();
            label15 = new Label();
            label14 = new Label();
            listViewDatabaseMovies = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            listViewDatabaseCharacters = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupDurationMinutesMovie).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupMinutesApparitionCharacter).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(nupDurationMinutesMovie);
            panel1.Controls.Add(cbGenreMovie);
            panel1.Controls.Add(btnCleanMovie);
            panel1.Controls.Add(btnAddMovie);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbNameMovie);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbCountryMovie);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbUuidMovie);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 387);
            panel1.TabIndex = 0;
            // 
            // nupDurationMinutesMovie
            // 
            nupDurationMinutesMovie.Location = new Point(181, 251);
            nupDurationMinutesMovie.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nupDurationMinutesMovie.Minimum = new decimal(new int[] { 40, 0, 0, 0 });
            nupDurationMinutesMovie.Name = "nupDurationMinutesMovie";
            nupDurationMinutesMovie.Size = new Size(330, 27);
            nupDurationMinutesMovie.TabIndex = 4;
            nupDurationMinutesMovie.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // cbGenreMovie
            // 
            cbGenreMovie.FormattingEnabled = true;
            cbGenreMovie.Items.AddRange(new object[] { "Comedia", "Drama", "Ciencia Ficcion", "Terror", "Anime" });
            cbGenreMovie.Location = new Point(181, 203);
            cbGenreMovie.Name = "cbGenreMovie";
            cbGenreMovie.Size = new Size(330, 28);
            cbGenreMovie.TabIndex = 3;
            // 
            // btnCleanMovie
            // 
            btnCleanMovie.BackColor = Color.CornflowerBlue;
            btnCleanMovie.FlatAppearance.BorderSize = 0;
            btnCleanMovie.FlatStyle = FlatStyle.Flat;
            btnCleanMovie.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCleanMovie.Location = new Point(316, 325);
            btnCleanMovie.Name = "btnCleanMovie";
            btnCleanMovie.Size = new Size(195, 39);
            btnCleanMovie.TabIndex = 2;
            btnCleanMovie.Text = "Limpiar";
            btnCleanMovie.UseVisualStyleBackColor = false;
            btnCleanMovie.Click += btnCleanMovie_Click;
            // 
            // btnAddMovie
            // 
            btnAddMovie.BackColor = Color.CornflowerBlue;
            btnAddMovie.FlatAppearance.BorderSize = 0;
            btnAddMovie.FlatStyle = FlatStyle.Flat;
            btnAddMovie.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddMovie.Location = new Point(66, 325);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(195, 39);
            btnAddMovie.TabIndex = 2;
            btnAddMovie.Text = "Agregar";
            btnAddMovie.UseVisualStyleBackColor = false;
            btnAddMovie.Click += btnAddMovie_Click;
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
            // tbNameMovie
            // 
            tbNameMovie.Location = new Point(181, 109);
            tbNameMovie.Name = "tbNameMovie";
            tbNameMovie.Size = new Size(330, 27);
            tbNameMovie.TabIndex = 1;
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
            // tbCountryMovie
            // 
            tbCountryMovie.Location = new Point(181, 159);
            tbCountryMovie.Name = "tbCountryMovie";
            tbCountryMovie.Size = new Size(330, 27);
            tbCountryMovie.TabIndex = 1;
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
            // tbUuidMovie
            // 
            tbUuidMovie.Location = new Point(181, 57);
            tbUuidMovie.Name = "tbUuidMovie";
            tbUuidMovie.Size = new Size(330, 27);
            tbUuidMovie.TabIndex = 1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(254, 10);
            label1.Name = "label1";
            label1.Size = new Size(111, 29);
            label1.TabIndex = 0;
            label1.Text = "PELICULA";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(nupMinutesApparitionCharacter);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(cbGenderCharacter);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnCleanCharacter);
            panel2.Controls.Add(tbUuidCharacter);
            panel2.Controls.Add(btnAddCharacter);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(tbNameActorCharacter);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(tbNameCharacter);
            panel2.Controls.Add(label12);
            panel2.Location = new Point(12, 418);
            panel2.Name = "panel2";
            panel2.Size = new Size(576, 386);
            panel2.TabIndex = 0;
            // 
            // nupMinutesApparitionCharacter
            // 
            nupMinutesApparitionCharacter.Location = new Point(178, 256);
            nupMinutesApparitionCharacter.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nupMinutesApparitionCharacter.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupMinutesApparitionCharacter.Name = "nupMinutesApparitionCharacter";
            nupMinutesApparitionCharacter.Size = new Size(330, 27);
            nupMinutesApparitionCharacter.TabIndex = 4;
            nupMinutesApparitionCharacter.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(66, 245);
            label10.Name = "label10";
            label10.Size = new Size(103, 48);
            label10.TabIndex = 0;
            label10.Text = "Minutos de \r\naparición:";
            // 
            // cbGenderCharacter
            // 
            cbGenderCharacter.FormattingEnabled = true;
            cbGenderCharacter.Items.AddRange(new object[] { "Masculino", "Femenino", "No definido" });
            cbGenderCharacter.Location = new Point(178, 208);
            cbGenderCharacter.Name = "cbGenderCharacter";
            cbGenderCharacter.Size = new Size(330, 28);
            cbGenderCharacter.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(104, 62);
            label7.Name = "label7";
            label7.Size = new Size(68, 24);
            label7.TabIndex = 0;
            label7.Text = "Código:";
            // 
            // btnCleanCharacter
            // 
            btnCleanCharacter.BackColor = Color.CornflowerBlue;
            btnCleanCharacter.FlatAppearance.BorderSize = 0;
            btnCleanCharacter.FlatStyle = FlatStyle.Flat;
            btnCleanCharacter.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCleanCharacter.Location = new Point(313, 330);
            btnCleanCharacter.Name = "btnCleanCharacter";
            btnCleanCharacter.Size = new Size(195, 39);
            btnCleanCharacter.TabIndex = 2;
            btnCleanCharacter.Text = "Limpiar";
            btnCleanCharacter.UseVisualStyleBackColor = false;
            btnCleanCharacter.Click += btnCleanCharacter_Click;
            // 
            // tbUuidCharacter
            // 
            tbUuidCharacter.Location = new Point(178, 62);
            tbUuidCharacter.Name = "tbUuidCharacter";
            tbUuidCharacter.Size = new Size(330, 27);
            tbUuidCharacter.TabIndex = 1;
            // 
            // btnAddCharacter
            // 
            btnAddCharacter.BackColor = Color.CornflowerBlue;
            btnAddCharacter.FlatAppearance.BorderSize = 0;
            btnAddCharacter.FlatStyle = FlatStyle.Flat;
            btnAddCharacter.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddCharacter.Location = new Point(63, 330);
            btnAddCharacter.Name = "btnAddCharacter";
            btnAddCharacter.Size = new Size(195, 39);
            btnAddCharacter.TabIndex = 2;
            btnAddCharacter.Text = "Agregar";
            btnAddCharacter.UseVisualStyleBackColor = false;
            btnAddCharacter.Click += btnAddCharacter_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(40, 167);
            label8.Name = "label8";
            label8.Size = new Size(129, 24);
            label8.TabIndex = 0;
            label8.Text = "Nombre actor:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(107, 208);
            label11.Name = "label11";
            label11.Size = new Size(57, 24);
            label11.TabIndex = 0;
            label11.Text = "Sexo:";
            // 
            // tbNameActorCharacter
            // 
            tbNameActorCharacter.Location = new Point(178, 164);
            tbNameActorCharacter.Name = "tbNameActorCharacter";
            tbNameActorCharacter.Size = new Size(330, 27);
            tbNameActorCharacter.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(68, 104);
            label9.Name = "label9";
            label9.Size = new Size(105, 48);
            label9.TabIndex = 0;
            label9.Text = "Nombre de \r\npersonaje:";
            // 
            // tbNameCharacter
            // 
            tbNameCharacter.Location = new Point(178, 114);
            tbNameCharacter.Name = "tbNameCharacter";
            tbNameCharacter.Size = new Size(330, 27);
            tbNameCharacter.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(242, 19);
            label12.Name = "label12";
            label12.Size = new Size(135, 29);
            label12.TabIndex = 0;
            label12.Text = "PERSONAJE";
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightCyan;
            panel5.Controls.Add(btnSearchMovieWithLeastCharactersGenderFemale);
            panel5.Controls.Add(cbSearchGenreMovie);
            panel5.Controls.Add(btnSearchGenreMovie);
            panel5.Controls.Add(label13);
            panel5.Location = new Point(1198, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(370, 387);
            panel5.TabIndex = 0;
            // 
            // btnSearchMovieWithLeastCharactersGenderFemale
            // 
            btnSearchMovieWithLeastCharactersGenderFemale.BackColor = Color.CornflowerBlue;
            btnSearchMovieWithLeastCharactersGenderFemale.FlatAppearance.BorderSize = 0;
            btnSearchMovieWithLeastCharactersGenderFemale.FlatStyle = FlatStyle.Flat;
            btnSearchMovieWithLeastCharactersGenderFemale.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSearchMovieWithLeastCharactersGenderFemale.Location = new Point(23, 251);
            btnSearchMovieWithLeastCharactersGenderFemale.Name = "btnSearchMovieWithLeastCharactersGenderFemale";
            btnSearchMovieWithLeastCharactersGenderFemale.Size = new Size(330, 95);
            btnSearchMovieWithLeastCharactersGenderFemale.TabIndex = 5;
            btnSearchMovieWithLeastCharactersGenderFemale.Text = "Buscar la pelicula con la menor\r\ncantidad de personajes de Sexo\r\nFemenino";
            btnSearchMovieWithLeastCharactersGenderFemale.UseVisualStyleBackColor = false;
            btnSearchMovieWithLeastCharactersGenderFemale.Click += btnSearchMovieWithLeastCharactersGenderFemale_Click;
            // 
            // cbSearchGenreMovie
            // 
            cbSearchGenreMovie.FormattingEnabled = true;
            cbSearchGenreMovie.Items.AddRange(new object[] { "Comedia", "Drama", "Ciencia Ficcion", "Terror", "Anime" });
            cbSearchGenreMovie.Location = new Point(23, 98);
            cbSearchGenreMovie.Name = "cbSearchGenreMovie";
            cbSearchGenreMovie.Size = new Size(330, 28);
            cbSearchGenreMovie.TabIndex = 3;
            // 
            // btnSearchGenreMovie
            // 
            btnSearchGenreMovie.BackColor = Color.CornflowerBlue;
            btnSearchGenreMovie.FlatAppearance.BorderSize = 0;
            btnSearchGenreMovie.FlatStyle = FlatStyle.Flat;
            btnSearchGenreMovie.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSearchGenreMovie.Location = new Point(96, 153);
            btnSearchGenreMovie.Name = "btnSearchGenreMovie";
            btnSearchGenreMovie.Size = new Size(195, 39);
            btnSearchGenreMovie.TabIndex = 5;
            btnSearchGenreMovie.Text = "Buscar";
            btnSearchGenreMovie.UseVisualStyleBackColor = false;
            btnSearchGenreMovie.Click += btnSearchGenreMovie_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(23, 60);
            label13.Name = "label13";
            label13.Size = new Size(252, 24);
            label13.TabIndex = 3;
            label13.Text = "Buscar por género de pelicula:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightCyan;
            panel6.Controls.Add(btnSearchUuidMovieForCharacter);
            panel6.Controls.Add(tbSearchUuidMovie);
            panel6.Controls.Add(lbCharactersMinutesApparition);
            panel6.Controls.Add(label15);
            panel6.Controls.Add(label14);
            panel6.Location = new Point(1198, 418);
            panel6.Name = "panel6";
            panel6.Size = new Size(370, 387);
            panel6.TabIndex = 1;
            // 
            // btnSearchUuidMovieForCharacter
            // 
            btnSearchUuidMovieForCharacter.BackColor = Color.CornflowerBlue;
            btnSearchUuidMovieForCharacter.FlatAppearance.BorderSize = 0;
            btnSearchUuidMovieForCharacter.FlatStyle = FlatStyle.Flat;
            btnSearchUuidMovieForCharacter.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSearchUuidMovieForCharacter.Location = new Point(96, 157);
            btnSearchUuidMovieForCharacter.Name = "btnSearchUuidMovieForCharacter";
            btnSearchUuidMovieForCharacter.Size = new Size(195, 39);
            btnSearchUuidMovieForCharacter.TabIndex = 8;
            btnSearchUuidMovieForCharacter.Text = "Buscar";
            btnSearchUuidMovieForCharacter.UseVisualStyleBackColor = false;
            btnSearchUuidMovieForCharacter.Click += btnSearchUuidMovieForCharacter_Click;
            // 
            // tbSearchUuidMovie
            // 
            tbSearchUuidMovie.Location = new Point(23, 114);
            tbSearchUuidMovie.Name = "tbSearchUuidMovie";
            tbSearchUuidMovie.Size = new Size(330, 27);
            tbSearchUuidMovie.TabIndex = 7;
            // 
            // lbCharactersMinutesApparition
            // 
            lbCharactersMinutesApparition.AutoSize = true;
            lbCharactersMinutesApparition.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbCharactersMinutesApparition.Location = new Point(184, 337);
            lbCharactersMinutesApparition.Name = "lbCharactersMinutesApparition";
            lbCharactersMinutesApparition.Size = new Size(20, 24);
            lbCharactersMinutesApparition.TabIndex = 6;
            lbCharactersMinutesApparition.Text = "0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(17, 241);
            label15.Name = "label15";
            label15.Size = new Size(342, 72);
            label15.TabIndex = 6;
            label15.Text = "Personajes que tienen más de 40 minutos \r\nde aparción en pantalla según el código \r\nespecificado es:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(23, 68);
            label14.Name = "label14";
            label14.Size = new Size(248, 24);
            label14.TabIndex = 6;
            label14.Text = "Buscar por código de pelicula:";
            // 
            // listViewDatabaseMovies
            // 
            listViewDatabaseMovies.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewDatabaseMovies.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listViewDatabaseMovies.Location = new Point(605, 12);
            listViewDatabaseMovies.Name = "listViewDatabaseMovies";
            listViewDatabaseMovies.Size = new Size(576, 387);
            listViewDatabaseMovies.TabIndex = 0;
            listViewDatabaseMovies.UseCompatibleStateImageBehavior = false;
            listViewDatabaseMovies.View = View.Details;
            listViewDatabaseMovies.SelectedIndexChanged += listViewDatabaseMovies_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "País";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Género";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Duración en minutos";
            columnHeader5.Width = 170;
            // 
            // listViewDatabaseCharacters
            // 
            listViewDatabaseCharacters.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            listViewDatabaseCharacters.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listViewDatabaseCharacters.Location = new Point(605, 418);
            listViewDatabaseCharacters.Name = "listViewDatabaseCharacters";
            listViewDatabaseCharacters.Size = new Size(576, 387);
            listViewDatabaseCharacters.TabIndex = 2;
            listViewDatabaseCharacters.UseCompatibleStateImageBehavior = false;
            listViewDatabaseCharacters.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Código";
            columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Nombre Personaje";
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Nombre actor";
            columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Sexo";
            columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Minutos aparición";
            columnHeader10.Width = 170;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1590, 817);
            Controls.Add(listViewDatabaseCharacters);
            Controls.Add(listViewDatabaseMovies);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel5);
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
            ((System.ComponentModel.ISupportInitialize)nupDurationMinutesMovie).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupMinutesApparitionCharacter).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel6;
        private NumericUpDown nupDurationMinutesMovie;
        private Button btnAddMovie;
        private TextBox tbUuidMovie;
        private Label label2;
        private Label label1;
        private ComboBox cbGenreMovie;
        private Label label6;
        private Label label5;
        private TextBox tbNameMovie;
        private Label label4;
        private TextBox tbCountryMovie;
        private Label label3;
        private Button btnCleanMovie;
        private NumericUpDown nupMinutesApparitionCharacter;
        private Label label10;
        private ComboBox cbGenderCharacter;
        private Label label7;
        private Button btnCleanCharacter;
        private TextBox tbUuidCharacter;
        private Button btnAddCharacter;
        private Label label8;
        private Label label11;
        private TextBox tbNameActorCharacter;
        private Label label9;
        private TextBox tbNameCharacter;
        private Label label12;
        private Button btnSearchGenreMovie;
        private Label label13;
        private Button btnSearchMovieWithLeastCharactersGenderFemale;
        private Button btnSearchUuidMovieForCharacter;
        private TextBox tbSearchUuidMovie;
        private Label lbCharactersMinutesApparition;
        private Label label15;
        private Label label14;
        private ListView listViewDatabaseMovies;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ListView listViewDatabaseCharacters;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ComboBox cbSearchGenreMovie;
    }
}