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
using Datos;
using Negocio;


namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnVerDocentes_Click(object sender, RoutedEventArgs e)
        {
            DocenteWindow window = new DocenteWindow();
            window.Show();
        }
        //es este
        private void btnVerDocente_Click(object sender, RoutedEventArgs e)
        {
            DocenteWindow window = new DocenteWindow();
            window.Show();
        }

        private void btnVerCursos_Click(object sender, RoutedEventArgs e)
        {
            CursoWindow window = new CursoWindow();
            window.Show();
        }
        //es este
        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAsignar_Click(object sender, RoutedEventArgs e)
        {
            DocenteXCursoWindow window = new DocenteXCursoWindow();
            window.Show();
        }

      
        //es este
        private void btnVerCurso_Click(object sender, RoutedEventArgs e)
        {
            CursoWindow window = new CursoWindow();
            window.Show();
        }
        //es este
        private void btnVerUniversidad_Click(object sender, RoutedEventArgs e)
        {
            UniversidadWindow window = new UniversidadWindow();
            window.Show();
        }
        //es este
        private void btnAsignarCurso_Click(object sender, RoutedEventArgs e)
        {
            DocenteXCursoWindow window = new DocenteXCursoWindow();
            window.Show();
        }
        //es este
        private void btnAsignarUniversidad_Click(object sender, RoutedEventArgs e)
        {
            DocenteXUniversidadWindow window = new DocenteXUniversidadWindow();
            window.Show();
        }
    }
}
