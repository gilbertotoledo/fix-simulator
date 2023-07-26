namespace FixSimulatorDesktop.View
{
    partial class FixFieldsConfigForm
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
            CancelBtn = new Button();
            SaveBtn = new Button();
            OrderConfigDg = new DataGridView();
            FixTag = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)OrderConfigDg).BeginInit();
            SuspendLayout();
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(501, 12);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 0;
            CancelBtn.Text = "Cancelar";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(582, 12);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 1;
            SaveBtn.Text = "Salvar";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // OrderConfigDg
            // 
            OrderConfigDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderConfigDg.Columns.AddRange(new DataGridViewColumn[] { FixTag, Description, Value });
            OrderConfigDg.Location = new Point(12, 41);
            OrderConfigDg.Name = "OrderConfigDg";
            OrderConfigDg.RowTemplate.Height = 25;
            OrderConfigDg.Size = new Size(645, 618);
            OrderConfigDg.TabIndex = 2;
            // 
            // FixTag
            // 
            FixTag.HeaderText = "Tag";
            FixTag.Name = "FixTag";
            // 
            // Description
            // 
            Description.HeaderText = "Descrição";
            Description.Name = "Description";
            Description.Width = 300;
            // 
            // Value
            // 
            Value.HeaderText = "Valor";
            Value.Name = "Value";
            Value.Width = 200;
            // 
            // FixFieldsConfigForm
            // 
            AcceptButton = SaveBtn;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            CancelButton = CancelBtn;
            ClientSize = new Size(670, 671);
            Controls.Add(OrderConfigDg);
            Controls.Add(SaveBtn);
            Controls.Add(CancelBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FixFieldsConfigForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuração de Ordem Padrão";
            ((System.ComponentModel.ISupportInitialize)OrderConfigDg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CancelBtn;
        private Button SaveBtn;
        private DataGridView OrderConfigDg;
        private DataGridViewTextBoxColumn FixTag;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Value;
    }
}