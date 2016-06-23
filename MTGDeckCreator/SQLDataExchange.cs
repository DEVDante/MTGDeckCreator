using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MTGDeckCreator
{
    //Klasa odpowiadająca za komunikacje z serwerem SQL
    class SQLDataExchange
    {
        private MySqlConnection connection;
        public string Server { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public SQLDataExchange()
        {
        }

        public SQLDataExchange(string server, string user, string pass, string db)
        {
            Server = server;
            Database = db;
            User = user;
            Password = pass;
            setConnection();
        }

        public void setConnection()
        {
            string connectionString;
            connectionString = "SERVER=" + Server + ";" + "DATABASE=" + Database + ";" + "UID=" + User + ";" + "PASSWORD=" + Password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "MySql error");
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "MySql error");
                return false;
            }
        }

        public List<SpellCard> GetSpellsList()
        {
            List<SpellCard> list = new List<SpellCard>();
            SpellCard card;

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM spellCards;", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string temp = Regex.Replace(dataReader["manaCost"].ToString(), @"\{(?<symbol>.)\}", "${symbol}");

                    card = new SpellCard(dataReader["name"].ToString(), dataReader["setID"].ToString(), dataReader["superTypes"].ToString().Split('|'), dataReader["types"].ToString().Split('|'), dataReader["subTypes"].ToString().Split('|'), dataReader["rarity"].ToString(), dataReader["rulesText"].ToString(), dataReader["flavorText"].ToString(), dataReader["artist"].ToString(), Int32.Parse(dataReader["setNumber"].ToString()), Int32.Parse(dataReader["multiverseid"].ToString()), dataReader["picture"].ToString(), temp.ToCharArray());

                    list.Add(card);
                }

                dataReader.Close();
                this.CloseConnection();
            }

            return list;
        }

        public List<CreatureCard> GetCreaturesList()
        {
            List<CreatureCard> list = new List<CreatureCard>();
            CreatureCard card;

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM creatureCards;", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string temp = Regex.Replace(dataReader["manaCost"].ToString(), @"\{(?<symbol>.)\}", "${symbol}");

                    card = new CreatureCard(dataReader["name"].ToString(), dataReader["setID"].ToString(), dataReader["superTypes"].ToString().Split('|'), dataReader["types"].ToString().Split('|'), dataReader["subTypes"].ToString().Split('|'), dataReader["rarity"].ToString(), dataReader["rulesText"].ToString(), dataReader["flavorText"].ToString(), dataReader["artist"].ToString(), Int32.Parse(dataReader["setNumber"].ToString()), Int32.Parse(dataReader["multiverseid"].ToString()), dataReader["picture"].ToString(), temp.ToCharArray(), Int32.Parse(dataReader["power"].ToString()), Int32.Parse(dataReader["toughness"].ToString()));

                    list.Add(card);
                }

                dataReader.Close();
                this.CloseConnection();
            }

            return list;
        }

        public List<PlaneswalkerCard> GetPlaneswalkersList()
        {
            List<PlaneswalkerCard> list = new List<PlaneswalkerCard>();
            PlaneswalkerCard card;

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM planeswalkerCards;", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string temp = Regex.Replace(dataReader["manaCost"].ToString(), @"\{(?<symbol>.)\}", "${symbol}");

                    card = new PlaneswalkerCard(dataReader["name"].ToString(), dataReader["setID"].ToString(), dataReader["superTypes"].ToString().Split('|'), dataReader["types"].ToString().Split('|'), dataReader["subTypes"].ToString().Split('|'), dataReader["rarity"].ToString(), dataReader["rulesText"].ToString(), dataReader["flavorText"].ToString(), dataReader["artist"].ToString(), Int32.Parse(dataReader["setNumber"].ToString()), Int32.Parse(dataReader["multiverseid"].ToString()), dataReader["picture"].ToString(), temp.ToCharArray(), Int32.Parse(dataReader["loyalty"].ToString()));

                    list.Add(card);
                }

                dataReader.Close();
                this.CloseConnection();
            }

            return list;
        }

        public List<SpellCard> GetCardsList()
        {
            List<CreatureCard> creatures = GetCreaturesList();
            List<PlaneswalkerCard> pwalkers = GetPlaneswalkersList();
            List<SpellCard> spells = GetSpellsList();

            List<SpellCard> cards = new List<SpellCard>();

            cards.AddRange(creatures);
            cards.AddRange(pwalkers);
            cards.AddRange(spells);

            return cards;
        }

        public SpellCard GetCardInfo(string name)
        {
            List<SpellCard> list = new List<SpellCard>();
            SpellCard card = null;

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM spellCards WHERE name = \"" + name + "\";", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string temp = Regex.Replace(dataReader["manaCost"].ToString(), @"\{(?<symbol>.)\}", "${symbol}");

                    card = new SpellCard(dataReader["name"].ToString(), dataReader["setID"].ToString(), dataReader["superTypes"].ToString().Split('|'), dataReader["types"].ToString().Split('|'), dataReader["subTypes"].ToString().Split('|'), dataReader["rarity"].ToString(), dataReader["rulesText"].ToString(), dataReader["flavorText"].ToString(), dataReader["artist"].ToString(), Int32.Parse(dataReader["setNumber"].ToString()), Int32.Parse(dataReader["multiverseid"].ToString()), dataReader["picture"].ToString(), temp.ToCharArray());

                    list.Add(card);
                }

                dataReader.Close();
                this.CloseConnection();
            }

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM planeswalkerCards WHERE name = \"" + name + "\";", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string temp = Regex.Replace(dataReader["manaCost"].ToString(), @"\{(?<symbol>.)\}", "${symbol}");

                    card = new PlaneswalkerCard(dataReader["name"].ToString(), dataReader["setID"].ToString(), dataReader["superTypes"].ToString().Split('|'), dataReader["types"].ToString().Split('|'), dataReader["subTypes"].ToString().Split('|'), dataReader["rarity"].ToString(), dataReader["rulesText"].ToString(), dataReader["flavorText"].ToString(), dataReader["artist"].ToString(), Int32.Parse(dataReader["setNumber"].ToString()), Int32.Parse(dataReader["multiverseid"].ToString()), dataReader["picture"].ToString(), temp.ToCharArray(), Int32.Parse(dataReader["loyalty"].ToString()));

                    list.Add(card);
                }

                dataReader.Close();
                this.CloseConnection();
            }

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM creatureCards WHERE name = \"" + name + "\";", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string temp = Regex.Replace(dataReader["manaCost"].ToString(), @"\{(?<symbol>.)\}", "${symbol}");

                    card = new CreatureCard(dataReader["name"].ToString(), dataReader["setID"].ToString(), dataReader["superTypes"].ToString().Split('|'), dataReader["types"].ToString().Split('|'), dataReader["subTypes"].ToString().Split('|'), dataReader["rarity"].ToString(), dataReader["rulesText"].ToString(), dataReader["flavorText"].ToString(), dataReader["artist"].ToString(), Int32.Parse(dataReader["setNumber"].ToString()), Int32.Parse(dataReader["multiverseid"].ToString()), dataReader["picture"].ToString(), temp.ToCharArray(), Int32.Parse(dataReader["power"].ToString()), Int32.Parse(dataReader["toughness"].ToString()));

                    list.Add(card);
                }

                dataReader.Close();
                this.CloseConnection();
            }

            if (list.Count > 0)
                return list[0];

            return null;
        }
    }
}
