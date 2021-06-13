using System.Windows.Forms;
using System.Drawing;

namespace Warehouse.Views.Topology
{
    public class TopologyBuilder
    {
        private static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const int cellSize = 50;
        private DataGridViewCellStyle m_shelfCell;

        public TopologyBuilder()
        {
            m_shelfCell = new DataGridViewCellStyle();
            m_shelfCell.Alignment = DataGridViewContentAlignment.MiddleCenter;
            m_shelfCell.BackColor = Color.Blue;
            m_shelfCell.ForeColor = Color.White;
        }

        public void setDefaultSettings(DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.MultiSelect = false;
            grid.ReadOnly = true;
            grid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            grid.SelectionMode = DataGridViewSelectionMode.CellSelect;

            grid.EnableHeadersVisualStyles = false;

            grid.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            grid.DefaultCellStyle.SelectionForeColor = Color.Transparent;

            var rowDefStyle = new DataGridViewCellStyle();
            rowDefStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            rowDefStyle.BackColor = Color.LightGoldenrodYellow;
            grid.RowHeadersDefaultCellStyle = rowDefStyle;

            var colDefStyle = new DataGridViewCellStyle();
            colDefStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colDefStyle.BackColor = Color.LightGoldenrodYellow;
            grid.ColumnHeadersDefaultCellStyle = colDefStyle;
        }

        public void rebuild(Common.Types.Topology input, DataGridView output)
        {
            output.RowCount = input.getSizeY();
            output.ColumnCount = input.getSizeX();

            for (int y = 0; y < input.getSizeY(); y++)
            {
                for (int x = 0; x < input.getSizeX(); x++)
                {
                    DataGridViewCell cell = new DataGridViewTextBoxCell();
                    cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //cell.Value = normalizeToAlphabet(x) + y.ToString(); // dbg
                    output[x, y] = cell;

                    if (y == 0)
                    {
                        output.Columns[x].HeaderText = normalizeToAlphabet(x);
                        output.Columns[x].SortMode = DataGridViewColumnSortMode.NotSortable;
                        output.Columns[x].Width = cellSize;
                        output.Columns[x].MinimumWidth = cellSize;
                    }
                }
                output.Rows[y].HeaderCell.Value = y.ToString();
                output.Rows[y].Height = cellSize;
                output.Rows[y].MinimumHeight = cellSize;
            }

            foreach (var shelf in input.getShelfList())
            {
                var cell = output[shelf.x, shelf.y];
                cell.Style = m_shelfCell.Clone();
                cell.Value = shelf.shelfID.ToString();
            }

            output.ClearSelection();
        }

        private static string normalizeToAlphabet(int value)
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

        private static int normilizeToNumber(string value)
        {
            int num = 0;

            for (int i = value.Length-1; i >= 0; i--)
            {
                char ch = value[i];
                int chIdx = alphabet.IndexOf(ch);
                if (i == value.Length-1)
                {
                    num += chIdx;
                }
                else
                {
                    num += ((value.Length - i - 1) * alphabet.Length * (chIdx + 1));
                }
            }

            return num;
        }

        static public Common.Types.Vec convertPosition(string pos)
        {
            Common.Types.Vec result = new Common.Types.Vec();

            int digitSubstringBegin = -1;
            for (int i = 0; i < pos.Length; i++)
            {
                if (char.IsDigit(pos[i]))
                {
                    digitSubstringBegin = i;
                    break;
                }
            }

            if (digitSubstringBegin > -1)
            {
                string strX = pos.Substring(0, digitSubstringBegin);
                string strY = pos.Substring(digitSubstringBegin);

                result.x = normilizeToNumber(strX);
                int tmpY = -1;
                int.TryParse(strY, out tmpY);
                result.y = tmpY;
            }

            return result;
        }

        static public string convertPosition(Common.Types.Vec pos)
        {
            return normalizeToAlphabet(pos.x) + pos.y.ToString();
        }
    }
}
