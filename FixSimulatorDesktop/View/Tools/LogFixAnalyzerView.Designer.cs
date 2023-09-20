namespace FixSimulatorDesktop.View.Tools.LogFixAnalyzer
{
    partial class LogFixAnalyzerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SelectBtn = new Button();
            ProcessBtn = new Button();
            SelectedFileTxt = new Label();
            Progress = new ProgressBar();
            StatusTxt = new Label();
            SuspendLayout();
            // 
            // SelectBtn
            // 
            SelectBtn.Location = new Point(12, 12);
            SelectBtn.Name = "SelectBtn";
            SelectBtn.Size = new Size(118, 23);
            SelectBtn.TabIndex = 0;
            SelectBtn.Text = "Selecionar Arquivo";
            SelectBtn.UseVisualStyleBackColor = true;
            SelectBtn.Click += SelectBtn_Click;
            // 
            // ProcessBtn
            // 
            ProcessBtn.Enabled = false;
            ProcessBtn.Location = new Point(461, 12);
            ProcessBtn.Name = "ProcessBtn";
            ProcessBtn.Size = new Size(75, 23);
            ProcessBtn.TabIndex = 1;
            ProcessBtn.Text = "Processar";
            ProcessBtn.UseVisualStyleBackColor = true;
            ProcessBtn.Click += ProcessBtn_Click;
            // 
            // SelectedFileTxt
            // 
            SelectedFileTxt.Location = new Point(136, 16);
            SelectedFileTxt.MaximumSize = new Size(315, 17);
            SelectedFileTxt.Name = "SelectedFileTxt";
            SelectedFileTxt.Size = new Size(315, 17);
            SelectedFileTxt.TabIndex = 2;
            SelectedFileTxt.Text = "Nenhum arquivo selecionado";
            // 
            // Progress
            // 
            Progress.Location = new Point(12, 79);
            Progress.Name = "Progress";
            Progress.Size = new Size(524, 23);
            Progress.Step = 1;
            Progress.Style = ProgressBarStyle.Continuous;
            Progress.TabIndex = 3;
            // 
            // StatusTxt
            // 
            StatusTxt.AutoSize = true;
            StatusTxt.Location = new Point(12, 61);
            StatusTxt.Name = "StatusTxt";
            StatusTxt.Size = new Size(125, 15);
            StatusTxt.TabIndex = 4;
            StatusTxt.Text = "Aguardando arquivo...";
            // 
            // LogFixAnalyzerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 112);
            Controls.Add(StatusTxt);
            Controls.Add(Progress);
            Controls.Add(SelectedFileTxt);
            Controls.Add(ProcessBtn);
            Controls.Add(SelectBtn);
            Name = "LogFixAnalyzerView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogFixView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SelectBtn;
        private Button ProcessBtn;
        private Label SelectedFileTxt;
        private ProgressBar Progress;
        private Label StatusTxt;
    }
}