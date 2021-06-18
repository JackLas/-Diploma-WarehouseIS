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
    public interface ILoginControllerListener
    {
        public abstract void onLoginSuccess(Account account);
        public abstract void onLoginFailed();
        public abstract void onPasswordExpired(int usedID);
        public abstract void onAccountInactive();
        public abstract void onUserNotFound();
        public abstract void onPasswordUpdateSuccess();
        public abstract void onPasswordUpdateFailed();
    }
}
