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
        public Options(string[] checkedColumns, DataGridViewAutoSizeColumnsMode m)
        {
            InitializeComponent();
            foreach (string name in checkedColumns)
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if ((string)checkedListBox.Items[i] == name )
                {
                    checkedListBox.SetItemChecked(i, true);
                }
            }

            if (m == DataGridViewAutoSizeColumnsMode.Fill)
                fillCheckBox.Checked = true;

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
