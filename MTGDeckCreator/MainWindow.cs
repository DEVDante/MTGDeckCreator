using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MTGDeckCreator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            canvas = CardViewPanel.CreateGraphics();
            deckTable = createTable();
            cardsTable = createTable();
            cardLibraryView.DataSource = cardsTable;
            deckView.DataSource = deckTable;
        }

        private Graphics canvas;
        private DataTable deckTable = new DataTable();
        private DataTable cardsTable = new DataTable();
        string[] columnsNames = { "Name", "Set", "SuperTypes", "Types", "SubTypes", "Rarity" };//,"RulesText","Flavor","Artist","Numer","MultiverseID","ManaCost"};
        

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadRow()
        {   
                       
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MTGDeckCreator \n Autorzy: \tJakub Rup \n \tEwa Szklanny \n","Informacje");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            string ofname = openFileDialog.FileName;
            if (result == DialogResult.OK)
            {
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog.ShowDialog();

            string sfname = saveFileDialog.FileName;
            if (result == DialogResult.OK)
            {
                MessageBox.Show("File saved.");
            }
        }

        private DataTable createTable()
        {
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            foreach (var name in columnsNames)
                table.Columns.Add(name);

            return table;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (cardLibraryView.SelectedRows.Count > 0)
                foreach (var row in cardLibraryView.SelectedRows)
                    deckTable.Rows.Add(row);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (deckView.SelectedRows.Count > 0)
                foreach (DataGridViewRow row in deckView.SelectedRows)
                    deckView.Rows.RemoveAt(row.Index);
        }

        private void add4Button_Click(object sender, EventArgs e)
        {

        }

        private void delete4Button_Click(object sender, EventArgs e)
        {

        }

        private void columnsSet(object sender, EventArgs e)
        {

        }

    }
}
