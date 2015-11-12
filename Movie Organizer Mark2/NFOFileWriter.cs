using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Movie_Organizer_Mark2
{
    public class NFOFileWriter
    {
        Movie callMovie = new Movie();
        private MovieFiles cacheFiles;
        //calling the MovieFiles class
        public NFOFileWriter(MovieFiles mf)
        {
            cacheFiles = mf;
        }

        public void  writeToFile(string text, string path)
        {
            using (StreamWriter sw = File.AppendText(path + "\\MovieInformation.txt"))
            {
                sw.WriteLine(text);
            }
        }
    }
}
