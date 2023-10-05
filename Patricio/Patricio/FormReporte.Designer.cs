
namespace Patricio
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
            this.btnCalularPromedio = new System.Windows.Forms.Button();
            this.btnDistritoMasEmpresas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTamañoPromedioRubrosMenorEmpresasMedianas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEmpresasEvaluacion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRubrosConMasEmpresas6Meses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewRubros = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewEmpresas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDistritos = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnCalularPromedio
            // 
            this.btnCalularPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalularPromedio.Location = new System.Drawing.Point(423, 456);
            this.btnCalularPromedio.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalularPromedio.Name = "btnCalularPromedio";
            this.btnCalularPromedio.Size = new System.Drawing.Size(94, 24);
            this.btnCalularPromedio.TabIndex = 48;
            this.btnCalularPromedio.Text = "Calcular";
            this.btnCalularPromedio.UseVisualStyleBackColor = true;
            this.btnCalularPromedio.Click += new System.EventHandler(this.btnCalularPromedio_Click);
            // 
            // btnDistritoMasEmpresas
            // 
            this.btnDistritoMasEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistritoMasEmpresas.Location = new System.Drawing.Point(423, 491);
            this.btnDistritoMasEmpresas.Margin = new System.Windows.Forms.Padding(2);
            this.btnDistritoMasEmpresas.Name = "btnDistritoMasEmpresas";
            this.btnDistritoMasEmpresas.Size = new System.Drawing.Size(94, 24);
            this.btnDistritoMasEmpresas.TabIndex = 47;
            this.btnDistritoMasEmpresas.Text = "Buscar";
            this.btnDistritoMasEmpresas.UseVisualStyleBackColor = true;
            this.btnDistritoMasEmpresas.Click += new System.EventHandler(this.btnDistritoMasEmpresas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 497);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Buscar distritos con mayor número de empresas:";
            // 
            // lbTamañoPromedioRubrosMenorEmpresasMedianas
            // 
            this.lbTamañoPromedioRubrosMenorEmpresasMedianas.AutoSize = true;
            this.lbTamañoPromedioRubrosMenorEmpresasMedianas.Location = new System.Drawing.Point(64, 467);
            this.lbTamañoPromedioRubrosMenorEmpresasMedianas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTamañoPromedioRubrosMenorEmpresasMedianas.Name = "lbTamañoPromedioRubrosMenorEmpresasMedianas";
            this.lbTamañoPromedioRubrosMenorEmpresasMedianas.Size = new System.Drawing.Size(13, 13);
            this.lbTamañoPromedioRubrosMenorEmpresasMedianas.TabIndex = 45;
            this.lbTamañoPromedioRubrosMenorEmpresasMedianas.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 442);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(468, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Tamaño promedio de los rubros registrados que tienen el menor número de MEDIANAS " +
    "empresas:";
            // 
            // btnEmpresasEvaluacion
            // 
            this.btnEmpresasEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresasEvaluacion.Location = new System.Drawing.Point(423, 193);
            this.btnEmpresasEvaluacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpresasEvaluacion.Name = "btnEmpresasEvaluacion";
            this.btnEmpresasEvaluacion.Size = new System.Drawing.Size(94, 24);
            this.btnEmpresasEvaluacion.TabIndex = 43;
            this.btnEmpresasEvaluacion.Text = "Buscar";
            this.btnEmpresasEvaluacion.UseVisualStyleBackColor = true;
            this.btnEmpresasEvaluacion.Click += new System.EventHandler(this.btnEmpresasEvaluacion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Buscar empresas en EVALUACIÓN:";
            // 
            // btnRubrosConMasEmpresas6Meses
            // 
            this.btnRubrosConMasEmpresas6Meses.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRubrosConMasEmpresas6Meses.Location = new System.Drawing.Point(423, 22);
            this.btnRubrosConMasEmpresas6Meses.Margin = new System.Windows.Forms.Padding(2);
            this.btnRubrosConMasEmpresas6Meses.Name = "btnRubrosConMasEmpresas6Meses";
            this.btnRubrosConMasEmpresas6Meses.Size = new System.Drawing.Size(94, 24);
            this.btnRubrosConMasEmpresas6Meses.TabIndex = 41;
            this.btnRubrosConMasEmpresas6Meses.Text = "Buscar";
            this.btnRubrosConMasEmpresas6Meses.UseVisualStyleBackColor = true;
            this.btnRubrosConMasEmpresas6Meses.Click += new System.EventHandler(this.btnRubrosConMasEmpresas6Meses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Buscar rubros de las empresas con mayor registro en los últimos 6 meses:";
            // 
            // listViewRubros
            // 
            this.listViewRubros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listViewRubros.HideSelection = false;
            this.listViewRubros.Location = new System.Drawing.Point(99, 65);
            this.listViewRubros.Margin = new System.Windows.Forms.Padding(2);
            this.listViewRubros.Name = "listViewRubros";
            this.listViewRubros.Size = new System.Drawing.Size(362, 109);
            this.listViewRubros.TabIndex = 39;
            this.listViewRubros.UseCompatibleStateImageBehavior = false;
            this.listViewRubros.View = System.Windows.Forms.View.Details;
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
            this.listViewEmpresas.Location = new System.Drawing.Point(55, 234);
            this.listViewEmpresas.Margin = new System.Windows.Forms.Padding(2);
            this.listViewEmpresas.Name = "listViewEmpresas";
            this.listViewEmpresas.Size = new System.Drawing.Size(454, 191);
            this.listViewEmpresas.TabIndex = 38;
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
            // listViewDistritos
            // 
            this.listViewDistritos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12});
            this.listViewDistritos.HideSelection = false;
            this.listViewDistritos.Location = new System.Drawing.Point(115, 525);
            this.listViewDistritos.Margin = new System.Windows.Forms.Padding(2);
            this.listViewDistritos.Name = "listViewDistritos";
            this.listViewDistritos.Size = new System.Drawing.Size(259, 80);
            this.listViewDistritos.TabIndex = 49;
            this.listViewDistritos.UseCompatibleStateImageBehavior = false;
            this.listViewDistritos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Distrito";
            this.columnHeader12.Width = 160;
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 639);
            this.Controls.Add(this.listViewDistritos);
            this.Controls.Add(this.btnCalularPromedio);
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
            this.Text = "FormReporte";
            this.Load += new System.EventHandler(this.FormReporte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        
        
        
        private System.Windows.Forms.Button btnCalularPromedio;
        private System.Windows.Forms.Button btnDistritoMasEmpresas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTamañoPromedioRubrosMenorEmpresasMedianas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEmpresasEvaluacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRubrosConMasEmpresas6Meses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewRubros;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ListView listViewEmpresas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView listViewDistritos;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}