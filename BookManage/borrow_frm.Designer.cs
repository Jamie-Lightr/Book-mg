namespace BookManage
{
    partial class borrow_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borrow_frm));
            this.rd_data = new System.Windows.Forms.DataGridView();
            this.rd_panel = new System.Windows.Forms.Panel();
            this.rd_select_bar = new System.Windows.Forms.ToolStrip();
            this.rd_refresh = new System.Windows.Forms.ToolStripButton();
            this.tss0 = new System.Windows.Forms.ToolStripSeparator();
            this.rd_excute_btn = new System.Windows.Forms.ToolStripButton();
            this.tss3 = new System.Windows.Forms.ToolStripSeparator();
            this.rd_input = new System.Windows.Forms.ToolStripTextBox();
            this.tss2 = new System.Windows.Forms.ToolStripSeparator();
            this.rd_choose_btn = new System.Windows.Forms.ToolStripComboBox();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.rd_lb = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bk_select_bar = new System.Windows.Forms.ToolStrip();
            this.bk_refresh = new System.Windows.Forms.ToolStripButton();
            this.tsss0 = new System.Windows.Forms.ToolStripSeparator();
            this.bk_excute_btn = new System.Windows.Forms.ToolStripButton();
            this.tsss1 = new System.Windows.Forms.ToolStripSeparator();
            this.bk_input = new System.Windows.Forms.ToolStripTextBox();
            this.tsss2 = new System.Windows.Forms.ToolStripSeparator();
            this.bk_choose_btn = new System.Windows.Forms.ToolStripComboBox();
            this.tsss3 = new System.Windows.Forms.ToolStripSeparator();
            this.bk_lb = new System.Windows.Forms.ToolStripLabel();
            this.bk_data = new System.Windows.Forms.DataGridView();
            this.p_borrow_message = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.get_date = new System.Windows.Forms.Button();
            this.tb_OperatorLend = new System.Windows.Forms.TextBox();
            this.l_OperatorLend = new System.Windows.Forms.Label();
            this.tb_ldDateOut = new System.Windows.Forms.TextBox();
            this.tb_rdID = new System.Windows.Forms.TextBox();
            this.l_ldDateOut = new System.Windows.Forms.Label();
            this.l_rdID = new System.Windows.Forms.Label();
            this.l_bkID = new System.Windows.Forms.Label();
            this.tb_BorrowID = new System.Windows.Forms.TextBox();
            this.l_BorrowID = new System.Windows.Forms.Label();
            this.tb_bkID = new System.Windows.Forms.TextBox();
            this.p_return_message = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.get_date_b = new System.Windows.Forms.Button();
            this.tb_OperatorRet = new System.Windows.Forms.TextBox();
            this.l_OperatorRet = new System.Windows.Forms.Label();
            this.tb_ldDateRetAct = new System.Windows.Forms.TextBox();
            this.tb_rdID_b = new System.Windows.Forms.TextBox();
            this.l_ldDateRetAct = new System.Windows.Forms.Label();
            this.l_rdID_b = new System.Windows.Forms.Label();
            this.l_bkID_b = new System.Windows.Forms.Label();
            this.tb_BorrowID_b = new System.Windows.Forms.TextBox();
            this.l_BorowID_b = new System.Windows.Forms.Label();
            this.tb_bkID_b = new System.Windows.Forms.TextBox();
            this.rb_borrow_bk = new System.Windows.Forms.RadioButton();
            this.rb_return_bk = new System.Windows.Forms.RadioButton();
            this.p_controlbox = new System.Windows.Forms.Panel();
            this.borrow_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rd_data)).BeginInit();
            this.rd_panel.SuspendLayout();
            this.rd_select_bar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bk_select_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bk_data)).BeginInit();
            this.p_borrow_message.SuspendLayout();
            this.p_return_message.SuspendLayout();
            this.p_controlbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rd_data
            // 
            this.rd_data.AllowUserToAddRows = false;
            this.rd_data.AllowUserToDeleteRows = false;
            this.rd_data.AllowUserToResizeColumns = false;
            this.rd_data.AllowUserToResizeRows = false;
            this.rd_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rd_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.rd_data.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.rd_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rd_data.Dock = System.Windows.Forms.DockStyle.Top;
            this.rd_data.Location = new System.Drawing.Point(0, 0);
            this.rd_data.Name = "rd_data";
            this.rd_data.ReadOnly = true;
            this.rd_data.RowTemplate.Height = 23;
            this.rd_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rd_data.Size = new System.Drawing.Size(780, 221);
            this.rd_data.TabIndex = 0;
            this.rd_data.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.rd_data_CellMouseClick);
            // 
            // rd_panel
            // 
            this.rd_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rd_panel.Controls.Add(this.rd_select_bar);
            this.rd_panel.Controls.Add(this.rd_data);
            this.rd_panel.Location = new System.Drawing.Point(12, 12);
            this.rd_panel.Name = "rd_panel";
            this.rd_panel.Size = new System.Drawing.Size(782, 254);
            this.rd_panel.TabIndex = 1;
            // 
            // rd_select_bar
            // 
            this.rd_select_bar.AutoSize = false;
            this.rd_select_bar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rd_select_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rd_refresh,
            this.tss0,
            this.rd_excute_btn,
            this.tss3,
            this.rd_input,
            this.tss2,
            this.rd_choose_btn,
            this.tss1,
            this.rd_lb});
            this.rd_select_bar.Location = new System.Drawing.Point(0, 224);
            this.rd_select_bar.Name = "rd_select_bar";
            this.rd_select_bar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.rd_select_bar.Size = new System.Drawing.Size(780, 28);
            this.rd_select_bar.TabIndex = 1;
            // 
            // rd_refresh
            // 
            this.rd_refresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rd_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rd_refresh.Image = global::BookManage.Properties.Resources.refresh;
            this.rd_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rd_refresh.Name = "rd_refresh";
            this.rd_refresh.Size = new System.Drawing.Size(23, 25);
            this.rd_refresh.Text = "refresh";
            this.rd_refresh.Click += new System.EventHandler(this.rd_refresh_Click);
            // 
            // tss0
            // 
            this.tss0.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tss0.Name = "tss0";
            this.tss0.Size = new System.Drawing.Size(6, 28);
            // 
            // rd_excute_btn
            // 
            this.rd_excute_btn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rd_excute_btn.AutoSize = false;
            this.rd_excute_btn.BackColor = System.Drawing.Color.LightCoral;
            this.rd_excute_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rd_excute_btn.Image = ((System.Drawing.Image)(resources.GetObject("rd_excute_btn.Image")));
            this.rd_excute_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rd_excute_btn.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.rd_excute_btn.Name = "rd_excute_btn";
            this.rd_excute_btn.Size = new System.Drawing.Size(100, 25);
            this.rd_excute_btn.Text = "Select";
            this.rd_excute_btn.Click += new System.EventHandler(this.rd_excute_btn_Click);
            // 
            // tss3
            // 
            this.tss3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tss3.Name = "tss3";
            this.tss3.Size = new System.Drawing.Size(6, 28);
            // 
            // rd_input
            // 
            this.rd_input.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rd_input.AutoSize = false;
            this.rd_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rd_input.Name = "rd_input";
            this.rd_input.Size = new System.Drawing.Size(400, 23);
            // 
            // tss2
            // 
            this.tss2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tss2.Name = "tss2";
            this.tss2.Size = new System.Drawing.Size(6, 28);
            // 
            // rd_choose_btn
            // 
            this.rd_choose_btn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rd_choose_btn.AutoSize = false;
            this.rd_choose_btn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rd_choose_btn.Items.AddRange(new object[] {
            "rdID",
            "rdType",
            "rdName",
            "rdSex",
            "rdDept",
            "rdEmail",
            "rdPhone",
            "rdQQ"});
            this.rd_choose_btn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
            this.rd_choose_btn.Name = "rd_choose_btn";
            this.rd_choose_btn.Size = new System.Drawing.Size(150, 25);
            this.rd_choose_btn.ToolTipText = "rdID";
            // 
            // tss1
            // 
            this.tss1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(6, 28);
            // 
            // rd_lb
            // 
            this.rd_lb.Name = "rd_lb";
            this.rd_lb.Size = new System.Drawing.Size(50, 25);
            this.rd_lb.Text = "Reader";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bk_select_bar);
            this.panel1.Controls.Add(this.bk_data);
            this.panel1.Location = new System.Drawing.Point(13, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 254);
            this.panel1.TabIndex = 2;
            // 
            // bk_select_bar
            // 
            this.bk_select_bar.AutoSize = false;
            this.bk_select_bar.BackColor = System.Drawing.SystemColors.Control;
            this.bk_select_bar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bk_select_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bk_refresh,
            this.tsss0,
            this.bk_excute_btn,
            this.tsss1,
            this.bk_input,
            this.tsss2,
            this.bk_choose_btn,
            this.tsss3,
            this.bk_lb});
            this.bk_select_bar.Location = new System.Drawing.Point(0, 224);
            this.bk_select_bar.Name = "bk_select_bar";
            this.bk_select_bar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bk_select_bar.Size = new System.Drawing.Size(780, 28);
            this.bk_select_bar.TabIndex = 1;
            // 
            // bk_refresh
            // 
            this.bk_refresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bk_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bk_refresh.Image = global::BookManage.Properties.Resources.refresh;
            this.bk_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bk_refresh.Name = "bk_refresh";
            this.bk_refresh.Size = new System.Drawing.Size(23, 25);
            this.bk_refresh.Text = "refresh";
            this.bk_refresh.Click += new System.EventHandler(this.bk_refresh_Click);
            // 
            // tsss0
            // 
            this.tsss0.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsss0.Name = "tsss0";
            this.tsss0.Size = new System.Drawing.Size(6, 28);
            // 
            // bk_excute_btn
            // 
            this.bk_excute_btn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bk_excute_btn.AutoSize = false;
            this.bk_excute_btn.BackColor = System.Drawing.Color.LightCoral;
            this.bk_excute_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bk_excute_btn.Image = ((System.Drawing.Image)(resources.GetObject("bk_excute_btn.Image")));
            this.bk_excute_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bk_excute_btn.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.bk_excute_btn.Name = "bk_excute_btn";
            this.bk_excute_btn.Size = new System.Drawing.Size(100, 25);
            this.bk_excute_btn.Text = "Select";
            this.bk_excute_btn.Click += new System.EventHandler(this.bk_excute_btn_Click);
            // 
            // tsss1
            // 
            this.tsss1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsss1.Name = "tsss1";
            this.tsss1.Size = new System.Drawing.Size(6, 28);
            // 
            // bk_input
            // 
            this.bk_input.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bk_input.AutoSize = false;
            this.bk_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bk_input.Name = "bk_input";
            this.bk_input.Size = new System.Drawing.Size(400, 23);
            // 
            // tsss2
            // 
            this.tsss2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsss2.Name = "tsss2";
            this.tsss2.Size = new System.Drawing.Size(6, 28);
            // 
            // bk_choose_btn
            // 
            this.bk_choose_btn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bk_choose_btn.AutoSize = false;
            this.bk_choose_btn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bk_choose_btn.Items.AddRange(new object[] {
            "bkID",
            "bkCode",
            "bkName",
            "bkAuthor",
            "bkPress",
            "bkDatePress",
            "bkLanguage",
            "bkPages",
            "bkPrice",
            "bkDateIn",
            "bkBrief",
            "bkStatus",
            "bkCover"});
            this.bk_choose_btn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
            this.bk_choose_btn.Name = "bk_choose_btn";
            this.bk_choose_btn.Size = new System.Drawing.Size(150, 25);
            // 
            // tsss3
            // 
            this.tsss3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsss3.Name = "tsss3";
            this.tsss3.Size = new System.Drawing.Size(6, 28);
            // 
            // bk_lb
            // 
            this.bk_lb.Name = "bk_lb";
            this.bk_lb.Size = new System.Drawing.Size(39, 25);
            this.bk_lb.Text = "Book";
            // 
            // bk_data
            // 
            this.bk_data.AllowUserToAddRows = false;
            this.bk_data.AllowUserToDeleteRows = false;
            this.bk_data.AllowUserToResizeColumns = false;
            this.bk_data.AllowUserToResizeRows = false;
            this.bk_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bk_data.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.bk_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bk_data.Dock = System.Windows.Forms.DockStyle.Top;
            this.bk_data.Location = new System.Drawing.Point(0, 0);
            this.bk_data.Name = "bk_data";
            this.bk_data.ReadOnly = true;
            this.bk_data.RowTemplate.Height = 23;
            this.bk_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bk_data.Size = new System.Drawing.Size(780, 221);
            this.bk_data.TabIndex = 0;
            this.bk_data.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bk_data_CellMouseClick);
            // 
            // p_borrow_message
            // 
            this.p_borrow_message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_borrow_message.Controls.Add(this.label1);
            this.p_borrow_message.Controls.Add(this.get_date);
            this.p_borrow_message.Controls.Add(this.tb_OperatorLend);
            this.p_borrow_message.Controls.Add(this.l_OperatorLend);
            this.p_borrow_message.Controls.Add(this.tb_ldDateOut);
            this.p_borrow_message.Controls.Add(this.tb_rdID);
            this.p_borrow_message.Controls.Add(this.l_ldDateOut);
            this.p_borrow_message.Controls.Add(this.l_rdID);
            this.p_borrow_message.Controls.Add(this.l_bkID);
            this.p_borrow_message.Controls.Add(this.tb_BorrowID);
            this.p_borrow_message.Controls.Add(this.l_BorrowID);
            this.p_borrow_message.Controls.Add(this.tb_bkID);
            this.p_borrow_message.Location = new System.Drawing.Point(818, 12);
            this.p_borrow_message.Name = "p_borrow_message";
            this.p_borrow_message.Size = new System.Drawing.Size(149, 222);
            this.p_borrow_message.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(77, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Borrow";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // get_date
            // 
            this.get_date.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_date.Location = new System.Drawing.Point(63, 117);
            this.get_date.Name = "get_date";
            this.get_date.Size = new System.Drawing.Size(70, 20);
            this.get_date.TabIndex = 12;
            this.get_date.Text = "Time";
            this.get_date.UseVisualStyleBackColor = true;
            this.get_date.Click += new System.EventHandler(this.get_date_Click);
            // 
            // tb_OperatorLend
            // 
            this.tb_OperatorLend.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_OperatorLend.Enabled = false;
            this.tb_OperatorLend.Location = new System.Drawing.Point(5, 176);
            this.tb_OperatorLend.Name = "tb_OperatorLend";
            this.tb_OperatorLend.ReadOnly = true;
            this.tb_OperatorLend.Size = new System.Drawing.Size(137, 21);
            this.tb_OperatorLend.TabIndex = 11;
            // 
            // l_OperatorLend
            // 
            this.l_OperatorLend.AutoSize = true;
            this.l_OperatorLend.Location = new System.Drawing.Point(3, 161);
            this.l_OperatorLend.Name = "l_OperatorLend";
            this.l_OperatorLend.Size = new System.Drawing.Size(65, 12);
            this.l_OperatorLend.TabIndex = 10;
            this.l_OperatorLend.Text = "借书操作员";
            // 
            // tb_ldDateOut
            // 
            this.tb_ldDateOut.Location = new System.Drawing.Point(3, 137);
            this.tb_ldDateOut.Name = "tb_ldDateOut";
            this.tb_ldDateOut.Size = new System.Drawing.Size(137, 21);
            this.tb_ldDateOut.TabIndex = 5;
            // 
            // tb_rdID
            // 
            this.tb_rdID.Location = new System.Drawing.Point(5, 57);
            this.tb_rdID.Name = "tb_rdID";
            this.tb_rdID.Size = new System.Drawing.Size(137, 21);
            this.tb_rdID.TabIndex = 1;
            // 
            // l_ldDateOut
            // 
            this.l_ldDateOut.AutoSize = true;
            this.l_ldDateOut.Location = new System.Drawing.Point(3, 121);
            this.l_ldDateOut.Name = "l_ldDateOut";
            this.l_ldDateOut.Size = new System.Drawing.Size(53, 12);
            this.l_ldDateOut.TabIndex = 4;
            this.l_ldDateOut.Text = "借出时间";
            // 
            // l_rdID
            // 
            this.l_rdID.AutoSize = true;
            this.l_rdID.Location = new System.Drawing.Point(3, 41);
            this.l_rdID.Name = "l_rdID";
            this.l_rdID.Size = new System.Drawing.Size(41, 12);
            this.l_rdID.TabIndex = 0;
            this.l_rdID.Text = "读者ID";
            // 
            // l_bkID
            // 
            this.l_bkID.AutoSize = true;
            this.l_bkID.Location = new System.Drawing.Point(3, 81);
            this.l_bkID.Name = "l_bkID";
            this.l_bkID.Size = new System.Drawing.Size(41, 12);
            this.l_bkID.TabIndex = 2;
            this.l_bkID.Text = "书本号";
            // 
            // tb_BorrowID
            // 
            this.tb_BorrowID.Location = new System.Drawing.Point(5, 17);
            this.tb_BorrowID.Name = "tb_BorrowID";
            this.tb_BorrowID.Size = new System.Drawing.Size(137, 21);
            this.tb_BorrowID.TabIndex = 7;
            this.tb_BorrowID.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tb_BorrowID_MouseDown);
            // 
            // l_BorrowID
            // 
            this.l_BorrowID.AutoSize = true;
            this.l_BorrowID.Location = new System.Drawing.Point(3, 1);
            this.l_BorrowID.Name = "l_BorrowID";
            this.l_BorrowID.Size = new System.Drawing.Size(41, 12);
            this.l_BorrowID.TabIndex = 6;
            this.l_BorrowID.Text = "借阅号";
            // 
            // tb_bkID
            // 
            this.tb_bkID.Location = new System.Drawing.Point(5, 97);
            this.tb_bkID.Name = "tb_bkID";
            this.tb_bkID.Size = new System.Drawing.Size(137, 21);
            this.tb_bkID.TabIndex = 3;
            // 
            // p_return_message
            // 
            this.p_return_message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_return_message.Controls.Add(this.label2);
            this.p_return_message.Controls.Add(this.get_date_b);
            this.p_return_message.Controls.Add(this.tb_OperatorRet);
            this.p_return_message.Controls.Add(this.l_OperatorRet);
            this.p_return_message.Controls.Add(this.tb_ldDateRetAct);
            this.p_return_message.Controls.Add(this.tb_rdID_b);
            this.p_return_message.Controls.Add(this.l_ldDateRetAct);
            this.p_return_message.Controls.Add(this.l_rdID_b);
            this.p_return_message.Controls.Add(this.l_bkID_b);
            this.p_return_message.Controls.Add(this.tb_BorrowID_b);
            this.p_return_message.Controls.Add(this.l_BorowID_b);
            this.p_return_message.Controls.Add(this.tb_bkID_b);
            this.p_return_message.Location = new System.Drawing.Point(818, 12);
            this.p_return_message.Name = "p_return_message";
            this.p_return_message.Size = new System.Drawing.Size(149, 222);
            this.p_return_message.TabIndex = 13;
            this.p_return_message.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(77, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Return";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // get_date_b
            // 
            this.get_date_b.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_date_b.Location = new System.Drawing.Point(63, 117);
            this.get_date_b.Name = "get_date_b";
            this.get_date_b.Size = new System.Drawing.Size(70, 20);
            this.get_date_b.TabIndex = 12;
            this.get_date_b.Text = "Time";
            this.get_date_b.UseVisualStyleBackColor = true;
            this.get_date_b.Click += new System.EventHandler(this.get_date_b_Click);
            // 
            // tb_OperatorRet
            // 
            this.tb_OperatorRet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_OperatorRet.Enabled = false;
            this.tb_OperatorRet.Location = new System.Drawing.Point(5, 176);
            this.tb_OperatorRet.Name = "tb_OperatorRet";
            this.tb_OperatorRet.ReadOnly = true;
            this.tb_OperatorRet.Size = new System.Drawing.Size(137, 21);
            this.tb_OperatorRet.TabIndex = 11;
            // 
            // l_OperatorRet
            // 
            this.l_OperatorRet.AutoSize = true;
            this.l_OperatorRet.Location = new System.Drawing.Point(3, 161);
            this.l_OperatorRet.Name = "l_OperatorRet";
            this.l_OperatorRet.Size = new System.Drawing.Size(65, 12);
            this.l_OperatorRet.TabIndex = 10;
            this.l_OperatorRet.Text = "还书操作员";
            // 
            // tb_ldDateRetAct
            // 
            this.tb_ldDateRetAct.Location = new System.Drawing.Point(3, 137);
            this.tb_ldDateRetAct.Name = "tb_ldDateRetAct";
            this.tb_ldDateRetAct.Size = new System.Drawing.Size(137, 21);
            this.tb_ldDateRetAct.TabIndex = 5;
            // 
            // tb_rdID_b
            // 
            this.tb_rdID_b.Location = new System.Drawing.Point(5, 57);
            this.tb_rdID_b.Name = "tb_rdID_b";
            this.tb_rdID_b.Size = new System.Drawing.Size(137, 21);
            this.tb_rdID_b.TabIndex = 1;
            // 
            // l_ldDateRetAct
            // 
            this.l_ldDateRetAct.AutoSize = true;
            this.l_ldDateRetAct.Location = new System.Drawing.Point(3, 121);
            this.l_ldDateRetAct.Name = "l_ldDateRetAct";
            this.l_ldDateRetAct.Size = new System.Drawing.Size(53, 12);
            this.l_ldDateRetAct.TabIndex = 4;
            this.l_ldDateRetAct.Text = "还书时间";
            // 
            // l_rdID_b
            // 
            this.l_rdID_b.AutoSize = true;
            this.l_rdID_b.Location = new System.Drawing.Point(3, 41);
            this.l_rdID_b.Name = "l_rdID_b";
            this.l_rdID_b.Size = new System.Drawing.Size(41, 12);
            this.l_rdID_b.TabIndex = 0;
            this.l_rdID_b.Text = "读者ID";
            // 
            // l_bkID_b
            // 
            this.l_bkID_b.AutoSize = true;
            this.l_bkID_b.Location = new System.Drawing.Point(3, 81);
            this.l_bkID_b.Name = "l_bkID_b";
            this.l_bkID_b.Size = new System.Drawing.Size(41, 12);
            this.l_bkID_b.TabIndex = 2;
            this.l_bkID_b.Text = "书本号";
            // 
            // tb_BorrowID_b
            // 
            this.tb_BorrowID_b.Location = new System.Drawing.Point(5, 17);
            this.tb_BorrowID_b.Name = "tb_BorrowID_b";
            this.tb_BorrowID_b.Size = new System.Drawing.Size(137, 21);
            this.tb_BorrowID_b.TabIndex = 7;
            // 
            // l_BorowID_b
            // 
            this.l_BorowID_b.AutoSize = true;
            this.l_BorowID_b.Location = new System.Drawing.Point(3, 1);
            this.l_BorowID_b.Name = "l_BorowID_b";
            this.l_BorowID_b.Size = new System.Drawing.Size(41, 12);
            this.l_BorowID_b.TabIndex = 6;
            this.l_BorowID_b.Text = "借阅号";
            // 
            // tb_bkID_b
            // 
            this.tb_bkID_b.Location = new System.Drawing.Point(5, 97);
            this.tb_bkID_b.Name = "tb_bkID_b";
            this.tb_bkID_b.Size = new System.Drawing.Size(137, 21);
            this.tb_bkID_b.TabIndex = 3;
            // 
            // rb_borrow_bk
            // 
            this.rb_borrow_bk.AutoSize = true;
            this.rb_borrow_bk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_borrow_bk.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rb_borrow_bk.Location = new System.Drawing.Point(818, 249);
            this.rb_borrow_bk.Name = "rb_borrow_bk";
            this.rb_borrow_bk.Size = new System.Drawing.Size(74, 16);
            this.rb_borrow_bk.TabIndex = 14;
            this.rb_borrow_bk.TabStop = true;
            this.rb_borrow_bk.Text = "借书信息";
            this.rb_borrow_bk.UseVisualStyleBackColor = true;
            this.rb_borrow_bk.CheckedChanged += new System.EventHandler(this.rb_borrow_bk_CheckedChanged);
            // 
            // rb_return_bk
            // 
            this.rb_return_bk.AutoSize = true;
            this.rb_return_bk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_return_bk.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rb_return_bk.Location = new System.Drawing.Point(896, 249);
            this.rb_return_bk.Name = "rb_return_bk";
            this.rb_return_bk.Size = new System.Drawing.Size(74, 16);
            this.rb_return_bk.TabIndex = 15;
            this.rb_return_bk.TabStop = true;
            this.rb_return_bk.Text = "还书信息";
            this.rb_return_bk.UseVisualStyleBackColor = true;
            this.rb_return_bk.CheckedChanged += new System.EventHandler(this.rb_return_bk_CheckedChanged);
            // 
            // p_controlbox
            // 
            this.p_controlbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_controlbox.Controls.Add(this.return_btn);
            this.p_controlbox.Controls.Add(this.button1);
            this.p_controlbox.Controls.Add(this.borrow_btn);
            this.p_controlbox.Location = new System.Drawing.Point(818, 268);
            this.p_controlbox.Name = "p_controlbox";
            this.p_controlbox.Size = new System.Drawing.Size(332, 254);
            this.p_controlbox.TabIndex = 16;
            // 
            // borrow_btn
            // 
            this.borrow_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.borrow_btn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.borrow_btn.Location = new System.Drawing.Point(15, 198);
            this.borrow_btn.Name = "borrow_btn";
            this.borrow_btn.Size = new System.Drawing.Size(75, 23);
            this.borrow_btn.TabIndex = 2;
            this.borrow_btn.Text = "借书";
            this.borrow_btn.UseVisualStyleBackColor = true;
            this.borrow_btn.Click += new System.EventHandler(this.borrow_btn_Click);
            // 
            // return_btn
            // 
            this.return_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.return_btn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.return_btn.Location = new System.Drawing.Point(96, 198);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(75, 23);
            this.return_btn.TabIndex = 1;
            this.return_btn.Text = "还书";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(177, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "续期";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // borrow_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 537);
            this.Controls.Add(this.p_controlbox);
            this.Controls.Add(this.rb_return_bk);
            this.Controls.Add(this.rb_borrow_bk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rd_panel);
            this.Controls.Add(this.p_borrow_message);
            this.Controls.Add(this.p_return_message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "borrow_frm";
            this.Text = "borrow_frm";
            ((System.ComponentModel.ISupportInitialize)(this.rd_data)).EndInit();
            this.rd_panel.ResumeLayout(false);
            this.rd_select_bar.ResumeLayout(false);
            this.rd_select_bar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.bk_select_bar.ResumeLayout(false);
            this.bk_select_bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bk_data)).EndInit();
            this.p_borrow_message.ResumeLayout(false);
            this.p_borrow_message.PerformLayout();
            this.p_return_message.ResumeLayout(false);
            this.p_return_message.PerformLayout();
            this.p_controlbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rd_data;
        private System.Windows.Forms.Panel rd_panel;
        private System.Windows.Forms.ToolStrip rd_select_bar;
        private System.Windows.Forms.ToolStripTextBox rd_input;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripComboBox rd_choose_btn;
        private System.Windows.Forms.ToolStripSeparator tss2;
        private System.Windows.Forms.ToolStripSeparator tss3;
        private System.Windows.Forms.ToolStripButton rd_excute_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip bk_select_bar;
        private System.Windows.Forms.ToolStripButton bk_excute_btn;
        private System.Windows.Forms.ToolStripSeparator tsss1;
        private System.Windows.Forms.ToolStripTextBox bk_input;
        private System.Windows.Forms.ToolStripSeparator tsss2;
        private System.Windows.Forms.ToolStripComboBox bk_choose_btn;
        private System.Windows.Forms.ToolStripSeparator tsss3;
        private System.Windows.Forms.DataGridView bk_data;
        private System.Windows.Forms.ToolStripLabel rd_lb;
        private System.Windows.Forms.ToolStripLabel bk_lb;
        private System.Windows.Forms.Panel p_borrow_message;
        private System.Windows.Forms.TextBox tb_OperatorLend;
        private System.Windows.Forms.Label l_OperatorLend;
        private System.Windows.Forms.TextBox tb_BorrowID;
        private System.Windows.Forms.Label l_BorrowID;
        private System.Windows.Forms.TextBox tb_ldDateOut;
        private System.Windows.Forms.Label l_ldDateOut;
        private System.Windows.Forms.TextBox tb_bkID;
        private System.Windows.Forms.Label l_bkID;
        private System.Windows.Forms.TextBox tb_rdID;
        private System.Windows.Forms.Label l_rdID;
        private System.Windows.Forms.ToolStripButton rd_refresh;
        private System.Windows.Forms.ToolStripSeparator tss0;
        private System.Windows.Forms.ToolStripButton bk_refresh;
        private System.Windows.Forms.ToolStripSeparator tsss0;
        private System.Windows.Forms.Button get_date;
        private System.Windows.Forms.Panel p_return_message;
        private System.Windows.Forms.Button get_date_b;
        private System.Windows.Forms.TextBox tb_OperatorRet;
        private System.Windows.Forms.Label l_OperatorRet;
        private System.Windows.Forms.TextBox tb_ldDateRetAct;
        private System.Windows.Forms.TextBox tb_rdID_b;
        private System.Windows.Forms.Label l_ldDateRetAct;
        private System.Windows.Forms.Label l_rdID_b;
        private System.Windows.Forms.Label l_bkID_b;
        private System.Windows.Forms.TextBox tb_BorrowID_b;
        private System.Windows.Forms.Label l_BorowID_b;
        private System.Windows.Forms.TextBox tb_bkID_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_borrow_bk;
        private System.Windows.Forms.RadioButton rb_return_bk;
        private System.Windows.Forms.Panel p_controlbox;
        private System.Windows.Forms.Button borrow_btn;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Button button1;
    }
}