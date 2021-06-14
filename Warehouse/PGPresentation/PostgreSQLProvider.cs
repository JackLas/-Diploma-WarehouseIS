using Common.Interfaces;
using Common.Types;
using Npgsql;
using System;
using System.Collections.Generic;

namespace PGPresentation
{
    public class PostgreSQLProvider : IDBProvider, System.IDisposable
    {
        private NpgsqlConnection m_db;
        private System.Action m_reconnectCallback;

        public PostgreSQLProvider(string ip, string port)
        {
            NpgsqlConnectionStringBuilder str = new NpgsqlConnectionStringBuilder();
            str.Host = ip;
            str.Port = int.Parse(port);
            str.Username = "postgres";
            str.Database = "Warehouse";
            str.KeepAlive = 5;
            str.Timeout = 60;
            str.ApplicationName = "DBG"; // todo: remove

            m_db = new NpgsqlConnection(str.ToString());

            m_db.StateChange += M_db_StateChange;
        }

        private void M_db_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            if (e.CurrentState == System.Data.ConnectionState.Broken)
            {
                m_db.Open();
                if (m_reconnectCallback != null)
                {
                    m_reconnectCallback();
                }
            }
        }

        public void subscribeOnReconnect(System.Action callback)
        {
            m_reconnectCallback = callback;
        }

        public void Dispose()
        {
            close();
        }

        public void open()
        {
            m_db.Open();
        }

        public void close()
        {
            m_db.Close();
            //m_db.Dispose();
        }

