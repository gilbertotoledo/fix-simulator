namespace FixSimulatorDesktop.View
{
    public partial class ReplaceMessageForm : Form
    {
        private readonly Action<int, decimal> _onConfirmReplace;

        public ReplaceMessageForm(QuickFix.Message message, Action<int, decimal> onConfirmReplace)
        {
            InitializeComponent();

            _onConfirmReplace = onConfirmReplace;
            this.CurrentPriceTxt.Text = message.GetDecimal(new QuickFix.Fields.Price().Tag).ToString();
            this.NewPriceTxt.Text = message.GetDecimal(new QuickFix.Fields.Price().Tag).ToString();
            this.CurrentQtyTxt.Text = message.GetDecimal(new QuickFix.Fields.OrderQty().Tag).ToString();
            this.NewQtyTxt.Text = message.GetDecimal(new QuickFix.Fields.OrderQty().Tag).ToString();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            _onConfirmReplace.Invoke(int.Parse(this.NewQtyTxt.Text), decimal.Parse(this.NewPriceTxt.Text));
            this.Close();
        }
    }
}
