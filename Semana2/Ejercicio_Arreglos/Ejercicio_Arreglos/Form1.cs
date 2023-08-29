using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Arreglos
{
    public partial class Form1 : Form
    {
        // Declaracion de variables
        frmTablaServicios frmTablaServicios;
        Array registros = Array.CreateInstance(typeof(ModelRegister), 100);

        public Form1()
        {
            InitializeComponent();
            //frmTablaServicios = new frmTablaServicios();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Botón para registrar/agregar una atención de lavado de autos
            // Validación del ingreso de datos
            if (txtNameClient.Text == "" || cmbTypeCar.Text == "" || cmbTypeService.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Creación de objeto
            ModelRegister registro = new ModelRegister();
            registro.Name = txtNameClient.Text;
            registro.TypeCar = cmbTypeCar.Text;
            registro.TypeService = cmbTypeService.Text;

            switch (registro.TypeService)
            {
                case "Lavado":
                case "1":
                case "Lavado (1)":
                    registro.MontoAPagar = 10.00; break;
                case "Encerado":
                case "2":
                case "Encerado (2)":
                    registro.MontoAPagar = 15.00; break;
                case "Silicona":
                case "3":
                case "Silicona (3)":
                    registro.MontoAPagar = 10.00; break;
            }
            if(registro.TypeCar.Contains("Camioneta")) { registro.MontoAPagar *= 1.05; }

            // Agregar objeto al arreglo
           for (int i = 0; i < registros.Length; i++)
            {
                if (registros.GetValue(i) == null)
                {
                    registros.SetValue(registro, i);
                    break;
                }
            }

           // Limpiar los controles
          txtNameClient.Text = "";
          cmbTypeCar.Text = "";
          cmbTypeService.Text = "";
         }

        public void mostrar()
        {
            //frmTablaServicios.listView.Items.Clear();
            foreach (ModelRegister registro in registros)
            {
                if (registro != null) // Si el registro no es nulo (no está vacío) osea si hay datos en el arreglo entonces se muestra
                {
                    ListViewItem item = new ListViewItem(registro.Name);
                    item.SubItems.Add(registro.TypeCar);
                    item.SubItems.Add(registro.TypeService);
                    item.SubItems.Add(registro.MontoAPagar.ToString());
                    frmTablaServicios.listView.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Botón para mostrar la tabla de servicios

            if (frmTablaServicios == null) // Si el formulario no está abierto entonces se crea una nueva instancia y se muestra el formulario de la tabla de servicios 
            {
                frmTablaServicios = new frmTablaServicios(registros);
                frmTablaServicios.Owner = this;
                frmTablaServicios.FormClosed += FrmTablaServicios_FormClosed;

               
                if (registros.GetValue(0) == null)
                {
                    MessageBox.Show("No hay registros para mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mostrar los datos en el listView
                mostrar();
                this.Hide();
                frmTablaServicios.Show();
            }
        }

        private void FrmTablaServicios_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmTablaServicios = null;
            this.Show();
        }

        public void eliminarRegistro()
        {
            // eliminar un registro del arreglo seleccionado del lisview
           //nt pos = Array.IndexOf(registros, registros.Cast<ModelRegister>().FirstOrDefault(modelRegistro => modelRegistro.Name == frmTablaServicios.listView.SelectedItems[0].Text));
            // Lógica de la eliminación
            /*for (int i = pos; i < registros.Length - 1; i++)
            {
                if (registros.GetValue(i + 1) != null)
                {
                    registros.SetValue(registros.GetValue(i + 1), i);
                }
                else
                {
                    registros.SetValue(null, i);
                    break;
                }
            }*/
        }

        public class Metodo_Comparacion : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                double MontoAPagar1 = ((ModelRegister)x).MontoAPagar;
                double MontoAPagar2 = ((ModelRegister)y).MontoAPagar;
                if (MontoAPagar1 < MontoAPagar2) return 1;
                else if (MontoAPagar1 > MontoAPagar2) return -1;
                else return 0;
            }
        }

        public void ordenar()
        {
            // Ordenar los registros del arreglo por el monto a pagar
            Array.Sort(registros,0,registros.Length, new Metodo_Comparacion());
            mostrar();
        }

    }
}
