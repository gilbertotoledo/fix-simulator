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
            InitiatorFixFieldsConfigBtn = new Button();
            InitiatorShowSentChb = new CheckBox();
            InitiatorOrderCancelBtn = new Button();
            InitiatorShowReceivedChb = new CheckBox();
            InitiatorOrderReplaceBtn = new Button();
            InitiatorNewOrderSingleBtn = new Button();
            groupBox4 = new GroupBox();
            InitiatorNextTargetMsgSeqNumTxt = new Label();
            InitiatorNextSenderMsgSeqNumText = new Label();
            label2 = new Label();
            label1 = new Label();
            InitiatorClearStoreBtn = new Button();
            InitiatorLogGroup = new GroupBox();
            InitiatorLogTxt = new TextBox();
            InitiatorStartStopBtn = new Button();
            InitiatorFixConfigBtn = new Button();
            GroupBox2 = new GroupBox();
            groupBox8 = new GroupBox();
            AcceptorShowSentChb = new CheckBox();
            ExecutionReportFilledBtn = new Button();
            AcceptorShowReceivedChb = new CheckBox();
            ExecutionReportNewBtn = new Button();
            groupBox6 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            AcceptorClearStoreBtn = new Button();
            AcceptorStartStopBtn = new Button();
            AcceptorLogGroup = new GroupBox();
            AcceptorLogTxt = new TextBox();
            AcceptorMacros = new GroupBox();
            AcceptorIntervalTxt = new TextBox();
            label7 = new Label();
            AcceptorMacrosClb = new CheckedListBox();
            AcceptorFixConfigBtn = new Button();
            GroupBox3 = new GroupBox();
            MessagesDg = new DataGridView();
            Direction = new DataGridViewTextBoxColumn();
            MsgType = new DataGridViewTextBoxColumn();
            ExecType = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            OrdQty = new DataGridViewTextBoxColumn();
            CumQty = new DataGridViewTextBoxColumn();
            ClOrderId = new DataGridViewTextBoxColumn();
            OrigClOrderId = new DataGridViewTextBoxColumn();
            Symbol = new DataGridViewTextBoxColumn();
            FixMsg = new DataGridViewTextBoxColumn();
            GroupBox1.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox4.SuspendLayout();
            InitiatorLogGroup.SuspendLayout();
            GroupBox2.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox6.SuspendLayout();
            AcceptorLogGroup.SuspendLayout();
            AcceptorMacros.SuspendLayout();
            GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MessagesDg).BeginInit();
            SuspendLayout();
            // 
            // GroupBox1
            // 
            GroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            GroupBox1.Controls.Add(groupBox7);
            GroupBox1.Controls.Add(groupBox4);
            GroupBox1.Controls.Add(InitiatorClearStoreBtn);
            GroupBox1.Controls.Add(InitiatorLogGroup);
            GroupBox1.Controls.Add(InitiatorStartStopBtn);
            GroupBox1.Controls.Add(InitiatorFixConfigBtn);
            GroupBox1.Location = new Point(12, 12);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(881, 434);
            GroupBox1.TabIndex = 0;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Initiator";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(InitiatorFixFieldsConfigBtn);
            groupBox7.Controls.Add(InitiatorShowSentChb);
            groupBox7.Controls.Add(InitiatorOrderCancelBtn);
            groupBox7.Controls.Add(InitiatorShowReceivedChb);
            groupBox7.Controls.Add(InitiatorOrderReplaceBtn);
            groupBox7.Controls.Add(InitiatorNewOrderSingleBtn);
            groupBox7.Location = new Point(12, 51);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(400, 86);
            groupBox7.TabIndex = 10;
            groupBox7.TabStop = false;
            groupBox7.Text = "Mensagens";
            // 
            // InitiatorFixFieldsConfigBtn
            // 
            InitiatorFixFieldsConfigBtn.Location = new Point(308, 17);
            InitiatorFixFieldsConfigBtn.Name = "InitiatorFixFieldsConfigBtn";
            InitiatorFixFieldsConfigBtn.Size = new Size(86, 23);
            InitiatorFixFieldsConfigBtn.TabIndex = 4;
            InitiatorFixFieldsConfigBtn.Text = "Dados";
            InitiatorFixFieldsConfigBtn.UseVisualStyleBackColor = true;
            InitiatorFixFieldsConfigBtn.Click += InitiatorFixFieldsConfigBtn_Click;
            // 
            // InitiatorShowSentChb
            // 
            InitiatorShowSentChb.AutoSize = true;
            InitiatorShowSentChb.Location = new Point(122, 21);
            InitiatorShowSentChb.Name = "InitiatorShowSentChb";
            InitiatorShowSentChb.Size = new Size(104, 19);
            InitiatorShowSentChb.TabIndex = 1;
            InitiatorShowSentChb.Text = "Exibir enviadas";
            InitiatorShowSentChb.UseVisualStyleBackColor = true;
            InitiatorShowSentChb.CheckedChanged += InitiatorShowSentChb_CheckedChanged;
            // 
            // InitiatorOrderCancelBtn
            // 
            InitiatorOrderCancelBtn.Location = new Point(212, 55);
            InitiatorOrderCancelBtn.Name = "InitiatorOrderCancelBtn";
            InitiatorOrderCancelBtn.Size = new Size(78, 23);
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
            InitiatorOrderReplaceBtn.Location = new Point(127, 55);
            InitiatorOrderReplaceBtn.Name = "InitiatorOrderReplaceBtn";
            InitiatorOrderReplaceBtn.Size = new Size(79, 23);
            InitiatorOrderReplaceBtn.TabIndex = 2;
            InitiatorOrderReplaceBtn.Text = "Replace";
            InitiatorOrderReplaceBtn.UseVisualStyleBackColor = true;
            InitiatorOrderReplaceBtn.Click += InitiatorOrderReplaceBtn_Click;
            // 
            // InitiatorNewOrderSingleBtn
            // 
            InitiatorNewOrderSingleBtn.Location = new Point(11, 55);
            InitiatorNewOrderSingleBtn.Name = "InitiatorNewOrderSingleBtn";
            InitiatorNewOrderSingleBtn.Size = new Size(110, 23);
            InitiatorNewOrderSingleBtn.TabIndex = 1;
            InitiatorNewOrderSingleBtn.Text = "NewOrderSingle";
            InitiatorNewOrderSingleBtn.UseVisualStyleBackColor = true;
            InitiatorNewOrderSingleBtn.Click += InitiatorNewOrderSingleBtn_Click;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(InitiatorNextTargetMsgSeqNumTxt);
            groupBox4.Controls.Add(InitiatorNextSenderMsgSeqNumText);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(12, 363);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(400, 62);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Status";
            // 
            // InitiatorNextTargetMsgSeqNumTxt
            // 
            InitiatorNextTargetMsgSeqNumTxt.AutoSize = true;
            InitiatorNextTargetMsgSeqNumTxt.Location = new Point(145, 35);
            InitiatorNextTargetMsgSeqNumTxt.Name = "InitiatorNextTargetMsgSeqNumTxt";
            InitiatorNextTargetMsgSeqNumTxt.Size = new Size(13, 15);
            InitiatorNextTargetMsgSeqNumTxt.TabIndex = 3;
            InitiatorNextTargetMsgSeqNumTxt.Text = "0";
            // 
            // InitiatorNextSenderMsgSeqNumText
            // 
            InitiatorNextSenderMsgSeqNumText.AutoSize = true;
            InitiatorNextSenderMsgSeqNumText.Location = new Point(145, 19);
            InitiatorNextSenderMsgSeqNumText.Name = "InitiatorNextSenderMsgSeqNumText";
            InitiatorNextSenderMsgSeqNumText.Size = new Size(13, 15);
            InitiatorNextSenderMsgSeqNumText.TabIndex = 2;
            InitiatorNextSenderMsgSeqNumText.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 1;
            label2.Text = "NextTargetMsgSeqNum:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 0;
            label1.Text = "NextSenderMsgSeqNum:";
            // 
            // InitiatorClearStoreBtn
            // 
            InitiatorClearStoreBtn.Location = new Point(93, 22);
            InitiatorClearStoreBtn.Name = "InitiatorClearStoreBtn";
            InitiatorClearStoreBtn.Size = new Size(93, 23);
            InitiatorClearStoreBtn.TabIndex = 8;
            InitiatorClearStoreBtn.Text = "Limpar Store";
            InitiatorClearStoreBtn.UseVisualStyleBackColor = true;
            InitiatorClearStoreBtn.Click += InitiatorClearStoreBtn_Click;
            // 
            // InitiatorLogGroup
            // 
            InitiatorLogGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InitiatorLogGroup.Controls.Add(InitiatorLogTxt);
            InitiatorLogGroup.Location = new Point(418, 51);
            InitiatorLogGroup.Name = "InitiatorLogGroup";
            InitiatorLogGroup.Size = new Size(457, 374);
            InitiatorLogGroup.TabIndex = 6;
            InitiatorLogGroup.TabStop = false;
            InitiatorLogGroup.Text = "Log";
            // 
            // InitiatorLogTxt
            // 
            InitiatorLogTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InitiatorLogTxt.Location = new Point(6, 22);
            InitiatorLogTxt.Multiline = true;
            InitiatorLogTxt.Name = "InitiatorLogTxt";
            InitiatorLogTxt.ReadOnly = true;
            InitiatorLogTxt.ScrollBars = ScrollBars.Vertical;
            InitiatorLogTxt.Size = new Size(445, 346);
            InitiatorLogTxt.TabIndex = 0;
            InitiatorLogTxt.DoubleClick += InitiatorLogTxt_DoubleClick;
            // 
            // InitiatorStartStopBtn
            // 
            InitiatorStartStopBtn.Location = new Point(12, 22);
            InitiatorStartStopBtn.Name = "InitiatorStartStopBtn";
            InitiatorStartStopBtn.Size = new Size(75, 23);
            InitiatorStartStopBtn.TabIndex = 7;
            InitiatorStartStopBtn.Text = "Iniciar";
            InitiatorStartStopBtn.UseVisualStyleBackColor = true;
            InitiatorStartStopBtn.Click += InitiatorStartStopBtn_Click;
            // 
            // InitiatorFixConfigBtn
            // 
            InitiatorFixConfigBtn.Location = new Point(192, 22);
            InitiatorFixConfigBtn.Name = "InitiatorFixConfigBtn";
            InitiatorFixConfigBtn.Size = new Size(118, 23);
            InitiatorFixConfigBtn.TabIndex = 0;
            InitiatorFixConfigBtn.Text = "Configurações Fix";
            InitiatorFixConfigBtn.UseVisualStyleBackColor = true;
            InitiatorFixConfigBtn.Click += InitiatorFixConfigBtn_Click;
            // 
            // GroupBox2
            // 
            GroupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            GroupBox2.Controls.Add(groupBox8);
            GroupBox2.Controls.Add(groupBox6);
            GroupBox2.Controls.Add(AcceptorClearStoreBtn);
            GroupBox2.Controls.Add(AcceptorStartStopBtn);
            GroupBox2.Controls.Add(AcceptorLogGroup);
            GroupBox2.Controls.Add(AcceptorMacros);
            GroupBox2.Controls.Add(AcceptorFixConfigBtn);
            GroupBox2.Location = new Point(899, 12);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(860, 434);
            GroupBox2.TabIndex = 1;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Acceptor";
            // 
            // groupBox8
            // 
            groupBox8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox8.Controls.Add(AcceptorShowSentChb);
            groupBox8.Controls.Add(ExecutionReportFilledBtn);
            groupBox8.Controls.Add(AcceptorShowReceivedChb);
            groupBox8.Controls.Add(ExecutionReportNewBtn);
            groupBox8.Location = new Point(454, 54);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(400, 86);
            groupBox8.TabIndex = 13;
            groupBox8.TabStop = false;
            groupBox8.Text = "Mensagens";
            // 
            // AcceptorShowSentChb
            // 
            AcceptorShowSentChb.AutoSize = true;
            AcceptorShowSentChb.Location = new Point(122, 21);
            AcceptorShowSentChb.Name = "AcceptorShowSentChb";
            AcceptorShowSentChb.Size = new Size(104, 19);
            AcceptorShowSentChb.TabIndex = 1;
            AcceptorShowSentChb.Text = "Exibir enviadas";
            AcceptorShowSentChb.UseVisualStyleBackColor = true;
            AcceptorShowSentChb.CheckedChanged += AcceptorShowSentChb_CheckedChanged;
            // 
            // ExecutionReportFilledBtn
            // 
            ExecutionReportFilledBtn.Location = new Point(161, 55);
            ExecutionReportFilledBtn.Name = "ExecutionReportFilledBtn";
            ExecutionReportFilledBtn.Size = new Size(144, 23);
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
            ExecutionReportNewBtn.Location = new Point(11, 55);
            ExecutionReportNewBtn.Name = "ExecutionReportNewBtn";
            ExecutionReportNewBtn.Size = new Size(144, 23);
            ExecutionReportNewBtn.TabIndex = 10;
            ExecutionReportNewBtn.Text = "ExecutionReport - New";
            ExecutionReportNewBtn.UseVisualStyleBackColor = true;
            ExecutionReportNewBtn.Click += ExecutionReportBtn_Click;
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox6.Controls.Add(label3);
            groupBox6.Controls.Add(label4);
            groupBox6.Controls.Add(label5);
            groupBox6.Controls.Add(label6);
            groupBox6.Location = new Point(454, 363);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(400, 62);
            groupBox6.TabIndex = 12;
            groupBox6.TabStop = false;
            groupBox6.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 35);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 3;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 19);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 2;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 35);
            label5.Name = "label5";
            label5.Size = new Size(136, 15);
            label5.TabIndex = 1;
            label5.Text = "NextTargetMsgSeqNum:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(140, 15);
            label6.TabIndex = 0;
            label6.Text = "NextSenderMsgSeqNum:";
            // 
            // AcceptorClearStoreBtn
            // 
            AcceptorClearStoreBtn.Location = new Point(87, 22);
            AcceptorClearStoreBtn.Name = "AcceptorClearStoreBtn";
            AcceptorClearStoreBtn.Size = new Size(93, 23);
            AcceptorClearStoreBtn.TabIndex = 9;
            AcceptorClearStoreBtn.Text = "Limpar Store";
            AcceptorClearStoreBtn.UseVisualStyleBackColor = true;
            AcceptorClearStoreBtn.Click += AcceptorClearStoreBtn_Click;
            // 
            // AcceptorStartStopBtn
            // 
            AcceptorStartStopBtn.Location = new Point(6, 22);
            AcceptorStartStopBtn.Name = "AcceptorStartStopBtn";
            AcceptorStartStopBtn.Size = new Size(75, 23);
            AcceptorStartStopBtn.TabIndex = 8;
            AcceptorStartStopBtn.Text = "Iniciar";
            AcceptorStartStopBtn.UseVisualStyleBackColor = true;
            AcceptorStartStopBtn.Click += AcceptorStartStopBtn_Click;
            // 
            // AcceptorLogGroup
            // 
            AcceptorLogGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AcceptorLogGroup.Controls.Add(AcceptorLogTxt);
            AcceptorLogGroup.Location = new Point(6, 54);
            AcceptorLogGroup.Name = "AcceptorLogGroup";
            AcceptorLogGroup.Size = new Size(442, 371);
            AcceptorLogGroup.TabIndex = 7;
            AcceptorLogGroup.TabStop = false;
            AcceptorLogGroup.Text = "Log";
            // 
            // AcceptorLogTxt
            // 
            AcceptorLogTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AcceptorLogTxt.Location = new Point(6, 22);
            AcceptorLogTxt.Multiline = true;
            AcceptorLogTxt.Name = "AcceptorLogTxt";
            AcceptorLogTxt.ReadOnly = true;
            AcceptorLogTxt.ScrollBars = ScrollBars.Vertical;
            AcceptorLogTxt.Size = new Size(430, 343);
            AcceptorLogTxt.TabIndex = 1;
            AcceptorLogTxt.DoubleClick += AcceptorLogTxt_DoubleClick;
            // 
            // AcceptorMacros
            // 
            AcceptorMacros.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AcceptorMacros.Controls.Add(AcceptorIntervalTxt);
            AcceptorMacros.Controls.Add(label7);
            AcceptorMacros.Controls.Add(AcceptorMacrosClb);
            AcceptorMacros.Location = new Point(454, 146);
            AcceptorMacros.Name = "AcceptorMacros";
            AcceptorMacros.Size = new Size(400, 211);
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
            AcceptorMacrosClb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AcceptorMacrosClb.FormattingEnabled = true;
            AcceptorMacrosClb.Items.AddRange(new object[] { "ExecutionReport - New", "ExecutionReport - Filled", "ExecutionReport - Partially Filled (25%) Único", "ExecutionReport - Partially Filled (25%) A cada intervalo, até 100%", "ExecutionReport - Replaced", "ExecutionReport - Replace Rejection", "ExecutionReport - Canceled", "ExecutionReport - Cancel Rejection" });
            AcceptorMacrosClb.Location = new Point(6, 51);
            AcceptorMacrosClb.Name = "AcceptorMacrosClb";
            AcceptorMacrosClb.Size = new Size(388, 148);
            AcceptorMacrosClb.TabIndex = 2;
            AcceptorMacrosClb.ItemCheck += AcceptorMacrosClb_ItemCheck;
            // 
            // AcceptorFixConfigBtn
            // 
            AcceptorFixConfigBtn.Location = new Point(186, 22);
            AcceptorFixConfigBtn.Name = "AcceptorFixConfigBtn";
            AcceptorFixConfigBtn.Size = new Size(119, 23);
            AcceptorFixConfigBtn.TabIndex = 1;
            AcceptorFixConfigBtn.Text = "Configurações Fix";
            AcceptorFixConfigBtn.UseVisualStyleBackColor = true;
            AcceptorFixConfigBtn.Click += AcceptorFixConfigBtn_Click;
            // 
            // GroupBox3
            // 
            GroupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupBox3.AutoSize = true;
            GroupBox3.Controls.Add(MessagesDg);
            GroupBox3.Location = new Point(12, 452);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Size = new Size(1747, 305);
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
            MessagesDg.Columns.AddRange(new DataGridViewColumn[] { Direction, MsgType, ExecType, Status, OrdQty, CumQty, ClOrderId, OrigClOrderId, Symbol, FixMsg });
            MessagesDg.Location = new Point(6, 22);
            MessagesDg.Name = "MessagesDg";
            MessagesDg.ReadOnly = true;
            MessagesDg.RowTemplate.Height = 25;
            MessagesDg.ShowEditingIcon = false;
            MessagesDg.Size = new Size(1735, 276);
            MessagesDg.TabIndex = 2;
            MessagesDg.CellDoubleClick += MessagesDg_CellDoubleClick;
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
            // Symbol
            // 
            Symbol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Symbol.HeaderText = "Symbol";
            Symbol.Name = "Symbol";
            Symbol.ReadOnly = true;
            Symbol.Width = 72;
            // 
            // FixMsg
            // 
            FixMsg.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FixMsg.HeaderText = "FixMsg";
            FixMsg.MinimumWidth = 1500;
            FixMsg.Name = "FixMsg";
            FixMsg.ReadOnly = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1771, 762);
            Controls.Add(GroupBox3);
            Controls.Add(GroupBox2);
            Controls.Add(GroupBox1);
            ImeMode = ImeMode.Disable;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FixSimulatorDesktop";
            FormClosing += MainForm_FormClosing;
            GroupBox1.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            InitiatorLogGroup.ResumeLayout(false);
            InitiatorLogGroup.PerformLayout();
            GroupBox2.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            AcceptorLogGroup.ResumeLayout(false);
            AcceptorLogGroup.PerformLayout();
            AcceptorMacros.ResumeLayout(false);
            AcceptorMacros.PerformLayout();
            GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MessagesDg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GroupBox1;
        private GroupBox GroupBox2;
        private GroupBox GroupBox3;
        private Button InitiatorFixConfigBtn;
        private Button AcceptorFixConfigBtn;
        private CheckedListBox AcceptorMacrosClb;
        private GroupBox AcceptorMacros;
        private Button InitiatorOrderCancelBtn;
        private Button InitiatorOrderReplaceBtn;
        private Button InitiatorNewOrderSingleBtn;
        private GroupBox InitiatorLogGroup;
        private Button InitiatorStartStopBtn;
        private GroupBox AcceptorLogGroup;
        private Button AcceptorStartStopBtn;
        private TextBox InitiatorLogTxt;
        private TextBox AcceptorLogTxt;
        private Button InitiatorClearStoreBtn;
        private Button AcceptorClearStoreBtn;
        private Button InitiatorFixFieldsConfigBtn;
        private DataGridView MessagesDg;
        private Button ExecutionReportNewBtn;
        private Button ExecutionReportFilledBtn;
        private GroupBox groupBox4;
        private Label label2;
        private Label label1;
        private Label InitiatorNextSenderMsgSeqNumText;
        private Label InitiatorNextTargetMsgSeqNumTxt;
        private GroupBox groupBox6;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn Direction;
        private DataGridViewTextBoxColumn MsgType;
        private DataGridViewTextBoxColumn ExecType;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn OrdQty;
        private DataGridViewTextBoxColumn CumQty;
        private DataGridViewTextBoxColumn ClOrderId;
        private DataGridViewTextBoxColumn OrigClOrderId;
        private DataGridViewTextBoxColumn Symbol;
        private DataGridViewTextBoxColumn FixMsg;
        private GroupBox groupBox7;
        private CheckBox InitiatorShowSentChb;
        private CheckBox InitiatorShowReceivedChb;
        private GroupBox groupBox8;
        private CheckBox AcceptorShowSentChb;
        private CheckBox AcceptorShowReceivedChb;
        private TextBox AcceptorIntervalTxt;
        private Label label7;
    }
}