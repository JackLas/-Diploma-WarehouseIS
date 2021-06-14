namespace Common.Types
{
    public class HighlightCell
    {
        public HighlightCell(int _x = -1, int _y = -1, int _z = -1)
        {
            x = _x;
            y = _y;
            z = _z;

        }
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
    }
}
