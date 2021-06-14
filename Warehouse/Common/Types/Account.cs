namespace Common.Types
{
    public class Account
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password_hash { get; set; }
        public bool isActive { get; set; }
        public int accessLevel { get; set; }
    }
}
