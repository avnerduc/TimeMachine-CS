namespace TM
{
    partial class Form1
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
            this.InfoButton = new System.Windows.Forms.Button();
            this.curr_sess = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartBotton = new System.Windows.Forms.Button();
            this.PauseBotton = new System.Windows.Forms.Button();
            this.StopBotton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(62, 13);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(55, 22);
            this.InfoButton.TabIndex = 0;
            this.InfoButton.Text = "Info";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoClick);
            // 
            // curr_sess
            // 
            this.curr_sess.AutoSize = true;
            this.curr_sess.Location = new System.Drawing.Point(21, 52);
            this.curr_sess.Name = "curr_sess";
            this.curr_sess.Size = new System.Drawing.Size(84, 13);
            this.curr_sess.TabIndex = 1;
            this.curr_sess.Text = "Current Session:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Completed:";
            // 
            // StartBotton
            // 
            this.StartBotton.Location = new System.Drawing.Point(50, 107);
            this.StartBotton.Name = "StartBotton";
            this.StartBotton.Size = new System.Drawing.Size(75, 23);
            this.StartBotton.TabIndex = 3;
            this.StartBotton.Text = "Start";
            this.StartBotton.UseVisualStyleBackColor = true;
            this.StartBotton.Click += new System.EventHandler(this.StartClick);
            // 
            // PauseBotton
            // 
            this.PauseBotton.Location = new System.Drawing.Point(51, 136);
            this.PauseBotton.Name = "PauseBotton";
            this.PauseBotton.Size = new System.Drawing.Size(74, 20);
            this.PauseBotton.TabIndex = 4;
            this.PauseBotton.Text = "Pause";
            this.PauseBotton.UseVisualStyleBackColor = true;
            // 
            // StopBotton
            // 
            this.StopBotton.Location = new System.Drawing.Point(50, 162);
            this.StopBotton.Name = "StopBotton";
            this.StopBotton.Size = new System.Drawing.Size(75, 23);
            this.StopBotton.TabIndex = 5;
            this.StopBotton.Text = "Stop";
            this.StopBotton.UseVisualStyleBackColor = true;
            this.StopBotton.Click += new System.EventHandler(this.StopClick);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(50, 191);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 237);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StopBotton);
            this.Controls.Add(this.PauseBotton);
            this.Controls.Add(this.StartBotton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.curr_sess);
            this.Controls.Add(this.InfoButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Label curr_sess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartBotton;
        private System.Windows.Forms.Button PauseBotton;
        private System.Windows.Forms.Button StopBotton;
        private System.Windows.Forms.Button ResetButton;
    }
}

