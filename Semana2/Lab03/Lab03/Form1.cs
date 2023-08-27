using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form1 : Form
    {
        // Crear una lista de atenciones
        //private List<Atencion> atenciones = new List<Atencion>();
        Atencion[] atenciones = new Atencion[100];
        int indice = 0; // indice para recorrer el arreglo actua como contador
        int totalServicio1 = 0;
        int totalServicio2 = 0;
        int totalServicio3 = 0;
        double montoPromedio = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e){}

        private void buttonRegistrarAtencion_Click(object sender, EventArgs e)
        {
            // VALIDACIÓN
            if (comboBoxTipoAuto.Text == "" || comboBoxTipoServicio.Text == "")
            {
                MessageBox.Show("Debes llenar todos los campos");
                return;
            }

            // Crear un objeto de tipo Atencion
            Atencion atencion = new Atencion();
            atencion.TipoAuto = comboBoxTipoAuto.Text;
            atencion.TipoServicio = comboBoxTipoServicio.Text;

            // Asignación del monto a pagar
            switch (atencion.TipoServicio)
            {
                case "1": atencion.MontoPagar = 10; totalServicio1++; break;
                case "2": atencion.MontoPagar = 15; totalServicio2++; break;
                case "3": atencion.MontoPagar = 10; totalServicio3++; break;
            }
            if (atencion.TipoAuto == "C") atencion.MontoPagar *= 1.05;

            // Agregar al arreglo
            atenciones[indice] = atencion;
            indice++;
        }

        private void buttonActualizarVista_Click(object sender, EventArgs e)
        {
                    // Validación
            if (indice == 0)
            {
                MessageBox.Show("No hay datos para mostrar");
                return;
            }

                    // Mostrar los datos en el listView
            listView1.Items.Clear();           
            for (int i = 0; i < indice; i++)
            {
                // Obtener la atencion en la posición i del arreglo atenciones y mostrar sus datos en el listView
                ListViewItem fila = new ListViewItem(atenciones[i].TipoAuto);
                fila.SubItems.Add(atenciones[i].TipoServicio);
                fila.SubItems.Add(atenciones[i].MontoPagar.ToString());
                listView1.Items.Add(fila);
                // Calcular el monto promedio
                montoPromedio += atenciones[i].MontoPagar;
            }
            montoPromedio /= indice;
            labelMontoPromedio.Text = montoPromedio.ToString();
            labelTotalServicio1.Text = totalServicio1.ToString();
            labelTotalServicio2.Text = totalServicio2.ToString();
            labelTotalServicio3.Text = totalServicio3.ToString();

            int[] totales = {totalServicio1, totalServicio2, totalServicio3};
            int min = totales.Min();

            if (min == totales[0]) labelServicioMenorDemanda.Text = "Servicio 1";
            else if (min == totales[1]) labelServicioMenorDemanda.Text = "Servicio 2";
            else labelServicioMenorDemanda.Text = "Servicio 3";

            // Limpiar los campos
            comboBoxTipoAuto.Text = "";
            comboBoxTipoServicio.Text = "";

            
        }
    }
}
