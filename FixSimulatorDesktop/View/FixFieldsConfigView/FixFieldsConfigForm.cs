using FixSimulatorDesktop.DTO;
using FixSimulatorDesktop.Helper;
using System.Text.Json;

namespace FixSimulatorDesktop.View
{
    public partial class FixFieldsConfigForm : Form
    {
        private const string DEFAULT_FIX_TAGS_FILE = "FixConfig\\DefaultFixTags.json";

        public FixFieldsConfigForm()
        {
            InitializeComponent();
            var configText = FileHelper.GetFileContents(DEFAULT_FIX_TAGS_FILE);
            if (!string.IsNullOrEmpty(configText))
            {
                this.SetOrderConfig(JsonSerializer.Deserialize<List<OrderFieldConfig>>(configText));
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var config = GetOrderConfig();
            var configText = JsonSerializer.Serialize(config);
            FileHelper.SaveContentToFile(configText, DEFAULT_FIX_TAGS_FILE);
            this.Close();
        }

        private List<OrderFieldConfig> GetOrderConfig()
        {
            var config = new List<OrderFieldConfig>();
            for (int i = 0; i < (OrderConfigDg.Rows.Count - 1); i++)
            {
                config.Add(new OrderFieldConfig()
                {
                    Tag = int.Parse(this.OrderConfigDg.Rows[i].Cells[0].Value.ToString()),
                    Name = this.OrderConfigDg.Rows[i].Cells[1].Value.ToString(),
                    Value = this.OrderConfigDg.Rows[i].Cells[2].Value.ToString()
                });
            }
            return config;
        }

        private void SetOrderConfig(List<OrderFieldConfig> config)
        {
            config.ForEach(c =>
            {
                this.OrderConfigDg.Rows.Add(c.Tag, c.Name, c.Value);
            });
        }
    }
}
