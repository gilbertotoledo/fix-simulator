﻿namespace FixSimulatorDesktop.View.LongTextView
{
    partial class LongTextViewerForm
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
            MessageTxt = new TextBox();
            SuspendLayout();
            // 
            // MessageTxt
            // 
            MessageTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MessageTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MessageTxt.Location = new Point(12, 12);
            MessageTxt.Multiline = true;
            MessageTxt.Name = "MessageTxt";
            MessageTxt.Size = new Size(1048, 569);
            MessageTxt.TabIndex = 0;
            // 
            // LongTextViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 593);
            Controls.Add(MessageTxt);
            Name = "LongTextViewerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizador de texto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MessageTxt;
    }
}