using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Warehouse.Controllers.Admin;

namespace Warehouse.Views.General
{
    public partial class AdminForm : Form, IAdminControllerListener
    {
        private AdminController m_ctrl;
        private Topology.TopologyBuilder m_topologyBuilder;
        public AdminForm()
        {
            InitializeComponent();
            m_ctrl = new AdminController(this);
            m_topologyBuilder = new Topology.TopologyBuilder();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_ctrl.Dispose();
            m_ctrl = null;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            m_topologyBuilder.setDefaultSettings(dgv_topology);

            cb_empl_post.Items.Clear();
            cb_empl_post.Items.Add("Адміністратор");
            cb_empl_post.Items.Add("Робітник складу");

            m_ctrl.refreshEmployeeList();
            m_ctrl.refreshClientList();
            m_ctrl.refreshShelfList();
        }

        private void tb_search_employee_TextChanged(object sender, EventArgs e)
        {
            m_ctrl.refreshEmployeeList(tb_search_employee.Text);
        }

        private void btn_employee_add_Click(object sender, EventArgs e)
        {
            if (tb_empl_fullname.Text.Length == 0)
            {
                MessageBox.Show("Введіть ім'я");
            }
            else if (cb_empl_post.SelectedIndex == -1)
            {
                MessageBox.Show("Оберіть посаду");
            }
            else if (!Common.Utils.checkPhoneFormat(tb_empl_phone.Text))
            {
                MessageBox.Show("Введіть номер телефону у форматі\n" + Common.Utils.phoneFormat); 
            }
            else if (tb_empl_address.Text.Length == 0)
            {
                MessageBox.Show("Введіть адресу");
            }
            else if (tb_empl_login.Text.Length == 0)
            {
                MessageBox.Show("Введіть логін");
            }
            else
            {
                m_ctrl.addEmployee(
                    tb_empl_fullname.Text, 
                    cb_empl_post.SelectedIndex,
                    tb_empl_address.Text,
                    tb_empl_phone.Text, 
                    tb_empl_login.Text);
            }
        }

        public void onLoginAlreadyExists()
        {
            MessageBox.Show("Такий логін вже існує");
        }

        public void onEmployeeAdded()
        {
            tb_empl_fullname.Clear();
            cb_empl_post.SelectedIndex = -1;
            tb_empl_phone.Clear();
            tb_empl_address.Clear();
            tb_empl_login.Clear();

            MessageBox.Show("Користувача зареєстровано");

            m_ctrl.refreshEmployeeList();
        }

        public void onEmployeeListUpdate(List<Common.Types.Employee> employees)
        {
            lb_employee.ClearSelected();
            lb_employee.Items.Clear();
            foreach (var empl in employees)
            {
                lb_employee.Items.Add(empl.id.ToString() + ": " + empl.fullName);
            }            
        }

        private void lb_employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_employee.SelectedIndex == -1) return;

            var str = lb_employee.SelectedItem.ToString();

            int id = -1;

