/*
 * Warehouse (c) by Yevhenii Kryvyi
 *
 * Warehouse is licensed under a
 * Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International License.
 *
 * You should have received a copy of the license along with this
 * work. If not, see <http://creativecommons.org/licenses/by-nc-nd/4.0/>. 
 */

using System.Windows.Forms;
using Warehouse.Controllers.Login;

namespace Warehouse.Views.Login
{
    public partial class NewPasswordForm : Form
    {
        private LoginController m_ctrl;
        private int m_userID;
        public NewPasswordForm(LoginController ctrl, int userID)
        {
            InitializeComponent();
            m_ctrl = ctrl;
            m_userID = userID;
        }

        private void btn_create_Click(object sender, System.EventArgs e)
        {
            if (tb_pass.Text == tb_one_more.Text)
            {
                m_ctrl.updatePassword(m_userID, tb_pass.Text);
            }
            else
            {
                MessageBox.Show("Паролі не співпадають");
            }
        }
    }
}
