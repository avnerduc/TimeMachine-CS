using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.InteropServices; //This is for 'Always on top'
using System.Collections;
using System.IO;
using System.Collections.Specialized;
using TM.Properties;

namespace TM
{

    //IMPORTANT
    //TODO: Add button to delete a category 
    //TODO: allow to delete a single session from history
    //Update git
    //Show Yair, make him join discord, post on discord the exe to michael nir and ofer

    //OR SIMPLY
    //Use this as a prototype for a more web-oriented approach, i.e. Angular


    //TODO
    //Add a feature to autoload the latest category used when loading TM
    //Create update_default_cat function that remembers the last selected category
    //Create a user settings for default_category
    //Uplate CategoryBox_SelectedIndexChanged to set the default settings to the current value of the category dropdown (Save)
    //Update MainForm_Load to set the category dropdown to the default settings (Load)
    //Add yair compatibility
    //Add export to CSV 
    //Add import from CSV
    //Take a look at https://stackoverflow.com/questions/12066511/write-csv-file-with-color-code/12066653 for maybe adding color coding
    //Color coding: in the category wizard you can assign a color to every category
    //Add an option to edit categories (using user setting might be a good idea) [allow assigning colors to categories]
    //Add a viewer for session history
    //Fix resizing of window (just block it)

    //Upcoming features: (by order of importance)

    //Add item to category list by adding it to the category ComboBox and pressing 'enter'

    //Add auto-complete to the categories dropdown
    //reference: http://net-informations.com/q/faq/autocombo.html
    //Next action: import from reference a parallel function to Form1_Load

    public partial class MainForm : Form
    {
        //String Constants
        private const string historyFileName = "history.xml";
        private const string info = "This is a Time Machine (C# style).\nRemember: There is no going back in time.";
        private const string start = "Start";
        private const string pause = "Pause";
        private const string resume = "Resume";
        private const string stop = "Stop";
        private const string save = "Save";
        private const string bugReport = "Sorry, we encountered an error. Please kindly report this bug.";
        private const string gitAddress = "https://github.com/avnerduc/TM";
        private const string sessionResetMessage = "Pressing OK will discard the current session. " +
            "Other information will remain intact.";
        private const string sessionResetTitle = "Reset Session";
        private const string resetMessage = "Pressing OK will discard the current session, and reset the Completed timer. " +
            "Other information will remain intact.";
        private const string resetTitle = "Reset Session";

        private const string unexpectedBug = "ERROR. Developer: search for 'unexpectedBug'";
        private const string newCategoryAddedMsg = "Category created";
        private const string unsavedSessionMessage = "You have an unsaved Session! Every minute counts.. Exit anyway?";

        //Other Constants
        private const int newSession = 0;
        private const int running = 1;
        private const int paused = 2;
        private const int stopped = 3;
        private const int saved = 4;

        //For 'Always on top'
        //Reference: https://stackoverflow.com/questions/14020086/preserve-data-between-application-executions
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        //Current Session Variables
        private int status = newSession;
        private readonly Stopwatch sessionStopWatch = new Stopwatch();
        private TimeSpan totalTimeSpan = new TimeSpan();
        private DateTime sessionStart;
        private DateTime sessionEnd;
        private string sessionCategory;
        private string sessionDescription;

        //Static Variables
        private static HistoryWizard history;

        public MainForm()
        {   
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            history = new HistoryWizard(historyFileName);
            LoadCategories(); //TODO adopt HistoryWizard design
            UpdateAlwaysOnTop();
        }

