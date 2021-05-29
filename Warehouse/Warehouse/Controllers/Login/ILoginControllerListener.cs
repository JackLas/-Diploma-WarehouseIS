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
