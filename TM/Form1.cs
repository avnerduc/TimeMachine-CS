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
    public partial class Form1 : Form
    {

        private Boolean running = false;
        //Perhaps TimeSpan is more suitable here
        private DateTime sess_start;

        public Form1()
        {
            InitializeComponent();
        }

        private void InfoClick(object sender, EventArgs e)
        {
            MessageBox.Show("This is a Time Machine (C# style).\nRemember: There is no going back in time");
        }

        private void StartClick(object sender, EventArgs e)
        {
            if(running == false)
            {
                running = true;
                sess_start = DateTime.Now;
                MessageBox.Show("Started a session at"+sess_start.ToString());

                var startTimeSpan = TimeSpan.Zero;
                var periodTimeSpan = TimeSpan.FromMinutes(5);




            }
            else
            {
                MessageBox.Show("Error: Session already running");
            }

        }

        private void UpdateTimer()
        {
            curr_sess.Text = (DateTime.Now - sess_start).ToString();
        }

        private void StopClick(object sender, EventArgs e)
        {
            if (running == true)
            {
                running = false;
                MessageBox.Show("Ended a session at"+sess_start.ToString());
            }
            else
            {
                MessageBox.Show("Error: Session not running");
            }
        }

        private void ResetClick(object sender, EventArgs e)
        {
            curr_sess.Text = (DateTime.Now - sess_start).ToString();
        }


    }
}
