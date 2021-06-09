namespace Common.Types
{
    public class Topology
    {
        public Topology()
        {
            sizeX = 0;
            sizeY = 0;
        }

        private int sizeX;
        private int sizeY;

        public int getSizeX()
        {
            return sizeX;
        }

        public int getSizeY()
        {
            return sizeY;
        }

        public void increaseSizeX()
        {
            sizeX++;
            if (sizeY < 1) sizeY++;
        }

        public void increaseSizeY()
        {
            sizeY++;
            if (sizeX < 1) sizeX++;
        }

        public void decreaseSizeX()
        {
            if ((sizeX - 1) >= 1) sizeX--;
        }

        public void decreaseSizeY()
        {
            if ((sizeY - 1) >= 1) sizeY--;
        }
    }
}
