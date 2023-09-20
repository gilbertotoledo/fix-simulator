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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            splitContainer1 = new SplitContainer();
            GroupBox2 = new GroupBox();
            groupBox8 = new GroupBox();
            AcceptorExecutionReportBtn = new Button();
            AcceptorShowSentChb = new CheckBox();
            AcceptorExecutionReportFastFilledBtn = new Button();
            AcceptorShowReceivedChb = new CheckBox();
            AcceptorExecutionReportFastNewBtn = new Button();
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
            MenuStrip = new MenuStrip();
            InitiatorToolStripMenuItem = new ToolStripMenuItem();
            InitiatorStartToolStripMenuItem = new ToolStripMenuItem();
            InitiatorClearLogToolStripMenuItem = new ToolStripMenuItem();
            InitiatorCleanStoreToolStripMenuItem = new ToolStripMenuItem();
            InitiatorFixConfigToolStripMenuItem = new ToolStripMenuItem();
            AcceptorToolStripMenuItem = new ToolStripMenuItem();
            AcceptorStartToolStripMenuItem = new ToolStripMenuItem();
            AcceptorClearLogToolStripMenuItem = new ToolStripMenuItem();
            AcceptorClearStoreToolStripMenuItem1 = new ToolStripMenuItem();
            AcceptorFixConfigToolStripMenuItem1 = new ToolStripMenuItem();
            MessagesToolStripMenuItem = new ToolStripMenuItem();
            ClearMessageListToolStripMenuItem = new ToolStripMenuItem();
            ToolsToolStripMenuItem = new ToolStripMenuItem();
            AnalisadorToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            mensagensEComportamentosToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            InitiatorStatus = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            AcceptorStatus = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            TipStripStatusLabel = new ToolStripStatusLabel();
            label1 = new Label();
            GroupBox1.SuspendLayout();
            groupBox7.SuspendLayout();
            InitiatorLogGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            GroupBox2.SuspendLayout();
            groupBox8.SuspendLayout();
            AcceptorLogGroup.SuspendLayout();
            AcceptorMacros.SuspendLayout();
            GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MessagesDg).BeginInit();
            MenuStrip.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox1
            // 
            GroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupBox1.Controls.Add(groupBox7);
            GroupBox1.Controls.Add(InitiatorLogGroup);
            GroupBox1.Location = new Point(3, 3);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(865, 442);
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
            groupBox7.Size = new Size(847, 86);
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
            InitiatorLogGroup.Size = new Size(847, 322);
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
            InitiatorLogRTxt.Size = new Size(835, 294);
            InitiatorLogRTxt.TabIndex = 5;
            InitiatorLogRTxt.Text = "";
            InitiatorLogRTxt.DoubleClick += InitiatorLogRTxt_DoubleClick;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(12, 34);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(GroupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(GroupBox2);
            splitContainer1.Size = new Size(1748, 448);
            splitContainer1.SplitterDistance = 871;
            splitContainer1.TabIndex = 5;
            // 
            // GroupBox2
            // 
            GroupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupBox2.Controls.Add(groupBox8);
            GroupBox2.Controls.Add(AcceptorLogGroup);
            GroupBox2.Controls.Add(AcceptorMacros);
            GroupBox2.Location = new Point(3, 3);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(864, 442);
            GroupBox2.TabIndex = 1;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Acceptor";
            // 
            // groupBox8
            // 
            groupBox8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox8.Controls.Add(AcceptorExecutionReportBtn);
            groupBox8.Controls.Add(AcceptorShowSentChb);
            groupBox8.Controls.Add(AcceptorExecutionReportFastFilledBtn);
            groupBox8.Controls.Add(AcceptorShowReceivedChb);
            groupBox8.Controls.Add(AcceptorExecutionReportFastNewBtn);
            groupBox8.Location = new Point(6, 22);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(846, 86);
            groupBox8.TabIndex = 13;
            groupBox8.TabStop = false;
            groupBox8.Text = "Mensagens";
            // 
            // AcceptorExecutionReportBtn
            // 
            AcceptorExecutionReportBtn.AutoSize = true;
            AcceptorExecutionReportBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AcceptorExecutionReportBtn.Location = new Point(382, 48);
            AcceptorExecutionReportBtn.Name = "AcceptorExecutionReportBtn";
            AcceptorExecutionReportBtn.Padding = new Padding(10, 0, 10, 0);
            AcceptorExecutionReportBtn.Size = new Size(200, 25);
            AcceptorExecutionReportBtn.TabIndex = 12;
            AcceptorExecutionReportBtn.Text = "ExecutionReport Personalizado";
            AcceptorExecutionReportBtn.UseVisualStyleBackColor = true;
            AcceptorExecutionReportBtn.Click += AcceptorExecutionReportBtn_Click;
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
            // AcceptorExecutionReportFastFilledBtn
            // 
            AcceptorExecutionReportFastFilledBtn.AutoSize = true;
            AcceptorExecutionReportFastFilledBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AcceptorExecutionReportFastFilledBtn.Location = new Point(202, 48);
            AcceptorExecutionReportFastFilledBtn.Name = "AcceptorExecutionReportFastFilledBtn";
            AcceptorExecutionReportFastFilledBtn.Padding = new Padding(10, 0, 10, 0);
            AcceptorExecutionReportFastFilledBtn.Size = new Size(163, 25);
            AcceptorExecutionReportFastFilledBtn.TabIndex = 11;
            AcceptorExecutionReportFastFilledBtn.Text = "ExecutionReport - Filled";
            AcceptorExecutionReportFastFilledBtn.UseVisualStyleBackColor = true;
            AcceptorExecutionReportFastFilledBtn.Click += AcceptorExecutionReportFastFilledBtn_Click;
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
            // AcceptorExecutionReportFastNewBtn
            // 
            AcceptorExecutionReportFastNewBtn.AutoSize = true;
            AcceptorExecutionReportFastNewBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AcceptorExecutionReportFastNewBtn.Location = new Point(11, 48);
            AcceptorExecutionReportFastNewBtn.Name = "AcceptorExecutionReportFastNewBtn";
            AcceptorExecutionReportFastNewBtn.Padding = new Padding(10, 0, 10, 0);
            AcceptorExecutionReportFastNewBtn.Size = new Size(159, 25);
            AcceptorExecutionReportFastNewBtn.TabIndex = 10;
            AcceptorExecutionReportFastNewBtn.Text = "ExecutionReport - New";
            AcceptorExecutionReportFastNewBtn.UseVisualStyleBackColor = true;
            AcceptorExecutionReportFastNewBtn.Click += AcceptorExecutionReportFastNewBtn_Click;
            // 
            // AcceptorLogGroup
            // 
            AcceptorLogGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AcceptorLogGroup.Controls.Add(AcceptorLogRTxt);
            AcceptorLogGroup.Location = new Point(6, 114);
            AcceptorLogGroup.Name = "AcceptorLogGroup";
            AcceptorLogGroup.Size = new Size(446, 322);
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
            AcceptorLogRTxt.Size = new Size(434, 294);
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
            AcceptorMacros.Location = new Point(458, 114);
            AcceptorMacros.Name = "AcceptorMacros";
            AcceptorMacros.Size = new Size(400, 322);
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
            AcceptorMacrosClb.Size = new Size(388, 256);
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            MessagesDg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            MessagesDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MessagesDg.Columns.AddRange(new DataGridViewColumn[] { Time, Direction, MsgType, Symbol, Side, ExecType, Status, OrdQty, CumQty, ClOrderId, OrigClOrderId, FixMsg });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            MessagesDg.DefaultCellStyle = dataGridViewCellStyle5;
            MessagesDg.Location = new Point(6, 22);
            MessagesDg.Name = "MessagesDg";
            MessagesDg.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            MessagesDg.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            // MenuStrip
            // 
            MenuStrip.Items.AddRange(new ToolStripItem[] { InitiatorToolStripMenuItem, AcceptorToolStripMenuItem, MessagesToolStripMenuItem, ToolsToolStripMenuItem, ajudaToolStripMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(1771, 24);
            MenuStrip.TabIndex = 2;
            MenuStrip.Text = "MainMenuStrip";
            // 
            // InitiatorToolStripMenuItem
            // 
            InitiatorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { InitiatorStartToolStripMenuItem, InitiatorClearLogToolStripMenuItem, InitiatorCleanStoreToolStripMenuItem, InitiatorFixConfigToolStripMenuItem });
            InitiatorToolStripMenuItem.Name = "InitiatorToolStripMenuItem";
            InitiatorToolStripMenuItem.Size = new Size(60, 20);
            InitiatorToolStripMenuItem.Text = "Initiator";
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
            // AcceptorToolStripMenuItem
            // 
            AcceptorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AcceptorStartToolStripMenuItem, AcceptorClearLogToolStripMenuItem, AcceptorClearStoreToolStripMenuItem1, AcceptorFixConfigToolStripMenuItem1 });
            AcceptorToolStripMenuItem.Name = "AcceptorToolStripMenuItem";
            AcceptorToolStripMenuItem.Size = new Size(67, 20);
            AcceptorToolStripMenuItem.Text = "Acceptor";
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
            // MessagesToolStripMenuItem
            // 
            MessagesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ClearMessageListToolStripMenuItem });
            MessagesToolStripMenuItem.Name = "MessagesToolStripMenuItem";
            MessagesToolStripMenuItem.Size = new Size(79, 20);
            MessagesToolStripMenuItem.Text = "Mensagens";
            // 
            // ClearMessageListToolStripMenuItem
            // 
            ClearMessageListToolStripMenuItem.Name = "ClearMessageListToolStripMenuItem";
            ClearMessageListToolStripMenuItem.Size = new Size(135, 22);
            ClearMessageListToolStripMenuItem.Text = "Limpar lista";
            ClearMessageListToolStripMenuItem.Click += ClearMessageListToolStripMenuItem_Click;
            // 
            // ToolsToolStripMenuItem
            // 
            ToolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AnalisadorToolStripMenuItem });
            ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            ToolsToolStripMenuItem.Size = new Size(84, 20);
            ToolsToolStripMenuItem.Text = "Ferramentas";
            // 
            // AnalisadorToolStripMenuItem
            // 
            AnalisadorToolStripMenuItem.Name = "AnalisadorToolStripMenuItem";
            AnalisadorToolStripMenuItem.Size = new Size(154, 22);
            AnalisadorToolStripMenuItem.Text = "Analisar log Fix";
            AnalisadorToolStripMenuItem.Click += AnalisadorToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mensagensEComportamentosToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // mensagensEComportamentosToolStripMenuItem
            // 
            mensagensEComportamentosToolStripMenuItem.Name = "mensagensEComportamentosToolStripMenuItem";
            mensagensEComportamentosToolStripMenuItem.Size = new Size(152, 22);
            mensagensEComportamentosToolStripMenuItem.Text = "Manual de uso";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { InitiatorStatus, toolStripStatusLabel1, AcceptorStatus, toolStripStatusLabel2, TipStripStatusLabel });
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
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(10, 17);
            toolStripStatusLabel2.Text = "|";
            // 
            // TipStripStatusLabel
            // 
            TipStripStatusLabel.Name = "TipStripStatusLabel";
            TipStripStatusLabel.Size = new Size(16, 17);
            TipStripStatusLabel.Text = "...";
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
            Controls.Add(splitContainer1);
            Controls.Add(label1);
            Controls.Add(statusStrip1);
            Controls.Add(GroupBox3);
            Controls.Add(MenuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Disable;
            KeyPreview = true;
            MainMenuStrip = MenuStrip;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FixSimulatorDesktop";
            FormClosing += MainForm_FormClosing;
            KeyDown += MainForm_KeyDown;
            GroupBox1.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            InitiatorLogGroup.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            GroupBox2.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            AcceptorLogGroup.ResumeLayout(false);
            AcceptorMacros.ResumeLayout(false);
            AcceptorMacros.PerformLayout();
            GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MessagesDg).EndInit();
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
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
        private Button AcceptorExecutionReportFastNewBtn;
        private Button AcceptorExecutionReportFastFilledBtn;
        private GroupBox groupBox7;
        private CheckBox InitiatorShowSentChb;
        private CheckBox InitiatorShowReceivedChb;
        private GroupBox groupBox8;
        private CheckBox AcceptorShowSentChb;
        private CheckBox AcceptorShowReceivedChb;
        private TextBox AcceptorIntervalTxt;
        private Label label7;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem InitiatorToolStripMenuItem;
        private ToolStripMenuItem InitiatorCleanStoreToolStripMenuItem;
        private ToolStripMenuItem InitiatorFixConfigToolStripMenuItem;
        private ToolStripMenuItem AcceptorToolStripMenuItem;
        private ToolStripMenuItem AcceptorClearStoreToolStripMenuItem1;
        private ToolStripMenuItem AcceptorFixConfigToolStripMenuItem1;
        private ToolStripMenuItem MessagesToolStripMenuItem;
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
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem mensagensEComportamentosToolStripMenuItem;
        private ToolStripMenuItem ToolsToolStripMenuItem;
        private ToolStripMenuItem AnalisadorToolStripMenuItem;
        private Button AcceptorExecutionReportBtn;
        private SplitContainer splitContainer1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel TipStripStatusLabel;
    }
}