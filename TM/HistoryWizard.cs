using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Serialization;
using TM.Properties;

namespace TM
{
    //FUTURE FEATURES
    //Display total time spent on all sessions
    //Allow viewing how many session were made in a specific category
    //Allow viewing how much time was spent on a specific category

    public partial class HistoryWizard : Form
    {

        private const string historyResetMessage = "Pressing OK will reset all history.";
        private const string historyResetTitle = "History Reset";
        private ArrayList sessionHistory;
        private string filePath;

        public HistoryWizard(string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
            LoadHistory();
        }


        private void LoadHistory()
        {
            //TODO: Crashes when there is no history file!
            try
            {
                Type[] extraTypes = new Type[1];
                extraTypes[0] = typeof(Session);
                XmlSerializer mySerializer = new XmlSerializer(typeof(ArrayList), extraTypes);
                //Comment next three lines when there is no history file, then uncomment them and restart
                var myFileStream = new FileStream(filePath, FileMode.Open);
                sessionHistory = (ArrayList)mySerializer.Deserialize(myFileStream);
                myFileStream.Close();
                //Uncomment next line when there is no history file, then comment it and restart
                //sessionHistory = new ArrayList();

            }
            finally { }
        }

        private void HistoryWizard_Load(object sender, EventArgs e)
        {
            UpdateHistoryGridView();


            //// Get the currently selected row using the SelectedRow property.
            //DataGridViewRow row = historyGridView.SelectedRow;

            //// In this example, the first column (index 0) contains
            //TextBox1.Text = row.Cells[0].Text;
        }

        private void UpdateHistoryGridView()
        {
            var source = new BindingSource
            {
                DataSource = sessionHistory
            };
            historyGridView.DataSource = source;
            historyGridView.AutoGenerateColumns = true;
        }

        public void Add(Session newSession)
        {
            sessionHistory.Add(newSession);
            SaveHistory();
        }

        public void SaveHistory()
        //TODO: add a Try, Catch block for IO problems
        //Inspiration: https://stackoverflow.com/questions/14675485/serialize-arraylist-of-objects
        {
            Type[] extraTypes = new Type[1];
            extraTypes[0] = typeof(Session);
            XmlSerializer mySerializer = new XmlSerializer(typeof(ArrayList), extraTypes);
            StreamWriter myWriter = new StreamWriter(filePath);
            mySerializer.Serialize(myWriter, sessionHistory);
            myWriter.Close();
        }


        private void ResetHistory_Click(object sender, EventArgs e)
        {
           HistoryReset();
        }

        public void HistoryReset()
        {
            if (System.Windows.Forms.MessageBox.Show(historyResetMessage, historyResetTitle, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                sessionHistory = new ArrayList();
                SaveHistory();
                Settings.Default.SessionID = 0;
                Settings.Default.Save();
                UpdateHistoryGridView();
            }
        }
    }
}
