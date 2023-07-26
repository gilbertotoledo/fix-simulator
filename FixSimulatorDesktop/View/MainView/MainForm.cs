using FixSimulatorDesktop.Controller;
using FixSimulatorDesktop.FixApplication;
using FixSimulatorDesktop.FixApplication.Order;
using FixSimulatorDesktop.Helper;
using FixSimulatorDesktop.View;
using FixSimulatorDesktop.View.FixMessageView;

namespace FixSimulatorDesktop
{
    public partial class MainForm : Form
    {
        delegate void SetAcceptorLogTextDelegatorType(string texto);
        delegate void SetInitiatorLogTextDelegatorType(string texto);
        delegate void SetOnMessageDelegatorType(object col0, object col1, object col2, object col3, object col4, object col5, object col6, object col7, object col8);

        private readonly FixApplicationManager _fixManager;

        public MainForm()
        {
            InitializeComponent();

            var loggerInitiator = (string message) =>
            {
                InitiatorAppendLog(message);
            };

            var loggerAcceptor = (string message) =>
            {
                AcceptorAppendLog(message);
            };

            var onMessageHandler = (QuickFix.Message message) =>
            {
                OnMessageHandler(message);
            };

            _fixManager = new FixApplicationManager(loggerInitiator, loggerAcceptor, onMessageHandler);

        }

        private void AcceptorAppendLog(string text)
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

        private void InitiatorAppendLog(string text)
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

        public void AddRow(params object[] values)
        {
            MessagesDg?.Rows?.Add(values);
        }

        private void InitiatorFixConfigBtn_Click(object sender, EventArgs e)
        {
            var initiatorConfigForm = new FixConfigForm("Initiator");
            initiatorConfigForm.ShowDialog();
        }

        private void AcceptorFixConfigBtn_Click(object sender, EventArgs e)
        {
            var acceptorConfigForm = new FixConfigForm("Acceptor");
            acceptorConfigForm.ShowDialog();
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
                }
            }
            else
            {
                StateManager.IsInitiatorRunning = _fixManager.StartInitiator();
                if (StateManager.IsInitiatorRunning)
                {
                    InitiatorStartStopBtn.Text = "Desativar";
                    InitiatorAppendLog("Iniciando...");
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
                }
            }
            else
            {
                StateManager.IsAcceptorRunning = _fixManager.StartAcceptor();
                if (StateManager.IsAcceptorRunning)
                {
                    AcceptorStartStopBtn.Text = "Desativar";
                    AcceptorAppendLog("Iniciando...");
                }
            }
        }

        private void InitiatorClearStoreBtn_Click(object sender, EventArgs e)
        {
            var confirmDialog = MessageBox.Show("Confirma a exclusão de todos os arquivos da Store do Initiator?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirmDialog == DialogResult.Yes)
            {
                FileHelper.DeleteFiles("InitiatorStore\\");
                InitiatorAppendLog("Arquivos da Store removidos!");
            }
        }

        private void AcceptorClearStoreBtn_Click(object sender, EventArgs e)
        {
            var confirmDialog = MessageBox.Show("Confirma a exclusão de todos os arquivos da Store do Acceptor?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirmDialog == DialogResult.Yes)
            {
                FileHelper.DeleteFiles("AcceptorStore\\");
                AcceptorAppendLog("Arquivos da Store removidos!");
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
            var order = OrderBuilder.NewOrderSingle();
            _fixManager.InitiatorFixApp.SendMessageToAllSessions(order);
        }

        private void ExecutionReportBtn_Click(object sender, EventArgs e)
        {
            _fixManager.AcceptorFixApp.SendErNewToLastMessage();
        }

        private void ExecutionReportFilledBtn_Click(object sender, EventArgs e)
        {
            _fixManager.AcceptorFixApp.SendErFilledToLastMessage();
        }

        private void AcceptorMacrosClb_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    StateManager.AcceptorMacrosEnabled.ExecutionReportNew = e.NewValue == CheckState.Checked; break;
                case 1:
                    StateManager.AcceptorMacrosEnabled.ExecutionReportFilled = e.NewValue == CheckState.Checked; break;
                case 2:
                    StateManager.AcceptorMacrosEnabled.ExecutionReportPartiallyFilledUnique = e.NewValue == CheckState.Checked; break;
                case 3:
                    StateManager.AcceptorMacrosEnabled.ExecutionReportPartiallyFilledScheduled = e.NewValue == CheckState.Checked; break;
            }
        }


        private void OnMessageHandler(QuickFix.Message message)
        {
            var senderCompId = message.Header.IsSetField(new QuickFix.Fields.SenderCompID().Tag) ? message.Header.GetString(new QuickFix.Fields.SenderCompID().Tag) : "";
            var direction = senderCompId.Contains("EXECUTOR") ? "<==" : "==>";
            var row = new object[]{
                direction,
                message.Header.IsSetField(new QuickFix.Fields.MsgType().Tag) ? message.Header.GetString(new QuickFix.Fields.MsgType().Tag) : "",
                message.IsSetField(new QuickFix.Fields.ClOrdID().Tag) ? message.GetString(new QuickFix.Fields.ClOrdID().Tag) : "",
                message.IsSetField(new QuickFix.Fields.OrigClOrdID().Tag) ? message.GetString(new QuickFix.Fields.OrigClOrdID().Tag) : "",
                message.IsSetField(new QuickFix.Fields.OrdStatus().Tag) ? message.GetChar(new QuickFix.Fields.OrdStatus().Tag).ToString() : "",
                message.IsSetField(new QuickFix.Fields.Symbol().Tag) ? message.GetString(new QuickFix.Fields.Symbol().Tag) : "",
                message.IsSetField(new QuickFix.Fields.CumQty().Tag) ? message.GetString(new QuickFix.Fields.CumQty().Tag) : "",
                message.IsSetField(new QuickFix.Fields.FillQty().Tag) ? message.GetString(new QuickFix.Fields.FillQty().Tag) : "",
                message.ToString().Replace("\u0001", "|") //Msg
            };
            if (this.MessagesDg.InvokeRequired)
            {
                var del = new SetOnMessageDelegatorType(
                    (object col0, object col1, object col2, object col3, object col4, object col5, object col6, object col7, object col8) =>
                        AddRow(col0, col1, col2, col3, col4, col5, col6, col7, col8));
                MessagesDg?.Invoke(del, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
            }
            else
            {
                AddRow(row);
            }
        }

        private void MessagesDg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var messageViewer = new FixMessageViewerForm(MessagesDg.Rows[e.RowIndex].Cells[8].Value.ToString());
            messageViewer.ShowDialog();
        }
    }
}