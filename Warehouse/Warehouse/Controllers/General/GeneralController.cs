namespace Warehouse.Controllers.General
{
    class GeneralController : BaseController
    {
        private IGeneralControllerListener m_listener;
        public GeneralController(IGeneralControllerListener listener) : base()
        {
            m_listener = listener;
        }
    }
}
