namespace TM
{
    partial class CategoryWizard
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
            this.CategoryGridView = new System.Windows.Forms.DataGridView();
            this.deleteCategories = new System.Windows.Forms.Button();
            this.visibleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.categoryWizardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryWizardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryGridView
            // 
            this.CategoryGridView.AllowUserToOrderColumns = true;
            this.CategoryGridView.AutoGenerateColumns = false;
            this.CategoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visibleDataGridViewCheckBoxColumn});
            this.CategoryGridView.DataSource = this.categoryWizardBindingSource;
            this.CategoryGridView.Location = new System.Drawing.Point(12, 23);
            this.CategoryGridView.Name = "CategoryGridView";
            this.CategoryGridView.Size = new System.Drawing.Size(261, 250);
            this.CategoryGridView.TabIndex = 0;
            this.CategoryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryGridView_CellContentClick);
            // 
            // deleteCategories
            // 
            this.deleteCategories.Location = new System.Drawing.Point(75, 288);
            this.deleteCategories.Name = "deleteCategories";
            this.deleteCategories.Size = new System.Drawing.Size(128, 27);
            this.deleteCategories.TabIndex = 1;
            this.deleteCategories.Text = "Delete All Categories!";
            this.deleteCategories.UseVisualStyleBackColor = true;
            this.deleteCategories.Click += new System.EventHandler(this.deleteCategories_Click);
            // 
            // visibleDataGridViewCheckBoxColumn
            // 
            this.visibleDataGridViewCheckBoxColumn.DataPropertyName = "Visible";
            this.visibleDataGridViewCheckBoxColumn.HeaderText = "Visible";
            this.visibleDataGridViewCheckBoxColumn.Name = "visibleDataGridViewCheckBoxColumn";
            // 
            // categoryWizardBindingSource
            // 
            this.categoryWizardBindingSource.DataSource = typeof(TM.CategoryWizard);
            this.categoryWizardBindingSource.CurrentChanged += new System.EventHandler(this.categoryWizardBindingSource_CurrentChanged);
            // 
            // CategoryWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 327);
            this.Controls.Add(this.deleteCategories);
            this.Controls.Add(this.CategoryGridView);
            this.Name = "CategoryWizard";
            this.Text = "CategoryWizard";
            this.Load += new System.EventHandler(this.CategoryWizard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryWizardBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CategoryGridView;
        private System.Windows.Forms.BindingSource categoryWizardBindingSource;
        private System.Windows.Forms.Button deleteCategories;
        private System.Windows.Forms.DataGridViewCheckBoxColumn visibleDataGridViewCheckBoxColumn;
    }
}