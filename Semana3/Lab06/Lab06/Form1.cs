namespace Lab06
{
    public partial class Form1 : Form
    {
        List<Album> albumes = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarAlbumes(List<Album> lista)
        {
            listViewAlbum.Items.Clear();
            foreach (Album album in lista)
            {
                ListViewItem fila = new(album.Codigo);
                fila.SubItems.Add(album.Nombre);
                listViewAlbum.Items.Add(fila);
            }

            // Obtener el album con más héroes
            Album? albumMasHeroes = lista.MaxBy(elemento => elemento.Heroes.Count()); // Con MaxBy se obtiene el elemento con el valor máximo de una propiedad específica de la lista (en este caso, la cantidad de héroes)
            if (albumMasHeroes != null) labelAlbumMasHeroes.Text = albumMasHeroes.Nombre;
        }

        private void MostrarHeroes(List<Heroe> lista)
        {
            listViewHeroe.Items.Clear();
            foreach (Heroe heroe in lista)
            {
                ListViewItem fila = new(heroe.Codigo);
                fila.SubItems.Add(heroe.Nombre);
                fila.SubItems.Add(heroe.Caracteristicas);
                fila.SubItems.Add(heroe.Poder.ToString());
                listViewHeroe.Items.Add(fila);
            }

            // Obtener el héroe con más poder
            Heroe? heroeMayorPoder = lista.MaxBy(elemento => elemento.Poder);
            // Obtener el héroe con menos poder
            Heroe? heroeMenorPoder = lista.MinBy(elemento => elemento.Poder);
            if (heroeMayorPoder != null) label1HeroeMasPoder.Text = heroeMayorPoder.Nombre;
            if (heroeMenorPoder != null) labelHeroeMenosPoder.Text = heroeMenorPoder.Nombre;

        }

        private void btnRegistrarAlbum_Click(object sender, EventArgs e)
        {
            // Validacion
            if (txtNombreAlbum.Text == "" || txtCodigoAlbum.Text == "")
            {
                MessageBox.Show("Ingresa todos los campos del álbum");
                return;
            }

            // Verificación de código
            bool existe = albumes.Exists(elemento => elemento.Codigo.Equals(txtCodigoAlbum.Text));
            if (existe)
            {
                MessageBox.Show("El código del álbum ya existe");
                return;
            }

            // Creación del objeto álbum
            Album album = new()
            {
                Codigo = txtCodigoAlbum.Text,
                Nombre = txtNombreAlbum.Text,
                Heroes = new() // importante inicializar la lista de héroes del álbum para evitar errores de null reference
            };

            // Agregar el álbum a la lista de álbumes
            albumes.Add(album);

            // Mostrar en el ListView
            MostrarAlbumes(albumes);

            // Limpiar los campos
            txtCodigoAlbum.Text = "";
            txtNombreAlbum.Text = "";
        }

        private void btnLimpiarAlbum_Click(object sender, EventArgs e)
        {
            MostrarAlbumes(albumes);
        }

        private void bntRegistrarHeroe_Click(object sender, EventArgs e)
        {
            // Validacion
            bool seleccionado = listViewAlbum.SelectedItems.Count != 0; // Verificar que se haya seleccionado un álbum

            if (!seleccionado || txtCaracteristicasHeroe.Text == "" || txtCodigoHeroe.Text == "" || txtNombreHeroe.Text == "" || txtPoderHeroe.Text == "")
            {
                MessageBox.Show("Ingresa todos los campos del álbum");
                return;
            }

            // Encontrar el album seleccionado
            String codigo = listViewAlbum.SelectedItems[0].Text; // Obtener el código del álbum seleccionado
            Album? albumSeleccionado = albumes.Find(elemento => elemento.Codigo.Equals(codigo)); // Buscar el álbum con el código seleccionado
            if (albumSeleccionado == null) return; // Si no se encuentra el álbum, no se puede registrar el héroe

            // Hallamos la lista de heroes del album seleccionado
            List<Heroe> heroes = albumSeleccionado.Heroes;

            // Verificación de código
            bool existe = heroes.Exists(elemento => elemento.Codigo.Equals(txtCodigoHeroe.Text));
            if (existe)
            {
                MessageBox.Show("El código del héroe ya existe");
                return;
            }

            // Creación del objeto héroe
            Heroe heroe = new()
            {
                Codigo = txtCodigoHeroe.Text,
                Nombre = txtNombreHeroe.Text,
                Caracteristicas = txtCaracteristicasHeroe.Text,
                Poder = double.Parse(txtPoderHeroe.Text)
            };

            // Agregar el objeto a la lista de heroes del album
            albumSeleccionado.Heroes.Add(heroe);

            // Mostrar en el ListView
            MostrarHeroes(albumSeleccionado.Heroes);
        }

        private void listViewAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar que se haya seleccionado un álbum
            bool seleccionado = listViewAlbum.SelectedItems.Count != 0;
            if (!seleccionado) return;

            // Hallar el album seleccionado
            String codigo = listViewAlbum.SelectedItems[0].Text;
            Album? albumSeleccionado = albumes.Find(elemento => elemento.Codigo.Equals(codigo));
            if (albumSeleccionado == null) return;

            // Mostrar los héroes del álbum seleccionado
            MostrarHeroes(albumSeleccionado.Heroes);


        }

        private void btnLimpiarHeroe_Click(object sender, EventArgs e)
        {
            MostrarHeroes(new List<Heroe>()); //MostrarHeroes(albumes[0].Heroes);
        }

        private void listViewHeroe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar que se haya seleccionado un héroe
            bool seleccionado = listViewHeroe.SelectedItems.Count != 0;
            if (!seleccionado) return;

            // Hallar el codigo del heroe
            String codigo = listViewHeroe.SelectedItems[0].Text;

            // Buscar los albumes que tengan el heroe con ese codigo
            // Esto es como una busqueda, como un filtro, algo temporal
            List<Album> albumesTemp = new(); 
            foreach (Album album in albumes)
            {
                bool existe = album.Heroes.Exists(elemento => elemento.Codigo.Equals(codigo));
                if (existe) albumesTemp.Add(album);
                
                /*List<Heroe> heroesTemp = album.Heroes.FindAll(elemento => elemento.Codigo.Equals(codigo));
                if (heroesTemp.Count != 0)
                {
                    albumesTemp.Add(album);
                }*/
            }

            // Mostrar los albumes que tengan el heroe con ese codigo
            MostrarAlbumes(albumesTemp);
        }
    }
}