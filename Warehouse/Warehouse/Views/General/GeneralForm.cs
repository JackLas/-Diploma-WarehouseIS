using System;
using System.Windows.Forms;
using Warehouse.Controllers.General;
using System.Collections.Generic;
using System.IO;

namespace Warehouse.Views.General
{
    public partial class GeneralForm : Form, IGeneralControllerListener
    {
        private const string lastModeFile = "lastmode.dat";
        private GeneralController m_ctrl;
        private Topology.TopologyBuilder m_topologyBuilder;
        public GeneralForm(int userID, int accessLevel)
        {
            InitializeComponent();
            m_ctrl = new GeneralController(this, userID, accessLevel);
            m_topologyBuilder = new Topology.TopologyBuilder();
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
            openDialog(new NewOrderForm());
        }

        public void onWarehouseListUpdate(List<Common.Types.Identificator> list)
        {
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
                m_ctrl.loadWarehouseTopology(id);
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
            m_topologyBuilder.rebuild(topology, dgv_topologyWH);
        }
    }
}
