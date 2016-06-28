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
            loginData = new LoginWindow();
            loginData.ShowDialog();
            sql = new SQLDataExchange(loginData.Server, loginData.Login, loginData.Password, "mtg");
            deck = new Deck();
            cards = sql.GetCardsList();
            deckTable.Columns.Add("Count");
            InterfaceOperations.addColumns(deckTable, new string[]{ "Name", "Set", "Types", "Rarity", "RulesText", "Flavor", "Artist","Number","MultiverseID","Picture","ManaCost"});
            InterfaceOperations.addColumns(cardsTable, new string[]{ "Name", "Set", "Types", "Rarity", "RulesText", "Flavor", "Artist","Number","MultiverseID","Picture","ManaCost"});
            cardViewPanel = CardViewPanel.CreateGraphics();
            InterfaceOperations.drawImage(cardViewPanel, currentCardImageLocation, CardViewPanel.Size.Width, CardViewPanel.Size.Height);
            //deckTable.PrimaryKey = new DataColumn[1] { deckTable.Columns["MultiverseID"] };
            //cardsTable.PrimaryKey = new DataColumn[1] { cardsTable.Columns["MultiverseID"] };

            cardLibraryView.DataSource = cardsTable;
            deckView.DataSource = deckTable;

            loadTables();

            foreach (SpellCard card in cards) addToDataTable(cardsTable, card);
        }

        private LoginWindow loginData;
        private SQLDataExchange sql;
        private Deck deck;
        private List<SpellCard> cards;
        private Graphics cardViewPanel;
        private Options optionsPanel;
        private DataTable deckTable = new DataTable();
        private DataTable cardsTable = new DataTable();

        private string currentCardImageLocation = @"C:\Users\Admin\Desktop\Projekt\MTGDeckCreator\MTGDeckCreator\cardBack.jpg";
        string[] columnNames = { "Name", "Set", "Types", "Rarity" };

        private void addToDataTable(DataTable data, SpellCard c, int? number = null)
        {
            StringBuilder type = new StringBuilder();
            type.Append(loopThrough(c.SuperTypes));
            type.Append(loopThrough(c.Types));
            string x = loopThrough(c.SubTypes);
            if ( x.Trim() != "")
            {
                type.Append(" - ");
                type.Append(loopThrough(c.SubTypes));
            }

            string manaCost = "";
            manaCost = loopThrough(c.ManaCost);
            
            if (number == null)
                data.Rows.Add(new object[] { c.Name, c.Set, type, c.Rarity, c.RulesText, c.Flavor, c.Artist, c.Number, c.MultiverseID, c.Picture, manaCost });
            else
                data.Rows.Add(new object[] { number, c.Name, c.Set, type, c.Rarity, c.RulesText, c.Flavor, c.Artist, c.Number, c.MultiverseID, c.Picture, manaCost });
        }

        private void addToDeckTable(List<Pair<int,string>> list)
        {
            foreach (Pair<int, string> pair in list)
                addToDataTable(deckTable, sql.GetCardInfo(pair.Second), pair.First);
        }

        private string loopThrough (string[] items)
        {
            string tmp = "";
            foreach (string s in items)
                tmp += s + " ";

            return tmp;
        }

        private string loopThrough(char[] items)
        {
            string tmp = "";
            foreach (char s in items)
                tmp += s + " ";

            return tmp;
        }

        private void modifyColumns(string[] s)
        {
            columnNames = s;
            loadTables();
        }

        private void columnsFillMode(bool fillModeOn)
        {
            if (fillModeOn)
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
            manaChart.Series[0].Points.Clear();
            List<int> table = deck.calculateManaCurve();
            for (int i = 0; i < table.Count(); i++)
                    manaChart.Series[0].Points.AddXY(i, table[i]);

            cardsLabel.Text = deck.CardsCount.ToString();
            landCardsLabel.Text = deck.calculateLandCount().ToString();
            creatureCardsLabel.Text = deck.calculateCreatureCount().ToString();
            otherCardsLabel.Text = deck.calculateOtherCount().ToString();
        }

        private void loadTables()
        {
            foreach ( DataGridViewColumn c in deckView.Columns)
                c.Visible = false;

            foreach (DataGridViewColumn c in cardLibraryView.Columns)
                c.Visible = false;

            foreach (string name in columnNames)
            {
                deckView.Columns[name].Visible = true;
                cardLibraryView.Columns[name].Visible = true;
            }

            deckView.Columns["Name"].Visible = true;
            deckView.Columns["Count"].Visible = true;
            cardLibraryView.Columns["Name"].Visible = true;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewAutoSizeColumnsMode m = cardLibraryView.AutoSizeColumnsMode;
            optionsPanel = new Options(columnNames, m);
            optionsPanel.columnsUpdate += modifyColumns;
            optionsPanel.columnsModeChange += columnsFillMode;
            optionsPanel.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MTGDeckCreator \n Authors: \tJakub Rup \n \tEwa Szklanny \n", "Informations");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            string ofname = openFileDialog.FileName;
            if (result == DialogResult.OK)
            {
                List<Pair<int, string>> list = new List<Pair<int, string>>();
                DCKDeckFile f = new DCKDeckFile(ofname);
                list = f.load();
                addToDeckTable(list);

                foreach (Pair<int,string> x in list)
                    for(int i =0; i < x.First; i++)
                        deck.addCard( sql.GetCardInfo(x.Second));
                
                viewStats();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog.ShowDialog();

            string sfname = saveFileDialog.FileName;
            if (result == DialogResult.OK)
            {
                DCKDeckFile f = new DCKDeckFile(sfname);
                f.save(ref deck);
                MessageBox.Show("File saved.");
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            InterfaceOperations.drawImage(cardViewPanel, currentCardImageLocation, CardViewPanel.Size.Width, CardViewPanel.Size.Height);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (cardLibraryView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in cardLibraryView.SelectedRows)
                {
                    SpellCard c = sql.GetCardInfo(row.Cells["Name"].Value.ToString());
                    DataGridViewRow rowInDeck = findRowInDeckTableByName(row.Cells["Name"].Value.ToString());

                    if ( rowInDeck == null)
                        addToDataTable(deckTable, c, 1);
                    else
                        upgradeCardNumber(rowInDeck);

                    deck.addCard(c);
                }
                viewStats();
            }
        }

        private void upgradeCardNumber(DataGridViewRow row)
        {
            string value = row.Cells["Count"].Value.ToString();
            if (int.Parse(value) < 4)
                row.Cells["Count"].Value = int.Parse(value) + 1;
            else MessageBox.Show("Can't add another " + row.Cells["Name"].Value.ToString() + " card.");
        }
        private void downgradeCardNumber(DataGridViewRow row)
        {
            string value = row.Cells["Count"].Value.ToString();
            if (int.Parse(value) > 1)
                row.Cells["Count"].Value = int.Parse(value) - 1;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (deckView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in deckView.SelectedRows)
                {
                    SpellCard c = sql.GetCardInfo(row.Cells["Name"].Value.ToString());

                    if (int.Parse(row.Cells["Count"].Value.ToString()) != 1)
                        downgradeCardNumber(row);
                    else
                        deckTable.Rows.RemoveAt(row.Index);

                    deck.deleteCard(c);
                }
                viewStats();
            }
        }

        private DataGridViewRow findRowInDeckTableByName(string name)
        {
            foreach (DataGridViewRow row in deckView.Rows)
                if (row.Cells["Name"].Value.ToString() == name)
                    return row;

            return null;
        }

        private void add4Button_Click(object sender, EventArgs e)
        {
            if (cardLibraryView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in cardLibraryView.SelectedRows)
                {
                    SpellCard c = sql.GetCardInfo(row.Cells["Name"].Value.ToString());

                    if (findRowInDeckTableByName(row.Cells["Name"].Value.ToString()) == null)
                    {
                        addToDataTable(deckTable, c, 4);

                        for (int i = 0; i < 4; i++)
                            deck.addCard(c);
                    }
                    else MessageBox.Show("Can't add 4 more " + c.Name + " cards.");                
                }
                viewStats();
            }
        }

        private void delete4Button_Click(object sender, EventArgs e)
        {
            if (deckView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in deckView.SelectedRows)
                {
                    SpellCard c = sql.GetCardInfo(row.Cells["Name"].Value.ToString());
                    deckTable.Rows.RemoveAt(row.Index);

                    for (int i = 0; i < 4; i++)
                        deck.deleteCard(c);
                }
                viewStats();
            }
        }

        private void deckView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string imagename = deckView.Rows[e.RowIndex].Cells["Picture"].Value.ToString();
            string filename = @"C:\Users\Admin\Desktop\Projekt\MTGDeckCreator\MTGDeckCreator\" + imagename;
            

            if (File.Exists(filename))
            {
                currentCardImageLocation = filename;
                InterfaceOperations.drawImage(cardViewPanel, currentCardImageLocation, CardViewPanel.Size.Width, CardViewPanel.Size.Height);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.loginData.ShowDialog();
        }
    }
}