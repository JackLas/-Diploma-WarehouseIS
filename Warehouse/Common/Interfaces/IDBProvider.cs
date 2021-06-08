using System.Collections.Generic;

namespace Common.Interfaces
{
    public interface IDBProvider
    {
        public abstract void open();
        public abstract void close();

        public abstract Types.Account getUserAccountData(string username);

        public abstract Types.Account getUserAccountData(int userID);

        public abstract void updatePassword(int userID, string password);

        public abstract bool isUsernameAlreadyExists(string username);

        public abstract void addUser(string username, int accessLevel);

        public abstract void addEmployee(string fullname, string phone, string address, int accountID);

        public abstract List<Common.Types.Employee> getEmployees(string search);

        public abstract Common.Types.Employee getEmployeeByID(int id);

        public abstract void addClient(string name, string address, string info);

        public abstract List<Common.Types.Client> getClients(string search);

        public abstract Common.Types.Client getClientByID(int id);
    }
}
