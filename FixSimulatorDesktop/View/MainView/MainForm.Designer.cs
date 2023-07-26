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
            InitiatorClearStoreBtn = new Button();
            InitiatorStartStopBtn = new Button();
            InitiatorLogGroup = new GroupBox();
            InitiatorLogTxt = new TextBox();
            GroupBox5 = new GroupBox();
            InitiatorFixFieldsConfigBtn = new Button();
            Button2 = new Button();
            InitiatorNewOrderSingleBtn = new Button();
            Button1 = new Button();
            InitiatorFixConfigBtn = new Button();
            GroupBox2 = new GroupBox();
            ExecutionReportFilledBtn = new Button();
            ExecutionReportNewBtn = new Button();
            AcceptorClearStoreBtn = new Button();
            AcceptorStartStopBtn = new Button();
            AcceptorLogGroup = new GroupBox();
            AcceptorLogTxt = new TextBox();
            AcceptorMacros = new GroupBox();
            AcceptorMacrosClb = new CheckedListBox();
            AcceptorFixConfigBtn = new Button();
            GroupBox3 = new GroupBox();
            MessagesDg = new DataGridView();
            Direction = new DataGridViewTextBoxColumn();
            MsgType = new DataGridViewTextBoxColumn();
            ClOrderId = new DataGridViewTextBoxColumn();
            OrigClOrderId = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Symbol = new DataGridViewTextBoxColumn();
            QTY = new DataGridViewTextBoxColumn();
            ExecQty = new DataGridViewTextBoxColumn();
            FixMsg = new DataGridViewTextBoxColumn();
            GroupBox1.SuspendLayout();
            InitiatorLogGroup.SuspendLayout();
            GroupBox5.SuspendLayout();
            GroupBox2.SuspendLayout();
            AcceptorLogGroup.SuspendLayout();
            AcceptorMacros.SuspendLayout();
            GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MessagesDg).BeginInit();
            SuspendLayout();
            // 
            // GroupBox1
            // 
            GroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            GroupBox1.Controls.Add(InitiatorClearStoreBtn);
            GroupBox1.Controls.Add(InitiatorStartStopBtn);
            GroupBox1.Controls.Add(InitiatorLogGroup);
            GroupBox1.Controls.Add(GroupBox5);
            GroupBox1.Controls.Add(InitiatorFixConfigBtn);
            GroupBox1.Location = new Point(12, 12);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(517, 738);
            GroupBox1.TabIndex = 0;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Initiator";
            // 
            // InitiatorClearStoreBtn
            // 
            InitiatorClearStoreBtn.Location = new Point(259, 22);
            InitiatorClearStoreBtn.Name = "InitiatorClearStoreBtn";
            InitiatorClearStoreBtn.Size = new Size(93, 23);
            InitiatorClearStoreBtn.TabIndex = 8;
            InitiatorClearStoreBtn.Text = "Limpar Store";
            InitiatorClearStoreBtn.UseVisualStyleBackColor = true;
            InitiatorClearStoreBtn.Click += InitiatorClearStoreBtn_Click;
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
            // InitiatorLogGroup
            // 
            InitiatorLogGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InitiatorLogGroup.Controls.Add(InitiatorLogTxt);
            InitiatorLogGroup.Location = new Point(12, 433);
            InitiatorLogGroup.Name = "InitiatorLogGroup";
            InitiatorLogGroup.Size = new Size(499, 299);
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
            InitiatorLogTxt.Size = new Size(487, 271);
            InitiatorLogTxt.TabIndex = 0;
            // 
            // GroupBox5
            // 
            GroupBox5.Controls.Add(InitiatorFixFieldsConfigBtn);
            GroupBox5.Controls.Add(Button2);
            GroupBox5.Controls.Add(InitiatorNewOrderSingleBtn);
            GroupBox5.Controls.Add(Button1);
            GroupBox5.Location = new Point(12, 51);
            GroupBox5.Name = "GroupBox5";
            GroupBox5.Size = new Size(499, 376);
            GroupBox5.TabIndex = 3;
            GroupBox5.TabStop = false;
            GroupBox5.Text = "Ordens";
            // 
            // InitiatorFixFieldsConfigBtn
            // 
            InitiatorFixFieldsConfigBtn.Location = new Point(372, 22);
            InitiatorFixFieldsConfigBtn.Name = "InitiatorFixFieldsConfigBtn";
            InitiatorFixFieldsConfigBtn.Size = new Size(86, 23);
            InitiatorFixFieldsConfigBtn.TabIndex = 4;
            InitiatorFixFieldsConfigBtn.Text = "Campos Fix";
            InitiatorFixFieldsConfigBtn.UseVisualStyleBackColor = true;
            InitiatorFixFieldsConfigBtn.Click += InitiatorFixFieldsConfigBtn_Click;
            // 
            // Button2
            // 
            Button2.Location = new Point(207, 22);
            Button2.Name = "Button2";
            Button2.Size = new Size(78, 23);
            Button2.TabIndex = 3;
            Button2.Text = "Cancel";
            Button2.UseVisualStyleBackColor = true;
            // 
            // InitiatorNewOrderSingleBtn
            // 
            InitiatorNewOrderSingleBtn.Location = new Point(6, 22);
            InitiatorNewOrderSingleBtn.Name = "InitiatorNewOrderSingleBtn";
            InitiatorNewOrderSingleBtn.Size = new Size(110, 23);
            InitiatorNewOrderSingleBtn.TabIndex = 1;
            InitiatorNewOrderSingleBtn.Text = "NewOrderSingle";
            InitiatorNewOrderSingleBtn.UseVisualStyleBackColor = true;
            InitiatorNewOrderSingleBtn.Click += InitiatorNewOrderSingleBtn_Click;
            // 
            // Button1
            // 
            Button1.Location = new Point(122, 22);
            Button1.Name = "Button1";
            Button1.Size = new Size(79, 23);
            Button1.TabIndex = 2;
            Button1.Text = "Replace";
            Button1.UseVisualStyleBackColor = true;
            // 
            // InitiatorFixConfigBtn
            // 
            InitiatorFixConfigBtn.Location = new Point(358, 22);
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
            GroupBox2.Controls.Add(ExecutionReportFilledBtn);
            GroupBox2.Controls.Add(ExecutionReportNewBtn);
            GroupBox2.Controls.Add(AcceptorClearStoreBtn);
            GroupBox2.Controls.Add(AcceptorStartStopBtn);
            GroupBox2.Controls.Add(AcceptorLogGroup);
            GroupBox2.Controls.Add(AcceptorMacros);
            GroupBox2.Controls.Add(AcceptorFixConfigBtn);
            GroupBox2.Location = new Point(1232, 12);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(527, 738);
            GroupBox2.TabIndex = 1;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Acceptor";
            // 
            // ExecutionReportFilledBtn
            // 
            ExecutionReportFilledBtn.Location = new Point(156, 64);
            ExecutionReportFilledBtn.Name = "ExecutionReportFilledBtn";
            ExecutionReportFilledBtn.Size = new Size(144, 23);
            ExecutionReportFilledBtn.TabIndex = 11;
            ExecutionReportFilledBtn.Text = "ExecutionReport - Filled";
            ExecutionReportFilledBtn.UseVisualStyleBackColor = true;
            ExecutionReportFilledBtn.Click += ExecutionReportFilledBtn_Click;
            // 
            // ExecutionReportNewBtn
            // 
            ExecutionReportNewBtn.Location = new Point(6, 64);
            ExecutionReportNewBtn.Name = "ExecutionReportNewBtn";
            ExecutionReportNewBtn.Size = new Size(144, 23);
            ExecutionReportNewBtn.TabIndex = 10;
            ExecutionReportNewBtn.Text = "ExecutionReport - New";
            ExecutionReportNewBtn.UseVisualStyleBackColor = true;
            ExecutionReportNewBtn.Click += ExecutionReportBtn_Click;
            // 
            // AcceptorClearStoreBtn
            // 
            AcceptorClearStoreBtn.Location = new Point(297, 19);
            AcceptorClearStoreBtn.Name = "AcceptorClearStoreBtn";
            AcceptorClearStoreBtn.Size = new Size(93, 23);
            AcceptorClearStoreBtn.TabIndex = 9;
            AcceptorClearStoreBtn.Text = "Limpar Store";
            AcceptorClearStoreBtn.UseVisualStyleBackColor = true;
            AcceptorClearStoreBtn.Click += AcceptorClearStoreBtn_Click;
            // 
            // AcceptorStartStopBtn
            // 
            AcceptorStartStopBtn.Location = new Point(12, 19);
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
            AcceptorLogGroup.Location = new Point(6, 440);
            AcceptorLogGroup.Name = "AcceptorLogGroup";
            AcceptorLogGroup.Size = new Size(515, 292);
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
            AcceptorLogTxt.Size = new Size(503, 264);
            AcceptorLogTxt.TabIndex = 1;
            // 
            // AcceptorMacros
            // 
            AcceptorMacros.Controls.Add(AcceptorMacrosClb);
            AcceptorMacros.Location = new Point(6, 216);
            AcceptorMacros.Name = "AcceptorMacros";
            AcceptorMacros.Size = new Size(515, 218);
            AcceptorMacros.TabIndex = 3;
            AcceptorMacros.TabStop = false;
            AcceptorMacros.Text = "Macros";
            // 
            // AcceptorMacrosClb
            // 
            AcceptorMacrosClb.FormattingEnabled = true;
            AcceptorMacrosClb.Items.AddRange(new object[] { "ExecutionReport - New", "ExecutionReport - Filled", "ExecutionReport - Partially Filled (25%) Único", "ExecutionReport - Partially Filled (25%) A cada 5s, até 100%" });
            AcceptorMacrosClb.Location = new Point(6, 22);
            AcceptorMacrosClb.Name = "AcceptorMacrosClb";
            AcceptorMacrosClb.Size = new Size(503, 184);
            AcceptorMacrosClb.TabIndex = 2;
            AcceptorMacrosClb.ItemCheck += AcceptorMacrosClb_ItemCheck;
            // 
            // AcceptorFixConfigBtn
            // 
            AcceptorFixConfigBtn.Location = new Point(396, 19);
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
            GroupBox3.Location = new Point(535, 12);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Size = new Size(691, 738);
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
            MessagesDg.Columns.AddRange(new DataGridViewColumn[] { Direction, MsgType, ClOrderId, OrigClOrderId, Status, Symbol, QTY, ExecQty, FixMsg });
            MessagesDg.Location = new Point(6, 22);
            MessagesDg.Name = "MessagesDg";
            MessagesDg.ReadOnly = true;
            MessagesDg.RowTemplate.Height = 25;
            MessagesDg.ShowEditingIcon = false;
            MessagesDg.Size = new Size(679, 697);
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
            MsgType.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            MsgType.HeaderText = "MsgType";
            MsgType.Name = "MsgType";
            MsgType.ReadOnly = true;
            MsgType.Width = 79;
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
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 64;
            // 
            // Symbol
            // 
            Symbol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Symbol.HeaderText = "Symbol";
            Symbol.Name = "Symbol";
            Symbol.ReadOnly = true;
            Symbol.Width = 72;
            // 
            // QTY
            // 
            QTY.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            QTY.HeaderText = "QTY";
            QTY.Name = "QTY";
            QTY.ReadOnly = true;
            QTY.Width = 53;
            // 
            // ExecQty
            // 
            ExecQty.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ExecQty.HeaderText = "ExecQty";
            ExecQty.Name = "ExecQty";
            ExecQty.ReadOnly = true;
            ExecQty.Width = 75;
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
            InitiatorLogGroup.ResumeLayout(false);
            InitiatorLogGroup.PerformLayout();
            GroupBox5.ResumeLayout(false);
            GroupBox2.ResumeLayout(false);
            AcceptorLogGroup.ResumeLayout(false);
            AcceptorLogGroup.PerformLayout();
            AcceptorMacros.ResumeLayout(false);
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
        private Button Button2;
        private Button Button1;
        private Button InitiatorNewOrderSingleBtn;
        private GroupBox GroupBox5;
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
        private DataGridViewTextBoxColumn Direction;
        private DataGridViewTextBoxColumn MsgType;
        private DataGridViewTextBoxColumn ClOrderId;
        private DataGridViewTextBoxColumn OrigClOrderId;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Symbol;
        private DataGridViewTextBoxColumn QTY;
        private DataGridViewTextBoxColumn ExecQty;
        private DataGridViewTextBoxColumn FixMsg;
    }
}