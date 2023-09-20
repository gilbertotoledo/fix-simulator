namespace FixSimulatorDesktop.View.ExecutionReportView
{
    partial class ExecutionReportView
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
            label1 = new Label();
            ClOrderIdTxt = new TextBox();
            SendBtn = new Button();
            label2 = new Label();
            StatusCb = new ComboBox();
            panel1 = new Panel();
            SideBuyRb = new RadioButton();
            SideSellRb = new RadioButton();
            PriceTxt = new TextBox();
            label5 = new Label();
            QuantityTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            OperationCb = new ComboBox();
            AccountTxt = new TextBox();
            label6 = new Label();
            SymbolTxt = new TextBox();
            label7 = new Label();
            CancelBtn = new Button();
            ApplIdTxt = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 102);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "OrigClOrderId:";
            // 
            // ClOrderIdTxt
            // 
            ClOrderIdTxt.Location = new Point(101, 99);
            ClOrderIdTxt.Name = "ClOrderIdTxt";
            ClOrderIdTxt.Size = new Size(202, 23);
            ClOrderIdTxt.TabIndex = 7;
            // 
            // SendBtn
            // 
            SendBtn.Location = new Point(263, 171);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(296, 23);
            SendBtn.TabIndex = 10;
            SendBtn.Text = "Enviar";
            SendBtn.UseVisualStyleBackColor = true;
            SendBtn.Click += SendBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 102);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Status:";
            // 
            // StatusCb
            // 
            StatusCb.FormattingEnabled = true;
            StatusCb.Items.AddRange(new object[] { "New", "Filled" });
            StatusCb.Location = new Point(393, 99);
            StatusCb.Name = "StatusCb";
            StatusCb.Size = new Size(115, 23);
            StatusCb.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(SideBuyRb);
            panel1.Controls.Add(SideSellRb);
            panel1.Location = new Point(222, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(144, 30);
            panel1.TabIndex = 5;
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
            SideBuyRb.TextChanged += SideBuyRb_CheckedChanged;
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
            SideSellRb.TextChanged += SideSellRb_CheckedChanged;
            // 
            // PriceTxt
            // 
            PriceTxt.Location = new Point(458, 12);
            PriceTxt.Name = "PriceTxt";
            PriceTxt.Size = new Size(100, 23);
            PriceTxt.TabIndex = 3;
            PriceTxt.TextChanged += PriceTxt_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(412, 15);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 23;
            label5.Text = "Preço:";
            // 
            // QuantityTxt
            // 
            QuantityTxt.Location = new Point(300, 12);
            QuantityTxt.Name = "QuantityTxt";
            QuantityTxt.Size = new Size(100, 23);
            QuantityTxt.TabIndex = 2;
            QuantityTxt.TextChanged += QuantityTxt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 15);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 20;
            label4.Text = "Quantidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 73);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 18;
            label3.Text = "Operação:";
            // 
            // OperationCb
            // 
            OperationCb.FormattingEnabled = true;
            OperationCb.Items.AddRange(new object[] { "POSITION", "DAYTRADE" });
            OperationCb.Location = new Point(101, 70);
            OperationCb.Name = "OperationCb";
            OperationCb.Size = new Size(100, 23);
            OperationCb.TabIndex = 6;
            OperationCb.TextChanged += OperationCb_SelectedIndexChanged;
            // 
            // AccountTxt
            // 
            AccountTxt.Location = new Point(101, 41);
            AccountTxt.Name = "AccountTxt";
            AccountTxt.Size = new Size(100, 23);
            AccountTxt.TabIndex = 4;
            AccountTxt.TextChanged += AccountTxt_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 44);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 17;
            label6.Text = "Conta:";
            // 
            // SymbolTxt
            // 
            SymbolTxt.Location = new Point(101, 12);
            SymbolTxt.Name = "SymbolTxt";
            SymbolTxt.Size = new Size(100, 23);
            SymbolTxt.TabIndex = 1;
            SymbolTxt.TextChanged += SymbolTxt_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 15);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 14;
            label7.Text = "Símbolo:";
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(12, 171);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(245, 23);
            CancelBtn.TabIndex = 11;
            CancelBtn.Text = "Cancelar";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // ApplIdTxt
            // 
            ApplIdTxt.Location = new Point(101, 128);
            ApplIdTxt.Name = "ApplIdTxt";
            ApplIdTxt.Size = new Size(202, 23);
            ApplIdTxt.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 131);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 25;
            label8.Text = "ApplID:";
            // 
            // ExecutionReportView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 206);
            Controls.Add(ApplIdTxt);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(PriceTxt);
            Controls.Add(label5);
            Controls.Add(QuantityTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(OperationCb);
            Controls.Add(AccountTxt);
            Controls.Add(label6);
            Controls.Add(SymbolTxt);
            Controls.Add(label7);
            Controls.Add(CancelBtn);
            Controls.Add(StatusCb);
            Controls.Add(label2);
            Controls.Add(SendBtn);
            Controls.Add(ClOrderIdTxt);
            Controls.Add(label1);
            Name = "ExecutionReportView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Envio de ExecutionReport";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ClOrderIdTxt;
        private Button SendBtn;
        private Label label2;
        private ComboBox StatusCb;
        private Panel panel1;
        private RadioButton SideBuyRb;
        private RadioButton SideSellRb;
        private TextBox PriceTxt;
        private Label label5;
        private TextBox QuantityTxt;
        private Label label4;
        private Label label3;
        private ComboBox OperationCb;
        private TextBox AccountTxt;
        private Label label6;
        private TextBox SymbolTxt;
        private Label label7;
        private Button CancelBtn;
        private TextBox ApplIdTxt;
        private Label label8;
    }
}