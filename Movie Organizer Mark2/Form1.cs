using System;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Data.SQLite;
using TMDbLib.Client;
using TMDbLib.Objects.Search;
using System.Text;
using System.Diagnostics;
using System.Drawing;

namespace Movie_Organizer_Mark2
{
    public partial class Form1 : Form
    {
        private List<Movie> myMovies = new List<Movie>();

        // TMDBclient license key.
        TMDbClient client = new TMDbClient("046e071c470806b9c44d71f1695e769e");
        //Calling for Movie.cs.
        Movie callMovie = new Movie();
        //Calling for the MovieFiter.
        MovieFilter movieFilter = new MovieFilter();
        string baseFolder;
        //Calling the MovieFiles class.
        MovieFiles cacheFiles;
        //Calling the NFO write and read classes.
        NFOFileWriter fileWriter;
        NFOFileReader fileReader;
        MovieFolder movieFolder;

        public Form1()
        {
            InitializeComponent();
            //firstRun();
            checkFolderexistence();
            baseFolder = Properties.Settings.Default.defaultFolder;
            cacheFiles = new MovieFiles(baseFolder);
            fileReader = new NFOFileReader(cacheFiles);
            fileWriter = new NFOFileWriter(cacheFiles);
            movieFolder = new MovieFolder("D:/Movies");
        }

        //Closing the application.
        private void closeAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Select Movies and series directory and place it into the ListBox.
        private void openFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var dlg = new FolderBrowserDialog();
            //Check if the user selected a directory and pressed the OK button.
            if (dlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var folder = dlg.SelectedPath;
            var directories = Directory.GetDirectories(folder);
            ListBox1.Items.Clear();
            //Foreach through the gotton items and add them into the ListBox.
            foreach (var dir in directories)
            {
                Movie m = new Movie();
                m.originalFolder = dir;
                m.displayName = movieFilter.extractMovieName(extractLastPart(dir));
                ListBox1.Items.Add(m);
            } 
        }
        //On startup select the default movies and series directory and remember it.
        private void firstRun()
        {

            if (!string.IsNullOrWhiteSpace(baseFolder))
            {
                foreach (var dir in baseFolder.Split(';'))
                {
                    Movie m = new Movie();
                    m.originalFolder = dir;
                    m.displayName = movieFilter.extractMovieName(extractLastPart(dir));
                    myMovies.Add(m);
                }
                ListBox1.Items.AddRange(myMovies.ToArray());
            }
            else
            {
                startupCheck();
            }
        }

        private void startupCheck()
        {
            var dlg = new FolderBrowserDialog();
            dlg.ShowDialog();
            var folder = dlg.SelectedPath;
            var directories = Directory.GetDirectories(folder);
            Properties.Settings.Default.defaultFolder = String.Join(";", directories);
            Properties.Settings.Default.Save();

            foreach (var dir in directories)
            {
                Movie m = new Movie();
                m.originalFolder = dir;
                m.displayName = movieFilter.extractMovieName(extractLastPart(dir));
                myMovies.Add(m);
            }
            ListBox1.Items.AddRange(myMovies.ToArray());
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            firstRun();
        }

        //information about selected movie or series.
        private void movieInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           chooseMovie();
        }

        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            chooseMovie();
        }

        private void chooseMovie()
        {
            Movie selectedItem = (Movie)ListBox1.SelectedItem;
            var dirPath = selectedItem.originalFolder;
            var results = client.SearchMovie(selectedItem.displayName).Results;

            var possibles = new List<Movie>();
            foreach (SearchMovie mov in results)
            {
                Movie m = new Movie();
                m.movieObject = mov;
                m.displayName = mov.Title;
                m.movieId = mov.Id;

                possibles.Add(m);
            }

            // send all movies to the dialog listbox
            SelectMovie dialog;
            dialog = new SelectMovie(possibles.ToArray());
            DialogResult res = dialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                // ask the dialog which item was selected
                Movie selectedMovieObject = dialog.GetSelectedItem();

                if (selectedMovieObject == null)
                {
                    MessageBox.Show("Please select a movie first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ((Movie)ListBox1.SelectedItem).displayName = selectedMovieObject.displayName;
                    searchMovieInfo((Movie)ListBox1.SelectedItem);
                }
            }
        }
        private string searchMovieInfo(Movie movie)
        {
            var dirPath = (movie.originalFolder);
            var getMovie = client.GetMovie(movie.movieId, movie.displayName);
            var movieArray = fileReader.readFromFile(dirPath);
            bool matchFound = false;
            string[] match = null;

            foreach (var m in movieArray)
            {
                if (movie.displayName == m[0])
                {
                    matchFound = true;
                    match = m;
                    break;
                }
            }

            if (matchFound)
            {
                MessageBox.Show(string.Format("The movie {0} has been published on {1} and has an average rating of {2}, and the popularity is {3}",
                    match[0],
                    match[1],
                    match[2],
                    match[3]));
            }
            else
            {
                var aboutMovie = string.Format("The movie {0} has been published on {1} and has an average rating of {2}, and the popularity is {3}",
                    getMovie.Title,
                    getMovie.ReleaseDate,
                    getMovie.VoteAverage,
                    getMovie.Popularity);
                MessageBox.Show(aboutMovie);
                var collecMoviedata = string.Format("{0},{1},{2},{3}", getMovie.Title, getMovie.ReleaseDate, getMovie.VoteAverage, getMovie.Popularity);
                fileWriter.writeToFile(collecMoviedata, dirPath.ToString());

            }
                return null;
        }

        private string extractLastPart(string fullpath)
        { 
            return fullpath.Substring(fullpath.LastIndexOf('\\') + 1);
        }

        private void ListBox1_MouseMove(object sender, MouseEventArgs e)
        {
            ListBox1.SelectedIndex = ListBox1.IndexFromPoint(e.X, e.Y);
        }

        private void playMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Warning. Some of these movies may not be compatible with your default media player.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Process.Start(movieFolder.GetFolderName(ListBox1.SelectedItem.ToString()));
        }

        private void checkFolderexistence()
        {
            if (baseFolder == "")
            {
                firstRun();
            }
        }

        private void personalizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new Settings();
            Form.Show();
        }
    }
}
