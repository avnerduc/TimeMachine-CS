using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TM
{
    //TODO: Fix resizing of window
    public partial class SessionDescription : Form
    {
        public string Description { get; set; }

        public SessionDescription(string description = "")
        {
            InitializeComponent();
            descriptionBox.Text = description;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.Description = descriptionBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
