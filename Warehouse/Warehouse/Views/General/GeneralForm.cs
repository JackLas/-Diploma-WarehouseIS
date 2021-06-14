using System;
using System.Windows.Forms;
using Warehouse.Controllers.General;
using System.Collections.Generic;
using System.IO;
using Common.Types;

namespace Warehouse.Views.General
{
    public partial class GeneralForm : Form, IGeneralControllerListener
    {
        private const string lastModeFile = "lastmode.dat";
        private GeneralController m_ctrl;
        private Topology.TopologyBuilder m_topologyBuilder;
        private HighlightCell m_hightlightCell;

        public GeneralForm(int userID, int accessLevel)
        {
            InitializeComponent();
            m_ctrl = new GeneralController(this, userID, accessLevel);
            m_topologyBuilder = new Topology.TopologyBuilder();
            m_topologyBuilder.setSimpleMode(true);

            m_hightlightCell = null;
        }

        private void GeneralForm_Load(object sender, EventArgs e)
        {
            m_topologyBuilder.setDefaultSettings(dgv_topologyWH);
            m_ctrl.refreshWarehouseList();

            if (File.Exists(lastModeFile))
            {
                StreamReader file = new StreamReader(lastModeFile);
                int id = -1;
                int.TryParse(file.ReadLine(), out id);
                for (int i = 0; i < cb_currentWH.Items.Count; i++)
                {
                    int listID = -1;
                    if (Common.Utils.getIDFromString(cb_currentWH.Items[i].ToString(), out listID))
                    {
                        if (id == listID)
                        {
                            cb_currentWH.SelectedIndex = i;
                            break;
                        }
                    }
                }               
                file.Close();
            }
        }

        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_ctrl.Dispose();
            m_ctrl = null;
            int lastMode = getSelectWarehouseID();
            if (lastMode != -1)
            {
                StreamWriter file = new StreamWriter(lastModeFile, false);
                file.Write(lastMode.ToString());
                file.Flush();
                file.Close();
            }
        }

        public void onAccessLevelUpdate(Common.Types.Posts post)
        {
            switch (post)
            {
                case Common.Types.Posts.ADMIN:
                    // tabs.TabPages["tp_admin"].Show();
                    break;
                case Common.Types.Posts.WORKER:
                    tabs.TabPages.RemoveByKey("tp_admin");
                    break;
                default: break;
            }
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
                bool isWHRestored = false;
                int selectedWH = -1;
                Common.Utils.getIDFromString(cb_currentWH.SelectedItem.ToString(), out selectedWH);

                m_ctrl.pauseResume();
                openDialog(new AdminForm()); // block while AdminForm is active
                m_ctrl.pauseResume();

                tabs.SelectedTab = tabs.TabPages[0];

                m_ctrl.refreshWarehouseList();

                for (int i = 0; i < cb_currentWH.Items.Count; i++)
                {
                    var str = cb_currentWH.Items[i].ToString();

                    int currentWH = -1;
                    if (Common.Utils.getIDFromString(str, out currentWH))
                    {
                        if (currentWH == selectedWH)
                        {
                            cb_currentWH.SelectedIndex = i;
                            isWHRestored = true;
                            break;
                        }
                    }
                }

                if (!isWHRestored)
                {
                    cb_currentWH.SelectedIndex = -1;
                }
            }
        }

        private void tb_item_search_TextChanged(object sender, EventArgs e)
        {
            int id = getSelectWarehouseID();
            if (id != -1)
            {
                m_ctrl.refreshItemList(id, tb_item_search.Text);
            }
        }

        private void btn_new_order_Click(object sender, EventArgs e)
        {
            if (cb_currentWH.SelectedIndex == -1)
            {
                MessageBox.Show("Склад не обрано");
                return;
            }

            int id = -1;
            if (Common.Utils.getIDFromString(cb_currentWH.SelectedItem.ToString(), out id))
            {
                openDialog(new NewOrderForm(m_ctrl, id));

                lb_orders.ClearSelected();
                m_ctrl.refreshOrderList();
            }            
        }

        public void onWarehouseListUpdate(List<Common.Types.Identificator> list)
        {
            cb_currentWH.Items.Clear();
            foreach (var id in list)
            {
                cb_currentWH.Items.Add(id);
            }
        }

        private void cb_currentWH_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = getSelectWarehouseID();
            if (id != -1)
            {
                lb_items.SelectedIndex = -1;
                m_ctrl.loadWarehouseTopology(id);
                m_ctrl.refreshOrderList();
                m_ctrl.refreshItemList(id, tb_item_search.Text);
            }
        }

        private int getSelectWarehouseID()
        {
            int id = -1;
            if (cb_currentWH.SelectedIndex != -1)
            {
                Common.Utils.getIDFromString(cb_currentWH.SelectedItem.ToString(), out id);
            }
            return id;
        }

        public void onCurrentTopologyUpdate(Common.Types.Topology topology)
        {
            m_topologyBuilder.rebuild(topology, dgv_topologyWH, m_hightlightCell);
        }

        public void onOrderListUpdate(List<Common.Types.Order> list)
        {
            lb_orders.Items.Clear();
            foreach (var order in list)
            {
                lb_orders.Items.Add(order.ToString());
            }
        }

        private void lb_items_DoubleClick(object sender, EventArgs e)
        {
            if (lb_items.SelectedIndex == -1) return;
        }

        private void lb_orders_DoubleClick(object sender, EventArgs e)
        {
            if (lb_orders.SelectedIndex == -1) return;

            int orderID = -1;
            if (Common.Utils.getIDFromString(lb_orders.SelectedItem.ToString(), out orderID))
            {
                Form form = new OrderForm(orderID, lb_orders.SelectedItem.ToString(), m_ctrl);
                form.Show();
            }
        }

        public void onItemListUpdate(List<Common.Types.Item> list)
        {
            lb_items.Items.Clear();
            foreach (var item in list)
            {
                lb_items.Items.Add(
                    item.id.ToString() + ": " +
                    "[" + Topology.TopologyBuilder.convertPosition(item.shelf_pos) + ":" + item.shelf_level.ToString() + "] " +
                    item.name + 
                    " (" + item.dim.length.ToString() + "x" + item.dim.width.ToString() + "x" + item.dim.height.ToString() + "x" + item.dim.weight.ToString() + ")"
                );
            }
        }

        private void lb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_hightlightCell = null;
            int whID = getSelectWarehouseID();
            if (whID != -1)
            {
                if (lb_items.SelectedIndex != -1)
                {
                    int itemId = -1;
                    if (Common.Utils.getIDFromString(lb_items.SelectedItem.ToString(), out itemId))
                    {
                        var item = m_ctrl.getItemByID(itemId);
                        m_hightlightCell = new HighlightCell(item.pos.x, item.pos.y, item.level);
                    }
                }

                m_ctrl.loadWarehouseTopology(whID);
            }
        }
    }
}
