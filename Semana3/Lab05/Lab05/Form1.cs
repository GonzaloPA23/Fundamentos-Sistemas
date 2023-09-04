namespace Lab05
{
    public partial class Form1 : Form
    {
        List<Electrodomestico> electrodomesticos = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Mostrar(List<Electrodomestico> lista)
        {
            listViewDatabase.Items.Clear();
            int stockTotal = 0;

            foreach (Electrodomestico elec in lista)
            {
                ListViewItem fila = new ListViewItem(elec.Codigo);
                fila.SubItems.Add(elec.Nombre);
                fila.SubItems.Add(elec.Stock.ToString());
                fila.SubItems.Add(elec.Precio.ToString());
                listViewDatabase.Items.Add(fila);
                stockTotal += elec.Stock;
            }
            // Actualizar los totales
            labelTotalRegistros.Text = lista.Count.ToString();
            labelTotalStock.Text = stockTotal.ToString();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            // Validacion 
            if (textBoxCodigo.Text == "" || textBoxNombre.Text == "" || textBoxPrecio.Text == "" || numericUpDownStock.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }
            // Verificacion de codigo repetido
            bool exists = electrodomesticos.Exists(elemento => elemento.Codigo.Equals(textBoxCodigo.Text));
            if (exists)
            {
                MessageBox.Show("El codigo ya existe");
                return;
            }
            // Crear el objeto
            Electrodomestico elec = new()
            {
                Codigo = textBoxCodigo.Text,
                Nombre = textBoxNombre.Text,
                Stock = (int)numericUpDownStock.Value,
                Precio = double.Parse(textBoxPrecio.Text),
            };
            // Agregarlo a la lista
            electrodomesticos.Add(elec);
            // Mostrar en el ListView
            Mostrar(electrodomesticos);
            // Limpiar los campos
            textBoxCodigo.Clear();
            textBoxNombre.Clear();
            textBoxPrecio.Clear();
            numericUpDownStock.Value = 0;

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Validacion
            if (listViewDatabase.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un elemento");
                return;
            }
            // Obtener el codigo
            String codigo = listViewDatabase.SelectedItems[0].Text;
            // Eliminar al que tiene ese codigo
            electrodomesticos.RemoveAll(elemento => elemento.Codigo.Equals(codigo));
            Mostrar(electrodomesticos);
        }

        private void buttonEliminarTodo_Click(object sender, EventArgs e)
        {
            electrodomesticos.Clear();
            Mostrar(electrodomesticos);
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            electrodomesticos.Sort((e1, e2) =>
            {
                if (e1.Precio < e2.Precio) return 1;
                else return -1;
            });
            // Mostrar en el ListView
            Mostrar(electrodomesticos);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            // Mostrar en el ListView
            Mostrar(electrodomesticos);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            // Validacion
            if(textBoxBuscarXNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del electrodomestico a buscar");
                return;
            }
            // Buscar el electrodomestico
            List<Electrodomestico> elecTemp = electrodomesticos.FindAll(elemento => elemento.Nombre.Contains(textBoxBuscarXNombre.Text));
            // Mostrar en el ListView
            Mostrar(elecTemp);
        }
    }
}