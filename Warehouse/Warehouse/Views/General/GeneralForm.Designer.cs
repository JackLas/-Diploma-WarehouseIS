
namespace Warehouse.Views.General
{
    partial class GeneralForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabs = new System.Windows.Forms.TabControl();
            this.tp_items = new System.Windows.Forms.TabPage();
            this.lb_items = new System.Windows.Forms.ListBox();
            this.tb_item_search = new System.Windows.Forms.TextBox();
            this.tp_orders = new System.Windows.Forms.TabPage();
            this.btn_new_order = new System.Windows.Forms.Button();
            this.lb_orders = new System.Windows.Forms.ListBox();
            this.tp_admin = new System.Windows.Forms.TabPage();
            this.dgv_topologyWH = new System.Windows.Forms.DataGridView();
            this.cb_currentWH = new System.Windows.Forms.ComboBox();
            this.tabs.SuspendLayout();
            this.tp_items.SuspendLayout();
            this.tp_orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_topologyWH)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tp_items);
            this.tabs.Controls.Add(this.tp_orders);
            this.tabs.Controls.Add(this.tp_admin);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(462, 657);
            this.tabs.TabIndex = 0;
            this.tabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabs_Selected);
            // 
            // tp_items
            // 
            this.tp_items.Controls.Add(this.lb_items);
            this.tp_items.Controls.Add(this.tb_item_search);
            this.tp_items.Location = new System.Drawing.Point(4, 24);
            this.tp_items.Name = "tp_items";
            this.tp_items.Padding = new System.Windows.Forms.Padding(3);
            this.tp_items.Size = new System.Drawing.Size(454, 629);
            this.tp_items.TabIndex = 0;
            this.tp_items.Text = "На складі";
            this.tp_items.UseVisualStyleBackColor = true;
            // 
            // lb_items
            // 
            this.lb_items.FormattingEnabled = true;
            this.lb_items.ItemHeight = 15;
            this.lb_items.Location = new System.Drawing.Point(6, 35);
            this.lb_items.Name = "lb_items";
            this.lb_items.Size = new System.Drawing.Size(442, 589);
            this.lb_items.TabIndex = 1;
            // 
            // tb_item_search
            // 
            this.tb_item_search.Location = new System.Drawing.Point(6, 6);
            this.tb_item_search.Name = "tb_item_search";
            this.tb_item_search.Size = new System.Drawing.Size(442, 23);
            this.tb_item_search.TabIndex = 0;
            this.tb_item_search.TextChanged += new System.EventHandler(this.tb_item_search_TextChanged);
            // 
            // tp_orders
            // 
            this.tp_orders.Controls.Add(this.btn_new_order);
            this.tp_orders.Controls.Add(this.lb_orders);
            this.tp_orders.Location = new System.Drawing.Point(4, 24);
            this.tp_orders.Name = "tp_orders";
            this.tp_orders.Padding = new System.Windows.Forms.Padding(3);
            this.tp_orders.Size = new System.Drawing.Size(454, 629);
            this.tp_orders.TabIndex = 1;
            this.tp_orders.Text = "Черга прийому";
            this.tp_orders.UseVisualStyleBackColor = true;
            // 
            // btn_new_order
            // 
            this.btn_new_order.Location = new System.Drawing.Point(149, 600);
            this.btn_new_order.Name = "btn_new_order";
            this.btn_new_order.Size = new System.Drawing.Size(156, 23);
            this.btn_new_order.TabIndex = 1;
            this.btn_new_order.Text = "Нова дія";
            this.btn_new_order.UseVisualStyleBackColor = true;
            this.btn_new_order.Click += new System.EventHandler(this.btn_new_order_Click);
            // 
            // lb_orders
            // 
            this.lb_orders.FormattingEnabled = true;
            this.lb_orders.ItemHeight = 15;
            this.lb_orders.Location = new System.Drawing.Point(6, 6);
            this.lb_orders.Name = "lb_orders";
            this.lb_orders.Size = new System.Drawing.Size(442, 589);
            this.lb_orders.TabIndex = 0;
            // 
            // tp_admin
            // 
            this.tp_admin.Location = new System.Drawing.Point(4, 24);
            this.tp_admin.Name = "tp_admin";
            this.tp_admin.Size = new System.Drawing.Size(454, 629);
            this.tp_admin.TabIndex = 2;
            this.tp_admin.Text = "Адміністрування";
            this.tp_admin.UseVisualStyleBackColor = true;
            // 
            // dgv_topologyWH
            // 
            this.dgv_topologyWH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_topologyWH.Location = new System.Drawing.Point(480, 36);
            this.dgv_topologyWH.Name = "dgv_topologyWH";
            this.dgv_topologyWH.RowTemplate.Height = 25;
            this.dgv_topologyWH.Size = new System.Drawing.Size(772, 629);
            this.dgv_topologyWH.TabIndex = 1;
            // 
            // cb_currentWH
            // 
            this.cb_currentWH.FormattingEnabled = true;
            this.cb_currentWH.Location = new System.Drawing.Point(480, 12);
            this.cb_currentWH.Name = "cb_currentWH";
            this.cb_currentWH.Size = new System.Drawing.Size(772, 23);
            this.cb_currentWH.TabIndex = 2;
            this.cb_currentWH.SelectedIndexChanged += new System.EventHandler(this.cb_currentWH_SelectedIndexChanged);
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.cb_currentWH);
            this.Controls.Add(this.dgv_topologyWH);
            this.Controls.Add(this.tabs);
            this.MaximizeBox = false;
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад - Головна";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GeneralForm_FormClosed);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.tabs.ResumeLayout(false);
            this.tp_items.ResumeLayout(false);
            this.tp_items.PerformLayout();
            this.tp_orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_topologyWH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tp_items;
        private System.Windows.Forms.TabPage tp_orders;
        private System.Windows.Forms.DataGridView dgv_topologyWH;
        private System.Windows.Forms.ComboBox cb_currentWH;
        private System.Windows.Forms.ListBox lb_items;
        private System.Windows.Forms.TextBox tb_item_search;
        private System.Windows.Forms.Button btn_new_order;
        private System.Windows.Forms.ListBox lb_orders;
        private System.Windows.Forms.TabPage tp_admin;
    }
}