using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MiningReminder
{
    public partial class minerMain : Form
    {
        private int timerLength = 0;
        private int timerCounter = 0;
        private System.Media.SoundPlayer splayer = new System.Media.SoundPlayer();
        
        public minerMain()
        {
            InitializeComponent();
            splayer.SoundLocation = @"C:\windows\media\ringin.wav";
        }

        private void minerMain_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This is the main on/off button (check box actually)
        /// </summary>
        private void ChkTimerCtrl_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkTimerCtrl.Checked)   // if checked timer is on
            {
                this.startTimer();
            }
            else
            {
                this.stopTimer();
            }
        }

        private void startTimer()
        {
            // Need to set timer interval to user's miner duration
            Regex isNum = new Regex(@"^\d+$");
            Match m = isNum.Match(this.tbxInterval.Text);
            if (!m.Success)
            {
                MessageBox.Show(@"Only positive integers are allowed.");
                ChkTimerCtrl.Checked = false;
                return;
            }
            timerLength = Convert.ToInt32(tbxInterval.Text);
            timerCounter = timerLength;
            timer1.Interval = 1000; // Every second raise event
            this.ChkTimerCtrl.Text = "Push to Stop";
            this.lblRunState.Text = "Running...";
            lblCountDown.Text = timerLength.ToString();
            tbxInterval.Enabled = false;    //So value cannot be changed
            timer1.Start();
            
        }

        private void stopTimer()
        {
            // Stops timer and whatever else goes with that
            ChkTimerCtrl.Checked = false;
            timer1.Stop();
            tbxInterval.Enabled = true;
            ChkTimerCtrl.Text = "Push to Start";
            this.lblRunState.Text = "Idle";
            
        }

        private void restartTimer()
        {
            timerCounter = timerLength;
            lblCountDown.Text  = timerCounter.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // This event occures at each interval.  It's only accruate to 55ms.
            timerCounter--;
            if (timerCounter > 0)
            {
                lblCountDown.Text = timerCounter.ToString();
                lblCountDown.Refresh();
            }
            else
            {
                doAlarm();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void doAlarm()
        {
            //if(this.menuStrip1. 
            
            splayer.Play();
            this.Activate();
            restartTimer();
            return;
        }

        private void testing(int i)
        {

            if (notifyIconToolStripMenuItem.Checked)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.BalloonTipText = "Mining Timer Alerts now Show here.";
                notifyIcon1.ShowBalloonTip(1);
            }
            else
            {
                this.ShowInTaskbar = true;
                notifyIcon1.BalloonTipText = "Alerts in main window.";
                notifyIcon1.ShowBalloonTip(1);
            }

        }

        private void notifyIconToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}