namespace TM
{
    partial class HistoryWizard
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
            this.historyGridView = new System.Windows.Forms.DataGridView();
            this.ResetHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.historyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // historyGridView
            // 
            this.historyGridView.AllowUserToOrderColumns = true;
            this.historyGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyGridView.Location = new System.Drawing.Point(12, 12);
            this.historyGridView.Name = "historyGridView";
            this.historyGridView.Size = new System.Drawing.Size(657, 339);
            this.historyGridView.TabIndex = 1;
            // 
            // ResetHistory
            // 
            this.ResetHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetHistory.AutoSize = true;
            this.ResetHistory.Location = new System.Drawing.Point(308, 357);
            this.ResetHistory.Name = "ResetHistory";
            this.ResetHistory.Size = new System.Drawing.Size(94, 23);
            this.ResetHistory.TabIndex = 2;
            this.ResetHistory.Text = "Reset All History";
            this.ResetHistory.UseVisualStyleBackColor = true;
            this.ResetHistory.Click += new System.EventHandler(this.ResetHistory_Click);
            // 
            // HistoryWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 392);
            this.Controls.Add(this.ResetHistory);
            this.Controls.Add(this.historyGridView);
            this.Name = "HistoryWizard";
            this.Text = "HistoryViewer";
            this.Load += new System.EventHandler(this.HistoryWizard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historyGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView historyGridView;
        private System.Windows.Forms.Button ResetHistory;
    }
}