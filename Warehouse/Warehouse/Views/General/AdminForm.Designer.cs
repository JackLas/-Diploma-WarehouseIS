
namespace Warehouse.Views.General
{
    partial class AdminForm
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
            this.tp_topology = new System.Windows.Forms.TabPage();
            this.tb_warehouse_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_topology_delete_column = new System.Windows.Forms.Button();
            this.btn_topology_add_column = new System.Windows.Forms.Button();
            this.btn_topology_delete_row = new System.Windows.Forms.Button();
            this.btn_topology_add_row = new System.Windows.Forms.Button();
            this.btn_save_warehouse = new System.Windows.Forms.Button();
            this.btn_add_shelf = new System.Windows.Forms.Button();
            this.lb_shelf = new System.Windows.Forms.ListBox();
            this.dgv_topology = new System.Windows.Forms.DataGridView();
            this.tp_employees = new System.Windows.Forms.TabPage();
            this.cb_empl_post = new System.Windows.Forms.ComboBox();
            this.btn_employee_add = new System.Windows.Forms.Button();
            this.tb_empl_login = new System.Windows.Forms.TextBox();
            this.tb_empl_address = new System.Windows.Forms.TextBox();
            this.tb_empl_phone = new System.Windows.Forms.TextBox();
            this.tb_empl_fullname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_search_employee = new System.Windows.Forms.TextBox();
            this.lb_employee = new System.Windows.Forms.ListBox();
            this.tp_clients = new System.Windows.Forms.TabPage();
            this.rtb_client_additional = new System.Windows.Forms.RichTextBox();
            this.tb_client_address = new System.Windows.Forms.TextBox();
            this.tb_client_name = new System.Windows.Forms.TextBox();
            this.btn_add_client = new System.Windows.Forms.Button();
            this.lbl_client_additional = new System.Windows.Forms.Label();
            this.text_client_address = new System.Windows.Forms.Label();
            this.lbl_client_name = new System.Windows.Forms.Label();
            this.tb_search_client = new System.Windows.Forms.TextBox();
            this.lb_clients = new System.Windows.Forms.ListBox();
            this.tabs.SuspendLayout();
            this.tp_topology.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_topology)).BeginInit();
            this.tp_employees.SuspendLayout();
            this.tp_clients.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tp_topology);
            this.tabs.Controls.Add(this.tp_employees);
            this.tabs.Controls.Add(this.tp_clients);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1240, 657);
            this.tabs.TabIndex = 0;
            // 
            // tp_topology
            // 
            this.tp_topology.Controls.Add(this.tb_warehouse_name);
            this.tp_topology.Controls.Add(this.label6);
            this.tp_topology.Controls.Add(this.btn_topology_delete_column);
            this.tp_topology.Controls.Add(this.btn_topology_add_column);
            this.tp_topology.Controls.Add(this.btn_topology_delete_row);
            this.tp_topology.Controls.Add(this.btn_topology_add_row);
            this.tp_topology.Controls.Add(this.btn_save_warehouse);
            this.tp_topology.Controls.Add(this.btn_add_shelf);
            this.tp_topology.Controls.Add(this.lb_shelf);
            this.tp_topology.Controls.Add(this.dgv_topology);
            this.tp_topology.Location = new System.Drawing.Point(4, 24);
            this.tp_topology.Name = "tp_topology";
            this.tp_topology.Padding = new System.Windows.Forms.Padding(3);
            this.tp_topology.Size = new System.Drawing.Size(1232, 629);
            this.tp_topology.TabIndex = 0;
            this.tp_topology.Text = "Топологія";
            this.tp_topology.UseVisualStyleBackColor = true;
            // 
            // tb_warehouse_name
            // 
            this.tb_warehouse_name.Location = new System.Drawing.Point(46, 3);
            this.tb_warehouse_name.Name = "tb_warehouse_name";
            this.tb_warehouse_name.Size = new System.Drawing.Size(933, 23);
            this.tb_warehouse_name.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Назва: ";
            // 
            // btn_topology_delete_column
            // 
            this.btn_topology_delete_column.Location = new System.Drawing.Point(356, 600);
            this.btn_topology_delete_column.Name = "btn_topology_delete_column";
            this.btn_topology_delete_column.Size = new System.Drawing.Size(122, 23);
            this.btn_topology_delete_column.TabIndex = 7;
            this.btn_topology_delete_column.Text = "Видалити стовпець";
            this.btn_topology_delete_column.UseVisualStyleBackColor = true;
            this.btn_topology_delete_column.Click += new System.EventHandler(this.btn_topology_delete_column_Click);
            // 
            // btn_topology_add_column
            // 
            this.btn_topology_add_column.Location = new System.Drawing.Point(241, 601);
            this.btn_topology_add_column.Name = "btn_topology_add_column";
            this.btn_topology_add_column.Size = new System.Drawing.Size(109, 23);
            this.btn_topology_add_column.TabIndex = 6;
            this.btn_topology_add_column.Text = "Додати стовпець";
            this.btn_topology_add_column.UseVisualStyleBackColor = true;
            this.btn_topology_add_column.Click += new System.EventHandler(this.btn_topology_add_column_Click);
            // 
            // btn_topology_delete_row
            // 
            this.btn_topology_delete_row.Location = new System.Drawing.Point(109, 601);
            this.btn_topology_delete_row.Name = "btn_topology_delete_row";
            this.btn_topology_delete_row.Size = new System.Drawing.Size(97, 23);
            this.btn_topology_delete_row.TabIndex = 5;
            this.btn_topology_delete_row.Text = "Видалити ряд";
            this.btn_topology_delete_row.UseVisualStyleBackColor = true;
            this.btn_topology_delete_row.Click += new System.EventHandler(this.btn_topology_delete_row_Click);
            // 
            // btn_topology_add_row
            // 
            this.btn_topology_add_row.Location = new System.Drawing.Point(6, 600);
            this.btn_topology_add_row.Name = "btn_topology_add_row";
            this.btn_topology_add_row.Size = new System.Drawing.Size(97, 23);
            this.btn_topology_add_row.TabIndex = 4;
            this.btn_topology_add_row.Text = "Додати ряд";
            this.btn_topology_add_row.UseVisualStyleBackColor = true;
            this.btn_topology_add_row.Click += new System.EventHandler(this.btn_topology_add_row_Click);
            // 
            // btn_save_warehouse
            // 
            this.btn_save_warehouse.Location = new System.Drawing.Point(795, 600);
            this.btn_save_warehouse.Name = "btn_save_warehouse";
            this.btn_save_warehouse.Size = new System.Drawing.Size(184, 23);
            this.btn_save_warehouse.TabIndex = 3;
            this.btn_save_warehouse.Text = "Зберегти";
            this.btn_save_warehouse.UseVisualStyleBackColor = true;
            this.btn_save_warehouse.Click += new System.EventHandler(this.btn_save_warehouse_Click);
            // 
            // btn_add_shelf
            // 
            this.btn_add_shelf.Location = new System.Drawing.Point(1069, 600);
            this.btn_add_shelf.Name = "btn_add_shelf";
            this.btn_add_shelf.Size = new System.Drawing.Size(75, 23);
            this.btn_add_shelf.TabIndex = 2;
            this.btn_add_shelf.Text = "Додати";
            this.btn_add_shelf.UseVisualStyleBackColor = true;
            this.btn_add_shelf.Click += new System.EventHandler(this.btn_add_shelf_Click);
            // 
            // lb_shelf
            // 
            this.lb_shelf.FormattingEnabled = true;
            this.lb_shelf.ItemHeight = 15;
            this.lb_shelf.Location = new System.Drawing.Point(985, 6);
            this.lb_shelf.Name = "lb_shelf";
            this.lb_shelf.Size = new System.Drawing.Size(241, 589);
            this.lb_shelf.TabIndex = 1;
            this.lb_shelf.DoubleClick += new System.EventHandler(this.lb_shelf_DoubleClick);
            // 
            // dgv_topology
            // 
            this.dgv_topology.AllowUserToAddRows = false;
            this.dgv_topology.AllowUserToDeleteRows = false;
            this.dgv_topology.AllowUserToResizeColumns = false;
            this.dgv_topology.AllowUserToResizeRows = false;
            this.dgv_topology.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_topology.Location = new System.Drawing.Point(6, 30);
            this.dgv_topology.MultiSelect = false;
            this.dgv_topology.Name = "dgv_topology";
            this.dgv_topology.ReadOnly = true;
            this.dgv_topology.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_topology.RowTemplate.Height = 25;
            this.dgv_topology.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_topology.Size = new System.Drawing.Size(973, 565);
            this.dgv_topology.TabIndex = 0;
            this.dgv_topology.Click += new System.EventHandler(this.dgv_topology_Click);
            // 
            // tp_employees
            // 
            this.tp_employees.Controls.Add(this.cb_empl_post);
            this.tp_employees.Controls.Add(this.btn_employee_add);
            this.tp_employees.Controls.Add(this.tb_empl_login);
            this.tp_employees.Controls.Add(this.tb_empl_address);
            this.tp_employees.Controls.Add(this.tb_empl_phone);
            this.tp_employees.Controls.Add(this.tb_empl_fullname);
            this.tp_employees.Controls.Add(this.label5);
            this.tp_employees.Controls.Add(this.label4);
            this.tp_employees.Controls.Add(this.label3);
            this.tp_employees.Controls.Add(this.label2);
            this.tp_employees.Controls.Add(this.label1);
            this.tp_employees.Controls.Add(this.tb_search_employee);
            this.tp_employees.Controls.Add(this.lb_employee);
            this.tp_employees.Location = new System.Drawing.Point(4, 24);
            this.tp_employees.Name = "tp_employees";
            this.tp_employees.Padding = new System.Windows.Forms.Padding(3);
            this.tp_employees.Size = new System.Drawing.Size(1232, 629);
            this.tp_employees.TabIndex = 1;
            this.tp_employees.Text = "Співробітники";
            this.tp_employees.UseVisualStyleBackColor = true;
            // 
            // cb_empl_post
            // 
            this.cb_empl_post.FormattingEnabled = true;
            this.cb_empl_post.Location = new System.Drawing.Point(689, 113);
            this.cb_empl_post.Name = "cb_empl_post";
            this.cb_empl_post.Size = new System.Drawing.Size(516, 23);
            this.cb_empl_post.TabIndex = 13;
            // 
            // btn_employee_add
            // 
            this.btn_employee_add.Location = new System.Drawing.Point(908, 395);
            this.btn_employee_add.Name = "btn_employee_add";
            this.btn_employee_add.Size = new System.Drawing.Size(75, 23);
            this.btn_employee_add.TabIndex = 12;
            this.btn_employee_add.Text = "Додати";
            this.btn_employee_add.UseVisualStyleBackColor = true;
            this.btn_employee_add.Click += new System.EventHandler(this.btn_employee_add_Click);
            // 
            // tb_empl_login
            // 
            this.tb_empl_login.Location = new System.Drawing.Point(689, 326);
            this.tb_empl_login.Name = "tb_empl_login";
            this.tb_empl_login.Size = new System.Drawing.Size(516, 23);
            this.tb_empl_login.TabIndex = 11;
            // 
            // tb_empl_address
            // 
            this.tb_empl_address.Location = new System.Drawing.Point(689, 247);
            this.tb_empl_address.Name = "tb_empl_address";
            this.tb_empl_address.Size = new System.Drawing.Size(516, 23);
            this.tb_empl_address.TabIndex = 10;
            // 
            // tb_empl_phone
            // 
            this.tb_empl_phone.Location = new System.Drawing.Point(689, 181);
            this.tb_empl_phone.Name = "tb_empl_phone";
            this.tb_empl_phone.Size = new System.Drawing.Size(516, 23);
            this.tb_empl_phone.TabIndex = 9;
            // 
            // tb_empl_fullname
            // 
            this.tb_empl_fullname.Location = new System.Drawing.Point(689, 54);
            this.tb_empl_fullname.Name = "tb_empl_fullname";
            this.tb_empl_fullname.Size = new System.Drawing.Size(516, 23);
            this.tb_empl_fullname.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(689, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Логін дла авторизації";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(689, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Адреса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(689, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(689, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Посада";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(689, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ПІБ";
            // 
            // tb_search_employee
            // 
            this.tb_search_employee.Location = new System.Drawing.Point(6, 6);
            this.tb_search_employee.Name = "tb_search_employee";
            this.tb_search_employee.Size = new System.Drawing.Size(661, 23);
            this.tb_search_employee.TabIndex = 1;
            this.tb_search_employee.TextChanged += new System.EventHandler(this.tb_search_employee_TextChanged);
            // 
            // lb_employee
            // 
            this.lb_employee.FormattingEnabled = true;
            this.lb_employee.ItemHeight = 15;
            this.lb_employee.Location = new System.Drawing.Point(6, 36);
            this.lb_employee.Name = "lb_employee";
            this.lb_employee.Size = new System.Drawing.Size(661, 589);
            this.lb_employee.TabIndex = 0;
            this.lb_employee.SelectedIndexChanged += new System.EventHandler(this.lb_employee_SelectedIndexChanged);
            // 
            // tp_clients
            // 
            this.tp_clients.Controls.Add(this.rtb_client_additional);
            this.tp_clients.Controls.Add(this.tb_client_address);
            this.tp_clients.Controls.Add(this.tb_client_name);
            this.tp_clients.Controls.Add(this.btn_add_client);
            this.tp_clients.Controls.Add(this.lbl_client_additional);
            this.tp_clients.Controls.Add(this.text_client_address);
            this.tp_clients.Controls.Add(this.lbl_client_name);
            this.tp_clients.Controls.Add(this.tb_search_client);
            this.tp_clients.Controls.Add(this.lb_clients);
            this.tp_clients.Location = new System.Drawing.Point(4, 24);
            this.tp_clients.Name = "tp_clients";
            this.tp_clients.Padding = new System.Windows.Forms.Padding(3);
            this.tp_clients.Size = new System.Drawing.Size(1232, 629);
            this.tp_clients.TabIndex = 2;
            this.tp_clients.Text = "Клієнти";
            this.tp_clients.UseVisualStyleBackColor = true;
            // 
            // rtb_client_additional
            // 
            this.rtb_client_additional.Location = new System.Drawing.Point(710, 242);
            this.rtb_client_additional.Name = "rtb_client_additional";
            this.rtb_client_additional.Size = new System.Drawing.Size(494, 135);
            this.rtb_client_additional.TabIndex = 10;
            this.rtb_client_additional.Text = "";
            // 
            // tb_client_address
            // 
            this.tb_client_address.Location = new System.Drawing.Point(710, 184);
            this.tb_client_address.Name = "tb_client_address";
            this.tb_client_address.Size = new System.Drawing.Size(494, 23);
            this.tb_client_address.TabIndex = 9;
            // 
            // tb_client_name
            // 
            this.tb_client_name.Location = new System.Drawing.Point(710, 130);
            this.tb_client_name.Name = "tb_client_name";
            this.tb_client_name.Size = new System.Drawing.Size(494, 23);
            this.tb_client_name.TabIndex = 8;
            // 
            // btn_add_client
            // 
            this.btn_add_client.Location = new System.Drawing.Point(927, 405);
            this.btn_add_client.Name = "btn_add_client";
            this.btn_add_client.Size = new System.Drawing.Size(75, 23);
            this.btn_add_client.TabIndex = 7;
            this.btn_add_client.Text = "Додати";
            this.btn_add_client.UseVisualStyleBackColor = true;
            this.btn_add_client.Click += new System.EventHandler(this.btn_add_client_Click);
            // 
            // lbl_client_additional
            // 
            this.lbl_client_additional.AutoSize = true;
            this.lbl_client_additional.Location = new System.Drawing.Point(710, 224);
            this.lbl_client_additional.Name = "lbl_client_additional";
            this.lbl_client_additional.Size = new System.Drawing.Size(131, 15);
            this.lbl_client_additional.TabIndex = 6;
            this.lbl_client_additional.Text = "Додаткова інформація";
            // 
            // text_client_address
            // 
            this.text_client_address.AutoSize = true;
            this.text_client_address.Location = new System.Drawing.Point(710, 166);
            this.text_client_address.Name = "text_client_address";
            this.text_client_address.Size = new System.Drawing.Size(46, 15);
            this.text_client_address.TabIndex = 5;
            this.text_client_address.Text = "Адреса";
            // 
            // lbl_client_name
            // 
            this.lbl_client_name.AutoSize = true;
            this.lbl_client_name.Location = new System.Drawing.Point(710, 112);
            this.lbl_client_name.Name = "lbl_client_name";
            this.lbl_client_name.Size = new System.Drawing.Size(39, 15);
            this.lbl_client_name.TabIndex = 4;
            this.lbl_client_name.Text = "Назва";
            // 
            // tb_search_client
            // 
            this.tb_search_client.Location = new System.Drawing.Point(6, 6);
            this.tb_search_client.Name = "tb_search_client";
            this.tb_search_client.Size = new System.Drawing.Size(661, 23);
            this.tb_search_client.TabIndex = 3;
            this.tb_search_client.TextChanged += new System.EventHandler(this.tb_search_client_TextChanged);
            // 
            // lb_clients
            // 
            this.lb_clients.FormattingEnabled = true;
            this.lb_clients.ItemHeight = 15;
            this.lb_clients.Location = new System.Drawing.Point(6, 36);
            this.lb_clients.Name = "lb_clients";
            this.lb_clients.Size = new System.Drawing.Size(661, 589);
            this.lb_clients.TabIndex = 2;
            this.lb_clients.SelectedIndexChanged += new System.EventHandler(this.lb_clients_SelectedIndexChanged);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabs);
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад - Адміністрування";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabs.ResumeLayout(false);
            this.tp_topology.ResumeLayout(false);
            this.tp_topology.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_topology)).EndInit();
            this.tp_employees.ResumeLayout(false);
            this.tp_employees.PerformLayout();
            this.tp_clients.ResumeLayout(false);
            this.tp_clients.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tp_topology;
        private System.Windows.Forms.DataGridView dgv_topology;
        private System.Windows.Forms.TabPage tp_employees;
        private System.Windows.Forms.TabPage tp_clients;
        private System.Windows.Forms.Button btn_add_shelf;
        private System.Windows.Forms.ListBox lb_shelf;
        private System.Windows.Forms.TextBox tb_search_employee;
        private System.Windows.Forms.ListBox lb_employee;
        private System.Windows.Forms.TextBox tb_search_client;
        private System.Windows.Forms.ListBox lb_clients;
        private System.Windows.Forms.RichTextBox rtb_client_additional;
        private System.Windows.Forms.TextBox tb_client_address;
        private System.Windows.Forms.TextBox tb_client_name;
        private System.Windows.Forms.Button btn_add_client;
        private System.Windows.Forms.Label lbl_client_additional;
        private System.Windows.Forms.Label text_client_address;
        private System.Windows.Forms.Label lbl_client_name;
        private System.Windows.Forms.Button btn_employee_add;
        private System.Windows.Forms.TextBox tb_empl_login;
        private System.Windows.Forms.TextBox tb_empl_address;
        private System.Windows.Forms.TextBox tb_empl_phone;
        private System.Windows.Forms.TextBox tb_empl_fullname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_empl_post;
        private System.Windows.Forms.Button btn_save_warehouse;
        private System.Windows.Forms.Button btn_topology_delete_column;
        private System.Windows.Forms.Button btn_topology_add_column;
        private System.Windows.Forms.Button btn_topology_delete_row;
        private System.Windows.Forms.Button btn_topology_add_row;
        private System.Windows.Forms.TextBox tb_warehouse_name;
        private System.Windows.Forms.Label label6;
    }
}