using System;
using System.Windows.Forms;

namespace Warehouse.Views.General
{
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            InitializeComponent();
        }

        private void tb_item_search_TextChanged(object sender, EventArgs e)
        {
            // update list (maybe create a timer)
        }

        private void tabs_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name == "tp_admin")
            {
                this.Hide();
                Form admin = new AdminForm();
                admin.ShowDialog();
                this.Show();
            }
        }

        private void btn_new_item_action_Click(object sender, EventArgs e)
        {
            // open form to create new action
        }
    }
}
