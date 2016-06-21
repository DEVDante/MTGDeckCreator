using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data;
using System.Threading.Tasks;
using System.IO;

namespace MTGDeckCreator
{
    //Klasa odpowiadająca za funkcjonalność interfejsu
    static class InterfaceOperations
    {
        private static DataTable destinationTable;
        private static DataTable sourceTable;

        public static void addRow(DataRow row, ref DataTable destinationTable)
        {
            destinationTable.ImportRow(row);
        }

        public static void drawImage(Graphics canva, string path, int w, int h )
        {
            //if (File.Exists(path))
                //    SQLDataExchange.GetImage();

            Image i = Bitmap.FromFile(path);
            i = new Bitmap(i, new Size(w, h));
            canva.DrawImage(i, new Point(0, 0));
        }
        //metoda, która sprawdza czy w pliku jest obrazek o takim ID jak kliknięta karta, a jak nie, to wywołuje funkcje (np. getImage) z klasy SQLDataExchange
    }
}
