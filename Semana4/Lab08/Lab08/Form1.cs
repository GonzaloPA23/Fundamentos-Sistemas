using Lab08.Modelos;

namespace Lab08
{
    public partial class Form1 : Form
    {
        List<Agencia> agencias = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarAgencias(List<Agencia> lista)
        {
            listViewAgencia.Items.Clear();
            foreach (Agencia agencia in lista)
            {
                ListViewItem fila = new(agencia.Codigo);
                fila.SubItems.Add(agencia.Direccion);
                fila.SubItems.Add(agencia.Ciudad);
                fila.SubItems.Add(agencia.Telefono);
                listViewAgencia.Items.Add(fila);
            }
        }

        private void MostrarInmuebles(List<Inmueble> lista)
        {
            listViewInmueble.Items.Clear();
            double montoTotalAlquiler = 0;
            foreach (Inmueble inmueble in lista)
            {
                if (inmueble.Condicion.Equals("Alquiler"))
                {
                    montoTotalAlquiler += inmueble.Precio;
                }
                ListViewItem fila = new(inmueble.Codigo);
                fila.SubItems.Add(inmueble.Direccion);
                fila.SubItems.Add(inmueble.Superficie.ToString());
                fila.SubItems.Add(inmueble.Precio.ToString());
                fila.SubItems.Add(inmueble.Condicion);
                listViewInmueble.Items.Add(fila);
            }
            lbMontoTotalAlquiler.Text = montoTotalAlquiler.ToString();
        }

