using System.Windows.Forms;
using Common.Types;
using System.Collections.Generic;

namespace Warehouse.Views.General
{
    public partial class NewOrderForm : Form, Controllers.NewOrder.INewOrderListener
    {
        private Controllers.General.GeneralController m_mainCtrl;
        private Controllers.NewOrder.NewOrderController m_ctrl;
        private bool m_isReceiveMode = true;

        private Dictionary<KeyValuePair<int, int>, List<int>> m_sendItemsPosition;

        public NewOrderForm(Controllers.General.GeneralController ctrl, int currentWarehouseID)
        {
            InitializeComponent();

            m_mainCtrl = ctrl;
            m_ctrl = new Controllers.NewOrder.NewOrderController(this, currentWarehouseID);
            m_mainCtrl.initNewOrderSubController(m_ctrl);

            tb_add_title.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb_add_title.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tb_add_title.AutoCompleteCustomSource = null;
            m_sendItemsPosition = new Dictionary<KeyValuePair<int, int>, List<int>>();
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
            int width = -1;
            int height = -1;
            int weight = -1;

            if (m_isReceiveMode)
            {

                if (!int.TryParse(tb_add_length.Text, out length))
                {
                    MessageBox.Show("Перевірте формат габаритів");
                    return;
                }


                if (!int.TryParse(tb_add_width.Text, out width))
                {
                    MessageBox.Show("Перевірте формат габаритів");
                    return;
                }


                if (!int.TryParse(tb_add_height.Text, out height))
                {
                    MessageBox.Show("Перевірте формат габаритів");
                    return;
                }


                if (!int.TryParse(tb_weight.Text, out weight))
                {
                    MessageBox.Show("Перевірте формат ваги");
                    return;
                }
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

            int level = -1;
            if (int.TryParse(cb_level.SelectedItem.ToString(), out level))
            {
                m_ctrl.addToOrder(
                   tb_add_title.Text,
                   length,
                   width,
                   height,
                   weight,
                   Topology.TopologyBuilder.convertPosition(cb_shelf.SelectedItem.ToString()),
                   level
               );
            }

           
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
                tb_add_height.Enabled = true;
                tb_add_width.Enabled = true;
                tb_add_length.Enabled = true;
                tb_weight.Enabled = true;
                m_isReceiveMode = true;
                m_ctrl.refreshShelfList();
            }
        }

        private void rtbn_send_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rtbn_send.Checked)
            {
                m_ctrl.switchMode(false);
                tb_add_height.Enabled = false;
                tb_add_width.Enabled = false;
                tb_add_length.Enabled = false;
                tb_weight.Enabled = false;
                m_isReceiveMode = false;
                m_sendItemsPosition.Clear();
                cb_shelf.Items.Clear();
                cb_shelf.Text = "";
                cb_level.Items.Clear();
                cb_level.Text = "";
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

            if (m_isReceiveMode)
            {
                m_ctrl.refreshCurrentShelfLevels(Topology.TopologyBuilder.convertPosition(cb_shelf.SelectedItem.ToString()));
                cb_level.Text = "";
                cb_level.SelectedItem = -1;
            }
            else
            {
                Vec pos = Topology.TopologyBuilder.convertPosition(cb_shelf.SelectedItem.ToString());
                List<int> levels;
                if (m_sendItemsPosition.TryGetValue(new KeyValuePair<int, int>(pos.x, pos.y), out levels))
                {
                    if (levels != null)
                    {
                        cb_level.Items.Clear();
                        foreach (int lvl in levels)
                        {
                            cb_level.Items.Add(lvl.ToString());
                        }
                    }
                }
            }
            
        }

        public void onModeUpdate()
        {
            btn_add_clear_Click(null, null);
        }

        public void onItemNameAutocompleteUpdate(List<string> list)
        {
            AutoCompleteStringCollection collection = null;

            if (list != null)
            {
                collection = new AutoCompleteStringCollection();
                foreach (string itemName in list)
                {
                    collection.Add(itemName);
                }
            }

            tb_add_title.AutoCompleteCustomSource = collection;
        }

        private void tb_add_title_TextChanged(object sender, System.EventArgs e)
        {
            m_ctrl.checkAutocomplete(tb_add_title.Text);
        }

        public void onAutocompleteMatch(List<Item> itemlist)
        {
            m_sendItemsPosition.Clear();

            foreach (var item in itemlist)
            {
                List<int> levels;
                m_sendItemsPosition.TryGetValue(new KeyValuePair<int, int>(item.shelf_pos.x, item.shelf_pos.y), out levels);
                //{
                    if (levels == null)
                    {
                        levels = new List<int>();
                    }

                    bool isLevelPresent = false;
                    foreach (int level in levels)
                    {
                        if (level == item.shelf_level)
                        {
                            isLevelPresent = true;
                            break;
                        }
                    }
                    if (!isLevelPresent)
                    {
                        levels.Add(item.shelf_level);
                        
                    }
                //}
                m_sendItemsPosition[new KeyValuePair<int, int>(item.shelf_pos.x, item.shelf_pos.y)] = levels;
            }

            cb_shelf.Items.Clear();
            foreach (var pair in m_sendItemsPosition)
            {
                Vec vec = new Vec();

                vec.x = pair.Key.Key;
                vec.y = pair.Key.Value;

                string shelf = Topology.TopologyBuilder.convertPosition(vec);
                cb_shelf.Items.Add(shelf);
            }
        }
    }
}
