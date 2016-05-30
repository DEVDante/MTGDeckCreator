using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTGDeckCreator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void opcjeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MTGDeckCreator \n Autorzy: \tJakub Rup \n \tEwa Szklanny \n","Informacje");
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