        private void btnAgregarAgencia_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbCodigoAgencia.Text == "" || tbTelefonoAgencia.Text == "" ||
                tbDireccionAgencia.Text == "" || tbCiudadAgencia.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }
            //Vlidación de código
            bool existe = agencias.Exists(a => a.Codigo.Equals(tbCodigoAgencia.Text));
            if (existe)
            {
                MessageBox.Show("Ya existe una agencia con ese código");
                return;
            }
            // Crear el objeto agencia
            Agencia agencia = new()
            {
                Codigo = tbCodigoAgencia.Text,
                Direccion = tbDireccionAgencia.Text,
                Ciudad = tbCiudadAgencia.Text,
                Telefono = tbTelefonoAgencia.Text,
                Inmuebles = new()
            };
            //Agregar a la lista
            agencias.Add(agencia);
            // Mostrar en el listbox
            MostrarAgencias(agencias);
            // Limpiar los campos
            tbCodigoAgencia.Text = "";
            tbDireccionAgencia.Text = "";
            tbCiudadAgencia.Text = "";
            tbTelefonoAgencia.Text = "";
        }

        private void btnLimpiarAgencia_Click(object sender, EventArgs e)
        {
            // Mostrar en el listbox
            MostrarAgencias(agencias);
        }

        private void btnAgregarInmueble_Click(object sender, EventArgs e)
        {
            //Validación de agencia seleccionada
            if (listViewAgencia.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una agencia");
                return;
            }
            // Validación de campos
            if (tbCodigoInmueble.Text == "" || tbDireccionInmueble.Text == "" || tbSuperficieInmueble.Text == "" ||
                tbPrecioInmueble.Text == "" || cbCondicionInmueble.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }
            // Validación de código
            String codigo = tbCodigoInmueble.Text;
            foreach (Agencia agencia in agencias)
            {
                bool existe = agencia.Inmuebles.Exists(i => i.Codigo.Equals(codigo));
                if (existe)
                {
                    MessageBox.Show("Ya existe un inmueble con ese código");
                    return;
                }
            }
            // Buscamos la agencia seleccionada
            String codigoAgencia = listViewAgencia.SelectedItems[0].Text;
            Agencia? agenciaSeleccionada = agencias.Find(a => a.Codigo.Equals(codigoAgencia));

            if (agenciaSeleccionada != null)
            {
                // Crear el objeto
                Inmueble inmueble = new()
                {
                    Codigo = tbCodigoInmueble.Text,
                    Direccion = tbDireccionInmueble.Text,
                    Superficie = double.Parse(tbSuperficieInmueble.Text),
                    Precio = double.Parse(tbPrecioInmueble.Text),
                    Condicion = cbCondicionInmueble.Text
                };
                // Agregar a la lista
                agenciaSeleccionada.Inmuebles.Add(inmueble);
                // Mostrar en el listbox
                MostrarInmuebles(agenciaSeleccionada.Inmuebles);
            }
        }

        private void btnLimpiarInmueble_Click(object sender, EventArgs e)
        {
            MostrarInmuebles(new List<Inmueble>());
        }

        private void listViewAgencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Validación de agencia seleccionada
            if (listViewAgencia.SelectedItems.Count == 0) return;
            // Buscamos la agencia seleccionada
            String codigoAgencia = listViewAgencia.SelectedItems[0].Text;
            Agencia? agencia = agencias.Find(a => a.Codigo.Equals(codigoAgencia));
            if (agencia != null)
            {
                // Mostrar en el listView
                MostrarInmuebles(agencia.Inmuebles);
            }

        }

        private void btnAlquilanInmueblesConMayorFrecuencia_Click(object sender, EventArgs e)
        {
            // Buscamos las que alquilan los inmuebles con mayor superficie (por agencia)
            List<Agencia> agenciasTemp = new();
            double maxSuperficie = 0;
            foreach (Agencia agencia in agencias)
            {
                Inmueble? inmuebleMaxSuperficie = agencia.Inmuebles.MaxBy(i => i.Superficie);
                if (inmuebleMaxSuperficie != null)
                {
                    if (inmuebleMaxSuperficie.Superficie > maxSuperficie)
                    {
                        maxSuperficie = inmuebleMaxSuperficie.Superficie;
                        agenciasTemp.Clear();
                        agenciasTemp.Add(agencia);
                    }
                    else if (inmuebleMaxSuperficie.Superficie == maxSuperficie)
                    {
                        agenciasTemp.Add(agencia);
                    }
                }
            }

            // Mostrar en el listview
            MostrarAgencias(agenciasTemp);
        }

        private void btnTienenMásInmueblesEnVenta_Click(object sender, EventArgs e)
        {
            // Buscamos las que tienen la mayor cantidad de inmuebles a la venta
            List<Agencia> agenciasTemp = new();
            int maxInmueblesVenta = 0;
            foreach (Agencia agencia in agencias)
            {
                int inmueblesVenta = agencia.Inmuebles.Count(i => i.Condicion.Equals("Venta"));
                // OTRA FORMA
                //int cantidad = (agencia.Inmuebles.FindAll(i => i.Condicion.Equals("Venta"))).Count();
                if (inmueblesVenta > maxInmueblesVenta)
                {
                    maxInmueblesVenta = inmueblesVenta;
                    agenciasTemp.Clear();
                    agenciasTemp.Add(agencia);
                }
                else if (inmueblesVenta == maxInmueblesVenta)
                {
                    agenciasTemp.Add(agencia);
                }
            }
            // Mostrar en el listview
            MostrarAgencias(agenciasTemp);
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            if(tbBuscarPorAgencia.Text == "")
            {
                MessageBox.Show("Debe ingresar un código de agencia");
                return;
            }
            // Buscamos la agencia seleccionada 
            Agencia? agenciaSeleccionada = agencias.Find(a => a.Codigo.Equals(tbBuscarPorAgencia.Text));
            if(agenciaSeleccionada != null)
            {
                // Buscamos los inmuebles en venta
                List<Inmueble> inmueblesTemp = agenciaSeleccionada.Inmuebles.FindAll(i => i.Condicion.Equals("Venta"));
                // Mostrar en el listview
                MostrarInmuebles(inmueblesTemp);
            }

        }
    }
}