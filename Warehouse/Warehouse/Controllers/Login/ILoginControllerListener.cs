using Common.Types;

namespace Warehouse.Controllers.Login
{
    interface ILoginControllerListener
    {
        public abstract void onLoginSuccess(Account account);
        public abstract void onLoginFailed();
        public abstract void onPasswordExpired();
        public abstract void onAccountInactive();

        public abstract void onUserNotFound();
    }
}
