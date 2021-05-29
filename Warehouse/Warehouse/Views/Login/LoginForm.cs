using System.Windows.Forms;
using Warehouse.Controllers.Login;
using Common.Types;

namespace Warehouse.Views.Login
{
    public partial class LoginForm : Form, ILoginControllerListener
    {
        private LoginController m_ctrl;
        public LoginForm()
        {
            InitializeComponent();
            m_ctrl = new LoginController(this);
        }

        private void btn_login_Click(object sender, System.EventArgs e)
        {
            m_ctrl.login(tb_login.Text, tb_password.Text);
        }

        public void onLoginSuccess(Account account)
        {
            // open general form
        }

        public void onPasswordExpired()
        {
            //MessageBox.Show("Expired");
        }

        public void onLoginFailed()
        {
            MessageBox.Show("Невірно введено логін або пароль");
        }

        public void onAccountInactive()
        {
            MessageBox.Show("Обліковий запис деактивовано");
        }

        public void onUserNotFound()
        {
            MessageBox.Show("Користувача не знайдено");
        }
    }
}
