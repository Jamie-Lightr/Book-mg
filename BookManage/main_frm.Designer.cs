namespace BookManage
{
    partial class main_frm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.admin_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.borrow_btn = new System.Windows.Forms.ToolStripButton();
            this.admin_identy = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admin_btn,
            this.toolStripSeparator1,
            this.borrow_btn,
            this.admin_identy});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1436, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // admin_btn
            // 
            this.admin_btn.Image = global::BookManage.Properties.Resources.Admin_32px_582766_easyicon_net;
            this.admin_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(88, 22);
            this.admin_btn.Text = "管理员面板";
            this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // borrow_btn
            // 
            this.borrow_btn.Image = global::BookManage.Properties.Resources.boo_mg;
            this.borrow_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.borrow_btn.Name = "borrow_btn";
            this.borrow_btn.Size = new System.Drawing.Size(76, 22);
            this.borrow_btn.Text = "借阅面板";
            this.borrow_btn.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.borrow_btn.Click += new System.EventHandler(this.borrow_btn_Click);
            // 
            // admin_identy
            // 
            this.admin_identy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.admin_identy.Image = global::BookManage.Properties.Resources.face;
            this.admin_identy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.admin_identy.Name = "admin_identy";
            this.admin_identy.Size = new System.Drawing.Size(23, 22);
            this.admin_identy.Click += new System.EventHandler(this.admin_identy_Click);
            // 
            // main_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 737);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "main_frm";
            this.Text = "Main_Frm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton admin_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton borrow_btn;
        private System.Windows.Forms.ToolStripButton admin_identy;
    }
}