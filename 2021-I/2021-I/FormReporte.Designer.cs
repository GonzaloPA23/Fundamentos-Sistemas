
namespace _2021_I
{
    partial class FormReporte
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
            this.listViewEmpresas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewRubros = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRubrosConMasEmpresas6Meses = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEmpresasEvaluacion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTamañoPromedioRubrosMenorEmpresasMedianas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDistritoMasEmpresas = new System.Windows.Forms.Button();
            this.listViewDistritos = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCalularPromedio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewEmpresas
            // 
            this.listViewEmpresas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewEmpresas.HideSelection = false;
            this.listViewEmpresas.Location = new System.Drawing.Point(27, 281);
            this.listViewEmpresas.Name = "listViewEmpresas";
            this.listViewEmpresas.Size = new System.Drawing.Size(604, 234);
            this.listViewEmpresas.TabIndex = 26;
            this.listViewEmpresas.UseCompatibleStateImageBehavior = false;
            this.listViewEmpresas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "RUC";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Celular";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Distrito";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fecha";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tamaño";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Estado";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Código";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Nombre";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Descripción";
            this.columnHeader10.Width = 140;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Prioridad";
            this.columnHeader11.Width = 80;
            // 
            // listViewRubros
            // 
            this.listViewRubros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listViewRubros.HideSelection = false;
            this.listViewRubros.Location = new System.Drawing.Point(85, 73);
            this.listViewRubros.Name = "listViewRubros";
            this.listViewRubros.Size = new System.Drawing.Size(482, 133);
            this.listViewRubros.TabIndex = 27;
            this.listViewRubros.UseCompatibleStateImageBehavior = false;
            this.listViewRubros.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Buscar rubros de las empresas con mayor registro en los últimos 6 meses:";
            // 
            // btnRubrosConMasEmpresas6Meses
            // 
            this.btnRubrosConMasEmpresas6Meses.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRubrosConMasEmpresas6Meses.Location = new System.Drawing.Point(518, 20);
            this.btnRubrosConMasEmpresas6Meses.Name = "btnRubrosConMasEmpresas6Meses";
            this.btnRubrosConMasEmpresas6Meses.Size = new System.Drawing.Size(125, 30);
            this.btnRubrosConMasEmpresas6Meses.TabIndex = 29;
            this.btnRubrosConMasEmpresas6Meses.Text = "Buscar";
            this.btnRubrosConMasEmpresas6Meses.UseVisualStyleBackColor = true;
            this.btnRubrosConMasEmpresas6Meses.Click += new System.EventHandler(this.btnRubrosConMasEmpresas6Meses_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Buscar empresas en EVALUACIÓN:";
            // 
            // btnEmpresasEvaluacion
            // 
            this.btnEmpresasEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresasEvaluacion.Location = new System.Drawing.Point(518, 230);
            this.btnEmpresasEvaluacion.Name = "btnEmpresasEvaluacion";
            this.btnEmpresasEvaluacion.Size = new System.Drawing.Size(125, 30);
            this.btnEmpresasEvaluacion.TabIndex = 31;
            this.btnEmpresasEvaluacion.Text = "Buscar";
            this.btnEmpresasEvaluacion.UseVisualStyleBackColor = true;
            this.btnEmpresasEvaluacion.Click += new System.EventHandler(this.btnEmpresasEvaluacion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(631, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tamaño promedio de los rubros registrados que tienen el menor número de MEDIANAS " +
    "empresas:";
            // 
            // lbTamañoPromedioRubrosMenorEmpresasMedianas
            // 
            this.lbTamañoPromedioRubrosMenorEmpresasMedianas.AutoSize = true;
            this.lbTamañoPromedioRubrosMenorEmpresasMedianas.Location = new System.Drawing.Point(39, 567);
            this.lbTamañoPromedioRubrosMenorEmpresasMedianas.Name = "lbTamañoPromedioRubrosMenorEmpresasMedianas";
            this.lbTamañoPromedioRubrosMenorEmpresasMedianas.Size = new System.Drawing.Size(16, 17);
            this.lbTamañoPromedioRubrosMenorEmpresasMedianas.TabIndex = 33;
            this.lbTamañoPromedioRubrosMenorEmpresasMedianas.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 604);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Buscar distritos con mayor número de empresas:";
            // 
            // btnDistritoMasEmpresas
            // 
            this.btnDistritoMasEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistritoMasEmpresas.Location = new System.Drawing.Point(518, 597);
            this.btnDistritoMasEmpresas.Name = "btnDistritoMasEmpresas";
            this.btnDistritoMasEmpresas.Size = new System.Drawing.Size(125, 30);
            this.btnDistritoMasEmpresas.TabIndex = 35;
            this.btnDistritoMasEmpresas.Text = "Buscar";
            this.btnDistritoMasEmpresas.UseVisualStyleBackColor = true;
            this.btnDistritoMasEmpresas.Click += new System.EventHandler(this.btnDistritoMasEmpresas_Click);
            // 
            // listViewDistritos
            // 
            this.listViewDistritos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12});
            this.listViewDistritos.HideSelection = false;
            this.listViewDistritos.Location = new System.Drawing.Point(138, 643);
            this.listViewDistritos.Name = "listViewDistritos";
            this.listViewDistritos.Size = new System.Drawing.Size(344, 97);
            this.listViewDistritos.TabIndex = 36;
            this.listViewDistritos.UseCompatibleStateImageBehavior = false;
            this.listViewDistritos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Distrito";
            this.columnHeader12.Width = 160;
            // 
            // btnCalularPromedio
            // 
            this.btnCalularPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalularPromedio.Location = new System.Drawing.Point(518, 554);
            this.btnCalularPromedio.Name = "btnCalularPromedio";
            this.btnCalularPromedio.Size = new System.Drawing.Size(125, 30);
            this.btnCalularPromedio.TabIndex = 37;
            this.btnCalularPromedio.Text = "Calcular";
            this.btnCalularPromedio.UseVisualStyleBackColor = true;
            this.btnCalularPromedio.Click += new System.EventHandler(this.btnCalularPromedio_Click);
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 761);
            this.Controls.Add(this.btnCalularPromedio);
            this.Controls.Add(this.listViewDistritos);
            this.Controls.Add(this.btnDistritoMasEmpresas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTamañoPromedioRubrosMenorEmpresasMedianas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEmpresasEvaluacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRubrosConMasEmpresas6Meses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewRubros);
            this.Controls.Add(this.listViewEmpresas);
            this.Name = "FormReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewEmpresas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ListView listViewRubros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRubrosConMasEmpresas6Meses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEmpresasEvaluacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTamañoPromedioRubrosMenorEmpresasMedianas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDistritoMasEmpresas;
        private System.Windows.Forms.ListView listViewDistritos;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button btnCalularPromedio;
    }
}