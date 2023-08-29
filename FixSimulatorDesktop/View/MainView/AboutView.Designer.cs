namespace FixSimulatorDesktop.View.MainView
{
    partial class AboutView
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
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(87, 23);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 0;
            label1.Text = "Fix Simulator Desktop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 50);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 1;
            label2.Text = "Autor: Gilberto Toledo";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(77, 75);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(149, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "github.com/gilbertotoledo";
            // 
            // AboutView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 134);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AboutView";
            Text = "Sobre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
    }
}