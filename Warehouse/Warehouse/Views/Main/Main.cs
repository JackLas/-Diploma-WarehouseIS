using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Warehouse.Views.Main
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            List<List<string>> data = new List<List<string>>();
            List<string> tmp = new List<string>();
            tmp.Add("a");
            tmp.Add("b");
            tmp.Add("c");
            data.Add(tmp);
            tmp = new List<string>();
            tmp.Add("d");
            tmp.Add("e");
            tmp.Add("f");
            data.Add(tmp);
            tmp = new List<string>();
            tmp.Add("g");
            tmp.Add("h");
            tmp.Add("i");
            data.Add(tmp);

            dataGridView1.CurrentCell = null;

            dataGridView1.ColumnCount = 3;
            dataGridView1.RowCount = 3;

            for (int i = 0; i < data.Count; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = i.ToString();
                for (int j = 0; j < data[i].Count; j++)
                {
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    cell.Style.BackColor = Color.FromArgb(50* i, 20*i*j, 10 * j*i);
                    cell.Value = data[j][i];
                    dataGridView1[i, j] = cell;
                }
            }

            //dataGridView1.DataSource = data;
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }
    }
}
