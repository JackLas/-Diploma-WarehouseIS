/*
 * Warehouse (c) by Yevhenii Kryvyi
 *
 * Warehouse is licensed under a
 * Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International License.
 *
 * You should have received a copy of the license along with this
 * work. If not, see <http://creativecommons.org/licenses/by-nc-nd/4.0/>. 
 */

using System;
using System.Windows.Forms;
using Warehouse.Controllers.General;

namespace Warehouse.Views.General
{
    public partial class OrderForm : Form
    {
        private int m_orderID;
        private IOrderController m_ctrl;
        public OrderForm(int orderID, string title, IOrderController ctrl)
        {
            InitializeComponent();
            this.Text += title;

            m_orderID = orderID;
            m_ctrl = ctrl;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            var desc = m_ctrl.getOrderDescription(m_orderID);
            if (desc == null) return;

            tb_clientName.Text = desc.client.title + " (" + desc.client.address +")";

            foreach (var item in desc.items)
            {
                lb_actions.Items.Add(
                    "[" + Topology.TopologyBuilder.convertPosition(item.pos) + ":" + item.level + "]: " +
                    item.name
                );
            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            m_ctrl.applyOrder(m_orderID);
            this.Close();
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            m_ctrl.cancelOrder(m_orderID);
            this.Close();
        }
    }
}
