using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Organizer_Mark2
{

    class MovieFolder
    {
        MovieFilter movieFilter = new MovieFilter();

        private string path;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }


        public MovieFolder(string path)
        {
            Path = path;
        }

        /// <summary>
        /// Gets the folder name based on the title of a movie.
        /// </summary>
        /// <param name="movieName">name of the movie</param>
        public string GetFolderName(string movieName)
        {
          var directories =  Directory.GetDirectories(System.IO.Path.GetFullPath(Path));
            return (from directory in directories let directoryName = movieFilter.extractMovieName(new DirectoryInfo(directory).Name) where directoryName.Equals(movieName) select isMovieInFolder(directory)).FirstOrDefault();
        }

        /// <summary>
        /// Checks if there is a movie in the folder
        /// </summary>
        /// <param name="folder">name of the folder to check</param>
        private string isMovieInFolder(string folder)
        {
                var ext = new List<string> { ".mkv", ".mp4", ".avi", ".wma", ".mov" };
                var myFiles = Directory.GetFiles(folder, "*.*", SearchOption.TopDirectoryOnly)
                     .Where(s => ext.Any(e => s.EndsWith(e)));
                return myFiles.OrderBy(p => new FileInfo(p).Length).First();
        }


    }
}
