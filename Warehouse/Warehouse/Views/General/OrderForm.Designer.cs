
namespace Warehouse.Views.General
{
    partial class OrderForm
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
            this.tb_clientName = new System.Windows.Forms.TextBox();
            this.lb_actions = new System.Windows.Forms.ListBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клієнт: ";
            // 
            // tb_clientName
            // 
            this.tb_clientName.Location = new System.Drawing.Point(66, 6);
            this.tb_clientName.Name = "tb_clientName";
            this.tb_clientName.ReadOnly = true;
            this.tb_clientName.Size = new System.Drawing.Size(722, 23);
            this.tb_clientName.TabIndex = 1;
            // 
            // lb_actions
            // 
            this.lb_actions.FormattingEnabled = true;
            this.lb_actions.ItemHeight = 15;
            this.lb_actions.Location = new System.Drawing.Point(12, 35);
            this.lb_actions.Name = "lb_actions";
            this.lb_actions.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lb_actions.Size = new System.Drawing.Size(776, 364);
            this.lb_actions.TabIndex = 2;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(252, 415);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(100, 23);
            this.btn_apply.TabIndex = 3;
            this.btn_apply.Text = "Затвердити";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.Location = new System.Drawing.Point(444, 415);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(100, 23);
            this.btn_cancle.TabIndex = 4;
            this.btn_cancle.Text = "Скасувати";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.lb_actions);
            this.Controls.Add(this.tb_clientName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад - ";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_clientName;
        private System.Windows.Forms.ListBox lb_actions;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_cancle;
    }
}