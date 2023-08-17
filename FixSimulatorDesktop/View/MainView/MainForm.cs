using FixSimulatorDesktop.FixApp;
using FixSimulatorDesktop.FixApplication;
using FixSimulatorDesktop.FixApplication.Order;
using FixSimulatorDesktop.Helper;
using FixSimulatorDesktop.State;
using FixSimulatorDesktop.View;
using FixSimulatorDesktop.View.LongTextView;
using QuickFix.Fields;
using QuickFix.FIX44;

namespace FixSimulatorDesktop
{
    public partial class MainForm : Form
    {
        delegate void SetAcceptorLogTextDelegatorType(string texto);
        delegate void SetInitiatorLogTextDelegatorType(string texto);
        delegate void SetOnMessageDelegatorType(object col0, object col1, object col2, object col3, object col4, object col5, object col6, object col7, object col8, object col9, object col10, object col11);

        private readonly FixApplicationManager _fixManager;

        public MainForm()
        {
            InitializeComponent();
            LoadState();
            ToggleInitiatorButtons(false);
            ToggleAcceptorButtons(false);

            _fixManager = new FixApplicationManager(InitiatorAppendLog, AcceptorAppendLog, OnMessageReceivedOrSent);
        }

        private void LoadState()
        {
            InitiatorShowReceivedChb.Checked = StateManager.IsInitiatorShowMessagesReceived;
            InitiatorShowSentChb.Checked = StateManager.IsInitiatorShowMessagesSent;
            AcceptorShowReceivedChb.Checked = StateManager.IsAcceptorShowMessagesReceived;
            AcceptorShowSentChb.Checked = StateManager.IsAcceptorShowMessagesSent;
            AcceptorIntervalTxt.Text = StateManager.AcceptorIntervalMilis.ToString();

            AcceptorMacrosClb.SetItemCheckState(0, StateManager.AcceptorMacroExecutionReportNew ? CheckState.Checked : CheckState.Unchecked);
            AcceptorMacrosClb.SetItemCheckState(1, StateManager.AcceptorMacroExecutionReportFilled ? CheckState.Checked : CheckState.Unchecked);
            AcceptorMacrosClb.SetItemCheckState(2, StateManager.AcceptorMacroExecutionReportPartiallyFilledUnique ? CheckState.Checked : CheckState.Unchecked);
            AcceptorMacrosClb.SetItemCheckState(3, StateManager.AcceptorMacroExecutionReportPartiallyFilledScheduled ? CheckState.Checked : CheckState.Unchecked);
            AcceptorMacrosClb.SetItemCheckState(4, StateManager.AcceptorMacroExecutionReportReplaced ? CheckState.Checked : CheckState.Unchecked);
            AcceptorMacrosClb.SetItemCheckState(5, StateManager.AcceptorMacroExecutionReportReplaceReject ? CheckState.Checked : CheckState.Unchecked);
            AcceptorMacrosClb.SetItemCheckState(6, StateManager.AcceptorMacroExecutionReportCanceled ? CheckState.Checked : CheckState.Unchecked);
            AcceptorMacrosClb.SetItemCheckState(7, StateManager.AcceptorMacroExecutionReportCancelReject ? CheckState.Checked : CheckState.Unchecked);
        }

        private void ToggleInitiatorButtons(bool isRunning)
        {
            InitiatorCleanStoreToolStripMenuItem.Enabled = !isRunning;
            InitiatorNewOrderSingleFastBtn.Enabled = isRunning;
            InitiatorNewOrderSingleBtn.Enabled = isRunning;
            InitiatorOrderReplaceBtn.Enabled = isRunning;
            InitiatorOrderCancelBtn.Enabled = isRunning;
        }

        private void ToggleAcceptorButtons(bool isRunning)
        {
            AcceptorClearStoreToolStripMenuItem1.Enabled = !isRunning;
            ExecutionReportNewBtn.Enabled = isRunning;
            ExecutionReportFilledBtn.Enabled = isRunning;
        }

        private void AcceptorAppendLog(string text)
        {
            try
            {
                text = $"{DateTime.Now:HH:mm:ss.ffff} {text}\r\n".Replace("\u0001", "|");
                if (this.AcceptorLogRTxt.InvokeRequired)
                {
                    var del = new SetAcceptorLogTextDelegatorType((string txt) => AcceptorLogRTxt?.AppendText(txt));
                    if (!AcceptorLogRTxt.IsDisposed)
                    {
                        AcceptorLogRTxt?.Invoke(del, text);
                    }
                }
                else
                {
                    AcceptorLogRTxt?.AppendText(text);
                }
            }
            catch
            {
                //do nothing
            }
        }