        private void LoadCategories()
        {
            try{
                categoryBox.Text = Properties.Settings.Default.LastCategory;
                sessionCategory = Properties.Settings.Default.LastCategory;
                foreach (var item in Settings.Default.Categories)
                {
                    categoryBox.Items.Add(item);
                }
            }
            catch
            {

            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //Listens to Return key when using categoryBox to detect manually entered Category
        //Reference: https://stackoverflow.com/questions/1226726/how-do-i-capture-the-enter-key-in-a-windows-forms-combobox
        //answer by Josip medved
        {
            if ((this.ActiveControl == categoryBox) && (keyData == Keys.Return))
            {
                string category = categoryBox.Text;
                if (!Settings.Default.Categories.Contains(category))
                {
                    setCurrentSessionCategory(category);
                    AddCategory(category);
                    UpdateLastCategory(category);
                    Message(newCategoryAddedMsg, category);
                }
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (status != newSession & status != saved)
            {
                if (MessageBox.Show(unsavedSessionMessage, "leaving?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("lal"); //cya later already / cya last time / cya previously / it was will be productive ... /sucks
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }


        private void StartPause_Click(object sender, EventArgs e)
        {
            if(status == newSession | status == saved)
            {
                InitiateSession();
            }
            else if(status == running)
            {
                PauseSession();
            }
            else if(status == paused)
            {
                ResumeSession();
            }
        }

        private void InitiateSession()
        {
            sessionStart = DateTime.Now;
            status = running;
            sessionStopWatch.Start();
            startPauseButton.Text = pause;
            stopSaveButton.Enabled = true;
            resetSessionButton.Enabled = true;
            resetButton.Enabled = true;
        }

        private void PauseSession()
        {
            status = paused;
            startPauseButton.Text = resume;
            sessionStopWatch.Stop();
        }

        private void ResumeSession()
        {
            status = running;
            startPauseButton.Text = pause;
            sessionStopWatch.Start();
        }

        private void StopSaveButton_Click(object sender, EventArgs e)
        {
            if(status != stopped)
            {
                StopSession();
            }
            else if(status == stopped)
            {
                SaveSession();
            }
            else
            {
                MessageBox.Show(unexpectedBug);
            }
        }

        private void StopSession()
        {
            status = stopped;
            sessionStopWatch.Stop();
            sessionEnd = DateTime.Now; 
            stopSaveButton.Text = save;
            startPauseButton.Text = start;
            startPauseButton.Enabled = false;
        }

        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = categoryBox.SelectedItem.ToString();
            setCurrentSessionCategory(category);
            UpdateLastCategory(category);
        }

        private void Message(string firstPart, string rest="")
        {
            MessageBox.Show('"'+rest+"\": "+firstPart, rest);        }

        private void setCurrentSessionCategory(string category)
        {
            sessionCategory = category;
        }

        private void UpdateLastCategory(string lastCategory)
        {
            Properties.Settings.Default.LastCategory = lastCategory; 
            Properties.Settings.Default.Save();
        }

        private void AddCategory(string newCategory)
        {
            Settings.Default.Categories.Add(newCategory);
            Settings.Default.Save();
            categoryBox.Items.Add(newCategory);
        }

        private void SaveSession()
        {
            Session finishedSession = new Session(sessionStart, sessionEnd, sessionStopWatch.Elapsed, 
                sessionCategory, sessionDescription);
            history.Add(finishedSession);
            totalTimeSpan += sessionStopWatch.Elapsed;
            sessionStopWatch.Reset();
            status = saved;
            startPauseButton.Enabled = true;
            stopSaveButton.Text = stop;
            stopSaveButton.Enabled = false;
            resetSessionButton.Enabled = false;
            sessionDescription = "";
            if (totalTimeSpan == TimeSpan.Zero)
            {
                MessageBox.Show(unexpectedBug); //TODO if this doesn't happen soon - delete this if-block
                resetButton.Enabled = false;
            }
        }

        private void ResetSessionButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(sessionResetMessage, sessionResetTitle, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                status = newSession;
                startPauseButton.Text = start;
                stopSaveButton.Text = stop;
                sessionStopWatch.Reset();
                startPauseButton.Enabled = true;
                stopSaveButton.Enabled = false;
                resetSessionButton.Enabled = false;
                if (totalTimeSpan == TimeSpan.Zero)
                {
                    resetButton.Enabled = false;
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(resetMessage, resetTitle, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                status = newSession;
                startPauseButton.Text = start;
                stopSaveButton.Text = stop;
                sessionStopWatch.Reset();
                totalTimeSpan = TimeSpan.Zero;
                startPauseButton.Enabled = true;
                stopSaveButton.Enabled = false;
                resetSessionButton.Enabled = false;
                resetButton.Enabled = false;
            }
        }

        private void CategoriesWizardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryEdit_Click(sender, e);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(info);
        }

        private void GitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(gitAddress);
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ReportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bugReport);
        }

        private void GUIRefresh_Tick(object sender, EventArgs e)
        {
            sessionTime.Text = StripMilliseconds(sessionStopWatch.Elapsed).ToString();
            completedTime.Text = StripMilliseconds(totalTimeSpan).ToString();
        }

        private static TimeSpan StripMilliseconds(TimeSpan time)
        {
            return new TimeSpan(time.Days, time.Hours, time.Minutes, time.Seconds);
        }

        //This section is for the 'Always On Top' feature
        //Reference: https://stackoverflow.com/questions/14020086/preserve-data-between-application-executions
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private void UpdateAlwaysOnTop()
        {
            if (Properties.Settings.Default.OnTop) //Always On Top
            {
                SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
                AlwaysOnTop.Image = global::TM.Properties.Resources.always_on_top_marked;
            }
            else //Not Always On Top
            {
                SetWindowPos(this.Handle, HWND_NOTOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
                AlwaysOnTop.Image = null;

            }
        }

        private void AlwaysOnTop_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OnTop = !Properties.Settings.Default.OnTop;
            Properties.Settings.Default.Save();
            UpdateAlwaysOnTop();
        }

        private void AddDescriptionButton_Click(object sender, EventArgs e)
        //Insipration from: https://stackoverflow.com/questions/5233502/how-to-return-a-value-from-a-form-in-c
        {
            //TODO: 
            using (var form = new SessionDescription(sessionDescription))
            {
                form.TopMost = true;
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    sessionDescription = form.Description;            
                }
            }
        }

        private void CategoryEdit_Click(object sender, EventArgs e)
        {
            using (var form = new CategoryWizard())
            {
                form.TopMost = true;
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //Here you should be able to add, remove, (and make sub?!) categories

                    //I think these could be useful here...
                    //Settings.Default.Categories
                    //Settings.Default.Save();
                }
            }
        }

        private void historyResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void historyWizardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            history.TopMost = true;
            history.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

    [Serializable]
    public class Session
    {
        //Constants
        private const string noneString = "None";

        //Variables
        private int id;
        private DateTime start;
        private DateTime end;
        private long duration;
        private TimeSpan span;
        private string category;
        private string description;

        //Getters and Setters
        public int Id { get => id; set => id = value; }
        public string Category { get => category; set => category = value; }
        public TimeSpan Span { get => StripMilliseconds(span); set => span = value; }
        public DateTime Start { get => start; set => start = value; }
        public DateTime End { get => end; set => end = value; }
        public string Description { get => description; set => description = value; }

        public Session(DateTime start, DateTime end, TimeSpan span, string category, string description)
            //TODO: is there any reason to let Sessions remember their category history?
        {
            Id = ++Settings.Default.SessionID;
            Settings.Default.Save();
            this.Start = start;
            this.End = end;
            this.Span = span;
            this.duration = span.Ticks;
            if(category is null)
            {
                this.Category = noneString;
            }
            else
            {
                this.Category = category;
            }
            if(description is null)
            {
                this.Description = noneString;
            }
            else
            {
                this.Description = description;
            }
        }

        private Session()
        {
            //Empty constructor for the sake of deserialization
        }

        //TODO: Remove this code duplication, find a reasonable way to use this method from the two classes
        private static TimeSpan StripMilliseconds(TimeSpan time)
        {
            return new TimeSpan(time.Days, time.Hours, time.Minutes, time.Seconds);
        }

        public override string ToString()
        {
            TimeSpan durationTimeSpan = new TimeSpan(this.duration);
            return(String.Format("Start time: {0}\nEnd time: {1}\nTotal time: {2}\nCategory: {3}\n" +
                "Description: {4}",
                this.Start.ToString(), this.End.ToString(), StripMilliseconds(durationTimeSpan).ToString(), this.Category,
                this.Description));
        }

        public string GetOneLineString()
        {
            TimeSpan durationTimeSpan = new TimeSpan(this.duration);
            return (String.Format("Start time: {0}, End time: {1}, Total time: {2}, Category: {3}, " +
                "Description: {4}",
                this.Start.ToString(), this.End.ToString(), StripMilliseconds(durationTimeSpan).ToString(), this.Category,
                this.Description));
        }

        private static string getReadableDuration(long duration)
        {
            TimeSpan durationTimeSpan = new TimeSpan(duration);
            return StripMilliseconds(durationTimeSpan).ToString();

        }

    }
}