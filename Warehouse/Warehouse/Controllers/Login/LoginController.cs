using Common.Interfaces;
using Common.Types;

namespace Warehouse.Controllers.Login
{
    public class LoginController
    {
        private ILoginControllerListener m_listener;
        private IDBProvider m_db;
        public LoginController(ILoginControllerListener listener)
        {
            m_listener = listener;
            m_db = Model.DBProviderFactory.createProvider();
            m_db.open();
        }

        public void login(string username, string password)
        {
            Account account = m_db.getUserAccountData(username);
            
            if (account == null)
            {
                m_listener.onUserNotFound();
            }
            else if (!account.isActive)
            {
                m_listener.onAccountInactive();
            }
            else if (account.password_hash.Length == 0)
            {
                m_listener.onPasswordExpired(account.id);
            }
            else if (account.password_hash == Common.Utils.toMD5(password))
            {
                m_listener.onLoginSuccess(account);
            }
            else
            {
                m_listener.onLoginFailed();
            }
        }

        public void updatePassword(int userID, string password)
        {
            m_db.updatePassword(userID, Common.Utils.toMD5(password));
            Account account = m_db.getUserAccountData(userID);
            if (account.password_hash == Common.Utils.toMD5(password))
            {
                m_listener.onPasswordUpdateSuccess();
            }
            else
            {
                m_listener.onPasswordUpdateFailed();
            }
        }
    }
}
