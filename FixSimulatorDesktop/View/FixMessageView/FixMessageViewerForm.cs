namespace FixSimulatorDesktop.View.FixMessageView
{
    public partial class FixMessageViewerForm : Form
    {
        public FixMessageViewerForm(string text)
        {
            InitializeComponent();
            MessageTxt.Text = text;
        }
    }
}
