
namespace Warehouse.Views.Login
{
    partial class NewPasswordForm
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
            this.btn_create = new System.Windows.Forms.Button();
            this.tb_one_more = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.lbl_one_more = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(115, 135);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 9;
            this.btn_create.Text = "Створити";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // tb_one_more
            // 
            this.tb_one_more.Location = new System.Drawing.Point(12, 106);
            this.tb_one_more.Name = "tb_one_more";
            this.tb_one_more.PasswordChar = '*';
            this.tb_one_more.Size = new System.Drawing.Size(272, 23);
            this.tb_one_more.TabIndex = 8;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(12, 62);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(272, 23);
            this.tb_pass.TabIndex = 7;
            // 
            // lbl_one_more
            // 
            this.lbl_one_more.AutoSize = true;
            this.lbl_one_more.Location = new System.Drawing.Point(12, 88);
            this.lbl_one_more.Name = "lbl_one_more";
            this.lbl_one_more.Size = new System.Drawing.Size(108, 15);
            this.lbl_one_more.TabIndex = 6;
            this.lbl_one_more.Text = "Повторіть пароль:";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(12, 44);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(92, 15);
            this.lbl_pass.TabIndex = 5;
            this.lbl_pass.Text = "Введіть пароль:";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(25, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(249, 15);
            this.lbl_title.TabIndex = 10;
            this.lbl_title.Text = "Придумайте пароль для облікового запису";
            // 
            // NewPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 170);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.tb_one_more);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.lbl_one_more);
            this.Controls.Add(this.lbl_pass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "NewPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад - Створення паролю";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox tb_one_more;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label lbl_one_more;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_title;
    }
}