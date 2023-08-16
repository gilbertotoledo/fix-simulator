using FixSimulatorDesktop.FixApp;
using FixSimulatorDesktop.FixApplication;
using FixSimulatorDesktop.FixApplication.Order;
using FixSimulatorDesktop.Helper;
using FixSimulatorDesktop.State;
using FixSimulatorDesktop.View;
using FixSimulatorDesktop.View.FixMessageView;
using QuickFix.Fields;
using QuickFix.FIX44;
using System.Windows.Forms;

namespace FixSimulatorDesktop
{
    public partial class MainForm : Form
    {
        delegate void SetAcceptorLogTextDelegatorType(string texto);
        delegate void SetInitiatorLogTextDelegatorType(string texto);
        delegate void SetOnMessageDelegatorType(object col0, object col1, object col2, object col3, object col4, object col5, object col6, object col7, object col8, object col9);

        private readonly FixApplicationManager _fixManager;

        public MainForm()
        {
            InitializeComponent();
            LoadState();
            ToggleInitiatorButtons(false);
            ToggleAcceptorButtons(false);

            _fixManager = new FixApplicationManager(InitiatorAppendLog, AcceptorAppendLog, AddMessageToDataGrid);
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
                if (this.AcceptorLogTxt.InvokeRequired)
                {
                    var del = new SetAcceptorLogTextDelegatorType((string txt) => AcceptorLogTxt?.AppendText(txt));
                    if (!AcceptorLogTxt.IsDisposed)
                    {
                        AcceptorLogTxt?.Invoke(del, text);
                    }
                }
                else
                {
                    AcceptorLogTxt?.AppendText(text);
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
                if (this.InitiatorLogTxt.InvokeRequired)
                {
                    var del = new SetInitiatorLogTextDelegatorType((string txt) => InitiatorLogTxt?.AppendText(txt));

                    if (!InitiatorLogTxt.IsDisposed)
                    {

                        InitiatorLogTxt?.Invoke(del, text);

                    }
                }
                else
                {
                    InitiatorLogTxt?.AppendText(text);
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

        private void InitiatorStartStopBtn_Click(object sender, EventArgs e)
        {
            if (StateManager.IsInitiatorRunning)
            {
                var confirmDialog = MessageBox.Show("O Initiator está rodando.\r\nTem certeza que gostaria de parar a aplicação?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirmDialog == DialogResult.Yes)
                {
                    _fixManager.StopInitiator();
                    StateManager.IsInitiatorRunning = false;
                    InitiatorStartStopBtn.Text = "Ativar";
                    InitiatorAppendLog("Parando...");
                    ToggleInitiatorButtons(false);
                }
            }
            else
            {
                StateManager.IsInitiatorRunning = _fixManager.StartInitiator();
                if (StateManager.IsInitiatorRunning)
                {
                    InitiatorStartStopBtn.Text = "Desativar";
                    InitiatorAppendLog("Iniciando...");
                    ToggleInitiatorButtons(true);
                }
            }
        }

        private void AcceptorStartStopBtn_Click(object sender, EventArgs e)
        {
            if (StateManager.IsAcceptorRunning)
            {
                var confirmDialog = MessageBox.Show("O Acceptor está rodando.\r\nTem certeza que gostaria de parar a aplicação?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirmDialog == DialogResult.Yes)
                {
                    _fixManager.StopAcceptor();
                    StateManager.IsAcceptorRunning = false;
                    AcceptorStartStopBtn.Text = "Ativar";
                    AcceptorAppendLog("Parando...");
                    ToggleAcceptorButtons(false);
                }
            }
            else
            {
                StateManager.IsAcceptorRunning = _fixManager.StartAcceptor();
                if (StateManager.IsAcceptorRunning)
                {
                    AcceptorStartStopBtn.Text = "Desativar";
                    AcceptorAppendLog("Iniciando...");
                    ToggleAcceptorButtons(true);
                }
            }
        }

        private void InitiatorFixFieldsConfigBtn_Click(object sender, EventArgs e)
        {
            var fixFieldsConfigForm = new FixFieldsConfigForm();
            fixFieldsConfigForm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _fixManager.StopAcceptor();
            _fixManager.StopInitiator();
        }

        private void InitiatorNewOrderSingleBtn_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var order = OrderBuilder.NewOrderSingle(StateManager.Account, StateManager.Symbol, StateManager.Side, StateManager.Strategy, StateManager.Price, StateManager.Quantity);
                _fixManager.InitiatorFixApp.Send(order);
            });
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


        private void AddMessageToDataGrid(QuickFix.Message message)
        {
            var senderCompId = message.Header.IsSetField(new SenderCompID().Tag) ? message.Header.GetString(new SenderCompID().Tag) : "";
            var direction = senderCompId.Contains("EXECUTOR") ? "<==" : "==>";
            var msgType = message.Header.IsSetField(new MsgType().Tag) ? message.Header.GetString(new MsgType().Tag) : "";
            msgType = FixDictionary.GetMsgTypeText(msgType);

            var statusChar = message.IsSetField(new OrdStatus().Tag) ? message.GetChar(new OrdStatus().Tag) : '\0';
            var statusString = FixDictionary.GetOrdStatus(statusChar);

            var execTypeChar = message.IsSetField(new ExecType().Tag) ? message.GetChar(new ExecType().Tag) : '\0';
            var execTypeString = FixDictionary.GetOrdStatus(execTypeChar);

            var row = new object[]{
                direction,
                msgType,
                message.IsSetField(new Symbol().Tag) ? message.GetString(new Symbol().Tag) : "",
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
                    (object col0, object col1, object col2, object col3, object col4, object col5, object col6, object col7, object col8, object col9) =>
                    {
                        AddRow(col0, col1, col2, col3, col4, col5, col6, col7, col8, col9);
                        MessagesDg.FirstDisplayedScrollingRowIndex = MessagesDg.RowCount - 1;
                    });
                MessagesDg?.Invoke(del, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9]);
            }
            else
            {
                AddRow(row);
                MessagesDg.FirstDisplayedScrollingRowIndex = MessagesDg.RowCount - 1;
            }
        }

        private void MessagesDg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var messageViewer = new LongTextViewerForm(MessagesDg.Rows[e.RowIndex].Cells[9].Value.ToString());
            messageViewer.ShowDialog();
        }

