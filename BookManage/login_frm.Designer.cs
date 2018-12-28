namespace BookManage
{
    partial class login_frm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.login_label = new System.Windows.Forms.Label();
            this.pwd_label = new System.Windows.Forms.Label();
            this.login_input = new System.Windows.Forms.TextBox();
            this.pwd_input = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(21, 48);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(53, 12);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "登录ID：";
            // 
            // pwd_label
            // 
            this.pwd_label.AutoSize = true;
            this.pwd_label.Location = new System.Drawing.Point(21, 81);
            this.pwd_label.Name = "pwd_label";
            this.pwd_label.Size = new System.Drawing.Size(53, 12);
            this.pwd_label.TabIndex = 1;
            this.pwd_label.Text = "密码框：";
            // 
            // login_input
            // 
            this.login_input.Location = new System.Drawing.Point(80, 45);
            this.login_input.Name = "login_input";
            this.login_input.Size = new System.Drawing.Size(176, 21);
            this.login_input.TabIndex = 2;
            // 
            // pwd_input
            // 
            this.pwd_input.Location = new System.Drawing.Point(80, 78);
            this.pwd_input.Name = "pwd_input";
            this.pwd_input.PasswordChar = '·';
            this.pwd_input.Size = new System.Drawing.Size(176, 21);
            this.pwd_input.TabIndex = 3;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(197, 123);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "登录";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_frm
            // 
            this.AcceptButton = this.login_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pwd_input);
            this.Controls.Add(this.login_input);
            this.Controls.Add(this.pwd_label);
            this.Controls.Add(this.login_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "login_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label pwd_label;
        private System.Windows.Forms.TextBox login_input;
        private System.Windows.Forms.TextBox pwd_input;
        private System.Windows.Forms.Button login_btn;
    }
}

