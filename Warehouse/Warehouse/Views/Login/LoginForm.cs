using System.Windows.Forms;
using Warehouse.Controllers.Login;
using Common.Types;

namespace Warehouse.Views.Login
{
    public partial class LoginForm : Form, ILoginControllerListener
    {
        private LoginController m_ctrl;
        private Form newPass = null;
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
            this.Hide();
            m_ctrl.Dispose();
            m_ctrl = null;
            Form general = new Warehouse.Views.General.GeneralForm(account.id, account.accessLevel);
            general.ShowDialog();
            this.Close();
        }

        public void onPasswordExpired(int userID)
        {
            newPass = new NewPasswordForm(m_ctrl, userID);
            this.Hide();
            newPass.ShowDialog();
            this.Show();
        }

        public void onPasswordUpdateSuccess()
        {
            newPass.Close();
            newPass = null;
        }

        public void onPasswordUpdateFailed()
        {
            MessageBox.Show("Пароль не встановлено");
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
