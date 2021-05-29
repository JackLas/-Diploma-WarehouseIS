namespace Warehouse.Controllers.Login
{
    class LoginController
    {
        private ILoginControllerListener m_listener;
        public LoginController(ILoginControllerListener listener)
        {
            m_listener = listener;
        }

        public void login(string username, string password)
        {
            m_listener.onLoginSuccess();
        }
    }
}
