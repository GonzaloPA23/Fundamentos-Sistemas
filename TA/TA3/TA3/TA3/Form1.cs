using System.Runtime.CompilerServices;

namespace TA3
{
    public partial class Form1 : Form
    {
        List<MovieModel> movies = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowMovies(List<MovieModel> list)
        {
            listViewDatabaseMovie.Items.Clear();
            int totalRecords = 0;

            foreach (MovieModel movie in list)
            {
                ListViewItem row = new ListViewItem(movie.Uuid);
                row.SubItems.Add(movie.Name);
                row.SubItems.Add(movie.Genre);
                row.SubItems.Add(movie.Country);
                row.SubItems.Add(movie.QuantityCharacters.ToString());
                row.SubItems.Add(movie.Duration.ToString());
                listViewDatabaseMovie.Items.Add(row);
                totalRecords += movie.QuantityCharacters;
            }
            // Show the total of record in the label and 
            labelTotalCharacters.Text = totalRecords.ToString();
            labelTotalRecords.Text = movies.Count.ToString();           // ----> Method Count()
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // Validation of the fields
            if (textBoxUuid.Text == "" || textBoxName.Text == "" || textBoxGenre.Text == "" ||
                textBoxCountry.Text == "" || nudQuantityCharacters.Text == "" || textBoxDuration.Text == "")
            {
                MessageBox.Show("Por favor, rellena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Verification of the UUID repeated
            bool exist = movies.Exists(element => element.Uuid.Equals(textBoxUuid.Text));
            if (exist)
            {
                MessageBox.Show("El código ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Create the object
            MovieModel movie = new()
            {
                Uuid = textBoxUuid.Text,
                Name = textBoxName.Text,
                Genre = textBoxGenre.Text,
                Country = textBoxCountry.Text,
                Duration = int.Parse(textBoxDuration.Text),
                QuantityCharacters = (int)nudQuantityCharacters.Value
            };
            // Add Method to the list of movies
            movies.Add(movie);                                         // ----> Method Add()        
            // Show the list of movies
            ShowMovies(movies);
            // Clean the felds;
            textBoxUuid.Clear();
            textBoxName.Clear();
            textBoxGenre.Clear();
            textBoxCountry.Clear();
            textBoxDuration.Clear();
            nudQuantityCharacters.Value = 2;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Validation
            if (listViewDatabaseMovie.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Get the UUID
            String uuid = listViewDatabaseMovie.SelectedItems[0].Text;
            // RemoveAll Method to the UUID selected
            movies.RemoveAll(element => element.Uuid.Equals(uuid));   // ----> Method RemoveAll()
            // Show the list of movies
            ShowMovies(movies);
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            movies.Clear();                                             // ----> Method Clear()
            ShowMovies(movies);
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            movies.Sort((x, y) =>
            {
                if (x.Duration < y.Duration) return 1;
                else return -1;
            });          // ----> Method Sort()
            ShowMovies(movies);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ShowMovies(movies);
            labelTotalSearches.Text = "0";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            // Validation 
            if (textBoxSearchName.Text == "")
            {
                MessageBox.Show("Por favor, rellena el campo nombre para la búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Search the movie
            List<MovieModel> movieTemp = movies.FindAll(element => element.Name.Contains(textBoxSearchName.Text)); // ----> Method FindAll()

            ShowMovies(movieTemp);
            labelTotalSearches.Text = movieTemp.Count.ToString();
        }

        private void buttonReplaceName_Click(object sender, EventArgs e)
        {
            if(textBoxNameForReplace.Text == "" || textBoxNameReplaced.Text == "")
            {
                MessageBox.Show("Por favor, rellena los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Replace the name
            movies.ForEach(element =>
            {
                if (element.Name.Equals(textBoxNameForReplace.Text))
                {
                    element.Name = textBoxNameReplaced.Text;
                }
            }); 
            ShowMovies(movies);
        }
    }
}