namespace Common.Types
{
    public class Identificator
    {
        public int ID { get; set; }
        public string name { get; set; }

        public Identificator()
        {
            ID = -1;
        }

        public override string ToString()
        {
            return ID.ToString() + (name.Length > 0 ? ": " + name : "");
        }
    }
}
