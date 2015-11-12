using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Movie_Organizer_Mark2
{
    public class MovieFiles
    {
        Movie callMovie = new Movie();

        public MovieFiles(string baseFolder)
        {
            basepath = baseFolder;
        }

        //put the folder path into var path
        public string basepath;
    }
}
