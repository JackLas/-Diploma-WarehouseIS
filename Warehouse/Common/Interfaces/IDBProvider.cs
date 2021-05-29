namespace Common.Interfaces
{
    public interface IDBProvider
    {
        public abstract void open();
        public abstract void close();

        public abstract Types.Account getUserAccountData(string username);

        public abstract Types.Account getUserAccountData(int userID);

        public abstract void updatePassword(int userID, string password);
    }
}
