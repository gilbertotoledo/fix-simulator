namespace FixSimulatorDesktop.View
{
    partial class NewOrderSingleForm
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
            ExecuteBtn = new Button();
            label1 = new Label();
            SymbolTxt = new TextBox();
            AccountTxt = new TextBox();
            label2 = new Label();
            OperationCb = new ComboBox();
            label3 = new Label();
            QuantityTxt = new TextBox();
            label4 = new Label();
            PriceTxt = new TextBox();
            label5 = new Label();
            SideBuyRb = new RadioButton();
            SideSellRb = new RadioButton();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(23, 115);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(204, 23);
            CancelBtn.TabIndex = 9;
            CancelBtn.Text = "Cancelar";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // ExecuteBtn
            // 
            ExecuteBtn.Location = new Point(233, 116);
            ExecuteBtn.Name = "ExecuteBtn";
            ExecuteBtn.Size = new Size(295, 23);
            ExecuteBtn.TabIndex = 8;
            ExecuteBtn.Text = "Executar";
            ExecuteBtn.UseVisualStyleBackColor = true;
            ExecuteBtn.Click += ExecuteBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Símbolo:";
            // 
            // SymbolTxt
            // 
            SymbolTxt.Location = new Point(71, 12);
            SymbolTxt.Name = "SymbolTxt";
            SymbolTxt.Size = new Size(100, 23);
            SymbolTxt.TabIndex = 1;
            SymbolTxt.TextChanged += SymbolTxt_TextChanged;
            // 
            // AccountTxt
            // 
            AccountTxt.Location = new Point(71, 41);
            AccountTxt.Name = "AccountTxt";
            AccountTxt.Size = new Size(100, 23);
            AccountTxt.TabIndex = 4;
            AccountTxt.TextChanged += AccountTxt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 44);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Conta:";
            // 
            // OperationCb
            // 
            OperationCb.FormattingEnabled = true;
            OperationCb.Items.AddRange(new object[] { "POSITION", "DAYTRADE" });
            OperationCb.Location = new Point(71, 70);
            OperationCb.Name = "OperationCb";
            OperationCb.Size = new Size(100, 23);
            OperationCb.TabIndex = 7;
            OperationCb.SelectedIndexChanged += OperationCb_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 73);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 7;
            label3.Text = "Operação:";
            // 
            // QuantityTxt
            // 
            QuantityTxt.Location = new Point(270, 12);
            QuantityTxt.Name = "QuantityTxt";
            QuantityTxt.Size = new Size(100, 23);
            QuantityTxt.TabIndex = 2;
            QuantityTxt.TextChanged += QuantityTxt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 15);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 8;
            label4.Text = "Quantidade:";
            // 
            // PriceTxt
            // 
            PriceTxt.Location = new Point(428, 12);
            PriceTxt.Name = "PriceTxt";
            PriceTxt.Size = new Size(100, 23);
            PriceTxt.TabIndex = 3;
            PriceTxt.TextChanged += PriceTxt_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(382, 15);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 10;
            label5.Text = "Preço:";
            // 
            // SideBuyRb
            // 
            SideBuyRb.AutoSize = true;
            SideBuyRb.Checked = true;
            SideBuyRb.Location = new Point(3, 3);
            SideBuyRb.Name = "SideBuyRb";
            SideBuyRb.Size = new Size(68, 19);
            SideBuyRb.TabIndex = 5;
            SideBuyRb.TabStop = true;
            SideBuyRb.Text = "Compra";
            SideBuyRb.UseVisualStyleBackColor = true;
            SideBuyRb.CheckedChanged += SideBuyRb_CheckedChanged;
            // 
            // SideSellRb
            // 
            SideSellRb.AutoSize = true;
            SideSellRb.Location = new Point(72, 3);
            SideSellRb.Name = "SideSellRb";
            SideSellRb.Size = new Size(57, 19);
            SideSellRb.TabIndex = 6;
            SideSellRb.Text = "Venda";
            SideSellRb.UseVisualStyleBackColor = true;
            SideSellRb.CheckedChanged += SideSellRb_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(SideBuyRb);
            panel1.Controls.Add(SideSellRb);
            panel1.Location = new Point(198, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(144, 30);
            panel1.TabIndex = 11;
            // 
            // NewOrderSingleForm
            // 
            AcceptButton = ExecuteBtn;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            CancelButton = CancelBtn;
            ClientSize = new Size(545, 153);
            Controls.Add(panel1);
            Controls.Add(PriceTxt);
            Controls.Add(label5);
            Controls.Add(QuantityTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(OperationCb);
            Controls.Add(AccountTxt);
            Controls.Add(label2);
            Controls.Add(SymbolTxt);
            Controls.Add(label1);
            Controls.Add(ExecuteBtn);
            Controls.Add(CancelBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "NewOrderSingleForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Envio de Ordem";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelBtn;
        private Button ExecuteBtn;
        private Label label1;
        private TextBox SymbolTxt;
        private TextBox AccountTxt;
        private Label label2;
        private ComboBox OperationCb;
        private Label label3;
        private TextBox QuantityTxt;
        private Label label4;
        private TextBox PriceTxt;
        private Label label5;
        private RadioButton SideBuyRb;
        private RadioButton SideSellRb;
        private Panel panel1;
    }
}