/*
 * Warehouse (c) by Yevhenii Kryvyi
 *
 * Warehouse is licensed under a
 * Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International License.
 *
 * You should have received a copy of the license along with this
 * work. If not, see <http://creativecommons.org/licenses/by-nc-nd/4.0/>. 
 */

using System.Collections.Generic;

namespace Common.Types
{
    public class Topology
    {
        public int sizeX { get; set; }
        public int sizeY { get; set; }
        public List<ShelfPoint> shelfList { get; set; }

        public Topology()
        {
            sizeX = 0;
            sizeY = 0;
            shelfList = new List<ShelfPoint>();
        }

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
            removeLostShelves();
        }

        public void decreaseSizeY()
        {
            if ((sizeY - 1) >= 1) sizeY--;
            removeLostShelves();
        }

        private void removeLostShelves()
        {
            for (int i = shelfList.Count - 1; i >= 0; --i)
            {
                var shelf = shelfList[i];
                if (shelf.x >= sizeX || shelf.y >= sizeY)
                {
                    shelfList.RemoveAt(i);
                }
            }
        }

        public bool addShelf(int shelfID, int x, int y)
        {
            if (findShelf(x, y) == null)
            {
                if (x < sizeX && x >= 0 && y < sizeY && y >= 0)
                {
                    ShelfPoint shelf = new ShelfPoint();
                    shelf.x = x;
                    shelf.y = y;
                    shelf.shelfID = shelfID;
                    shelfList.Add(shelf);
                    return true;
                }
            }

            return false;
        }

        public bool removeShelf(int x, int y)
        {
            for (int i = shelfList.Count - 1; i >= 0; --i)
            {
                var shelf = shelfList[i];
                if (shelf.x == x && shelf.y == y)
                {
                    shelfList.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public ShelfPoint findShelf(int x, int y)
        {
            foreach (var shelf in shelfList)
            {
                if (shelf.x == x && shelf.y == y)
                {
                    return shelf;
                }
            }
            return null;
        }

        public List<ShelfPoint> getShelfList()
        {
            return shelfList;
        }

    }
}
