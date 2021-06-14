namespace Common.Types
{
    public class Dimensions
    {
        public Dimensions()
        {
            length = -1;
            width = -1;
            height = -1;
            weight = -1;
        }
        public int length { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
    }
}
