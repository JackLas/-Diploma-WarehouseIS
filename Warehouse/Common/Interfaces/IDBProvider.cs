using System;
using System.Collections.Generic;

namespace Common.Interfaces
{
    public interface IDBProvider
    {
        public abstract void open();

        public abstract void close();

        public void subscribeOnReconnect(Action callback);

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

        public abstract void addNewShelf(string name, int length, int width, int height, int weight, int levels);
        
        public abstract List<Common.Types.Shelf> getShelfList();

        public abstract Common.Types.Shelf getShelfByID(int id);

        public abstract void saveTopology(string name, string json);
    }
}
