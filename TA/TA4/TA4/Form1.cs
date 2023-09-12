using TA4.Models;

namespace TA4
{
    public partial class Form1 : Form
    {
        List<Movie> movies = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowMovies(List<Movie> list)
        {
            // Clean the listView
            listViewDatabaseMovies.Items.Clear();
            foreach (Movie movie in list)
            {
                ListViewItem row = new(movie.Uuid);
                row.SubItems.Add(movie.Name);
                row.SubItems.Add(movie.Country);
                row.SubItems.Add(movie.Genre);
                row.SubItems.Add(movie.DurationMinutes.ToString());
                listViewDatabaseMovies.Items.Add(row);
            }
        }

        private void ShowCharacters(List<Character> list)
        {
            // Clean the listView
            listViewDatabaseCharacters.Items.Clear();
            foreach (Character character in list)
            {
                ListViewItem row = new(character.Uuid);
                row.SubItems.Add(character.NameCharacter);
                row.SubItems.Add(character.NameActor);
                row.SubItems.Add(character.Gender);
                row.SubItems.Add(character.MinutesApparition.ToString());
                listViewDatabaseCharacters.Items.Add(row);
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            // Verifications for the fields
            if (tbCountryMovie.Text == "" || tbNameMovie.Text == "" || tbCountryMovie.Text == "" || cbGenreMovie.Text == "" ||
                nupDurationMinutesMovie.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Verification data correct for the fields
            if (!(cbGenreMovie.Text.Contains("comedia") || cbGenreMovie.Text.Contains("Comedia") || cbGenreMovie.Text.Contains("Drama") || cbGenreMovie.Text.Contains("drama")
                || cbGenreMovie.Text.Contains("Ciencia Ficcion") || cbGenreMovie.Text.Contains("ciencia ficcion") || cbGenreMovie.Text.Contains("terror") || cbGenreMovie.Text.Contains("Terror")
                || cbGenreMovie.Text.Contains("Anime") || cbGenreMovie.Text.Contains("anime")))
            {
                // Message error data incorrect
                MessageBox.Show("Debe ingresar un género correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Verification of the UUID repeated
            bool exist = movies.Exists(movie => movie.Uuid == tbUuidMovie.Text);
            if (exist) { MessageBox.Show("Ya existe una película con ese codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            // Create the object movie
            Movie movie = new()
            {
                Uuid = tbUuidMovie.Text,
                Name = tbNameMovie.Text,
                Country = tbCountryMovie.Text,
                Genre = cbGenreMovie.Text,
                DurationMinutes = int.Parse(nupDurationMinutesMovie.Text),
                Characters = new()
            };
            // Add the movie to the list
            movies.Add(movie);
            // Message success
            MessageBox.Show("Película agregada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Clean the fields
            tbUuidMovie.Text = "";
            tbNameMovie.Text = "";
            tbCountryMovie.Text = "";
            cbGenreMovie.Text = "";
            nupDurationMinutesMovie.Text = "40";
            // Show the movies in the listView
            ShowMovies(movies);
        }

        private void btnCleanMovie_Click(object sender, EventArgs e)
        {
            ShowMovies(movies);
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            // Validation of movie selected
            if (listViewDatabaseMovies.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validation of the fields
            if (tbUuidCharacter.Text == "" || tbNameCharacter.Text == "" || cbGenderCharacter.Text == ""
                || nupMinutesApparitionCharacter.Text == "" || tbNameActorCharacter.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validation of the data correct for the fields
            if (!(cbGenderCharacter.Text.Contains("masculino") || cbGenderCharacter.Text.Contains("Masculino") || cbGenderCharacter.Text.Contains("femenino") || cbGenderCharacter.Text.Contains("Femenino") ||
                cbGenderCharacter.Text.Contains("no definido") || cbGenderCharacter.Text.Contains("No Definido")))
            {
                MessageBox.Show("Debe ingresar un género correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validation of the UUID repeated
            String UuidMovie = tbUuidCharacter.Text;
            foreach (Movie movie in movies)
            {
                bool exist = movie.Characters.Exists(character => character.Uuid == UuidMovie);
                if (exist) { MessageBox.Show("Ya existe un personaje con ese codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            }
            // Search the movie selected
            String UuidMovieSelected = listViewDatabaseMovies.SelectedItems[0].Text;
            Movie? movieSelected = movies.Find(movie => movie.Uuid.Equals(UuidMovieSelected));
            if (movieSelected != null)
            {
                // Create the object character
                Character character = new()
                {
                    Uuid = tbUuidCharacter.Text,
                    NameCharacter = tbNameCharacter.Text,
                    NameActor = tbNameActorCharacter.Text,
                    Gender = cbGenderCharacter.Text,
                    MinutesApparition = int.Parse(nupMinutesApparitionCharacter.Text)
                };
                // Add the character to the movie
                movieSelected.Characters.Add(character);
                // Message success
                MessageBox.Show("Personaje agregado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clean the fields
                tbUuidCharacter.Text = "";
                tbNameCharacter.Text = "";
                tbNameActorCharacter.Text = "";
                cbGenderCharacter.Text = "";
                nupMinutesApparitionCharacter.Text = "1";
                // Show the characters in the listView
                ShowCharacters(movieSelected.Characters);
            }

        }

        private void btnCleanCharacter_Click(object sender, EventArgs e)
        {
            ShowCharacters(new List<Character>());
        }

        private void listViewDatabaseMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Validation of movie selected
            if (listViewDatabaseMovies.SelectedItems.Count == 0) return;
            // Search the movie selected
            String UuidMovieSelected = listViewDatabaseMovies.SelectedItems[0].Text;
            Movie? movieSelected = movies.Find(movie => movie.Uuid.Equals(UuidMovieSelected));
            if (movieSelected != null)
            {
                // Show the characters in the listView
                ShowCharacters(movieSelected.Characters);
            }
        }

        private void btnSearchGenreMovie_Click(object sender, EventArgs e)
        {
            // Validation of the field
            if (cbSearchGenreMovie.Text == "") { MessageBox.Show("Por favor, llene el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            // Search the movies with the genre selected
            List<Movie> moviesSearch = movies.FindAll(movie => movie.Genre.Equals(cbSearchGenreMovie.Text));
            // Show the movies in the listView
            ShowMovies(moviesSearch);
            // clean the field
            cbSearchGenreMovie.Text = "";
        }

        private void btnSearchMovieWithLeastCharactersGenderFemale_Click(object sender, EventArgs e)
        {
            // Search the movies with the minimum characters of gender Female
            List<Movie> moviesTemp = new();
            int minCharactersFemale = 100000;
            foreach (Movie movie in movies)
            {
                int quantityCharactersFemale = movie.Characters.Count(c => c.Gender.Equals("Femenino") || c.Gender.Equals("femenino"));
                if (quantityCharactersFemale < minCharactersFemale)
                {
                    minCharactersFemale = quantityCharactersFemale;
                    moviesTemp.Clear();
                    moviesTemp.Add(movie);
                }
                else if (quantityCharactersFemale == minCharactersFemale)
                {
                    moviesTemp.Add(movie);
                }
            }
            // Show the movies in the listView
            ShowMovies(moviesTemp);
        }

        private void btnSearchUuidMovieForCharacter_Click(object sender, EventArgs e)
        {
            // Verifitacion of the field
            if(tbSearchUuidMovie.Text == "") { MessageBox.Show("Por favor, llene el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            // Search the movie with the UUID
            Movie? movieSelected = movies.Find(movie => movie.Uuid.Equals(tbSearchUuidMovie.Text));
            if(movieSelected != null)
            {
                // Search the characters with more minutes of apparition > 40 
                List<Character> charactersTemp = movieSelected.Characters.FindAll(character => character.MinutesApparition > 40);
                if (charactersTemp.Count > 0)
                {
                    // Show the characters in the listView
                    ShowCharacters(charactersTemp);
                    lbCharactersMinutesApparition.Text = charactersTemp.Count.ToString();
                }
                else
                {
                    MessageBox.Show("No existen personajes con más de 40 minutos de aparición", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else
            {
                MessageBox.Show("No existe una película con ese codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Clean the field
            tbSearchUuidMovie.Text = "";          
        }
    }
}