using System.Collections.Generic;

namespace Common.Types
{
    public class OrderDescriptionData
    {
        public OrderDescriptionData()
        {
            client = new Client();
            items = new List<OrderItem>();
        }
        public int id { get; set; }
        public Client client { get; set; }
        public List<OrderItem> items { get; set; }
    }
}
