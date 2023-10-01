using PC1.Modelos;

namespace PC1
{
    public partial class Form1 : Form
    {
        List<Viaje> viajes = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarViajes(List<Viaje> lista)
        {
            listViewDatabaseViajes.Items.Clear();
            foreach (Viaje viaje in lista)
            {
                ListViewItem item = new(viaje.Codigo);
                item.SubItems.Add(viaje.Destino);
                item.SubItems.Add(viaje.FechaSalida);
                item.SubItems.Add(viaje.FechaRegreso);
                item.SubItems.Add(viaje.Precio.ToString());
                listViewDatabaseViajes.Items.Add(item);
            }
        }

        private void MostrarClientes(List<Cliente> lista)
        {
            listViewDatabaseClientes.Items.Clear();
            foreach (Cliente cliente in lista)
            {
                ListViewItem item = new(cliente.Codigo);
                item.SubItems.Add(cliente.Nombre);
                item.SubItems.Add(cliente.CorreoElectronico);
                item.SubItems.Add(cliente.NumeroTelefono);
                listViewDatabaseClientes.Items.Add(item);
            }
        }

        private void btnAgregarViaje_Click(object sender, EventArgs e)
        {
            // Validaci�n de campos
            if (tbCodigoViaje.Text == "" || tbDestinoViaje.Text == "" || dtpFechaSalidaViaje.Text == "" || dtpFechaRegresoViaje.Text == "" || tbPrecioViaje.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validaci�n de fechas
            if (dtpFechaSalidaViaje.Value > dtpFechaRegresoViaje.Value)
            {
                MessageBox.Show("La fecha de salida no puede ser mayor a la fecha de regreso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Verificaci�n de codigo de viaje 
            bool existe = viajes.Exists(viaje => viaje.Codigo == tbCodigoViaje.Text);
            if (existe)
            {
                MessageBox.Show("Ya existe una reserva de viaje con ese c�digo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Crear el objeto
            Viaje viaje = new()
            {
                Codigo = tbCodigoViaje.Text,
                Destino = tbDestinoViaje.Text,
                FechaSalida = dtpFechaSalidaViaje.Text,
                FechaRegreso = dtpFechaRegresoViaje.Text,
                Precio = double.Parse(tbPrecioViaje.Text),
                Clientes = new()
            };
            // A�adir a la lista
            viajes.Add(viaje);
            // Limpiar campos
            tbCodigoViaje.Text = "";
            tbDestinoViaje.Text = "";
            dtpFechaSalidaViaje.Text = "";
            dtpFechaRegresoViaje.Text = "";
            tbPrecioViaje.Text = "";
            // Mostrar las reservas de viaje en el listview
            MostrarViajes(viajes);
        }

        private void btnLimpiarViaje_Click(object sender, EventArgs e)
        {
            MostrarViajes(viajes);
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            // Validaci�n de Reserva seleccionada
            if (listViewDatabaseViajes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva de viaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validaci�n de campos
            if (tbCodigoCliente.Text == "" || tbNombreCliente.Text == "" || tbCorreoCliente.Text == "" || tbNumeroTelefonoCliente.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validaci�n que sea un correo
            if (!tbCorreoCliente.Text.Contains("@"))
            {
                MessageBox.Show("Por favor, ingrese un correo electr�nico v�lido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validaci�n de c�digo repetido
            String codigoViaje = tbCodigoCliente.Text;
            foreach (Viaje viaje in viajes)
            {
                bool existe = viaje.Clientes.Exists(cliente => cliente.Codigo == tbCodigoCliente.Text);
                if (existe)
                {
                    MessageBox.Show("Ya existe un cliente con ese c�digo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            // Buscar el viaje seleccionado
            String codigoViajeSeleccionado = listViewDatabaseViajes.SelectedItems[0].Text;
            Viaje? viajeSeleccionado = viajes.Find(viaje => viaje.Codigo.Equals(codigoViajeSeleccionado));
            if (viajeSeleccionado != null)
            {
                // Crear el objeto cliente
                Cliente cliente = new()
                {
                    Codigo = tbCodigoCliente.Text,
                    Nombre = tbNombreCliente.Text,
                    CorreoElectronico = tbCorreoCliente.Text,
                    NumeroTelefono = tbNumeroTelefonoCliente.Text
                };
                // Agregar a la lista 
                viajeSeleccionado.Clientes.Add(cliente);
                // Limpiar campos
                tbCodigoCliente.Text = "";
                tbNombreCliente.Text = "";
                tbCorreoCliente.Text = "";
                tbNumeroTelefonoCliente.Text = "";
                // Mostrar los clientes en el listview
                MostrarClientes(viajeSeleccionado.Clientes);
            }
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            MostrarClientes(new List<Cliente>());
        }

        private void listViewDatabaseViajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Validaci�n de Reserva seleccionada
            if (listViewDatabaseViajes.SelectedItems.Count == 0) return;
            // Buscar el viaje seleccionado
            String codigoViajeSeleccionado = listViewDatabaseViajes.SelectedItems[0].Text;
            Viaje? viajeSeleccionado = viajes.Find(viaje => viaje.Codigo.Equals(codigoViajeSeleccionado));
            if (viajeSeleccionado != null)
            {
                // Mostrar los clientes en el listview
                MostrarClientes(viajeSeleccionado.Clientes);
            }
        }

        private void btnBuscarViajesXDestino_Click(object sender, EventArgs e)
        {
            // Validaci�n de campo
            if (tbBuscarDestino.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Buscar viajes por destino
            List<Viaje> viajesEncontrados = viajes.FindAll(viaje => viaje.Destino.Contains(tbBuscarDestino.Text));
            // Mostrar los viajes encontrados
            MostrarViajes(viajesEncontrados);
            // Limpiar el textbox
            tbBuscarDestino.Text = "";
        }

        private void button6_Click(object sender, EventArgs e) // Buscqueda de filtrar los clientes por su direcci�n de correo electronico
        {
            // Validaci�n de campo
            if (tbBuscarClienteXCorreo.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un correo electr�nico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Buscar clientes por correo electr�nico
            List<Cliente> clientesEncontrados = new();
            foreach (Viaje viaje in viajes)
            {
                List<Cliente> clientes = viaje.Clientes.FindAll(cliente => cliente.CorreoElectronico.Contains(tbBuscarClienteXCorreo.Text));
                clientesEncontrados.AddRange(clientes);
            }
            // Mostrar los clientes encontrados
            MostrarClientes(clientesEncontrados);
            // Limpiar el textbox
            tbBuscarClienteXCorreo.Text = "";
        }
    }
}