            if (Common.Utils.getIDFromString(str, out id))
            {
                var empl = m_ctrl.getEmployeeByID(id);

                if (empl != null)
                {
                    MessageBox.Show(
                        "ID: " + empl.id + "\n" +
                        "ПІБ: " + empl.fullName + "\n" +
                        "Телефон: " + empl.phone + "\n" +
                        "Адреса: " + "\n" + empl.address
                    );
                }
            }
        }

        private void btn_add_client_Click(object sender, EventArgs e)
        {
            if (tb_client_name.Text.Length == 0)
            {
                MessageBox.Show("Введіть назву клієнта");
            }
            else if (tb_client_address.Text.Length == 0)
            {
                MessageBox.Show("Введіть адресу клієнта");
            }
            else
            {
                m_ctrl.addClient(
                    tb_client_name.Text,
                    tb_client_address.Text,
                    rtb_client_additional.Text
                );
            }
        }

        private void tb_search_client_TextChanged(object sender, EventArgs e)
        {
            m_ctrl.refreshClientList(tb_search_client.Text);
        }

        public void onClientAdded()
        {
            MessageBox.Show("Клієнта додано");
            tb_client_name.Clear();
            tb_client_address.Clear();
            rtb_client_additional.Clear();
            m_ctrl.refreshClientList(tb_search_client.Text);
        }

        public void onClientListRefresh(List<Common.Types.Client> clientList)
        {
            lb_clients.ClearSelected();
            lb_clients.Items.Clear();
            foreach (var client in clientList)
            {
                lb_clients.Items.Add(client.id.ToString() + ": " + client.title);
            }
        }

        private void lb_clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_clients.SelectedIndex == -1) return;

            var str = lb_clients.SelectedItem.ToString();

            int id = -1;

            if (Common.Utils.getIDFromString(str, out id))
            {
                var client = m_ctrl.getClientByID(id);

                if (client != null)
                {
                    MessageBox.Show(
                        "ID: " + client.id + "\n" +
                        "Назва: " + client.title + "\n" +
                        "Адреса: " + "\n" + client.address + "\n" + 
                        (client.info.Length == 0 ? "" : "Додаткова інформація:\n" +  client.info)
                    );
                }
            }
        }

        private void btn_add_shelf_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form newShelfForm = new NewShelfForm(m_ctrl);
            newShelfForm.ShowDialog();
            this.Show();
        }

        public void onNewShelfAdded()
        {
            m_ctrl.refreshShelfList();
            MessageBox.Show("Стелаж додано");
        }
        public void onShelfListRefresh(List<Common.Types.Shelf> shelfList)
        {
            lb_shelf.Items.Clear();
            foreach (var shelf in shelfList)
            {
                lb_shelf.Items.Add(shelf.id.ToString() + ": " + shelf.name);
            }
        }

        private void lb_shelf_DoubleClick(object sender, EventArgs e)
        {
            if (lb_shelf.SelectedIndex == -1) return;

            var str = lb_shelf.SelectedItem.ToString();

            int id = -1;

            if (Common.Utils.getIDFromString(str, out id))
            {
                var shelf = m_ctrl.getShelfByID(id);

                if (shelf != null)
                {
                    MessageBox.Show(
                        "ID: " + shelf.id + "\n" +
                        "Назва: " + shelf.name + "\n" +
                        "Габарити (ДхШхВ), мм:\n" +
                        shelf.length + " x " + shelf.width + " x " + shelf.height + "\n" +
                        "Максимальна вага: " + shelf.weight + "\n" +
                        "Рівні: " + shelf.levels
                    );
                }
            }
        }

        private void btn_topology_add_row_Click(object sender, EventArgs e)
        {
            m_ctrl.topologyAddRow();
        }

        private void btn_topology_delete_row_Click(object sender, EventArgs e)
        {
            m_ctrl.topologyDeleteRow();
        }

        private void btn_topology_add_column_Click(object sender, EventArgs e)
        {
            m_ctrl.topologyAddColumn();
        }

        private void btn_topology_delete_column_Click(object sender, EventArgs e)
        {
            m_ctrl.topologyDeleteColumn();
        }

        public void onCurrentTopologyUpdate(Common.Types.Topology topology)
        {
            m_topologyBuilder.rebuild(topology, dgv_topology);
        }

        private void btn_save_warehouse_Click(object sender, EventArgs e)
        {
            if (tb_warehouse_name.Text.Length == 0)
            {
                MessageBox.Show("Введіть назву складу");
            }
            else
            {
                m_ctrl.saveTopology(tb_warehouse_name.Text);
            }
        }

        public void onTopologySaved()
        {
            MessageBox.Show("Топологія збережена");
            btn_clear_warehouse_Click(this, null);
        }

        private void dgv_topology_Click(object sender, EventArgs e)
        {
            var mouseEvent = (MouseEventArgs) e;

            if (mouseEvent.Button == MouseButtons.Left) // add
            {
                if (dgv_topology.SelectedCells.Count > 0)
                {
                    int shelfID = -1;
                    if (lb_shelf.SelectedIndex >= 0 && Common.Utils.getIDFromString(lb_shelf.SelectedItem.ToString(), out shelfID))
                    {
                        var selectedCell = dgv_topology.SelectedCells[0];
                        m_ctrl.addShelfToTopology(shelfID, selectedCell.ColumnIndex, selectedCell.RowIndex);
                    }
                }
            }
            else if (mouseEvent.Button == MouseButtons.Right) // remove
            {
                var selectedCell = dgv_topology.HitTest(mouseEvent.X, mouseEvent.Y);
                m_ctrl.removeShelfFromTopology(selectedCell.ColumnIndex, selectedCell.RowIndex);
            }

            dgv_topology.ClearSelection();
        }

        public void handleNotification(string msg)
        {
            MessageBox.Show(msg);
        }

        private void btn_clear_warehouse_Click(object sender, EventArgs e)
        {
            dgv_topology.ColumnCount = 0;
            dgv_topology.RowCount = 0;
            lb_shelf.ClearSelected();
            tb_warehouse_name.Clear();

            m_ctrl.clearTopology();
        }
    }
}
