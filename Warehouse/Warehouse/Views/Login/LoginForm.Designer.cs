namespace Warehouse.Views.Login
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(12, 9);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(37, 15);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "Логін";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(12, 53);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(49, 15);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Пароль";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(12, 27);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(272, 23);
            this.tb_login.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(12, 71);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(272, 23);
            this.tb_password.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(115, 100);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Увійти";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 140);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад - авторизація ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_login;
    }
}

