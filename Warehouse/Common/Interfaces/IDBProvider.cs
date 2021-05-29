namespace Common.Interfaces
{
    public interface IDBProvider
    {
        public abstract void open();
        public abstract void close();

        public abstract Types.Account getUserAccountData(string username);
    }
}
