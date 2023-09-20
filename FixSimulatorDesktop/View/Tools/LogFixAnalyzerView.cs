using Business.Tools.LogFixAnalyzer;
using System.Diagnostics;
using System.Text;

namespace FixSimulatorDesktop.View.Tools.LogFixAnalyzer
{
    public partial class LogFixAnalyzerView : Form
    {
        delegate void SetStatusTextDelegatorType(string texto);

        public FixLogStats FixLogStats { get; set; }

        public string SelectedFilePath { get; set; }
        public int TotalLines { get; set; }

        public LogFixAnalyzerView()
        {
            InitializeComponent();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                Title = "Selecione o arquivo contendo o LogFix"
            };
            var dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK && !string.IsNullOrEmpty(openFileDialog.FileName))
            {
                SelectedFilePath = openFileDialog.FileName;
                SelectedFileTxt.Text = SelectedFilePath;
                ProcessBtn.Enabled = true;

                TotalLines = File.ReadLines(SelectedFilePath).Count();
                SetStatus($"Total de linhas no arquivo selecionado: {TotalLines}");
            }
        }

        private async void ProcessBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SelectedFilePath))
            {
                var progress = new Progress<int>(v =>
                {
                    Progress.Value = v;
                });

                FixLogStats = new FixLogStats();
                await Task.Run(() => DoWork(progress));

                SetStatus("Processamento concluído!");

                string reportFile = FixLogStats.GenerateReport(@"C:\temp");
                if (reportFile != null)
                {
                    var p = new Process()
                    {
                        StartInfo = new ProcessStartInfo(reportFile)
                        {
                            UseShellExecute = true
                        }
                    };
                    p.Start();
                }
            }
        }

        private void SetStatus(string text)
        {
            try
            {
                if (this.StatusTxt.InvokeRequired)
                {
                    var del = new SetStatusTextDelegatorType((string txt) => StatusTxt.Text = txt);
                    if (!StatusTxt.IsDisposed)
                    {
                        StatusTxt?.Invoke(del, text);
                    }
                }
                else
                {
                    StatusTxt.Text = text;
                }
            }
            catch
            {
                //do nothing
            }
        }

        private void DoWork(IProgress<int> progress)
        {
            const Int32 BufferSize = 256;
            using var fileStream = File.OpenRead(SelectedFilePath);
            using var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize);

            int processedLines = 0;
            String line;
            SetStatus("Processando...");
            while ((line = streamReader.ReadLine()) != null)
            {
                processedLines++;
                FixLogStats.ProcessText(line);
                progress?.Report(processedLines * 100 / TotalLines);
            }
        }
    }
}
