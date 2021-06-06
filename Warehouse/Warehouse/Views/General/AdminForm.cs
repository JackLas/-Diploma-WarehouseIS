using System;
using System.Windows.Forms;

namespace Warehouse.Views.General
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void tp_employees_Click(object sender, EventArgs e)
        {

        }

        private void tb_search_employee_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_client_Click(object sender, EventArgs e)
        {

        }

        private void btn_employee_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_shelf_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form dialog = new NewShelfForm();
            dialog.ShowDialog();
            this.Show();
        }

        private void btn_topology_add_row_Click(object sender, EventArgs e)
        {

        }

        private void btn_topology_delete_row_Click(object sender, EventArgs e)
        {

        }

        private void btn_topology_add_column_Click(object sender, EventArgs e)
        {

        }

        private void btn_topology_delete_column_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_warehouse_Click(object sender, EventArgs e)
        {

        }

    }
}
