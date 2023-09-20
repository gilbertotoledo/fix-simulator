namespace FixSimulatorDesktop.View
{
    partial class ReplaceMessageForm
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
            ConfirmBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            NewPriceTxt = new TextBox();
            CurrentPriceTxt = new TextBox();
            CurrentQtyTxt = new TextBox();
            NewQtyTxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = SystemColors.Control;
            CancelBtn.Location = new Point(23, 88);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(194, 23);
            CancelBtn.TabIndex = 4;
            CancelBtn.Text = "Cancelar";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.Location = new Point(223, 87);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(163, 23);
            ConfirmBtn.TabIndex = 3;
            ConfirmBtn.Text = "Executar";
            ConfirmBtn.UseVisualStyleBackColor = true;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 2;
            label1.Text = "Valor atual:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 48);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Valor novo:";
            // 
            // NewPriceTxt
            // 
            NewPriceTxt.Location = new Point(94, 45);
            NewPriceTxt.Name = "NewPriceTxt";
            NewPriceTxt.Size = new Size(100, 23);
            NewPriceTxt.TabIndex = 1;
            // 
            // CurrentPriceTxt
            // 
            CurrentPriceTxt.Location = new Point(94, 16);
            CurrentPriceTxt.Name = "CurrentPriceTxt";
            CurrentPriceTxt.ReadOnly = true;
            CurrentPriceTxt.Size = new Size(100, 23);
            CurrentPriceTxt.TabIndex = 5;
            // 
            // CurrentQtyTxt
            // 
            CurrentQtyTxt.Location = new Point(286, 16);
            CurrentQtyTxt.Name = "CurrentQtyTxt";
            CurrentQtyTxt.ReadOnly = true;
            CurrentQtyTxt.Size = new Size(100, 23);
            CurrentQtyTxt.TabIndex = 9;
            // 
            // NewQtyTxt
            // 
            NewQtyTxt.Location = new Point(286, 45);
            NewQtyTxt.Name = "NewQtyTxt";
            NewQtyTxt.Size = new Size(100, 23);
            NewQtyTxt.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(214, 48);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 7;
            label3.Text = "Qtd nova:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(215, 19);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 6;
            label4.Text = "Qtd atual:";
            // 
            // ReplaceMessageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 128);
            Controls.Add(CurrentQtyTxt);
            Controls.Add(NewQtyTxt);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(CurrentPriceTxt);
            Controls.Add(NewPriceTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ConfirmBtn);
            Controls.Add(CancelBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ReplaceMessageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Ordem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelBtn;
        private Button ConfirmBtn;
        private Label label1;
        private Label label2;
        private TextBox NewPriceTxt;
        private TextBox CurrentPriceTxt;
        private TextBox CurrentQtyTxt;
        private TextBox NewQtyTxt;
        private Label label3;
        private Label label4;
    }
}