        private void InitiatorOrderReplaceBtn_Click(object sender, EventArgs e)
        {
            var lastNewOrderSingle = (NewOrderSingle)this._fixManager.InitiatorFixApp.SentMessages
                .LastOrDefault(m =>
                    m.Header.GetString(new MsgType().Tag) == QuickFix.Fields.MsgType.NEWORDERSINGLE);

            var replaceMessageForm = new ReplaceMessageForm(lastNewOrderSingle,
                (int newQty, decimal newPrice) =>
            {
                var replaceMessage = OrderBuilder.OrderCancelReplaceRequest(lastNewOrderSingle, newQty, newPrice);
                this._fixManager.InitiatorFixApp.Send(replaceMessage);
            });
            replaceMessageForm.ShowDialog();
        }

        private void InitiatorOrderCancelBtn_Click(object sender, EventArgs e)
        {
            var lastNewOrderSingle = (NewOrderSingle)this._fixManager.InitiatorFixApp.SentMessages
                .LastOrDefault(m =>
                    m.Header.GetString(new MsgType().Tag) == QuickFix.Fields.MsgType.NEWORDERSINGLE);
            var replaceMessage = OrderBuilder.OrderCancelRequest(lastNewOrderSingle);
            this._fixManager.InitiatorFixApp.Send(replaceMessage);
        }

        private void InitiatorLogTxt_DoubleClick(object sender, EventArgs e)
        {
            var textViewForm = new LongTextViewerForm(InitiatorLogTxt.Text);
            textViewForm.ShowDialog();
        }

        private void AcceptorLogTxt_DoubleClick(object sender, EventArgs e)
        {
            var textViewForm = new LongTextViewerForm(AcceptorLogTxt.Text);
            textViewForm.ShowDialog();
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
    }
}