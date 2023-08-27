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

namespace Lab04
{
    public partial class Form1 : Form
    {
        Alumno[] alumnos = new Alumno[100];
        int indice = 0; // Indice para el arreglo de alumnos (alumnos), actua como contador

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            // Validacion
            if (textBoxCodigo.Text == "" || textBoxNombreCompleto.Text == "" || textBoxPromedio.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los campos");
                return;
            }

            // Crear un objeto de tipo Alumno
            Alumno alumno = new Alumno();
            alumno.Codigo = textBoxCodigo.Text;
            alumno.Nombre = textBoxNombreCompleto.Text;
            alumno.Promedio = double.Parse(textBoxPromedio.Text);

            // Agregar el objeto al array de Alumnos
            alumnos[indice] = alumno;
            indice++;

            // Limpiar los campos
            textBoxCodigo.Text = "";
            textBoxNombreCompleto.Text = "";
            textBoxPromedio.Text = "";
        }

        private void mostrar(Alumno[] arreglo, int cantidad)
        {
            listView1.Items.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                ListViewItem fila = new ListViewItem(arreglo[i].Codigo);
                fila.SubItems.Add(arreglo[i].Nombre);
                fila.SubItems.Add(arreglo[i].Promedio.ToString());
                listView1.Items.Add(fila);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrar(alumnos, indice);
        }

        private class Metodo_Comparacion : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                double promedio1 = ((Alumno)x).Promedio;
                double promedio2 = ((Alumno)y).Promedio;
                //return promedio1.CompareTo(promedio2);
                if (promedio1 < promedio2)
                    return 1;
                else if (promedio1 > promedio2)
                    return -1;
                else
                    return 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Array.Sort(alumnos, new Metodo_Comparacion());
            Array.Sort(alumnos,0,indice, new Metodo_Comparacion());
            mostrar(alumnos, indice);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Validacion
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un alumno a eliminar");
                return;
            }

            // Obtener el indice del alumno seleccionado
            // lambda: expresion => expresion ; elemento => condicion del elemento
            int pos = Array.FindIndex(alumnos, alumno => alumno.Codigo == listView1.SelectedItems[0].Text);

            // Lógica de la eliminación
            for(int i = 0; i < indice; i++)
            {
                if (i >= pos)
                {
                    alumnos[i] = alumnos[i + 1];
                }
            }
            indice--;
            mostrar(alumnos, indice);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Validacion 
            if (textBoxBuscar.Text == "")
            {
                MessageBox.Show("Ingrese un codigo a buscar");
                return;
            }

            // Busqueda
            // Creamos un arreglo temporal para almacenar los resultados de la busqueda 
            Alumno[] alumnoTmp = Array.FindAll(alumnos,alumno => alumno != null && textBoxBuscar.Text == alumno.Codigo); // Buscamos el codigo que pasan por el textBox
            mostrar(alumnoTmp, alumnoTmp.Length);

        }
    }
}
