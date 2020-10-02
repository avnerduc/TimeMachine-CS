using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TM.Properties;

namespace TM
{
    //TODO: allow creation and deletion of sessions
    //Make sure to always keep at least 1 category
    //Display total sessions and total time for every category
    //When deleting a category ask where to move the categories' session to
    public partial class CategoryWizard : Form
    {

        private const string categoriesResetMessage = "Pressing OK will reset all categories.";
        private const string categoriesResetTitle = "Categories Reset";
        private string defaultCategoryName = "Enter Category Name";

        public CategoryWizard()
        {
            InitializeComponent();
        }

        private void CategoryWizard_Load(object sender, EventArgs e)
        //Reference: https://stackoverflow.com/questions/59058041/how-to-add-or-create-a-string-collection-editor-control-in-my-windows-form-in
        {
            var source = new BindingSource();
            source.DataSource = Settings.Default.Categories;
            CategoryGridView.DataSource = source;
            CategoryGridView.AutoGenerateColumns = true;
            var categories = Settings.Default.Categories.Cast<string>().ToList();
            //Reference for next line: https://www.codeproject.com/Questions/1189216/How-to-show-string-on-datagridview-in-Csharp
            var wappedCategories = categories.Select(s => new { value = s }).ToList();
            CategoryGridView.DataSource = wappedCategories;
        }

        private void CategoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void categoryWizardBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void deleteCategories_Click(object sender, EventArgs e)
        {
            DeleteAllCategories();
        }

        private void DeleteAllCategories()
        {
            if (System.Windows.Forms.MessageBox.Show(categoriesResetMessage, categoriesResetTitle, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Settings.Default.Categories = new System.Collections.Specialized.StringCollection();
                Settings.Default.LastCategory = defaultCategoryName;
                Settings.Default.Save();
            }
        }
    }
}
