using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse.Controllers.Login
{
    interface ILoginControllerListener
    {
        public abstract void onLoginSuccess();
        public abstract void onLoginFailed();
        public abstract void onPasswordExpired();
        public abstract void onAccountInactive();
    }
}
