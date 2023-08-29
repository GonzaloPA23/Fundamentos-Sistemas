namespace TA2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNameFilm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.cmbTypeService = new System.Windows.Forms.ComboBox();
            this.cmbTypeFilm = new System.Windows.Forms.ComboBox();
            this.txtNameClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDatabase = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.txtNameFilm);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buttonSort);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonShow);
            this.panel1.Controls.Add(this.cmbTypeService);
            this.panel1.Controls.Add(this.cmbTypeFilm);
            this.panel1.Controls.Add(this.txtNameClient);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 442);
            this.panel1.TabIndex = 1;
            // 
            // txtNameFilm
            // 
            this.txtNameFilm.Location = new System.Drawing.Point(321, 160);
            this.txtNameFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameFilm.Name = "txtNameFilm";
            this.txtNameFilm.Size = new System.Drawing.Size(317, 22);
            this.txtNameFilm.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre pelicula:";
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(146)))), ((int)(((byte)(174)))));
            this.buttonSort.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSort.ForeColor = System.Drawing.Color.White;
            this.buttonSort.Location = new System.Drawing.Point(531, 345);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(107, 61);
            this.buttonSort.TabIndex = 10;
            this.buttonSort.Text = "Ordenar";
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(146)))), ((int)(((byte)(174)))));
            this.buttonDelete.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(382, 345);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(107, 61);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(146)))), ((int)(((byte)(174)))));
            this.buttonAdd.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(113, 345);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(107, 61);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(146)))), ((int)(((byte)(174)))));
            this.buttonShow.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.ForeColor = System.Drawing.Color.White;
            this.buttonShow.Location = new System.Drawing.Point(247, 345);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(107, 61);
            this.buttonShow.TabIndex = 8;
            this.buttonShow.Text = "Mostrar";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // cmbTypeService
            // 
            this.cmbTypeService.FormattingEnabled = true;
            this.cmbTypeService.Items.AddRange(new object[] {
            "2D",
            "3D",
            "VIP"});
            this.cmbTypeService.Location = new System.Drawing.Point(321, 266);
            this.cmbTypeService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTypeService.Name = "cmbTypeService";
            this.cmbTypeService.Size = new System.Drawing.Size(317, 24);
            this.cmbTypeService.TabIndex = 7;
            // 
            // cmbTypeFilm
            // 
            this.cmbTypeFilm.FormattingEnabled = true;
            this.cmbTypeFilm.Items.AddRange(new object[] {
            "Accion",
            "Comedia",
            "Terror"});
            this.cmbTypeFilm.Location = new System.Drawing.Point(321, 213);
            this.cmbTypeFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTypeFilm.Name = "cmbTypeFilm";
            this.cmbTypeFilm.Size = new System.Drawing.Size(317, 24);
            this.cmbTypeFilm.TabIndex = 5;
            // 
            // txtNameClient
            // 
            this.txtNameClient.Location = new System.Drawing.Point(321, 109);
            this.txtNameClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.Size = new System.Drawing.Size(317, 22);
            this.txtNameClient.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de servicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de pelicula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cine-Mania";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(843, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 442);
            this.panel2.TabIndex = 2;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nombre Cliente";
            this.columnHeader5.Width = 179;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nombre Pelicula";
            this.columnHeader6.Width = 225;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tipo de Pelicula";
            this.columnHeader7.Width = 178;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tipo de Servicio";
            this.columnHeader8.Width = 154;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Monto a Pagar";
            this.columnHeader1.Width = 201;
            // 
            // listViewDatabase
            // 
            this.listViewDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.listViewDatabase.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader1});
            this.listViewDatabase.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDatabase.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listViewDatabase.HideSelection = false;
            this.listViewDatabase.Location = new System.Drawing.Point(23, 498);
            this.listViewDatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewDatabase.Name = "listViewDatabase";
            this.listViewDatabase.Size = new System.Drawing.Size(1228, 433);
            this.listViewDatabase.TabIndex = 3;
            this.listViewDatabase.UseCompatibleStateImageBehavior = false;
            this.listViewDatabase.View = System.Windows.Forms.View.Details;
            this.listViewDatabase.SelectedIndexChanged += new System.EventHandler(this.listViewDatabase_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(210)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1273, 962);
            this.Controls.Add(this.listViewDatabase);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.ComboBox cmbTypeService;
        private System.Windows.Forms.ComboBox cmbTypeFilm;
        private System.Windows.Forms.TextBox txtNameClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNameFilm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listViewDatabase;
    }
}

