using System.Windows.Forms;
using Common.Types;
using System.Collections.Generic;

namespace Warehouse.Views.General
{
    public partial class NewOrderForm : Form, Controllers.NewOrder.INewOrderListener
    {
        private Controllers.General.GeneralController m_mainCtrl;
        private Controllers.NewOrder.NewOrderController m_ctrl;

        public NewOrderForm(Controllers.General.GeneralController ctrl, int currentWarehouseID)
        {
            InitializeComponent();

            m_mainCtrl = ctrl;
            m_ctrl = new Controllers.NewOrder.NewOrderController(this, currentWarehouseID);
            m_mainCtrl.initNewOrderSubController(m_ctrl);

            tb_add_title.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb_add_title.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tb_add_title.AutoCompleteCustomSource = null;
        }

        private void NewOrderForm_Load(object sender, System.EventArgs e)
        {
            m_ctrl.refreshClientList();
            m_ctrl.refreshShelfList();
        }

        private void btn_create_order_Click(object sender, System.EventArgs e)
        {
            if (cb_client.SelectedIndex == -1)
            {
                MessageBox.Show("Оберіть клієнта");
                return;
            }

            int clientID = -1;
            if (Common.Utils.getIDFromString(cb_client.SelectedItem.ToString(), out clientID))
            {
                if (lb_order.Items.Count > 0)
                {
                    m_ctrl.createOrder(clientID);
                    this.Close();
                }
            }
        }

        private void btn_add_Click(object sender, System.EventArgs e)
        {
            if (tb_add_title.Text.Length == 0)
            {
                MessageBox.Show("Введіть назву вантажу");
                return;
            }

            int length = -1;
            if (!int.TryParse(tb_add_length.Text, out length))
            {
                MessageBox.Show("Перевірте формат габаритів");
                return;
            }

            int width = -1;
            if (!int.TryParse(tb_add_width.Text, out width))
            {
                MessageBox.Show("Перевірте формат габаритів");
                return;
            }

            int height = -1;
            if (!int.TryParse(tb_add_height.Text, out height))
            {
                MessageBox.Show("Перевірте формат габаритів");
                return;
            }

            int weight = -1;
            if (!int.TryParse(tb_weight.Text, out weight))
            {
                MessageBox.Show("Перевірте формат ваги");
                return;
            }

            if (cb_shelf.SelectedIndex == -1)
            {
                MessageBox.Show("Стелаж не обрано");
                return;
            }

            if (cb_level.SelectedIndex == -1)
            {
                MessageBox.Show("Рівень стелажу не обрано");
                return;
            }

            m_ctrl.addToOrder(
                tb_add_title.Text,
                length,
                width,
                height,
                weight,
                Topology.TopologyBuilder.convertPosition(cb_shelf.SelectedItem.ToString()),
                (cb_level.SelectedIndex + 1)
            );
        }

        private void btn_add_clear_Click(object sender, System.EventArgs e)
        {
            tb_add_height.Clear();
            tb_add_length.Clear();
            tb_add_title.Clear();
            tb_add_width.Clear();
            tb_weight.Clear();
            cb_level.SelectedIndex = -1;
            cb_shelf.SelectedIndex = -1;
        }

        private void rbtn_receive_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbtn_receive.Checked)
            {
                m_ctrl.switchMode(true);
                tb_add_title.AutoCompleteCustomSource = null;

                tb_add_height.Enabled = true;
                tb_add_width.Enabled = true;
                tb_add_length.Enabled = true;
                tb_weight.Enabled = true;
            }
        }

        private void rtbn_send_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rtbn_send.Checked)
            {
                m_ctrl.switchMode(false);
                m_ctrl.refreshItemsAutocomplete();
                tb_add_height.Enabled = false;
                tb_add_width.Enabled = false;
                tb_add_length.Enabled = false;
                tb_weight.Enabled = false;
            }
        }

        private void btn_remove_Click(object sender, System.EventArgs e)
        {
            if (lb_order.SelectedIndex != -1)
            {
                m_ctrl.removeFromOrder(lb_order.SelectedIndex);
            }
        }

        public void onOrderListUpdate(List<OrderItem> list)
        {
            lb_order.Items.Clear();
            foreach (var item in list)
            {
                lb_order.Items.Add(item.id + ": "+ item.name + " [" + Topology.TopologyBuilder.convertPosition(item.pos) + ":" + item.level + "]");
            }
        }

        public void onClientListUpdate(List<Client> list)
        {
            cb_client.Items.Clear();
            foreach (var client in list)
            {
                cb_client.Items.Add(client.id.ToString() + ": " + client.title + " (" + client.address + ")");
            }
        }

        public void onShelfListUpdate(List<Vec> list)
        {
            cb_shelf.Items.Clear();
            foreach (var pos in list)
            {
                cb_shelf.Items.Add(Topology.TopologyBuilder.convertPosition(pos));
            }
        }

        public void onCurrentShelfLevelsUpdate(int levels)
        {
            cb_level.Items.Clear();
            for (int i = 1; i <= levels; i++)
            {
                cb_level.Items.Add(i.ToString());
            }
        }

        private void cb_shelf_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cb_shelf.SelectedIndex == -1)
            {
                onCurrentShelfLevelsUpdate(0);
                return;
            }

            m_ctrl.refreshCurrentShelfLevels(Topology.TopologyBuilder.convertPosition(cb_shelf.SelectedItem.ToString()));
            cb_shelf.SelectedIndex = -1;
        }

        public void onModeUpdate()
        {
            btn_add_clear_Click(null, null);
        }

        private void tb_add_title_TextChanged(object sender, System.EventArgs e)
        {
        }
    }
}