        public Account getUserAccountData(string username)
        {
            string sql = "SELECT * FROM account WHERE username=@username";

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("username", username);

                var data = cmd.ExecuteReader();
                Account result = null;
                if (data.Read())
                {
                    result = new Account();
                    result.id = data.GetInt32(0);
                    result.username = data.GetString(1);
                    result.password_hash = data.IsDBNull(2) ? "" : data.GetString(2);
                    result.isActive = data.GetBoolean(3);
                    result.accessLevel = data.GetInt32(4);
                }
                data.Close();
                return result;
            }
        }

        public Account getUserAccountData(int userID)
        {
            string sql = "SELECT * FROM account WHERE id=@id";

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("id", userID);

                var data = cmd.ExecuteReader();
                Account result = null;
                if (data.Read())
                {
                    result = new Account();
                    result.id = data.GetInt32(0);
                    result.username = data.GetString(1);
                    result.password_hash = data.IsDBNull(2) ? "" : data.GetString(2);
                    result.isActive = data.GetBoolean(3);
                    result.accessLevel = data.GetInt32(4);
                }
                data.Close();
                return result;
            }
        }

        public void updatePassword(int userID, string password)
        {
            string sql = "UPDATE account SET password=@pass WHERE id=@id";

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("pass", password);
                cmd.Parameters.AddWithValue("id", userID);

                cmd.ExecuteNonQuery();
            }
        }

        public bool isUsernameAlreadyExists(string username)
        {
            string sql = "SELECT COUNT(*) FROM account WHERE username=@username";

            bool result = false;
            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("username", username);

                var data = cmd.ExecuteReader();

                if (data.Read())
                {
                    result = data.GetInt32(0) > 0;
                }

                data.Close();
            }
            return result;
        }

        public void addUser(string username, int accessLevel)
        {
            string sql = "INSERT INTO account(username, is_active, access_level) VALUES(@username, @is_active, @access)";

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("is_active", true);
                cmd.Parameters.AddWithValue("access", accessLevel);

                cmd.ExecuteNonQuery();
            }
        }

        public void addEmployee(string fullname, string phone, string address, int accountID)
        {
            string sql = "INSERT INTO employees(fullname, phone, address, account_id) VALUES(@fullname, @phone, @address, @account_id)";

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("fullname", fullname);
                cmd.Parameters.AddWithValue("phone", phone);
                cmd.Parameters.AddWithValue("address", address);
                cmd.Parameters.AddWithValue("account_id", accountID);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Common.Types.Employee> getEmployees(string search)
        {
            List<Common.Types.Employee> result = new List<Common.Types.Employee>();

            string sql = "SELECT * FROM employees WHERE LOWER(fullname) LIKE LOWER(@search) OR LOWER(address) LIKE LOWER(@search)";

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("search", "%" + search + "%");

                var data = cmd.ExecuteReader();

                while (data.Read())
                {
                    Common.Types.Employee empl = new Common.Types.Employee();

                    empl.id = data.GetInt32(0);
                    empl.fullName = data.GetString(1);
                    empl.phone = data.IsDBNull(2) ? "" : data.GetString(2);
                    empl.address = data.IsDBNull(3) ? "" : data.GetString(3);
                    empl.account_id = data.GetInt32(4);

                    result.Add(empl);
                }

                data.Close();
            }

            return result;
        }

        public Common.Types.Employee getEmployeeByID(int id)
        {
            string sql = "SELECT * FROM employees WHERE id=@id";

            Common.Types.Employee empl = null;
            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("id", id);

                var data = cmd.ExecuteReader();

                if (data.Read())
                {
                    empl = new Common.Types.Employee();

                    empl.id = data.GetInt32(0);
                    empl.fullName = data.GetString(1);
                    empl.phone = data.IsDBNull(2) ? "" : data.GetString(2);
                    empl.address = data.IsDBNull(3) ? "" : data.GetString(3);
                    empl.account_id = data.GetInt32(4);
                }

                data.Close();
            }

            return empl;
        }

        public void addClient(string name, string address, string info)
        {
            string sql = "INSERT INTO clients(title, address, info) VALUES (@title, @address, @info)";

            using (var cmd = new NpgsqlCommand(sql , m_db))
            {
                cmd.Parameters.AddWithValue("title", name);
                cmd.Parameters.AddWithValue("address", address);
                cmd.Parameters.AddWithValue("info", info);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Client> getClients(string search)
        {
            List<Client> result = new List<Client>();

            string sql = "SELECT * FROM clients WHERE LOWER(title) LIKE LOWER(@search) OR address LIKE LOWER(@search)";

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("search", "%" + search + "%");

                var data = cmd.ExecuteReader();

                while(data.Read())
                {
                    Client client = new Client();

                    client.id = data.GetInt32(0);
                    client.title = data.GetString(1);
                    client.address = data.GetString(2);
                    client.info = data.IsDBNull(3) ? "" : data.GetString(3);

                    result.Add(client);
                }

                data.Close();
            }

            return result;
        }

        public Client getClientByID(int id)
        {
            Client result = null;
            string sql = "SELECT * FROM clients WHERE id=@id";

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("id", id);

                var data = cmd.ExecuteReader();

                if (data.Read())
                {
                    result = new Client();
                    result.id = data.GetInt32(0);
                    result.title = data.GetString(1);
                    result.address = data.GetString(2);
                    result.info = data.IsDBNull(3) ? "" : data.GetString(3);
                }

                data.Close();
            }

            return result;
        }

        public void addNewShelf(string name, int length, int width, int height, int weight, int levels)
        {
            string sql = "INSERT INTO shelf(name, length, width, height, weight, levels) VALUES(@name, @length, @width, @height, @weight, @levels)";

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("length", length);
                cmd.Parameters.AddWithValue("width", width);
                cmd.Parameters.AddWithValue("height", height);
                cmd.Parameters.AddWithValue("weight", weight);
                cmd.Parameters.AddWithValue("levels", levels);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Shelf> getShelfList()
        {
            List<Shelf> result = new List<Shelf>();

            string sql = "SELECT * FROM shelf";

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                var data = cmd.ExecuteReader();

                while (data.Read())
                {
                    Shelf shelf = new Shelf();

                    shelf.id = data.GetInt32(0);
                    shelf.name = data.GetString(1);
                    shelf.length = data.GetInt32(2);
                    shelf.width = data.GetInt32(3);
                    shelf.height = data.GetInt32(4);
                    shelf.weight = data.GetInt32(5);
                    shelf.levels = data.GetInt32(6);

                    result.Add(shelf);
                }

                data.Close();
            }

            return result;
        }

        public Common.Types.Shelf getShelfByID(int id)
        {
            Shelf shelf = null;

            string sql = "SELECT * FROM shelf WHERE id=@id";

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("id", id);

                var data = cmd.ExecuteReader();

                if (data.Read())
                {
                    shelf = new Shelf();

                    shelf.id = data.GetInt32(0);
                    shelf.name = data.GetString(1);
                    shelf.length = data.GetInt32(2);
                    shelf.width = data.GetInt32(3);
                    shelf.height = data.GetInt32(4);
                    shelf.weight = data.GetInt32(5);
                    shelf.levels = data.GetInt32(6);
                }

                data.Close();
            }

            return shelf;
        }

        public void saveTopology(string name, string json)
        {
            string sql = "INSERT INTO room(name, topology) VALUES (@name, @topology)";

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("topology", json);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Identificator> getRoomsIdentificatorList()
        {
            List<Identificator> result = new List<Identificator>();

            string sql = "SELECT id, name FROM room";

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                var data = cmd.ExecuteReader();

                while (data.Read())
                {
                    Identificator id = new Identificator();

                    id.ID = data.GetInt32(0);
                    id.name = data.GetString(1);

                    result.Add(id);
                }

                data.Close();
            }

            return result;
        }

        public string getTopologyByID(int id)
        {
            string result = "";
            string sql = "SELECT topology FROM room WHERE id=@id";

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("id", id);

                var data = cmd.ExecuteReader();
                if (data.Read())
                {
                    result = data.GetString(0);
                }
                data.Close();
            }

            return result;
        }

        public int getItemID(string name, int length, int width, int height, int weight)
        {
            string sql = "SELECT id FROM item WHERE name=@name AND length=@length AND width=@width AND height=@height AND weight=@weight";

            int id = -1;

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("length", length);
                cmd.Parameters.AddWithValue("width", width);
                cmd.Parameters.AddWithValue("height", height);
                cmd.Parameters.AddWithValue("weight", weight);

                var data = cmd.ExecuteReader();

                if (data.Read())
                {
                    id = data.GetInt32(0);
                }

                data.Close();
            }

            return id;
        }

        public void createItem(string name, int length, int width, int height, int weight)
        {
            string sql = "INSERT INTO item (name, length, width, height, weight) VALUES (@name, @length, @width, @height, @weight)";

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("length", length);
                cmd.Parameters.AddWithValue("width", width);
                cmd.Parameters.AddWithValue("height", height);
                cmd.Parameters.AddWithValue("weight", weight);

                cmd.ExecuteNonQuery();
            }
        }

        public int addItemToReceiveQueue(int itemID, int roomID, int shelfX, int shelfY, int shelfLvl)
        {
            string sql = "INSERT INTO queue_itemlist(item_id, room_id, shelf_pos_x, shelf_pos_y, shelf_level) VALUES (@itemID, @roomID, @shelfX, @shelfY, @shelfLvl) RETURNING id";

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("itemID", itemID);
                cmd.Parameters.AddWithValue("roomID", roomID);
                cmd.Parameters.AddWithValue("shelfX", shelfX);
                cmd.Parameters.AddWithValue("shelfY", shelfY);
                cmd.Parameters.AddWithValue("shelfLvl", shelfLvl);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        
        public void createOrder(int clientID, int roomID, List<int> items, OrderType type)
        {
            string sql = "INSERT INTO orderlist(client_id, type, room_id, items) VALUES (@clientID, @type, @roomID, @items)";

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("clientID", clientID);
                cmd.Parameters.AddWithValue("type", (int)type);
                cmd.Parameters.AddWithValue("roomID", roomID);

                var itemsParam = new NpgsqlParameter("items", NpgsqlTypes.NpgsqlDbType.Array | NpgsqlTypes.NpgsqlDbType.Integer);
                itemsParam.Value = items.ToArray();
                cmd.Parameters.Add(itemsParam);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Order> getOrders(int roomID)
        {
            List<Order> result = new List<Order>();

            string sql = "SELECT orderlist.id, clients.title, orderlist.type FROM orderlist INNER JOIN clients ON orderlist.client_id=clients.id WHERE room_id=@roomID ORDER BY orderlist.id ASC";

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("roomID", roomID);

                var data = cmd.ExecuteReader();

                while(data.Read())
                {
                    Order order = new Order();

                    order.id = data.GetInt32(0);
                    order.clientName = data.GetString(1);
                    order.type = (OrderType)data.GetInt32(2);

                    result.Add(order);
                }

                data.Close();
            }

            return result;
        }

        private OrderItem getItemByID(int itemID, string tableName)
        {
            OrderItem result = null;
            string sql = "SELECT " + tableName + ".*, item.name FROM " + tableName + " INNER JOIN item ON item_id=item.id WHERE "+tableName+".id=@itemID";

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("itemID", itemID);

                var data = cmd.ExecuteReader();

                if (data.Read())
                {
                    result = new OrderItem();
                    result.id = data.GetInt32(0);
                    result.name = data.GetString(6);
                    result.pos.x = data.GetInt32(3);
                    result.pos.y = data.GetInt32(4);
                    result.level = data.GetInt32(5);
                }

                data.Close();
            }

            return result;
        }

        public OrderDescriptionData getOrderDescription(int orderID)
        {
            OrderDescriptionData result = new OrderDescriptionData();
            int[] items = {};
            string itemsTable = "";

            string sql = "SELECT orderlist.id, orderlist.items, clients.title, clients.address, orderlist.type FROM orderlist INNER JOIN clients ON orderlist.client_id=clients.id WHERE orderlist.id=@orderID";

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("orderID", orderID);

                var data = cmd.ExecuteReader();

                if (data.Read())
                {
                    result.id = data.GetInt32(0);
                    items = data.GetFieldValue<int[]>(1);
                    result.client.title = data.GetString(2);
                    result.client.address = data.GetString(3);
                    itemsTable = ((OrderType)data.GetInt32(4) == OrderType.RECEIVE ? "queue_itemlist" : "itemlist");
                }

                data.Close();
            }

            
            foreach (int i in items)
            {
                var item = getItemByID(i, itemsTable);
                result.items.Add(item);
            }

            return result;
        }

        public void deleteOrder(int orderID)
        {
            string sql = "DELETE FROM orderlist WHERE id=@orderID";

            using (var cmd = new NpgsqlCommand(sql, m_db))
            {
                cmd.Parameters.AddWithValue("orderID", orderID);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
