namespace Common.Types
{
    public class Order
    {
        public int id { get; set; }

        public string clientName { get; set; }

        public OrderType type { get; set; }

        public override string ToString()
        {
            return id.ToString() + ": [" + (type == OrderType.SEND ? "Відправлення" : "Прийом") + "] - " + clientName; 
        }
    }
}
