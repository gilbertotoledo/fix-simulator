namespace FixSimulatorDesktop.View
{
    partial class FixConfigForm
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
            ConfigTxt = new TextBox();
            SaveBtn = new Button();
            CancelBtn = new Button();
            SuspendLayout();
            // 
            // ConfigTxt
            // 
            ConfigTxt.CausesValidation = false;
            ConfigTxt.Location = new Point(12, 34);
            ConfigTxt.Multiline = true;
            ConfigTxt.Name = "ConfigTxt";
            ConfigTxt.ScrollBars = ScrollBars.Vertical;
            ConfigTxt.Size = new Size(617, 636);
            ConfigTxt.TabIndex = 0;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(554, 5);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 1;
            SaveBtn.Text = "Salvar";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(473, 5);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 2;
            CancelBtn.Text = "Cancelar";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 682);
            Controls.Add(CancelBtn);
            Controls.Add(SaveBtn);
            Controls.Add(ConfigTxt);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ConfigForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configurações Fix";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ConfigTxt;
        private Button SaveBtn;
        private Button CancelBtn;
    }
}