using System;

namespace TM
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sessionTime = new System.Windows.Forms.Label();
            this.completedLabel = new System.Windows.Forms.Label();
            this.startPauseButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.sessionLabel = new System.Windows.Forms.Label();
            this.GUIRefresh = new System.Windows.Forms.Timer(this.components);
            this.completedTime = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryEdit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlwaysOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.QuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesWizardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyWizardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopSaveButton = new System.Windows.Forms.Button();
            this.resetSessionButton = new System.Windows.Forms.Button();
            this.descriptionButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sessionTime
            // 
            this.sessionTime.AutoSize = true;
            this.sessionTime.Location = new System.Drawing.Point(114, 48);
            this.sessionTime.Name = "sessionTime";
            this.sessionTime.Size = new System.Drawing.Size(49, 13);
            this.sessionTime.TabIndex = 1;
            this.sessionTime.Text = "00:00:00";
            // 
            // completedLabel
            // 
            this.completedLabel.AutoSize = true;
            this.completedLabel.Location = new System.Drawing.Point(13, 71);
            this.completedLabel.Name = "completedLabel";
            this.completedLabel.Size = new System.Drawing.Size(60, 13);
            this.completedLabel.TabIndex = 2;
            this.completedLabel.Text = "Completed:";
            // 
            // startPauseButton
            // 
            this.startPauseButton.Location = new System.Drawing.Point(12, 98);
            this.startPauseButton.Name = "startPauseButton";
            this.startPauseButton.Size = new System.Drawing.Size(75, 23);
            this.startPauseButton.TabIndex = 3;
            this.startPauseButton.Text = "Start";
            this.startPauseButton.UseVisualStyleBackColor = true;
            this.startPauseButton.Click += new System.EventHandler(this.StartPause_Click);
            // 
            // resetButton
            // 
            this.resetButton.Enabled = false;
            this.resetButton.Location = new System.Drawing.Point(115, 231);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(48, 23);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.Reset_Click);
            // 
            // sessionLabel
            // 
            this.sessionLabel.AutoSize = true;
            this.sessionLabel.Location = new System.Drawing.Point(13, 48);
            this.sessionLabel.Name = "sessionLabel";
            this.sessionLabel.Size = new System.Drawing.Size(84, 13);
            this.sessionLabel.TabIndex = 7;
            this.sessionLabel.Text = "Current Session:";
            this.sessionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // GUIRefresh
            // 
            this.GUIRefresh.Enabled = true;
            this.GUIRefresh.Tick += new System.EventHandler(this.GUIRefresh_Tick);
            // 
            // completedTime
            // 
            this.completedTime.AutoSize = true;
            this.completedTime.Location = new System.Drawing.Point(114, 71);
            this.completedTime.Name = "completedTime";
            this.completedTime.Size = new System.Drawing.Size(49, 13);
            this.completedTime.TabIndex = 8;
            this.completedTime.Text = "00:00:00";
            this.completedTime.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(16, 159);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(121, 21);
            this.categoryBox.TabIndex = 9;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.CategoryBox_SelectedIndexChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(13, 143);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 10;
            this.categoryLabel.Text = "Category";
            // 
            // categoryEdit
            // 
            this.categoryEdit.Image = global::TM.Properties.Resources.Categories;
            this.categoryEdit.Location = new System.Drawing.Point(139, 159);
            this.categoryEdit.Name = "categoryEdit";
            this.categoryEdit.Size = new System.Drawing.Size(24, 24);
            this.categoryEdit.TabIndex = 11;
            this.categoryEdit.UseVisualStyleBackColor = true;
            this.categoryEdit.Click += new System.EventHandler(this.CategoryEdit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(186, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AlwaysOnTop,
            this.toolStripSeparator1,
            this.QuitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // AlwaysOnTop
            // 
            this.AlwaysOnTop.Name = "AlwaysOnTop";
            this.AlwaysOnTop.Size = new System.Drawing.Size(152, 22);
            this.AlwaysOnTop.Text = "Always On Top";
            this.AlwaysOnTop.Click += new System.EventHandler(this.AlwaysOnTop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // QuitToolStripMenuItem
            // 
            this.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
            this.QuitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.QuitToolStripMenuItem.Text = "Quit";
            this.QuitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriesWizardToolStripMenuItem,
            this.historyWizardToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // categoriesWizardToolStripMenuItem
            // 
            this.categoriesWizardToolStripMenuItem.Name = "categoriesWizardToolStripMenuItem";
            this.categoriesWizardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriesWizardToolStripMenuItem.Text = "Category Wizard";
            this.categoriesWizardToolStripMenuItem.Click += new System.EventHandler(this.CategoriesWizardToolStripMenuItem_Click);
            // 
            // historyWizardToolStripMenuItem
            // 
            this.historyWizardToolStripMenuItem.Name = "historyWizardToolStripMenuItem";
            this.historyWizardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.historyWizardToolStripMenuItem.Text = "History Wizard";
            this.historyWizardToolStripMenuItem.Click += new System.EventHandler(this.historyWizardToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.gitToolStripMenuItem,
            this.reportABugToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // gitToolStripMenuItem
            // 
            this.gitToolStripMenuItem.Name = "gitToolStripMenuItem";
            this.gitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.gitToolStripMenuItem.Text = "Git";
            this.gitToolStripMenuItem.Click += new System.EventHandler(this.GitToolStripMenuItem_Click);
            // 
            // reportABugToolStripMenuItem
            // 
            this.reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
            this.reportABugToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.reportABugToolStripMenuItem.Text = "Report A Bug";
            this.reportABugToolStripMenuItem.Click += new System.EventHandler(this.ReportABugToolStripMenuItem_Click);
            // 
            // stopSaveButton
            // 
            this.stopSaveButton.Enabled = false;
            this.stopSaveButton.Location = new System.Drawing.Point(99, 98);
            this.stopSaveButton.Name = "stopSaveButton";
            this.stopSaveButton.Size = new System.Drawing.Size(75, 23);
            this.stopSaveButton.TabIndex = 14;
            this.stopSaveButton.Text = "Stop";
            this.stopSaveButton.UseVisualStyleBackColor = true;
            this.stopSaveButton.Click += new System.EventHandler(this.StopSaveButton_Click);
            // 
            // resetSessionButton
            // 
            this.resetSessionButton.Enabled = false;
            this.resetSessionButton.Location = new System.Drawing.Point(16, 231);
            this.resetSessionButton.Name = "resetSessionButton";
            this.resetSessionButton.Size = new System.Drawing.Size(93, 23);
            this.resetSessionButton.TabIndex = 15;
            this.resetSessionButton.Text = "Reset Session";
            this.resetSessionButton.UseVisualStyleBackColor = true;
            this.resetSessionButton.Click += new System.EventHandler(this.ResetSessionButton_Click);
            // 
            // descriptionButton
            // 
            this.descriptionButton.Location = new System.Drawing.Point(16, 186);
            this.descriptionButton.Name = "descriptionButton";
            this.descriptionButton.Size = new System.Drawing.Size(71, 23);
            this.descriptionButton.TabIndex = 16;
            this.descriptionButton.Text = "Description";
            this.descriptionButton.UseVisualStyleBackColor = true;
            this.descriptionButton.Click += new System.EventHandler(this.AddDescriptionButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 263);
            this.Controls.Add(this.descriptionButton);
            this.Controls.Add(this.resetSessionButton);
            this.Controls.Add(this.stopSaveButton);
            this.Controls.Add(this.categoryEdit);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.completedTime);
            this.Controls.Add(this.sessionLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startPauseButton);
            this.Controls.Add(this.completedLabel);
            this.Controls.Add(this.sessionTime);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "TM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //TODO make this never happen
            throw new NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void curr_sess_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label sessionTime;
        private System.Windows.Forms.Label completedLabel;
        private System.Windows.Forms.Button startPauseButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label sessionLabel;
        private System.Windows.Forms.Timer GUIRefresh;
        private System.Windows.Forms.Label completedTime;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button categoryEdit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesWizardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button stopSaveButton;
        private System.Windows.Forms.Button resetSessionButton;
        private System.Windows.Forms.ToolStripMenuItem AlwaysOnTop;
        private System.Windows.Forms.ToolStripMenuItem reportABugToolStripMenuItem;
        private System.Windows.Forms.Button descriptionButton;
        private System.Windows.Forms.ToolStripMenuItem historyWizardToolStripMenuItem;
    }
}

