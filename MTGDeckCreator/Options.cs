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
    public partial class Options : Form
    {
        public Options( MainWindow w )
        {
            InitializeComponent();
        }

        public event Action<string[]> columnsUpdate;
        public event Action<bool> columnsModeChange;

        private void button1_Click(object sender, EventArgs e)
        {
            string[] selectedItems = new string[checkedListBox.CheckedItems.Count];
            int i = 0;
            foreach (string s in checkedListBox.CheckedItems)
            {
                selectedItems[i] = s;
                i++;
            }

            if (columnsUpdate != null) columnsUpdate(selectedItems);
            if (columnsModeChange != null) columnsModeChange(fillCheckBox.Checked);

                this.Close();

            
        }
    }
}
