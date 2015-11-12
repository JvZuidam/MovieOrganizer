using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Organizer_Mark2
{
    public partial class SelectMovie : Form
    {
        public SelectMovie(Movie[] movies)
        {
            InitializeComponent();

            LstBoxSelectedMovie.Items.AddRange(movies);

        }

        public Movie GetSelectedItem()
        {
            return (Movie)LstBoxSelectedMovie.SelectedItem;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LstBoxSelectedMovie_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void LstBoxSelectedMovie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
