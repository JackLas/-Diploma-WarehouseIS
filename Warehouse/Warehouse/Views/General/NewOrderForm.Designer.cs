
namespace Warehouse.Views.General
{
    partial class NewOrderForm
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
            this.lb_order = new System.Windows.Forms.ListBox();
            this.gb_add = new System.Windows.Forms.GroupBox();
            this.tb_shelf_level = new System.Windows.Forms.TextBox();
            this.tb_shelf_pos = new System.Windows.Forms.TextBox();
            this.tb_weight = new System.Windows.Forms.TextBox();
            this.tb_add_height = new System.Windows.Forms.TextBox();
            this.tb_add_width = new System.Windows.Forms.TextBox();
            this.tb_add_length = new System.Windows.Forms.TextBox();
            this.tb_add_title = new System.Windows.Forms.TextBox();
            this.btn_add_clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_type = new System.Windows.Forms.GroupBox();
            this.rtbn_send = new System.Windows.Forms.RadioButton();
            this.rbtn_receive = new System.Windows.Forms.RadioButton();
            this.btn_create_order = new System.Windows.Forms.Button();
            this.gb_add.SuspendLayout();
            this.gb_type.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_order
            // 
            this.lb_order.FormattingEnabled = true;
            this.lb_order.ItemHeight = 15;
            this.lb_order.Location = new System.Drawing.Point(12, 274);
            this.lb_order.Name = "lb_order";
            this.lb_order.Size = new System.Drawing.Size(500, 169);
            this.lb_order.TabIndex = 2;
            // 
            // gb_add
            // 
            this.gb_add.Controls.Add(this.tb_shelf_level);
            this.gb_add.Controls.Add(this.tb_shelf_pos);
            this.gb_add.Controls.Add(this.tb_weight);
            this.gb_add.Controls.Add(this.tb_add_height);
            this.gb_add.Controls.Add(this.tb_add_width);
            this.gb_add.Controls.Add(this.tb_add_length);
            this.gb_add.Controls.Add(this.tb_add_title);
            this.gb_add.Controls.Add(this.btn_add_clear);
            this.gb_add.Controls.Add(this.btn_add);
            this.gb_add.Controls.Add(this.label6);
            this.gb_add.Controls.Add(this.label5);
            this.gb_add.Controls.Add(this.label4);
            this.gb_add.Controls.Add(this.label3);
            this.gb_add.Controls.Add(this.label2);
            this.gb_add.Location = new System.Drawing.Point(12, 70);
            this.gb_add.Name = "gb_add";
            this.gb_add.Size = new System.Drawing.Size(500, 198);
            this.gb_add.TabIndex = 3;
            this.gb_add.TabStop = false;
            // 
            // tb_shelf_level
            // 
            this.tb_shelf_level.Location = new System.Drawing.Point(197, 121);
            this.tb_shelf_level.Name = "tb_shelf_level";
            this.tb_shelf_level.Size = new System.Drawing.Size(71, 23);
            this.tb_shelf_level.TabIndex = 13;
            // 
            // tb_shelf_pos
            // 
            this.tb_shelf_pos.Location = new System.Drawing.Point(60, 121);
            this.tb_shelf_pos.Name = "tb_shelf_pos";
            this.tb_shelf_pos.Size = new System.Drawing.Size(71, 23);
            this.tb_shelf_pos.TabIndex = 12;
            // 
            // tb_weight
            // 
            this.tb_weight.Location = new System.Drawing.Point(63, 83);
            this.tb_weight.Name = "tb_weight";
            this.tb_weight.Size = new System.Drawing.Size(106, 23);
            this.tb_weight.TabIndex = 11;
            // 
            // tb_add_height
            // 
            this.tb_add_height.Location = new System.Drawing.Point(250, 50);
            this.tb_add_height.Name = "tb_add_height";
            this.tb_add_height.Size = new System.Drawing.Size(44, 23);
            this.tb_add_height.TabIndex = 10;
            // 
            // tb_add_width
            // 
            this.tb_add_width.Location = new System.Drawing.Point(200, 50);
            this.tb_add_width.Name = "tb_add_width";
            this.tb_add_width.Size = new System.Drawing.Size(44, 23);
            this.tb_add_width.TabIndex = 9;
            // 
            // tb_add_length
            // 
            this.tb_add_length.Location = new System.Drawing.Point(149, 50);
            this.tb_add_length.Name = "tb_add_length";
            this.tb_add_length.Size = new System.Drawing.Size(44, 23);
            this.tb_add_length.TabIndex = 8;
            // 
            // tb_add_title
            // 
            this.tb_add_title.Location = new System.Drawing.Point(51, 16);
            this.tb_add_title.Name = "tb_add_title";
            this.tb_add_title.Size = new System.Drawing.Size(443, 23);
            this.tb_add_title.TabIndex = 7;
            // 
            // btn_add_clear
            // 
            this.btn_add_clear.Location = new System.Drawing.Point(419, 165);
            this.btn_add_clear.Name = "btn_add_clear";
            this.btn_add_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_add_clear.TabIndex = 6;
            this.btn_add_clear.Text = "Очистити";
            this.btn_add_clear.UseVisualStyleBackColor = true;
            this.btn_add_clear.Click += new System.EventHandler(this.btn_add_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(219, 165);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Додати";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Рівень:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Стелаж:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Вага, кг:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Габарити (ДхШхВ), мм :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Назва:";
            // 
            // gb_type
            // 
            this.gb_type.Controls.Add(this.rtbn_send);
            this.gb_type.Controls.Add(this.rbtn_receive);
            this.gb_type.Location = new System.Drawing.Point(12, 12);
            this.gb_type.Name = "gb_type";
            this.gb_type.Size = new System.Drawing.Size(500, 52);
            this.gb_type.TabIndex = 4;
            this.gb_type.TabStop = false;
            this.gb_type.Text = "Тип";
            // 
            // rtbn_send
            // 
            this.rtbn_send.AutoSize = true;
            this.rtbn_send.Location = new System.Drawing.Point(309, 22);
            this.rtbn_send.Name = "rtbn_send";
            this.rtbn_send.Size = new System.Drawing.Size(79, 19);
            this.rtbn_send.TabIndex = 1;
            this.rtbn_send.TabStop = true;
            this.rtbn_send.Text = "Відправка";
            this.rtbn_send.UseVisualStyleBackColor = true;
            this.rtbn_send.CheckedChanged += new System.EventHandler(this.rtbn_send_CheckedChanged);
            // 
            // rbtn_receive
            // 
            this.rbtn_receive.AutoSize = true;
            this.rbtn_receive.Checked = true;
            this.rbtn_receive.Location = new System.Drawing.Point(122, 22);
            this.rbtn_receive.Name = "rbtn_receive";
            this.rbtn_receive.Size = new System.Drawing.Size(71, 19);
            this.rbtn_receive.TabIndex = 0;
            this.rbtn_receive.TabStop = true;
            this.rbtn_receive.Text = "Прийом";
            this.rbtn_receive.UseVisualStyleBackColor = true;
            this.rbtn_receive.CheckedChanged += new System.EventHandler(this.rbtn_receive_CheckedChanged);
            // 
            // btn_create_order
            // 
            this.btn_create_order.Location = new System.Drawing.Point(176, 449);
            this.btn_create_order.Name = "btn_create_order";
            this.btn_create_order.Size = new System.Drawing.Size(172, 23);
            this.btn_create_order.TabIndex = 7;
            this.btn_create_order.Text = "Стоврити замовлення";
            this.btn_create_order.UseVisualStyleBackColor = true;
            this.btn_create_order.Click += new System.EventHandler(this.btn_create_order_Click);
            // 
            // NewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 482);
            this.Controls.Add(this.btn_create_order);
            this.Controls.Add(this.gb_type);
            this.Controls.Add(this.gb_add);
            this.Controls.Add(this.lb_order);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "NewOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад - Нове замовлення";
            this.gb_add.ResumeLayout(false);
            this.gb_add.PerformLayout();
            this.gb_type.ResumeLayout(false);
            this.gb_type.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lb_order;
        private System.Windows.Forms.GroupBox gb_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_weight;
        private System.Windows.Forms.TextBox tb_add_height;
        private System.Windows.Forms.TextBox tb_add_width;
        private System.Windows.Forms.TextBox tb_add_length;
        private System.Windows.Forms.TextBox tb_add_title;
        private System.Windows.Forms.Button btn_add_clear;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_type;
        private System.Windows.Forms.RadioButton rtbn_send;
        private System.Windows.Forms.RadioButton rbtn_receive;
        private System.Windows.Forms.Button btn_create_order;
        private System.Windows.Forms.TextBox tb_shelf_level;
        private System.Windows.Forms.TextBox tb_shelf_pos;
    }
}