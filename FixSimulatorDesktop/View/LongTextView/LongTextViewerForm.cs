namespace FixSimulatorDesktop.View.LongTextView
{
    public partial class LongTextViewerForm : Form
    {
        public LongTextViewerForm(string text)
        {
            InitializeComponent();
            MessageTxt.Text = text;
        }
    }
}
