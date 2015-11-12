using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDbLib.Objects.Search;

namespace Movie_Organizer_Mark2
{
    public class Movie
    {
        /// <summary>
        /// Full pathname to the movie folder (e.g. C:\Movies\A Good Year (1999)  )
        /// </summary>
        public string originalFolder { get; set; }

        /// <summary>
        /// Human readable, configurable name. Can be changed without breaking reference to external sources. e.g. "A Good Year (romantic)".
        /// </summary>
        public string displayName { get; set; }

        public string movieTitle { get; set; }
        public int movieId { get; set; }

        public SearchMovie movieObject { get; set; }

        // this is for the listbox, so it can display all objects as a list 
        public override string ToString()
        {
            return displayName;
        }
    }
}
