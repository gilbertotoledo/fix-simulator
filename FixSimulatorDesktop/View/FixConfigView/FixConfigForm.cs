using FixSimulatorDesktop.Helper;

namespace FixSimulatorDesktop.View
{
    public partial class FixConfigForm : Form
    {
        private readonly string reference;

        public FixConfigForm(string reference)
        {
            InitializeComponent();
            this.reference = reference;
            this.Text += $" - {reference}";
            ConfigTxt.Text = FileHelper.GetFileContents($"FixConfig\\{reference}.cfg");
            ConfigTxt.SelectionStart = 0;
            ConfigTxt.SelectionLength = 0;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ConfigTxt.Text = string.Empty;
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            FileHelper.SaveContentToFile(ConfigTxt.Text, $"FixConfig\\{this.reference}.cfg");
            ConfigTxt.Text = string.Empty;
            this.Close();
        }

    }
}
