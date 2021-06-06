
namespace Warehouse.Views.General
{
    partial class NewShelfForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_max_length = new System.Windows.Forms.TextBox();
            this.tb_max_width = new System.Windows.Forms.TextBox();
            this.tb_max_height = new System.Windows.Forms.TextBox();
            this.tb_levels = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_max_weight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Макс.  довжина рівня, мм";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Макс.  ширина рівня, мм";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Макс. висота рівня, мм";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Кількість рівнів";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(12, 27);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(290, 23);
            this.tb_name.TabIndex = 5;
            // 
            // tb_max_length
            // 
            this.tb_max_length.Location = new System.Drawing.Point(12, 71);
            this.tb_max_length.Name = "tb_max_length";
            this.tb_max_length.Size = new System.Drawing.Size(290, 23);
            this.tb_max_length.TabIndex = 6;
            // 
            // tb_max_width
            // 
            this.tb_max_width.Location = new System.Drawing.Point(12, 115);
            this.tb_max_width.Name = "tb_max_width";
            this.tb_max_width.Size = new System.Drawing.Size(290, 23);
            this.tb_max_width.TabIndex = 7;
            // 
            // tb_max_height
            // 
            this.tb_max_height.Location = new System.Drawing.Point(12, 159);
            this.tb_max_height.Name = "tb_max_height";
            this.tb_max_height.Size = new System.Drawing.Size(290, 23);
            this.tb_max_height.TabIndex = 8;
            // 
            // tb_levels
            // 
            this.tb_levels.Location = new System.Drawing.Point(12, 251);
            this.tb_levels.Name = "tb_levels";
            this.tb_levels.Size = new System.Drawing.Size(290, 23);
            this.tb_levels.TabIndex = 9;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(117, 280);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Додати";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_max_weight
            // 
            this.tb_max_weight.Location = new System.Drawing.Point(12, 204);
            this.tb_max_weight.Name = "tb_max_weight";
            this.tb_max_weight.Size = new System.Drawing.Size(290, 23);
            this.tb_max_weight.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Макс. вага рівня, кг";
            // 
            // NewShelfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 310);
            this.Controls.Add(this.tb_max_weight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_levels);
            this.Controls.Add(this.tb_max_height);
            this.Controls.Add(this.tb_max_width);
            this.Controls.Add(this.tb_max_length);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "NewShelfForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад - Додати стелаж";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_max_length;
        private System.Windows.Forms.TextBox tb_max_width;
        private System.Windows.Forms.TextBox tb_max_height;
        private System.Windows.Forms.TextBox tb_levels;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_max_weight;
        private System.Windows.Forms.Label label6;
    }
}