        private void InitiatorAppendLog(string text)
        {
            try
            {
                text = $"{DateTime.Now:HH:mm:ss.ffff} {text}\r\n".Replace("\u0001", "|");
                if (this.InitiatorLogRTxt.InvokeRequired)
                {
                    var del = new SetInitiatorLogTextDelegatorType((string txt) => InitiatorLogRTxt?.AppendText(txt));

                    if (!InitiatorLogRTxt.IsDisposed)
                    {

                        InitiatorLogRTxt?.Invoke(del, text);

                    }
                }
                else
                {
                    InitiatorLogRTxt?.AppendText(text);
                }
            }
            catch
            {
                //do nothing
            }
        }

        public void AddRow(params object[] values)
        {
            MessagesDg?.Rows?.Add(values);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cursor = Cursors.WaitCursor;            
            InitiatorStatus.Text = "Encerrando aplicação. Aguarde...";
            AcceptorStatus.Text = "";

            _fixManager.StopInitiator();
            Thread.Sleep(100);
            _fixManager.StopAcceptor();
            Thread.Sleep(100);
            Application.Exit();
        }

        private void InitiatorNewOrderSingleFastBtn_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var order = OrderBuilder.NewOrderSingle(StateManager.Account, StateManager.Symbol, StateManager.Side, StateManager.Operation, StateManager.Price, StateManager.Quantity);
                _fixManager.InitiatorFixApp.Send(order);
            });
        }

        private void InitiatorNewOrderSingleBtn_Click(object sender, EventArgs e)
        {
            var newOrderSingleForm = new NewOrderSingleForm(() =>
            {
                Task.Run(() =>
                {
                    var order = OrderBuilder.NewOrderSingle(StateManager.Account, StateManager.Symbol, StateManager.Side, StateManager.Operation, StateManager.Price, StateManager.Quantity);
                    _fixManager.InitiatorFixApp.Send(order);
                });
            });
            newOrderSingleForm.ShowDialog();
        }

        private void ExecutionReportBtn_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                _fixManager.AcceptorFixApp.SendErNewToLastMessage();
            });
        }

        private void ExecutionReportFilledBtn_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                _fixManager.AcceptorFixApp.SendErFilledToLastMessage();
            });
        }

        private void AcceptorMacrosClb_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    StateManager.AcceptorMacroExecutionReportNew = e.NewValue == CheckState.Checked; break;
                case 1:
                    StateManager.AcceptorMacroExecutionReportFilled = e.NewValue == CheckState.Checked; break;
                case 2:
                    StateManager.AcceptorMacroExecutionReportPartiallyFilledUnique = e.NewValue == CheckState.Checked; break;
                case 3:
                    StateManager.AcceptorMacroExecutionReportPartiallyFilledScheduled = e.NewValue == CheckState.Checked; break;
                case 4:
                    StateManager.AcceptorMacroExecutionReportReplaced = e.NewValue == CheckState.Checked; break;
                case 5:
                    StateManager.AcceptorMacroExecutionReportReplaceReject = e.NewValue == CheckState.Checked; break;
                case 6:
                    StateManager.AcceptorMacroExecutionReportCanceled = e.NewValue == CheckState.Checked; break;
                case 7:
                    StateManager.AcceptorMacroExecutionReportCancelReject = e.NewValue == CheckState.Checked; break;
            }
        }


        private void OnMessageReceivedOrSent(QuickFix.Message message)
        {
            var senderCompId = message.Header.IsSetField(new SenderCompID().Tag) ? message.Header.GetString(new SenderCompID().Tag) : "";
            var direction = senderCompId.Contains("EXECUTOR") ? "<==" : "==>";
            var msgType = message.Header.IsSetField(new MsgType().Tag) ? message.Header.GetString(new MsgType().Tag) : "";
            msgType = FixDictionary.GetMsgTypeText(msgType);

            var statusChar = message.IsSetField(new OrdStatus().Tag) ? message.GetChar(new OrdStatus().Tag) : '\0';
            var statusString = FixDictionary.GetOrdStatus(statusChar);

            var execTypeChar = message.IsSetField(new ExecType().Tag) ? message.GetChar(new ExecType().Tag) : '\0';
            var execTypeString = FixDictionary.GetOrdStatus(execTypeChar);

            var sideChar = message.IsSetField(new Side().Tag) ? message.GetChar(new Side().Tag) : '\0';
            var sideString = FixDictionary.GetSide(sideChar);

            var row = new object[]{
                message.GetDateTime(new TransactTime().Tag).ToString("HH:mm:ss.ffff"),
                direction,
                msgType,
                message.IsSetField(new Symbol().Tag) ? message.GetString(new Symbol().Tag) : "",
                sideString,
                execTypeString,
                statusString,
                message.IsSetField(new OrderQty().Tag) ? message.GetDecimal(new OrderQty().Tag) : "",
                message.IsSetField(new CumQty().Tag) ? message.GetDecimal(new CumQty().Tag) : "",
                message.IsSetField(new ClOrdID().Tag) ? message.GetString(new ClOrdID().Tag) : "",
                message.IsSetField(new OrigClOrdID().Tag) ? message.GetString(new OrigClOrdID().Tag) : "",
                message.ToString().Replace("\u0001", "|") //Msg
            };
            if (this.MessagesDg.InvokeRequired)
            {
                var del = new SetOnMessageDelegatorType(
                    (object col0, object col1, object col2, object col3, object col4, object col5, object col6, object col7, object col8, object col9, object col10, object col11) =>
                    {
                        AddRow(col0, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11);
                        MessagesDg.FirstDisplayedScrollingRowIndex = MessagesDg.RowCount - 1;
                    });
                MessagesDg?.Invoke(del, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11]);
            }
            else
            {
                AddRow(row);
                MessagesDg.FirstDisplayedScrollingRowIndex = MessagesDg.RowCount - 1;
            }
        }

        private void MessagesDg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var messageViewer = new LongTextViewerForm(MessagesDg.Rows[e.RowIndex].Cells[MessagesDg.ColumnCount - 1].Value.ToString());
            messageViewer.ShowDialog();
        }

        private void InitiatorOrderReplaceBtn_Click(object sender, EventArgs e)
        {
            var lastNewOrderSingle = (NewOrderSingle)this._fixManager.InitiatorFixApp.SentMessages
                .LastOrDefault(m =>
                    m.Header.GetString(new MsgType().Tag) == QuickFix.Fields.MsgType.NEWORDERSINGLE);

            if (lastNewOrderSingle != null)
            {
                var replaceMessageForm = new ReplaceMessageForm(lastNewOrderSingle,
                    (int newQty, decimal newPrice) =>
                {
                    var replaceMessage = OrderBuilder.OrderCancelReplaceRequest(lastNewOrderSingle, newQty, newPrice);
                    this._fixManager.InitiatorFixApp.Send(replaceMessage);
                });
                replaceMessageForm.ShowDialog();
            }
        }

        private void InitiatorOrderCancelBtn_Click(object sender, EventArgs e)
        {
            var lastNewOrderSingle = (NewOrderSingle)this._fixManager.InitiatorFixApp.SentMessages
                .LastOrDefault(m =>
                    m.Header.GetString(new MsgType().Tag) == QuickFix.Fields.MsgType.NEWORDERSINGLE);
            if (lastNewOrderSingle != null)
            {
                var replaceMessage = OrderBuilder.OrderCancelRequest(lastNewOrderSingle);
                this._fixManager.InitiatorFixApp.Send(replaceMessage);
            }
        }

        private void InitiatorShowReceivedChb_CheckedChanged(object sender, EventArgs e)
        {
            StateManager.IsInitiatorShowMessagesReceived = InitiatorShowReceivedChb.Checked;
        }

        private void InitiatorShowSentChb_CheckedChanged(object sender, EventArgs e)
        {
            StateManager.IsInitiatorShowMessagesSent = InitiatorShowSentChb.Checked;
        }

        private void AcceptorShowReceivedChb_CheckedChanged(object sender, EventArgs e)
        {
            StateManager.IsAcceptorShowMessagesReceived = AcceptorShowReceivedChb.Checked;
        }

        private void AcceptorShowSentChb_CheckedChanged(object sender, EventArgs e)
        {
            StateManager.IsAcceptorShowMessagesSent = AcceptorShowSentChb.Checked;
        }

        private void AcceptorIntervalTxt_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(AcceptorIntervalTxt.Text, out var interval))
            {
                StateManager.AcceptorIntervalMilis = interval;
            }
            else
            {
                AcceptorIntervalTxt.Text = StateManager.AcceptorIntervalMilis.ToString();
            }
        }

        private void InitiatorCleanStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmDialog = MessageBox.Show("Confirma a exclusão de todos os arquivos da Store do Initiator?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirmDialog == DialogResult.Yes)
            {
                FileHelper.DeleteFiles("InitiatorStore\\");
                InitiatorAppendLog("Arquivos da Store removidos!");
            }
        }

        private void InitiatorFixConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var initiatorConfigForm = new FixConfigForm("Initiator");
            initiatorConfigForm.ShowDialog();
        }

        private void AcceptorClearStoreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var confirmDialog = MessageBox.Show("Confirma a exclusão de todos os arquivos da Store do Acceptor?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirmDialog == DialogResult.Yes)
            {
                FileHelper.DeleteFiles("AcceptorStore\\");
                AcceptorAppendLog("Arquivos da Store removidos!");
            }
        }

        private void AcceptorFixConfigToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var acceptorConfigForm = new FixConfigForm("Acceptor");
            acceptorConfigForm.ShowDialog();
        }

        private void ClearMessageListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessagesDg.Rows.Clear();
        }

        private void ClearLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitiatorLogRTxt.Text = string.Empty;
        }

        private void AcceptorClearLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcceptorLogRTxt.Text = string.Empty;
        }

        private void InitiatorStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StateManager.IsInitiatorRunning)
            {
                var confirmDialog = MessageBox.Show("O Initiator está rodando.\r\nTem certeza que gostaria de parar a aplicação?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirmDialog == DialogResult.Yes)
                {
                    _fixManager.StopInitiator();
                    StateManager.IsInitiatorRunning = false;
                    InitiatorStartToolStripMenuItem.Text = "Ativar";
                    InitiatorAppendLog("Parando...");
                    InitiatorStatus.Text = "Initiator: Parado";
                    ToggleInitiatorButtons(false);
                }
            }
            else
            {
                StateManager.IsInitiatorRunning = _fixManager.StartInitiator();
                if (StateManager.IsInitiatorRunning)
                {
                    InitiatorStartToolStripMenuItem.Text = "Desativar";
                    InitiatorAppendLog("Iniciando...");
                    InitiatorStatus.Text = "Initiator: Rodando";
                    ToggleInitiatorButtons(true);
                }
            }
        }

        private void AcceptorStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StateManager.IsAcceptorRunning)
            {
                var confirmDialog = MessageBox.Show("O Acceptor está rodando.\r\nTem certeza que gostaria de parar a aplicação?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirmDialog == DialogResult.Yes)
                {
                    _fixManager.StopAcceptor();
                    StateManager.IsAcceptorRunning = false;
                    AcceptorStartToolStripMenuItem.Text = "Ativar";
                    AcceptorAppendLog("Parando...");
                    AcceptorStatus.Text = "Acceptor: Parado";
                    ToggleAcceptorButtons(false);
                }
            }
            else
            {
                StateManager.IsAcceptorRunning = _fixManager.StartAcceptor();
                if (StateManager.IsAcceptorRunning)
                {
                    AcceptorStartToolStripMenuItem.Text = "Desativar";
                    AcceptorAppendLog("Iniciando...");
                    AcceptorStatus.Text = "Acceptor: Rodando";
                    ToggleAcceptorButtons(true);
                }
            }
        }

        public void SetAllControlsFont(ControlCollection ctrls, string operation)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl.Controls != null)
                    SetAllControlsFont(ctrl.Controls, operation);

                if (operation == "increase" && ctrl.Font.Size < 11)
                {
                    ctrl.Font = new Font("Segoe UI", ctrl.Font.Size + 1);
                }
                else if (operation == "decrease" && ctrl.Font.Size > 9)
                {
                    ctrl.Font = new Font("Segoe UI", ctrl.Font.Size - 1);
                }
                else if (operation == "default")
                {
                    ctrl.Font = new Font("Segoe UI", 9);
                }
            }
        }

        public void SetAllControlsFont(Control.ControlCollection ctrls, string operation)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl.Controls != null)
                    SetAllControlsFont(ctrl.Controls, operation);

                if (operation == "increase" && ctrl.Font.Size < 11)
                {
                    ctrl.Font = new Font("Segoe UI", ctrl.Font.Size + 1);
                }
                else if (operation == "decrease" && ctrl.Font.Size > 9)
                {
                    ctrl.Font = new Font("Segoe UI", ctrl.Font.Size - 1);
                }
                else if (operation == "default")
                {
                    ctrl.Font = new Font("Segoe UI", 9);
                }

            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.OemMinus)
            {
                e.SuppressKeyPress = true;
                SetAllControlsFont(this.Controls, "decrease");
            }

            if (e.Control && e.KeyCode == Keys.Oemplus)
            {
                e.SuppressKeyPress = true;
                SetAllControlsFont(this.Controls, "increase");
            }

            if (e.Control && e.KeyCode == Keys.D0)
            {
                e.SuppressKeyPress = true;
                SetAllControlsFont(this.Controls, "default");
            }
        }

        private void InitiatorLogRTxt_DoubleClick(object sender, EventArgs e)
        {
            var textViewForm = new LongTextViewerForm(InitiatorLogRTxt.Text);
            textViewForm.ShowDialog();
        }

        private void AcceptorLogRTxt_DoubleClick(object sender, EventArgs e)
        {
            var textViewForm = new LongTextViewerForm(AcceptorLogRTxt.Text);
            textViewForm.ShowDialog();
        }
    }
}