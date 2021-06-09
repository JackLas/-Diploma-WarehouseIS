using System.Windows.Forms;

namespace Warehouse.Views.Topology
{
    public class TopologyBuilder
    {
        private const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public void rebuild(Common.Types.Topology input, DataGridView output)
        {
            output.CurrentCell = null;

            output.RowCount = input.getSizeY();
            output.ColumnCount = input.getSizeX();

            for (int y = 0; y < input.getSizeY(); y++)
            {
                for (int x = 0; x < input.getSizeX(); x++)
                {
                    DataGridViewCell cell = new DataGridViewTextBoxCell();
                    cell.Value = normalizeToAlphabet(x) + y.ToString(); // dbg
                    output[x, y] = cell;
                    output.Columns[x].HeaderText = normalizeToAlphabet(x);
                }
                output.Rows[y].HeaderCell.Value = y.ToString();
            }
        }

        private string normalizeToAlphabet(int value)
        {
            if (value < 0) return "";

            if (value > alphabet.Length - 1)
            {
                return normalizeToAlphabet((value / alphabet.Length) - 1) + alphabet[value % alphabet.Length].ToString();
            }
            else
            {
                return alphabet[value].ToString();
            }
        }
    }
}
