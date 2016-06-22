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
            deckTable = InterfaceOperations.createTable(columnNames);
            cardsTable = InterfaceOperations.createTable(columnNames);
            cardLibraryView.DataSource = cardsTable;
            deckView.DataSource = deckTable;
            cardViewPanel = CardViewPanel.CreateGraphics();
            
            for (int i = 1; i<3; i++)
            {
                cardsTable.Rows.Add(i.ToString(), "Zestaw"+i, "Typ"+i);
            }
        }

        private Graphics cardViewPanel;
        private Options optionsPanel;
        private DataTable deckTable = new DataTable();
        private DataTable cardsTable = new DataTable();
        private string currentCardImageLocation = "";
        string[] columnNames = { "Name", "Set", "SuperTypes", "Types", "SubTypes", "Rarity" }; //,"RulesText","Flavor","Artist","Numer","MultiverseID","ManaCost"};
        

        private void modifyColumns(string[] s)
        {
            columnNames = s;
            loadTables();
        }

        private void loadTables()
        {
            //wyświetlanie tylko tych kolumn z datasource, których nazwy znajdują się w columnNames
        }


        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            optionsPanel = new Options(this);
            optionsPanel.update += modifyColumns;
            optionsPanel.Show();
        }
        
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SQLDataExchange sql = new SQLDataExchange("localhost", "root", "toor", "mtg"); --testy podpięte do Info be jestem leniwy
            //List<SpellCard> list = sql.GetCardsList();
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

        private void addButton_Click(object sender, EventArgs e)
        {
            if (cardLibraryView.SelectedRows.Count > 0)
            foreach(DataGridViewRow row in cardLibraryView.SelectedRows)
             InterfaceOperations.addRow(((DataRowView)cardLibraryView.SelectedRows[row.Index].DataBoundItem).Row, ref deckTable);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if(currentCardImageLocation != "")
                InterfaceOperations.drawImage(cardViewPanel, currentCardImageLocation, CardViewPanel.Size.Width, CardViewPanel.Size.Height);
        }

        //private IEnumerator<string> returnCell( DataGridViewRow r)
        //{
        //    for (int i = 0; i < r.Cells.Count; i++)
        //        yield return r.Cells[i].Value.ToString();
        //    yield break;
        //}

        //private bool checkIfContains(string number)
        //{
        //    deckTable.Rows.Contains(number);
        //    return false;
        //}

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

        private void ssSet(object sender, EventArgs e)
        {

        }

        private void deckView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
                string imagename = deckView.Rows[e.RowIndex].Cells[0].Value.ToString() + ".jpg";
                currentCardImageLocation = @"C:\Users\Admin\Desktop\Projekt\MTGDeckCreator\MTGDeckCreator\" + imagename;
                InterfaceOperations.drawImage(cardViewPanel, currentCardImageLocation,CardViewPanel.Size.Width, CardViewPanel.Size.Height);
        }

        private void cardLibraryView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n' && cardLibraryView.SelectedRows.Count > 0)
                addButton_Click(sender, e);
        }
    }
}
