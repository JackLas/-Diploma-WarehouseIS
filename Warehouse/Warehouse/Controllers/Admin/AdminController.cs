namespace Warehouse.Controllers.Admin
{
    class AdminController : BaseController
    {
        private IAdminControllerListener m_listener;

        public AdminController(IAdminControllerListener listener) : base()
        {
            m_listener = listener;
        }
    }
}
