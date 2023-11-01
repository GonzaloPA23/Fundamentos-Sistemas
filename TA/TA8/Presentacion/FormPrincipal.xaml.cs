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
using Entidades;
using Negocio;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para FormPrincipal.xaml
    /// </summary>
    public partial class FormPrincipal : Window
    {
        private EChofer choferSeleccionado = null;
        private NChofer nChofer = new NChofer();      
        public FormPrincipal()
        {
            InitializeComponent();
            Mostrar(nChofer.ListarChoferes());
        }

        private void Mostrar(List<EChofer> choferes)
        {
            dtgChoferes.ItemsSource = new List<EChofer>();
            dtgChoferes.ItemsSource = choferes;
        }

        private void LimpiarCampos()
        {
            txtDni.Text = string.Empty;
            txtNombreCompleto.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtCorreo.Text = string.Empty;
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            string mensaje = string.Empty;
            EChofer eChofer = new EChofer()
            {
                Dni = txtDni.Text,
                NombreCompleto = txtNombreCompleto.Text,
                Celular = txtCelular.Text,
                Correo = txtCorreo.Text
            };
            int idchofergenerado = new NChofer().RegistrarChofer(eChofer,out mensaje);
            if (idchofergenerado != 0)
            {
                MessageBox.Show("Chofer registrado correctamente", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                LimpiarCampos();
                Mostrar(nChofer.ListarChoferes());
            }
            else MessageBox.Show(mensaje, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de que se haya seleccionado un chofer
            if (choferSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un chofer", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            // Eliminación del chofer
            int filasafectadas = nChofer.EliminarChofer(choferSeleccionado.Id);
            if (filasafectadas != 0)
            {
                MessageBox.Show("Chofer eliminado correctamente", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                Mostrar(nChofer.ListarChoferes());
            }
            else MessageBox.Show("No se pudo eliminar el chofer", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
           
            // Validación de que se haya seleccionado un chofer
            if (choferSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un chofer", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            // Empesar a editar
            EChofer eChofer = new EChofer()
            {
                Id = choferSeleccionado.Id,
                Dni = txtDni.Text,
                NombreCompleto = txtNombreCompleto.Text,
                Celular = txtCelular.Text,
                Correo = txtCorreo.Text
            };

            string mensaje = nChofer.Modificar(eChofer);
            if (mensaje == string.Empty)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else {
                MessageBox.Show("Chofer modificado correctamente", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                LimpiarCampos();
                Mostrar(nChofer.ListarChoferes());
            }                    
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dtgChoferes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            choferSeleccionado = dtgChoferes.SelectedItem as EChofer;
        }
    }
}
