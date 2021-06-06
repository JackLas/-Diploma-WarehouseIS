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

        private void openDialog(Form dialog)
        {
            this.Hide();
            dialog.ShowDialog();
            this.Show();
        }

        private void tabs_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name == "tp_admin")
            {
                openDialog(new AdminForm());
                tabs.SelectedTab = tabs.TabPages[0];
            }
        }

        private void tb_item_search_TextChanged(object sender, EventArgs e)
        {
            // update list (maybe create a timer)
        }

        private void btn_new_order_Click(object sender, EventArgs e)
        {
            // open form to create new action
            openDialog(new NewOrderForm());
        }
    }
}
