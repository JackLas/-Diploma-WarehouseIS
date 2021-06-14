namespace Common.Types
{
    public class OrderItem
    {
        public OrderItem()
        {
            id = -1;
            pos = new Vec();
            room_id = -1;
            item_id = -1;
            name = string.Empty;
            level = -1;
        }
        public int id { get; set; }
        public int room_id { get; set; }
        public int item_id { get; set; }
        public string name { get; set; }
        public Vec pos { get; set; }
        public int level { get; set; }
    }
}
