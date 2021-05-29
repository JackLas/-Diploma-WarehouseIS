using System.Windows.Forms;
using Warehouse.Controllers.Login;

using System.Configuration;

namespace Warehouse.Views.Login
{
    public partial class LoginForm : Form, ILoginControllerListener
    {
        private LoginController m_ctrl;
        public LoginForm()
        {
            InitializeComponent();
            m_ctrl = new LoginController(this);
            //label1.Text = ConfigurationManager.AppSettings.Get("test");
        }

        private void btn_login_Click(object sender, System.EventArgs e)
        {
            m_ctrl.login(tb_login.Text, tb_password.Text);
        }

        public void onLoginSuccess()
        {
            MessageBox.Show("Success");
        }
        public void onLoginFailed()
        {

        }
        public void onPasswordExpired()
        {

        }
        public void onAccountInactive()
        {

        }
    }
}
