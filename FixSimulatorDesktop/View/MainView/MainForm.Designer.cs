namespace FixSimulatorDesktop
{
    partial class MainForm
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
            GroupBox1 = new GroupBox();
            groupBox7 = new GroupBox();
            InitiatorNewOrderSingleBtn = new Button();
            InitiatorShowSentChb = new CheckBox();
            InitiatorOrderCancelBtn = new Button();
            InitiatorShowReceivedChb = new CheckBox();
            InitiatorOrderReplaceBtn = new Button();
            InitiatorNewOrderSingleFastBtn = new Button();
            InitiatorLogGroup = new GroupBox();
            InitiatorLogRTxt = new RichTextBox();
            GroupBox2 = new GroupBox();
            groupBox8 = new GroupBox();
            AcceptorShowSentChb = new CheckBox();
            ExecutionReportFilledBtn = new Button();
            AcceptorShowReceivedChb = new CheckBox();
            ExecutionReportNewBtn = new Button();
            AcceptorLogGroup = new GroupBox();
            AcceptorLogRTxt = new RichTextBox();
            AcceptorMacros = new GroupBox();
            AcceptorIntervalTxt = new TextBox();
            label7 = new Label();
            AcceptorMacrosClb = new CheckedListBox();
            GroupBox3 = new GroupBox();
            MessagesDg = new DataGridView();
            Time = new DataGridViewTextBoxColumn();
            Direction = new DataGridViewTextBoxColumn();
            MsgType = new DataGridViewTextBoxColumn();
            Symbol = new DataGridViewTextBoxColumn();
            Side = new DataGridViewTextBoxColumn();
            ExecType = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            OrdQty = new DataGridViewTextBoxColumn();
            CumQty = new DataGridViewTextBoxColumn();
            ClOrderId = new DataGridViewTextBoxColumn();
            OrigClOrderId = new DataGridViewTextBoxColumn();
            FixMsg = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            acceptorToolStripMenuItem = new ToolStripMenuItem();
            InitiatorStartToolStripMenuItem = new ToolStripMenuItem();
            InitiatorClearLogToolStripMenuItem = new ToolStripMenuItem();
            InitiatorCleanStoreToolStripMenuItem = new ToolStripMenuItem();
            InitiatorFixConfigToolStripMenuItem = new ToolStripMenuItem();
            acceptorToolStripMenuItem1 = new ToolStripMenuItem();
            AcceptorStartToolStripMenuItem = new ToolStripMenuItem();
            AcceptorClearLogToolStripMenuItem = new ToolStripMenuItem();
            AcceptorClearStoreToolStripMenuItem1 = new ToolStripMenuItem();
            AcceptorFixConfigToolStripMenuItem1 = new ToolStripMenuItem();
            mensagensToolStripMenuItem = new ToolStripMenuItem();
            ClearMessageListToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            InitiatorStatus = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            AcceptorStatus = new ToolStripStatusLabel();
            label1 = new Label();
            GroupBox1.SuspendLayout();
            groupBox7.SuspendLayout();
            InitiatorLogGroup.SuspendLayout();
            GroupBox2.SuspendLayout();
            groupBox8.SuspendLayout();
            AcceptorLogGroup.SuspendLayout();
            AcceptorMacros.SuspendLayout();
            GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MessagesDg).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox1
            // 
            GroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            GroupBox1.Controls.Add(groupBox7);
            GroupBox1.Controls.Add(InitiatorLogGroup);
            GroupBox1.Location = new Point(12, 34);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(881, 448);
            GroupBox1.TabIndex = 0;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Initiator";
            // 
            // groupBox7
            // 
            groupBox7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox7.Controls.Add(InitiatorNewOrderSingleBtn);
            groupBox7.Controls.Add(InitiatorShowSentChb);
            groupBox7.Controls.Add(InitiatorOrderCancelBtn);
            groupBox7.Controls.Add(InitiatorShowReceivedChb);
            groupBox7.Controls.Add(InitiatorOrderReplaceBtn);
            groupBox7.Controls.Add(InitiatorNewOrderSingleFastBtn);
            groupBox7.Location = new Point(12, 22);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(863, 86);
            groupBox7.TabIndex = 10;
            groupBox7.TabStop = false;
            groupBox7.Text = "Mensagens";
            // 
            // InitiatorNewOrderSingleBtn
            // 
            InitiatorNewOrderSingleBtn.AutoSize = true;
            InitiatorNewOrderSingleBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            InitiatorNewOrderSingleBtn.Location = new Point(211, 46);
            InitiatorNewOrderSingleBtn.Name = "InitiatorNewOrderSingleBtn";
            InitiatorNewOrderSingleBtn.Padding = new Padding(10, 0, 10, 0);
            InitiatorNewOrderSingleBtn.Size = new Size(123, 25);
            InitiatorNewOrderSingleBtn.TabIndex = 4;
            InitiatorNewOrderSingleBtn.Text = "NewOrderSingle";
            InitiatorNewOrderSingleBtn.UseVisualStyleBackColor = true;
            InitiatorNewOrderSingleBtn.Click += InitiatorNewOrderSingleBtn_Click;
            // 
            // InitiatorShowSentChb
            // 
            InitiatorShowSentChb.AutoSize = true;
            InitiatorShowSentChb.Location = new Point(154, 21);
            InitiatorShowSentChb.Name = "InitiatorShowSentChb";
            InitiatorShowSentChb.Size = new Size(104, 19);
            InitiatorShowSentChb.TabIndex = 1;
            InitiatorShowSentChb.Text = "Exibir enviadas";
            InitiatorShowSentChb.UseVisualStyleBackColor = true;
            InitiatorShowSentChb.CheckedChanged += InitiatorShowSentChb_CheckedChanged;
            // 
            // InitiatorOrderCancelBtn
            // 
            InitiatorOrderCancelBtn.AutoSize = true;
            InitiatorOrderCancelBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            InitiatorOrderCancelBtn.Location = new Point(470, 46);
            InitiatorOrderCancelBtn.Name = "InitiatorOrderCancelBtn";
            InitiatorOrderCancelBtn.Padding = new Padding(10, 0, 10, 0);
            InitiatorOrderCancelBtn.Size = new Size(73, 25);
            InitiatorOrderCancelBtn.TabIndex = 3;
            InitiatorOrderCancelBtn.Text = "Cancel";
            InitiatorOrderCancelBtn.UseVisualStyleBackColor = true;
            InitiatorOrderCancelBtn.Click += InitiatorOrderCancelBtn_Click;
            // 
            // InitiatorShowReceivedChb
            // 
            InitiatorShowReceivedChb.AutoSize = true;
            InitiatorShowReceivedChb.Checked = true;
            InitiatorShowReceivedChb.CheckState = CheckState.Checked;
            InitiatorShowReceivedChb.Location = new Point(11, 21);
            InitiatorShowReceivedChb.Name = "InitiatorShowReceivedChb";
            InitiatorShowReceivedChb.Size = new Size(108, 19);
            InitiatorShowReceivedChb.TabIndex = 0;
            InitiatorShowReceivedChb.Text = "Exibir recebidas";
            InitiatorShowReceivedChb.UseVisualStyleBackColor = true;
            InitiatorShowReceivedChb.CheckedChanged += InitiatorShowReceivedChb_CheckedChanged;
            // 
            // InitiatorOrderReplaceBtn
            // 
            InitiatorOrderReplaceBtn.AutoSize = true;
            InitiatorOrderReplaceBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            InitiatorOrderReplaceBtn.Location = new Point(364, 46);
            InitiatorOrderReplaceBtn.Name = "InitiatorOrderReplaceBtn";
            InitiatorOrderReplaceBtn.Padding = new Padding(10, 0, 10, 0);
            InitiatorOrderReplaceBtn.Size = new Size(78, 25);
            InitiatorOrderReplaceBtn.TabIndex = 2;
            InitiatorOrderReplaceBtn.Text = "Replace";
            InitiatorOrderReplaceBtn.UseVisualStyleBackColor = true;
            InitiatorOrderReplaceBtn.Click += InitiatorOrderReplaceBtn_Click;
            // 
            // InitiatorNewOrderSingleFastBtn
            // 
            InitiatorNewOrderSingleFastBtn.AutoSize = true;
            InitiatorNewOrderSingleFastBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            InitiatorNewOrderSingleFastBtn.Location = new Point(11, 46);
            InitiatorNewOrderSingleFastBtn.Name = "InitiatorNewOrderSingleFastBtn";
            InitiatorNewOrderSingleFastBtn.Padding = new Padding(10, 0, 10, 0);
            InitiatorNewOrderSingleFastBtn.Size = new Size(170, 25);
            InitiatorNewOrderSingleFastBtn.TabIndex = 1;
            InitiatorNewOrderSingleFastBtn.Text = "NewOrderSingle - Rápida";
            InitiatorNewOrderSingleFastBtn.UseVisualStyleBackColor = true;
            InitiatorNewOrderSingleFastBtn.Click += InitiatorNewOrderSingleFastBtn_Click;
            // 
            // InitiatorLogGroup
            // 
            InitiatorLogGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InitiatorLogGroup.Controls.Add(InitiatorLogRTxt);
            InitiatorLogGroup.Location = new Point(12, 114);
            InitiatorLogGroup.Name = "InitiatorLogGroup";
            InitiatorLogGroup.Size = new Size(863, 328);
            InitiatorLogGroup.TabIndex = 6;
            InitiatorLogGroup.TabStop = false;
            InitiatorLogGroup.Text = "Log";
            // 
            // InitiatorLogRTxt
            // 
            InitiatorLogRTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InitiatorLogRTxt.Location = new Point(6, 22);
            InitiatorLogRTxt.Name = "InitiatorLogRTxt";
            InitiatorLogRTxt.ReadOnly = true;
            InitiatorLogRTxt.Size = new Size(851, 300);
            InitiatorLogRTxt.TabIndex = 5;
            InitiatorLogRTxt.Text = "";
            InitiatorLogRTxt.DoubleClick += InitiatorLogRTxt_DoubleClick;
            // 
            // GroupBox2
            // 
            GroupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupBox2.Controls.Add(groupBox8);
            GroupBox2.Controls.Add(AcceptorLogGroup);
            GroupBox2.Controls.Add(AcceptorMacros);
            GroupBox2.Location = new Point(899, 34);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(860, 448);
            GroupBox2.TabIndex = 1;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Acceptor";
            // 
            // groupBox8
            // 
            groupBox8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox8.Controls.Add(AcceptorShowSentChb);
            groupBox8.Controls.Add(ExecutionReportFilledBtn);
            groupBox8.Controls.Add(AcceptorShowReceivedChb);
            groupBox8.Controls.Add(ExecutionReportNewBtn);
            groupBox8.Location = new Point(6, 22);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(842, 86);
            groupBox8.TabIndex = 13;
            groupBox8.TabStop = false;
            groupBox8.Text = "Mensagens";
            // 
            // AcceptorShowSentChb
            // 
            AcceptorShowSentChb.AutoSize = true;
            AcceptorShowSentChb.Location = new Point(149, 21);
            AcceptorShowSentChb.Name = "AcceptorShowSentChb";
            AcceptorShowSentChb.Size = new Size(104, 19);
            AcceptorShowSentChb.TabIndex = 1;
            AcceptorShowSentChb.Text = "Exibir enviadas";
            AcceptorShowSentChb.UseVisualStyleBackColor = true;
            AcceptorShowSentChb.CheckedChanged += AcceptorShowSentChb_CheckedChanged;
            // 
            // ExecutionReportFilledBtn
            // 
            ExecutionReportFilledBtn.AutoSize = true;
            ExecutionReportFilledBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ExecutionReportFilledBtn.Location = new Point(202, 48);
            ExecutionReportFilledBtn.Name = "ExecutionReportFilledBtn";
            ExecutionReportFilledBtn.Padding = new Padding(10, 0, 10, 0);
            ExecutionReportFilledBtn.Size = new Size(163, 25);
            ExecutionReportFilledBtn.TabIndex = 11;
            ExecutionReportFilledBtn.Text = "ExecutionReport - Filled";
            ExecutionReportFilledBtn.UseVisualStyleBackColor = true;
            ExecutionReportFilledBtn.Click += ExecutionReportFilledBtn_Click;
            // 
            // AcceptorShowReceivedChb
            // 
            AcceptorShowReceivedChb.AutoSize = true;
            AcceptorShowReceivedChb.Checked = true;
            AcceptorShowReceivedChb.CheckState = CheckState.Checked;
            AcceptorShowReceivedChb.Location = new Point(11, 21);
            AcceptorShowReceivedChb.Name = "AcceptorShowReceivedChb";
            AcceptorShowReceivedChb.Size = new Size(108, 19);
            AcceptorShowReceivedChb.TabIndex = 0;
            AcceptorShowReceivedChb.Text = "Exibir recebidas";
            AcceptorShowReceivedChb.UseVisualStyleBackColor = true;
            AcceptorShowReceivedChb.CheckedChanged += AcceptorShowReceivedChb_CheckedChanged;
            // 
            // ExecutionReportNewBtn
            // 
            ExecutionReportNewBtn.AutoSize = true;
            ExecutionReportNewBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ExecutionReportNewBtn.Location = new Point(11, 48);
            ExecutionReportNewBtn.Name = "ExecutionReportNewBtn";
            ExecutionReportNewBtn.Padding = new Padding(10, 0, 10, 0);
            ExecutionReportNewBtn.Size = new Size(159, 25);
            ExecutionReportNewBtn.TabIndex = 10;
            ExecutionReportNewBtn.Text = "ExecutionReport - New";
            ExecutionReportNewBtn.UseVisualStyleBackColor = true;
            ExecutionReportNewBtn.Click += ExecutionReportBtn_Click;
            // 
            // AcceptorLogGroup
            // 
            AcceptorLogGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AcceptorLogGroup.Controls.Add(AcceptorLogRTxt);
            AcceptorLogGroup.Location = new Point(6, 114);
            AcceptorLogGroup.Name = "AcceptorLogGroup";
            AcceptorLogGroup.Size = new Size(442, 328);
            AcceptorLogGroup.TabIndex = 7;
            AcceptorLogGroup.TabStop = false;
            AcceptorLogGroup.Text = "Log";
            // 
            // AcceptorLogRTxt
            // 
            AcceptorLogRTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AcceptorLogRTxt.Location = new Point(6, 22);
            AcceptorLogRTxt.Name = "AcceptorLogRTxt";
            AcceptorLogRTxt.ReadOnly = true;
            AcceptorLogRTxt.Size = new Size(430, 300);
            AcceptorLogRTxt.TabIndex = 6;
            AcceptorLogRTxt.Text = "";
            AcceptorLogRTxt.DoubleClick += AcceptorLogRTxt_DoubleClick;
            // 
            // AcceptorMacros
            // 
            AcceptorMacros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            AcceptorMacros.Controls.Add(AcceptorIntervalTxt);
            AcceptorMacros.Controls.Add(label7);
            AcceptorMacros.Controls.Add(AcceptorMacrosClb);
            AcceptorMacros.Location = new Point(454, 114);
            AcceptorMacros.Name = "AcceptorMacros";
            AcceptorMacros.Size = new Size(400, 328);
            AcceptorMacros.TabIndex = 3;
            AcceptorMacros.TabStop = false;
            AcceptorMacros.Text = "Macros";
            // 
            // AcceptorIntervalTxt
            // 
            AcceptorIntervalTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AcceptorIntervalTxt.Location = new Point(345, 22);
            AcceptorIntervalTxt.MaxLength = 10;
            AcceptorIntervalTxt.Name = "AcceptorIntervalTxt";
            AcceptorIntervalTxt.Size = new Size(49, 23);
            AcceptorIntervalTxt.TabIndex = 4;
            AcceptorIntervalTxt.TextChanged += AcceptorIntervalTxt_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(256, 25);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 3;
            label7.Text = "Intervalo (ms):";
            // 
            // AcceptorMacrosClb
            // 
            AcceptorMacrosClb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AcceptorMacrosClb.CheckOnClick = true;
            AcceptorMacrosClb.FormattingEnabled = true;
            AcceptorMacrosClb.Items.AddRange(new object[] { "ExecutionReport - New", "ExecutionReport - Filled", "ExecutionReport - Partially Filled (25%) Único", "ExecutionReport - Partially Filled (25%) A cada intervalo, até 100%", "ExecutionReport - Replaced", "ExecutionReport - Replace Rejection", "ExecutionReport - Canceled", "ExecutionReport - Cancel Rejection" });
            AcceptorMacrosClb.Location = new Point(6, 48);
            AcceptorMacrosClb.Name = "AcceptorMacrosClb";
            AcceptorMacrosClb.ScrollAlwaysVisible = true;
            AcceptorMacrosClb.Size = new Size(388, 274);
            AcceptorMacrosClb.TabIndex = 2;
            AcceptorMacrosClb.ItemCheck += AcceptorMacrosClb_ItemCheck;
            // 
            // GroupBox3
            // 
            GroupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupBox3.AutoSize = true;
            GroupBox3.Controls.Add(MessagesDg);
            GroupBox3.Location = new Point(12, 488);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Size = new Size(1748, 345);
            GroupBox3.TabIndex = 1;
            GroupBox3.TabStop = false;
            GroupBox3.Text = "Mensagens";
            // 
            // MessagesDg
            // 
            MessagesDg.AllowUserToAddRows = false;
            MessagesDg.AllowUserToDeleteRows = false;
            MessagesDg.AllowUserToOrderColumns = true;
            MessagesDg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MessagesDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MessagesDg.Columns.AddRange(new DataGridViewColumn[] { Time, Direction, MsgType, Symbol, Side, ExecType, Status, OrdQty, CumQty, ClOrderId, OrigClOrderId, FixMsg });
            MessagesDg.Location = new Point(6, 22);
            MessagesDg.Name = "MessagesDg";
            MessagesDg.ReadOnly = true;
            MessagesDg.RowTemplate.Height = 25;
            MessagesDg.ShowEditingIcon = false;
            MessagesDg.Size = new Size(1736, 316);
            MessagesDg.TabIndex = 2;
            MessagesDg.CellDoubleClick += MessagesDg_CellDoubleClick;
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.Name = "Time";
            Time.ReadOnly = true;
            // 
            // Direction
            // 
            Direction.HeaderText = "Direction";
            Direction.Name = "Direction";
            Direction.ReadOnly = true;
            // 
            // MsgType
            // 
            MsgType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MsgType.HeaderText = "MsgType";
            MsgType.Name = "MsgType";
            MsgType.ReadOnly = true;
            MsgType.Width = 79;
            // 
            // Symbol
            // 
            Symbol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Symbol.HeaderText = "Symbol";
            Symbol.Name = "Symbol";
            Symbol.ReadOnly = true;
            Symbol.Width = 72;
            // 
            // Side
            // 
            Side.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Side.HeaderText = "Side";
            Side.Name = "Side";
            Side.ReadOnly = true;
            Side.Width = 54;
            // 
            // ExecType
            // 
            ExecType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ExecType.HeaderText = "ExecType";
            ExecType.Name = "ExecType";
            ExecType.ReadOnly = true;
            ExecType.Width = 80;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 64;
            // 
            // OrdQty
            // 
            OrdQty.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrdQty.HeaderText = "OrdQty";
            OrdQty.Name = "OrdQty";
            OrdQty.ReadOnly = true;
            OrdQty.Width = 71;
            // 
            // CumQty
            // 
            CumQty.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CumQty.HeaderText = "CumQty";
            CumQty.Name = "CumQty";
            CumQty.ReadOnly = true;
            CumQty.Width = 77;
            // 
            // ClOrderId
            // 
            ClOrderId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ClOrderId.HeaderText = "ClOrderId";
            ClOrderId.Name = "ClOrderId";
            ClOrderId.ReadOnly = true;
            ClOrderId.Width = 83;
            // 
            // OrigClOrderId
            // 
            OrigClOrderId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrigClOrderId.HeaderText = "OrigClOrderId";
            OrigClOrderId.Name = "OrigClOrderId";
            OrigClOrderId.ReadOnly = true;
            OrigClOrderId.Width = 106;
            // 
            // FixMsg
            // 
            FixMsg.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FixMsg.HeaderText = "FixMsg";
            FixMsg.MinimumWidth = 1500;
            FixMsg.Name = "FixMsg";
            FixMsg.ReadOnly = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { acceptorToolStripMenuItem, acceptorToolStripMenuItem1, mensagensToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1771, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // acceptorToolStripMenuItem
            // 
            acceptorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { InitiatorStartToolStripMenuItem, InitiatorClearLogToolStripMenuItem, InitiatorCleanStoreToolStripMenuItem, InitiatorFixConfigToolStripMenuItem });
            acceptorToolStripMenuItem.Name = "acceptorToolStripMenuItem";
            acceptorToolStripMenuItem.Size = new Size(60, 20);
            acceptorToolStripMenuItem.Text = "Initiator";
            // 
            // InitiatorStartToolStripMenuItem
            // 
            InitiatorStartToolStripMenuItem.Name = "InitiatorStartToolStripMenuItem";
            InitiatorStartToolStripMenuItem.Size = new Size(169, 22);
            InitiatorStartToolStripMenuItem.Text = "Iniciar";
            InitiatorStartToolStripMenuItem.Click += InitiatorStartToolStripMenuItem_Click;
            // 
            // InitiatorClearLogToolStripMenuItem
            // 
            InitiatorClearLogToolStripMenuItem.Name = "InitiatorClearLogToolStripMenuItem";
            InitiatorClearLogToolStripMenuItem.Size = new Size(169, 22);
            InitiatorClearLogToolStripMenuItem.Text = "Limpar log";
            InitiatorClearLogToolStripMenuItem.Click += ClearLogToolStripMenuItem_Click;
            // 
            // InitiatorCleanStoreToolStripMenuItem
            // 
            InitiatorCleanStoreToolStripMenuItem.Name = "InitiatorCleanStoreToolStripMenuItem";
            InitiatorCleanStoreToolStripMenuItem.Size = new Size(169, 22);
            InitiatorCleanStoreToolStripMenuItem.Text = "Limpar store";
            InitiatorCleanStoreToolStripMenuItem.Click += InitiatorCleanStoreToolStripMenuItem_Click;
            // 
            // InitiatorFixConfigToolStripMenuItem
            // 
            InitiatorFixConfigToolStripMenuItem.Name = "InitiatorFixConfigToolStripMenuItem";
            InitiatorFixConfigToolStripMenuItem.Size = new Size(169, 22);
            InitiatorFixConfigToolStripMenuItem.Text = "Configurações Fix";
            InitiatorFixConfigToolStripMenuItem.Click += InitiatorFixConfigToolStripMenuItem_Click;
            // 
            // acceptorToolStripMenuItem1
            // 
            acceptorToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { AcceptorStartToolStripMenuItem, AcceptorClearLogToolStripMenuItem, AcceptorClearStoreToolStripMenuItem1, AcceptorFixConfigToolStripMenuItem1 });
            acceptorToolStripMenuItem1.Name = "acceptorToolStripMenuItem1";
            acceptorToolStripMenuItem1.Size = new Size(67, 20);
            acceptorToolStripMenuItem1.Text = "Acceptor";
            // 
            // AcceptorStartToolStripMenuItem
            // 
            AcceptorStartToolStripMenuItem.Name = "AcceptorStartToolStripMenuItem";
            AcceptorStartToolStripMenuItem.Size = new Size(169, 22);
            AcceptorStartToolStripMenuItem.Text = "Iniciar";
            AcceptorStartToolStripMenuItem.Click += AcceptorStartToolStripMenuItem_Click;
            // 
            // AcceptorClearLogToolStripMenuItem
            // 
            AcceptorClearLogToolStripMenuItem.Name = "AcceptorClearLogToolStripMenuItem";
            AcceptorClearLogToolStripMenuItem.Size = new Size(169, 22);
            AcceptorClearLogToolStripMenuItem.Text = "Limpar log";
            AcceptorClearLogToolStripMenuItem.Click += AcceptorClearLogToolStripMenuItem_Click;
            // 
            // AcceptorClearStoreToolStripMenuItem1
            // 
            AcceptorClearStoreToolStripMenuItem1.Name = "AcceptorClearStoreToolStripMenuItem1";
            AcceptorClearStoreToolStripMenuItem1.Size = new Size(169, 22);
            AcceptorClearStoreToolStripMenuItem1.Text = "Limpar store";
            AcceptorClearStoreToolStripMenuItem1.Click += AcceptorClearStoreToolStripMenuItem1_Click;
            // 
            // AcceptorFixConfigToolStripMenuItem1
            // 
            AcceptorFixConfigToolStripMenuItem1.Name = "AcceptorFixConfigToolStripMenuItem1";
            AcceptorFixConfigToolStripMenuItem1.Size = new Size(169, 22);
            AcceptorFixConfigToolStripMenuItem1.Text = "Configurações Fix";
            AcceptorFixConfigToolStripMenuItem1.Click += AcceptorFixConfigToolStripMenuItem1_Click;
            // 
            // mensagensToolStripMenuItem
            // 
            mensagensToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ClearMessageListToolStripMenuItem });
            mensagensToolStripMenuItem.Name = "mensagensToolStripMenuItem";
            mensagensToolStripMenuItem.Size = new Size(79, 20);
            mensagensToolStripMenuItem.Text = "Mensagens";
            // 
            // ClearMessageListToolStripMenuItem
            // 
            ClearMessageListToolStripMenuItem.Name = "ClearMessageListToolStripMenuItem";
            ClearMessageListToolStripMenuItem.Size = new Size(135, 22);
            ClearMessageListToolStripMenuItem.Text = "Limpar lista";
            ClearMessageListToolStripMenuItem.Click += ClearMessageListToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { InitiatorStatus, toolStripStatusLabel1, AcceptorStatus });
            statusStrip1.Location = new Point(0, 836);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1771, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // InitiatorStatus
            // 
            InitiatorStatus.Name = "InitiatorStatus";
            InitiatorStatus.Size = new Size(91, 17);
            InitiatorStatus.Text = "Initiator: Parado";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(16, 17);
            toolStripStatusLabel1.Text = " | ";
            // 
            // AcceptorStatus
            // 
            AcceptorStatus.Name = "AcceptorStatus";
            AcceptorStatus.Size = new Size(98, 17);
            AcceptorStatus.Text = "Acceptor: Parado";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(1, 24);
            label1.Name = "label1";
            label1.Size = new Size(1769, 2);
            label1.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1771, 858);
            Controls.Add(label1);
            Controls.Add(statusStrip1);
            Controls.Add(GroupBox3);
            Controls.Add(GroupBox2);
            Controls.Add(GroupBox1);
            Controls.Add(menuStrip1);
            ImeMode = ImeMode.Disable;
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FixSimulatorDesktop";
            FormClosing += MainForm_FormClosing;
            KeyDown += MainForm_KeyDown;
            GroupBox1.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            InitiatorLogGroup.ResumeLayout(false);
            GroupBox2.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            AcceptorLogGroup.ResumeLayout(false);
            AcceptorMacros.ResumeLayout(false);
            AcceptorMacros.PerformLayout();
            GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MessagesDg).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GroupBox1;
        private GroupBox GroupBox2;
        private GroupBox GroupBox3;
        private CheckedListBox AcceptorMacrosClb;
        private GroupBox AcceptorMacros;
        private Button InitiatorOrderCancelBtn;
        private Button InitiatorOrderReplaceBtn;
        private Button InitiatorNewOrderSingleFastBtn;
        private GroupBox InitiatorLogGroup;
        private GroupBox AcceptorLogGroup;
        private DataGridView MessagesDg;
        private Button ExecutionReportNewBtn;
        private Button ExecutionReportFilledBtn;
        private GroupBox groupBox7;
        private CheckBox InitiatorShowSentChb;
        private CheckBox InitiatorShowReceivedChb;
        private GroupBox groupBox8;
        private CheckBox AcceptorShowSentChb;
        private CheckBox AcceptorShowReceivedChb;
        private TextBox AcceptorIntervalTxt;
        private Label label7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem acceptorToolStripMenuItem;
        private ToolStripMenuItem InitiatorCleanStoreToolStripMenuItem;
        private ToolStripMenuItem InitiatorFixConfigToolStripMenuItem;
        private ToolStripMenuItem acceptorToolStripMenuItem1;
        private ToolStripMenuItem AcceptorClearStoreToolStripMenuItem1;
        private ToolStripMenuItem AcceptorFixConfigToolStripMenuItem1;
        private ToolStripMenuItem mensagensToolStripMenuItem;
        private ToolStripMenuItem ClearMessageListToolStripMenuItem;
        private ToolStripMenuItem InitiatorClearLogToolStripMenuItem;
        private ToolStripMenuItem AcceptorClearLogToolStripMenuItem;
        private Button InitiatorNewOrderSingleBtn;
        private ToolStripMenuItem InitiatorStartToolStripMenuItem;
        private ToolStripMenuItem AcceptorStartToolStripMenuItem;
        private RichTextBox InitiatorLogRTxt;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel InitiatorStatus;
        private ToolStripStatusLabel AcceptorStatus;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private RichTextBox AcceptorLogRTxt;
        private Label label1;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Direction;
        private DataGridViewTextBoxColumn MsgType;
        private DataGridViewTextBoxColumn Symbol;
        private DataGridViewTextBoxColumn Side;
        private DataGridViewTextBoxColumn ExecType;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn OrdQty;
        private DataGridViewTextBoxColumn CumQty;
        private DataGridViewTextBoxColumn ClOrderId;
        private DataGridViewTextBoxColumn OrigClOrderId;
        private DataGridViewTextBoxColumn FixMsg;
    }
}