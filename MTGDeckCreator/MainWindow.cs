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
            sql = new SQLDataExchange("localhost", "root", "toor", "mtg");
            deck = new Deck();
            cards = sql.GetCardsList();
            deckTable = InterfaceOperations.createTable(columnNames);
            cardsTable = InterfaceOperations.createTable(columnNames);
            cardLibraryView.DataSource = cardsTable;
            deckView.DataSource = deckTable;
            cardViewPanel = CardViewPanel.CreateGraphics();

            foreach (SpellCard card in cards) addToDataTable(cardsTable, card);
            
        }

        private SQLDataExchange sql;
        private Deck deck;
        private List<SpellCard> cards;
        private Graphics cardViewPanel;
        private Options optionsPanel;
        private DataTable deckTable = new DataTable();
        private DataTable cardsTable = new DataTable();
        private string currentCardImageLocation = "";
        string[] columnNames = { "Name", "Set", "Types", "Rarity" ,"RulesText","Flavor","Artist","Numer","MultiverseID","Picture","ManaCost"};

        private void addToDataTable(DataTable data, SpellCard c)
        {
            StringBuilder type = new StringBuilder();
            type.Append(loopThroughTypes(c.SuperTypes));
            type.Append(loopThroughTypes(c.Types));
            if(c.SubTypes != null)
            {
                type.Append(" - ");
                type.Append(loopThroughTypes(c.SubTypes));
            }

            data.Rows.Add(new object[] { c.Name, c.Set, type, c.Rarity, c.RulesText, c.Flavor, c.Artist, c.Number, c.MultiverseID, c.Picture, c.ManaCost});
        }

        private string loopThroughTypes (string[] types)
        {
            string tmp = "";
            foreach (string s in types)
                tmp += s + " ";

            return tmp;
        }

        private void modifyColumns(string[] s)
        {
            columnNames = s;
            loadTables();
        }

        private void columnsFillMode(bool b)
        {
            if (b)
            {
                cardLibraryView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                deckView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                cardLibraryView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                deckView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void viewStats()
        {
            List<int> mana = deck.calculateManaCurve();
            
            foreach (int i in mana)
                manaChart.Series[0].Points.Add(mana[i]);

            cardsLabel.Text = deck.CardsCount.ToString();
            landCardsLabel.Text = deck.calculateLandCount().ToString();
            creatureCardsLabel.Text = deck.calculateCreatureCount().ToString();
            otherCardsLabel.Text = deck.calculateOtherCount().ToString();
        }

        private void loadTables()
        {
            //wyświetlanie tylko tych kolumn z datasource, których nazwy znajdują się w columnNames
           // cardLibraryView.DataSource = cardsTable.Columns.
        }



        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            optionsPanel = new Options(this);
            optionsPanel.columnsUpdate += modifyColumns;
            optionsPanel.columnsModeChange += columnsFillMode;
            optionsPanel.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLDataExchange sql = new SQLDataExchange("localhost", "root", "toor", "mtg");
            List<SpellCard> list = sql.GetCardsList();
            MessageBox.Show("MTGDeckCreator \n Authors: \tJakub Rup \n \tEwa Szklanny \n", "Informations");
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

        private SpellCard findCardByID( int id )
        {
            foreach (SpellCard card in cards)
                if ((int)card.MultiverseID == id) return card;

            return null;
        }

        private string getValueFromCell(DataGridViewRow row, string heder = "Name")
        {
            foreach (DataGridViewCell cell in row.Cells)
                if (cell.OwningColumn.HeaderText == heder) return cell.Value.ToString();
            return "";
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            if (cardLibraryView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in cardLibraryView.SelectedRows)
                {
                    SpellCard c = sql.GetCardInfo(getValueFromCell(row));

                    addToDataTable(deckTable, c);
                    deck.addCard(c);
                }
                viewStats();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
           // if (currentCardImageLocation != "")
              //  InterfaceOperations.drawImage(cardViewPanel, currentCardImageLocation, CardViewPanel.Size.Width, CardViewPanel.Size.Height);
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

        private void deckView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string imagename = deckView.Rows[e.RowIndex].Cells["Picture"].Value.ToString();
            currentCardImageLocation = @"C:\Users\Admin\Desktop\Projekt\MTGDeckCreator\MTGDeckCreator\" + imagename;

            if (File.Exists(currentCardImageLocation)) 
                InterfaceOperations.drawImage(cardViewPanel, currentCardImageLocation, CardViewPanel.Size.Width, CardViewPanel.Size.Height);
        }

        private void cardLibraryView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n' && cardLibraryView.SelectedRows.Count > 0)
                addButton_Click(sender, e);
        }
        
    }
}
