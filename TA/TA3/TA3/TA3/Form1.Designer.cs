namespace TA3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            buttonSort = new Button();
            buttonDeleteAll = new Button();
            buttonDelete = new Button();
            panel2 = new Panel();
            buttonReplaceName = new Button();
            panel4 = new Panel();
            label15 = new Label();
            label14 = new Label();
            labelTotalCharacters = new Label();
            labelTotalRecords = new Label();
            label13 = new Label();
            label12 = new Label();
            label2 = new Label();
            textBoxNameReplaced = new TextBox();
            textBoxNameForReplace = new TextBox();
            textBoxSearchName = new TextBox();
            buttonClear = new Button();
            buttonSearch = new Button();
            label11 = new Label();
            label18 = new Label();
            label17 = new Label();
            label10 = new Label();
            labelTotalSearches = new Label();
            panel3 = new Panel();
            nudQuantityCharacters = new NumericUpDown();
            textBoxDuration = new TextBox();
            textBoxCountry = new TextBox();
            buttonRegister = new Button();
            textBoxGenre = new TextBox();
            textBoxName = new TextBox();
            textBoxUuid = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            listViewDatabaseMovie = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label16 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantityCharacters).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonSort);
            panel1.Controls.Add(buttonDeleteAll);
            panel1.Controls.Add(buttonDelete);
            panel1.Location = new Point(43, 29);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 464);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(120, 42);
            label1.Name = "label1";
            label1.Size = new Size(138, 32);
            label1.TabIndex = 1;
            label1.Text = "OPCIONES";
            // 
            // buttonSort
            // 
            buttonSort.BackColor = Color.FromArgb(229, 62, 62);
            buttonSort.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonSort.Location = new Point(82, 324);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(205, 51);
            buttonSort.TabIndex = 0;
            buttonSort.Text = "Ordenar";
            buttonSort.UseVisualStyleBackColor = false;
            buttonSort.Click += buttonSort_Click;
            // 
            // buttonDeleteAll
            // 
            buttonDeleteAll.BackColor = Color.FromArgb(229, 62, 62);
            buttonDeleteAll.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonDeleteAll.Location = new Point(82, 223);
            buttonDeleteAll.Name = "buttonDeleteAll";
            buttonDeleteAll.Size = new Size(205, 51);
            buttonDeleteAll.TabIndex = 0;
            buttonDeleteAll.Text = "Eliminar Todo";
            buttonDeleteAll.UseVisualStyleBackColor = false;
            buttonDeleteAll.Click += buttonDeleteAll_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(229, 62, 62);
            buttonDelete.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonDelete.Location = new Point(82, 122);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(205, 51);
            buttonDelete.TabIndex = 0;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(buttonReplaceName);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxNameReplaced);
            panel2.Controls.Add(textBoxNameForReplace);
            panel2.Controls.Add(textBoxSearchName);
            panel2.Controls.Add(buttonClear);
            panel2.Controls.Add(buttonSearch);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(1318, 29);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(348, 464);
            panel2.TabIndex = 1;
            // 
            // buttonReplaceName
            // 
            buttonReplaceName.BackColor = Color.FromArgb(229, 62, 62);
            buttonReplaceName.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonReplaceName.Location = new Point(112, 275);
            buttonReplaceName.Name = "buttonReplaceName";
            buttonReplaceName.Size = new Size(141, 40);
            buttonReplaceName.TabIndex = 6;
            buttonReplaceName.Text = "Reemplazar";
            buttonReplaceName.UseVisualStyleBackColor = false;
            buttonReplaceName.Click += buttonReplaceName_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(224, 224, 224, 224);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(labelTotalCharacters);
            panel4.Controls.Add(labelTotalRecords);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(39, 324);
            panel4.Name = "panel4";
            panel4.Size = new Size(283, 133);
            panel4.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(-3, 150);
            label15.Name = "label15";
            label15.Size = new Size(190, 28);
            label15.TabIndex = 3;
            label15.Text = "Total de busquedas";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(7, 99);
            label14.Name = "label14";
            label14.Size = new Size(203, 28);
            label14.TabIndex = 3;
            label14.Text = "Total de personajes:";
            // 
            // labelTotalCharacters
            // 
            labelTotalCharacters.AutoSize = true;
            labelTotalCharacters.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalCharacters.Location = new Point(220, 99);
            labelTotalCharacters.Name = "labelTotalCharacters";
            labelTotalCharacters.Size = new Size(20, 28);
            labelTotalCharacters.TabIndex = 3;
            labelTotalCharacters.Text = "-";
            // 
            // labelTotalRecords
            // 
            labelTotalRecords.AutoSize = true;
            labelTotalRecords.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalRecords.Location = new Point(220, 49);
            labelTotalRecords.Name = "labelTotalRecords";
            labelTotalRecords.Size = new Size(20, 28);
            labelTotalRecords.TabIndex = 3;
            labelTotalRecords.Text = "-";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(9, 49);
            label13.Name = "label13";
            label13.Size = new Size(188, 28);
            label13.TabIndex = 3;
            label13.Text = "Total de registros:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(101, 9);
            label12.Name = "label12";
            label12.Size = new Size(96, 29);
            label12.TabIndex = 3;
            label12.Text = "Historial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 35);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 2;
            // 
            // textBoxNameReplaced
            // 
            textBoxNameReplaced.Location = new Point(36, 238);
            textBoxNameReplaced.Name = "textBoxNameReplaced";
            textBoxNameReplaced.Size = new Size(286, 27);
            textBoxNameReplaced.TabIndex = 4;
            // 
            // textBoxNameForReplace
            // 
            textBoxNameForReplace.Location = new Point(36, 163);
            textBoxNameForReplace.Name = "textBoxNameForReplace";
            textBoxNameForReplace.Size = new Size(286, 27);
            textBoxNameForReplace.TabIndex = 4;
            // 
            // textBoxSearchName
            // 
            textBoxSearchName.Location = new Point(36, 41);
            textBoxSearchName.Name = "textBoxSearchName";
            textBoxSearchName.Size = new Size(286, 27);
            textBoxSearchName.TabIndex = 4;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(229, 62, 62);
            buttonClear.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonClear.Location = new Point(193, 71);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(129, 39);
            buttonClear.TabIndex = 0;
            buttonClear.Text = "Limpiar";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(229, 62, 62);
            buttonSearch.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonSearch.Location = new Point(36, 71);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(129, 39);
            buttonSearch.TabIndex = 0;
            buttonSearch.Text = "Buscar";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(424, 183);
            label11.Name = "label11";
            label11.Size = new Size(194, 28);
            label11.TabIndex = 3;
            label11.Text = "Buscar por nombre:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(36, 201);
            label18.Name = "label18";
            label18.Size = new Size(54, 29);
            label18.TabIndex = 3;
            label18.Text = "Por:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(36, 122);
            label17.Name = "label17";
            label17.Size = new Size(217, 29);
            label17.TabIndex = 3;
            label17.Text = "Reemplazar Nombre:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(36, 6);
            label10.Name = "label10";
            label10.Size = new Size(206, 29);
            label10.TabIndex = 3;
            label10.Text = "Buscar por nombre:";
            // 
            // labelTotalSearches
            // 
            labelTotalSearches.AutoSize = true;
            labelTotalSearches.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalSearches.Location = new Point(1618, 915);
            labelTotalSearches.Name = "labelTotalSearches";
            labelTotalSearches.Size = new Size(24, 28);
            labelTotalSearches.TabIndex = 3;
            labelTotalSearches.Text = "0";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(nudQuantityCharacters);
            panel3.Controls.Add(textBoxDuration);
            panel3.Controls.Add(textBoxCountry);
            panel3.Controls.Add(buttonRegister);
            panel3.Controls.Add(textBoxGenre);
            panel3.Controls.Add(textBoxName);
            panel3.Controls.Add(textBoxUuid);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(424, 29);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(874, 464);
            panel3.TabIndex = 2;
            // 
            // nudQuantityCharacters
            // 
            nudQuantityCharacters.Location = new Point(553, 206);
            nudQuantityCharacters.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            nudQuantityCharacters.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudQuantityCharacters.Name = "nudQuantityCharacters";
            nudQuantityCharacters.Size = new Size(286, 27);
            nudQuantityCharacters.TabIndex = 5;
            nudQuantityCharacters.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // textBoxDuration
            // 
            textBoxDuration.Location = new Point(553, 275);
            textBoxDuration.Name = "textBoxDuration";
            textBoxDuration.Size = new Size(286, 27);
            textBoxDuration.TabIndex = 4;
            // 
            // textBoxCountry
            // 
            textBoxCountry.HideSelection = false;
            textBoxCountry.Location = new Point(553, 137);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(286, 27);
            textBoxCountry.TabIndex = 4;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.FromArgb(229, 62, 62);
            buttonRegister.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonRegister.Location = new Point(342, 375);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(205, 51);
            buttonRegister.TabIndex = 0;
            buttonRegister.Text = "Registrar";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(119, 278);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(244, 27);
            textBoxGenre.TabIndex = 4;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(119, 209);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(244, 27);
            textBoxName.TabIndex = 4;
            // 
            // textBoxUuid
            // 
            textBoxUuid.Location = new Point(119, 137);
            textBoxUuid.Name = "textBoxUuid";
            textBoxUuid.Size = new Size(244, 27);
            textBoxUuid.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(420, 275);
            label9.Name = "label9";
            label9.Size = new Size(126, 56);
            label9.TabIndex = 3;
            label9.Text = "Duración en \r\nminutos:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(420, 194);
            label8.Name = "label8";
            label8.Size = new Size(127, 56);
            label8.TabIndex = 3;
            label8.Text = "Cantidad de \r\npersonajes:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(479, 134);
            label7.Name = "label7";
            label7.Size = new Size(54, 28);
            label7.TabIndex = 3;
            label7.Text = "País:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(32, 275);
            label6.Name = "label6";
            label6.Size = new Size(85, 28);
            label6.TabIndex = 3;
            label6.Text = "Género:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 206);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 3;
            label5.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 134);
            label4.Name = "label4";
            label4.Size = new Size(81, 28);
            label4.TabIndex = 3;
            label4.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(277, 35);
            label3.Name = "label3";
            label3.Size = new Size(379, 39);
            label3.TabIndex = 3;
            label3.Text = "REGISTRO DE PELICULAS";
            // 
            // listViewDatabaseMovie
            // 
            listViewDatabaseMovie.Alignment = ListViewAlignment.Default;
            listViewDatabaseMovie.BackColor = Color.WhiteSmoke;
            listViewDatabaseMovie.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewDatabaseMovie.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listViewDatabaseMovie.Location = new Point(43, 500);
            listViewDatabaseMovie.Name = "listViewDatabaseMovie";
            listViewDatabaseMovie.Size = new Size(1623, 394);
            listViewDatabaseMovie.TabIndex = 3;
            listViewDatabaseMovie.UseCompatibleStateImageBehavior = false;
            listViewDatabaseMovie.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Género";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "País";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Cantidad de personajes";
            columnHeader5.Width = 250;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Duración en minutos";
            columnHeader6.Width = 200;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(1285, 915);
            label16.Name = "label16";
            label16.Size = new Size(314, 28);
            label16.TabIndex = 3;
            label16.Text = "Total de búsquedas encontradas:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 148, 243);
            ClientSize = new Size(1708, 966);
            Controls.Add(listViewDatabaseMovie);
            Controls.Add(label16);
            Controls.Add(labelTotalSearches);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantityCharacters).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ListView listViewDatabaseMovie;
        private Label label1;
        private Button buttonSort;
        private Button buttonDeleteAll;
        private Button buttonDelete;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox textBoxDuration;
        private TextBox textBoxCountry;
        private TextBox textBoxGenre;
        private TextBox textBoxName;
        private TextBox textBoxUuid;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private NumericUpDown nudQuantityCharacters;
        private Button buttonRegister;
        private TextBox textBoxSearchName;
        private Button buttonClear;
        private Button buttonSearch;
        private Label label11;
        private Label label10;
        private Panel panel4;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label labelTotalSearches;
        private Label labelTotalCharacters;
        private Label labelTotalRecords;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label16;
        private TextBox textBoxNameReplaced;
        private TextBox textBoxNameForReplace;
        private Label label18;
        private Label label17;
        private Button buttonReplaceName;
    }
}