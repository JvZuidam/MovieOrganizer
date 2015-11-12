using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Movie_Organizer_Mark2
{
    public class NFOFileReader
    {
        Movie callMovie = new Movie();
        private MovieFiles cacheFiles;
        //calling the MovieFiles class
        public NFOFileReader(MovieFiles mf)
        {
            cacheFiles = mf;
        }

        public List<string> findFromFile(string searchQuery, string path)
        {

            string[] x = File.ReadAllLines(path + "\\MovieInformation.txt");
            return x.ToList().FindAll(y => y.Contains(searchQuery));
        }

        public string[][] readFromFile(string path)
        {
            string[] data = File.ReadAllLines(path + "\\MovieInformation.txt");
            var a = new string[data.Count()][];
            int i = 0;
            foreach (var line in data)
            {
                string source = line;
                string[] stringSeparators = new string[] { "," };
                string[] result;

                
                result = source.Split(stringSeparators, StringSplitOptions.None);
                a[i++] = result;
            }
            return a;
        }
    }
}
