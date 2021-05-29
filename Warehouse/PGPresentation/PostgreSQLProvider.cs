using Common.Interfaces;
using Common.Types;
using Npgsql;

namespace PGPresentation
{
    public class PostgreSQLProvider : IDBProvider, System.IDisposable
    {
        private NpgsqlConnection m_db;

        public PostgreSQLProvider(string ip, string port)
        {
            NpgsqlConnectionStringBuilder str = new NpgsqlConnectionStringBuilder();
            str.Host = ip;
            str.Port = int.Parse(port);
            str.Username = "postgres";
            str.Database = "Warehouse";

            m_db = new NpgsqlConnection(str.ToString());
        }

        public void Dispose()
        {
            m_db.Close();
        }

        public void open()
        {
            m_db.Open();
        }

        public void close()
        {
            m_db.Close();
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
    }
}
