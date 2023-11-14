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
using System.Windows.Navigation;
using System.Windows.Shapes;
using datos;
using entidades;
using negocio;

namespace presentacion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private nDocente negocioDocente = new nDocente();
        private nCurso negocioCurso = new nCurso();
        private nDocentexCurso negocioDocentexCurso = new nDocentexCurso();

        public MainWindow()
        {
            InitializeComponent();

            // Llena el ComboBox con los cursos disponibles
            cmbCurso.ItemsSource = negocioCurso.ObtenerNombresCursos();

            // Obtén y muestra la lista de DocentexCurso
            List<DocentexCurso> docentexCursos = negocioDocentexCurso.ObtenerTodosLosDocentexCursos();
            datagridDocentexCurso.ItemsSource = docentexCursos;

            // Obtén y muestra la lista de cursos
            List<Curso> cursos = negocioCurso.ObtenerTodosLosCursos();
            datagridCursos.ItemsSource = cursos;

            // Carga la lista de docentes en el DataGrid al iniciar la ventana
            ActualizarDataGrid();
        }

        private void BtnInsertar_Click(object sender, RoutedEventArgs e)
        {
            // Obtén los valores de los TextBox
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            // Validar que los campos de nombre y apellido no estén en blanco
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Por favor, complete los campos de Nombre y Apellido.");
                return; // No insertar si falta información
            }

            // Validar que se haya seleccionado un elemento en el ComboBox
            if (cmbEscuela.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una Escuela.");
                return; // No insertar si no se seleccionó una escuela
            }

            // Obtén la escuela seleccionada del ComboBox
            ComboBoxItem escuelaItem = (ComboBoxItem)cmbEscuela.SelectedItem;
            string escuela = escuelaItem.Content.ToString();

            // Crea un nuevo objeto Docente con los valores obtenidos
            Docente nuevoDocente = new Docente
            {
                Nombre = nombre,
                Apellido = apellido,
                Escuela = escuela
            };

            // Inserta un nuevo docente
            negocioDocente.AgregarDocente(nuevoDocente);

            // Actualiza el DataGrid
            ActualizarDataGrid();

            // Limpia los campos de entrada
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            cmbEscuela.SelectedIndex = -1; // Deseleccionar el elemento del ComboBox

        }

        private void BtnActualizar_Click(object sender, RoutedEventArgs e)
        {
            // Verifica si hay un registro seleccionado en el DataGrid
            if (datagridDocentes.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un docente de la lista antes de actualizar.");
                return; // Sale de la función si no hay un registro seleccionado
            }
            // Obtén el docente seleccionado del DataGrid
            Docente docenteSeleccionado = (Docente)datagridDocentes.SelectedItem;

            if (docenteSeleccionado != null)
            {
                // Actualiza los datos del docente
                docenteSeleccionado.Nombre = txtNombre.Text;
                docenteSeleccionado.Apellido = txtApellido.Text;

                // Asegúrate de que el combo contenga objetos ComboBoxItem
                if (cmbEscuela.SelectedItem is ComboBoxItem escuelaItem)
                {
                    docenteSeleccionado.Escuela = escuelaItem.Content.ToString();
                }

                negocioDocente.ActualizarDocente(docenteSeleccionado);

                // Actualiza el DataGrid
                ActualizarDataGrid();

                // Limpia los campos de entrada
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;

                // Limpia la selección del ComboBox
                cmbEscuela.SelectedItem = null;
            }
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            // Obtén el docente seleccionado del DataGrid
            Docente docenteSeleccionado = (Docente)datagridDocentes.SelectedItem;

            if (docenteSeleccionado != null)
            {
                // Elimina el docente
                negocioDocente.EliminarDocentePorId(docenteSeleccionado.Id_docente);

                // Actualiza el DataGrid
                ActualizarDataGrid();
            }
        }

        private void BtnGenerarReporte_Click(object sender, RoutedEventArgs e)
        {
            if (cmbCurso.SelectedItem != null)
            {
                string cursoSeleccionado = cmbCurso.SelectedItem.ToString();

                // Utiliza el método de negocio para obtener los docentes por curso
                List<Docente> docentesCurso = negocioCurso.ObtenerDocentesPorCurso(cursoSeleccionado);

                // Limpia cualquier contenido previo en el ListBox
                listBoxReporte.Items.Clear();

                // Muestra los docentes en un ListBox
                foreach (var docente in docentesCurso)
                {
                    listBoxReporte.Items.Add($"{docente.Nombre} {docente.Apellido}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un curso antes de generar el reporte.", "Selección de Curso", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void ActualizarDataGrid()
        {
            // Obtén y muestra la lista de docentes en el DataGrid
            List<Docente> docentes = negocioDocente.ObtenerTodosLosDocentes();
            datagridDocentes.ItemsSource = docentes;
        }

        private void datagridDocentes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Verifica que haya una selección válida en el DataGrid
            //if (datagridDocentes.SelectedItem != null)
            if (datagridDocentes.SelectedItem is Docente docenteSeleccionado)
            {
                // Obtén el docente seleccionado
                //Docente docenteSeleccionado = (Docente)datagridDocentes.SelectedItem;

                // Llena los campos con los datos del docente seleccionado
                txtNombre.Text = docenteSeleccionado.Nombre;
                txtApellido.Text = docenteSeleccionado.Apellido;

                string escuelaSeleccionada = docenteSeleccionado.Escuela;

                foreach (ComboBoxItem item in cmbEscuela.Items)
                {
                    if (item.Content.ToString() == escuelaSeleccionada)
                    {
                        cmbEscuela.SelectedItem = item;
                        break; // Para detener la búsqueda una vez que se haya encontrado la coincidencia
                    }
                }
            }
        }

        private void BtnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            // Limpia los campos de entrada y el ComboBox
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            cmbEscuela.SelectedItem = null; // Esto limpia la selección en el ComboBox

            // Deselecciona cualquier elemento seleccionado en el DataGrid
            datagridDocentes.SelectedItem = null;
        }
    }
}
