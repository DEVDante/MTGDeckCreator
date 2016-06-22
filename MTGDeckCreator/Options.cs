﻿using System;
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

        public event Action<string[]> update;

        private void button1_Click(object sender, EventArgs e)
        {
            string[] selectedItems = new string[checkedListBox.CheckedItems.Count];
            int i = 0;
            foreach (string s in checkedListBox.CheckedItems)
            {
                selectedItems[i] = s;
                i++;
            }

            if (update != null) update(selectedItems);

            this.Close();
        }
    }
}
