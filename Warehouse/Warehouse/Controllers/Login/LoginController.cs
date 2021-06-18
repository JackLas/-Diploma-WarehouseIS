/*
 * Warehouse (c) by Yevhenii Kryvyi
 *
 * Warehouse is licensed under a
 * Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International License.
 *
 * You should have received a copy of the license along with this
 * work. If not, see <http://creativecommons.org/licenses/by-nc-nd/4.0/>. 
 */

using Common.Types;

namespace Warehouse.Controllers.Login
{
    public class LoginController : BaseController
    {
        private ILoginControllerListener m_listener;
        
        public LoginController(ILoginControllerListener listener) : base()
        {
            m_listener = listener;
        }

        public void login(string username, string password)
        {
            Account account = m_db.getUserAccountData(username);

            if (m_listener == null) return;

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

            if (m_listener == null) return;

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
