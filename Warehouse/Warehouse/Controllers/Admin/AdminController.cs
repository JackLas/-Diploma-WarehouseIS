namespace Warehouse.Controllers.Admin
{
    class AdminController : BaseController
    {
        private IAdminControllerListener m_listener;

        public AdminController(IAdminControllerListener listener) : base()
        {
            m_listener = listener;
        }

        public void addEmployee(string name, int post, string address, string phone, string login)
        {
            if(m_db.isUsernameAlreadyExists(login))
            {
                m_listener.onLoginAlreadyExists();
                return;
            }

            m_db.addUser(login, post);
            Common.Types.Account acc = m_db.getUserAccountData(login);

            m_db.addEmployee(name, phone, address, acc.id);

            m_listener.onEmployeeAdded();
        }

        public void refreshEmployeeList(string search = "")
        {
            var list = m_db.getEmployees(search);
            m_listener.onEmployeeListUpdate(list);
        }

        public Common.Types.Employee getEmployeeByID(int id)
        {
            return m_db.getEmployeeByID(id);
        }
    }
}
