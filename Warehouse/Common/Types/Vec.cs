namespace Common.Types
{
    public class Vec
    {
        public Vec()
        {
            x = -1;
            y = -1;
        }

        public int x { get; set; }
        public int y { get; set; }

        public override string ToString()
        {
            return "(" + x.ToString() + "; " + y.ToString() + ")";
        }
    }
}
