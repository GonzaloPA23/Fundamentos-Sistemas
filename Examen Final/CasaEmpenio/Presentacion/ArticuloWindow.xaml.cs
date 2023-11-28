using Datos;
using Negocio;
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

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para ArticuloWindow.xaml
    /// </summary>
    public partial class ArticuloWindow : Window
    {
        private NArticulo nArticulo = new NArticulo();
        ARTICULO articuloSeleccionado = null;
        public ArticuloWindow()
        {
            InitializeComponent();
            MostrarArticulos(nArticulo.ListarArticulos());
        }

        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            cbPais.SelectedIndex = -1;
            dpFechaRegistro.Text = DateTime.Now.ToString();
            txtPrecio.Text = "";
            cbTipo.SelectedIndex = -1;  
            cbParaOfrecer.SelectedIndex = -1;
        }

        private void MostrarArticulos(List<ARTICULO> articulos)
        {
            dgArticulos.ItemsSource = new List<ARTICULO>(); 
            dgArticulos.ItemsSource = articulos;
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            // Crear un objeto de tipo ARTICULO
            ARTICULO articulo = new ARTICULO()
            {
                codarticulo = txtCodigo.Text,
                descripcion = txtDescripcion.Text,
                pais = cbPais.Text,
                fecharegistro = DateTime.Parse(dpFechaRegistro.Text),
                precio = decimal.Parse(txtPrecio.Text),
                tipo = cbTipo.Text,
                paraofrecer = cbParaOfrecer.Text
            };

            // Llamar al método RegistrarArticulo de la clase NArticulo
            String mensaje = nArticulo.RegistrarArticulo(articulo);
            MessageBox.Show(mensaje, "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);

            // Actualizar el DataGrid
            MostrarArticulos(nArticulo.ListarArticulos());
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if(articuloSeleccionado == null) { MessageBox.Show ("Seleccione un articulo", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning); return; }
            // Crear un objeto de tipo ARTICULO
            ARTICULO articulo = new ARTICULO()
            {
                codarticulo = articuloSeleccionado.codarticulo,
                descripcion = txtDescripcion.Text,
                pais = cbPais.Text,
                fecharegistro = DateTime.Parse(dpFechaRegistro.Text),
                precio = decimal.Parse(txtPrecio.Text),
                tipo = cbTipo.Text,
                paraofrecer = cbParaOfrecer.Text
            };

            String mensaje = nArticulo.ModificarArticulo(articulo);
            MessageBox.Show(mensaje, "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);

            if (mensaje == "Articulo modificado correctamente")
            {
                LimpiarCampos();
                txtCodigo.IsEnabled = true;
            }
            // Actualizar el DataGrid
            MostrarArticulos(nArticulo.ListarArticulos());
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if(articuloSeleccionado == null) { MessageBox.Show ("Seleccione un articulo", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning); return; }
            String mensaje = nArticulo.EliminarArticulo(articuloSeleccionado.codarticulo);
            MessageBox.Show(mensaje, "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
            
            MostrarArticulos(nArticulo.ListarArticulos());
            LimpiarCampos();
        }

        private void dgArticulos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            articuloSeleccionado = dgArticulos.SelectedItem as ARTICULO;
            if (articuloSeleccionado != null)
            {
                txtCodigo.Text = articuloSeleccionado.codarticulo;
                txtCodigo.IsEnabled = false;
                txtDescripcion.Text = articuloSeleccionado.descripcion;
                cbPais.Text = articuloSeleccionado.pais;
                dpFechaRegistro.Text = articuloSeleccionado.fecharegistro.ToString();
                txtPrecio.Text = articuloSeleccionado.precio.ToString();
                cbTipo.Text = articuloSeleccionado.tipo;
                cbParaOfrecer.Text = articuloSeleccionado.paraofrecer;
            }
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            LimpiarCampos();
            txtCodigo.IsEnabled = true;
            MostrarArticulos(nArticulo.ListarArticulos());
        }
    }
}
