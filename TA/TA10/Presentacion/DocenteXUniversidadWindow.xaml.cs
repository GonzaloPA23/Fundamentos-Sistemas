using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Datos;
using Negocio;


namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para DocenteXUniversidadWindow.xaml
    /// </summary>
    public partial class DocenteXUniversidadWindow : Window
    {
        private NDocentexUniversidad nDocenteXUniversidad = new NDocentexUniversidad();
        private NUniversidad nUniversidad = new NUniversidad();
        private NDocente nDocente = new NDocente();
        public DocenteXUniversidadWindow()
        {
            InitializeComponent();
            MostrarDocentes(nDocente.ListarTodo());
            MostrarUniversidades(nUniversidad.ListarTodo());
            MostrarDocenteXUniversidades(nDocenteXUniversidad.ListarTodo());
        }
        private void MostrarDocenteXUniversidades(List<DocentexUniversidad> docenteXUniversidades)
        {
            dgvDocenteXUniversidades.ItemsSource = new List<DocentexUniversidad>();
            dgvDocenteXUniversidades.ItemsSource = docenteXUniversidades;
        }
        private void MostrarDocentes(List<Docente> docentes)
        {
            cmbDocente.ItemsSource = new List<Docente>();
            cmbDocente.ItemsSource = docentes;
            cmbDocente.DisplayMemberPath = "Nombre";
            cmbDocente.SelectedValuePath = "Id_docente";
        }
        private void MostrarUniversidades(List<Universidad> universidades)
        {
            cmbUniversidad.ItemsSource = new List<Universidad>();
            cmbUniversidad.ItemsSource = universidades;
            cmbUniversidad.DisplayMemberPath = "Nombre";
            cmbUniversidad.SelectedValuePath = "Id_universidad";
        }
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (cmbUniversidad.Text == "" || cmbDocente.Text == "" || txbDetalle.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            DocentexUniversidad docenteXUniversidad = new DocentexUniversidad
            {
                Id_docente = (int)cmbDocente.SelectedValue,
                Id_universidad = (int)cmbUniversidad.SelectedValue,
                Detalle = txbDetalle.Text
            };

            // Asignar el objeto
            String mensaje = nDocenteXUniversidad.Asignar(docenteXUniversidad);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarDocenteXUniversidades(nDocenteXUniversidad.ListarTodo());
        }
        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
