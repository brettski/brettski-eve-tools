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
        private bool useBaloonAlerts = false;
        private System.Media.SoundPlayer splayer = new System.Media.SoundPlayer();
        
        public minerMain()
        {
            InitializeComponent();
            splayer.SoundLocation = @"C:\windows\media\ringin.wav";
        }

        private void minerMain_Load(object sender, EventArgs e)
        {
            SettingsMenuAction();
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
            ChkTimerCtrl.Checked = true;
            ChkTimerCtrl.Update();
            timerLength = Convert.ToInt32(tbxInterval.Text);
            timerCounter = timerLength;
            timer1.Interval = 1000; // Every second raise event +-55ms
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
                // put inactivate if here
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
            if (false == disableSoundToolStripMenuItem.Checked)
            {
                splayer.Play();
            }
            this.Activate();
            if (useBaloonAlerts)
            {
                notifyIcon1.BalloonTipText = "Dump your Cargo";
                notifyIcon1.ShowBalloonTip(1);
            }
            restartTimer();
            return;
        }

        private void testing()
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
        /// <summary>
        /// For any item changed in the settings tool strip item, this will fire, so all 
        /// checks can be done here in this event.
        /// The bitch of this even is that the item clicked isn't actually updated until after this event
        /// </summary>
        private void settingsToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Flip the value for the action method, then flip it back before leaving this method.
            // The clicked item isn't updated until after this event.
            if ("notifyIconToolStripMenuItem" == e.ClickedItem.Name)
                notifyIconToolStripMenuItem.Checked = !notifyIconToolStripMenuItem.Checked;
            if ("hideOnTaskbarToolStripMenuItem" == e.ClickedItem.Name)
                hideOnTaskbarToolStripMenuItem.Checked = !hideOnTaskbarToolStripMenuItem.Checked;
            if ("baloonAlertToolStripMenuItem" == e.ClickedItem.Name)
                baloonAlertToolStripMenuItem.Checked = !baloonAlertToolStripMenuItem.Checked;
            
            SettingsMenuAction();
            
            if ("notifyIconToolStripMenuItem" == e.ClickedItem.Name)
                notifyIconToolStripMenuItem.Checked = !notifyIconToolStripMenuItem.Checked;
            if ("hideOnTaskbarToolStripMenuItem" == e.ClickedItem.Name)
                hideOnTaskbarToolStripMenuItem.Checked = !hideOnTaskbarToolStripMenuItem.Checked;
            if ("baloonAlertToolStripMenuItem" == e.ClickedItem.Name)
                baloonAlertToolStripMenuItem.Checked = !baloonAlertToolStripMenuItem.Checked;

        }
        /// <summary>
        /// Based on current conditions figure out what to do with the whole settings menu tree
        /// </summary>
        private void SettingsMenuAction()
        {
            // Menu Items:
            // notifyIconToolStripMenuItem;
            // hideOnTaskbarToolStripMenuItem;
            // baloonAlertToolStripMenuItem;
            // ------------------------------------------------------------
            // Stupid Auto-naming.  Use Notify Icon from Settings menu item
            // Setup up proper view after an item is clicked.
            if (notifyIconToolStripMenuItem.Checked)
            {
                notifyIcon1.Visible = true;
                hideOnTaskbarToolStripMenuItem.Enabled = true;
                baloonAlertToolStripMenuItem.Enabled  = true;
            }
            else
            {
                notifyIcon1.Visible = false;
                hideOnTaskbarToolStripMenuItem.Enabled = false;
                hideOnTaskbarToolStripMenuItem.Checked = false;
                baloonAlertToolStripMenuItem.Enabled = false;
                baloonAlertToolStripMenuItem.Checked = false;
            }

            // Process needs for Hide on Taskbar
            HideOnTaskbarAction();
            BaloonAlertAction();
            

        }
        /// <summary>
        /// Based on current conditions figure out what you need to do to hide the form
        /// on the task bar
        /// </summary>
        private void HideOnTaskbarAction()
        {
            if (!notifyIconToolStripMenuItem.Checked)
            {
                this.ShowInTaskbar = true;
            }
            else if(notifyIconToolStripMenuItem.Checked && hideOnTaskbarToolStripMenuItem.Checked)
            {
                this.ShowInTaskbar = false;
            }
            
        }
        /// <summary>
        /// Based on current conditions figure out what you need to do for the baloon alerts.
        /// </summary>
        private void BaloonAlertAction()
        {
            if (!notifyIconToolStripMenuItem.Checked)
            {
                useBaloonAlerts = false;
            }
            else if (notifyIconToolStripMenuItem.Checked && baloonAlertToolStripMenuItem.Checked)
            {
                useBaloonAlerts = true;
            }
        }

        private void tsmStopTimer_Click(object sender, EventArgs e)
        {
            this.stopTimer();
        }

        private void tsmStartTimer_Click(object sender, EventArgs e)
        {
            this.startTimer();
        }

        private void tsmHide_Click(object sender, EventArgs e)
        {
            notifyIconToolStripMenuItem.Checked = false;
            SettingsMenuAction();
        }

        private void tsmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tbxInterval.Text = toolStripComboBox1.SelectedItem.ToString();
            cmsTimeList.Close();    // Close the list after writing value
        }

        private void cmsTimeList_Opening(object sender, CancelEventArgs e)
        {
            toolStripComboBox1.SelectedIndex = 0;   // Set Combo to first value while cms opens
        }

        private void tbxInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for enter, if occurs, Start timer
            if (Convert.ToChar(Keys.Enter) == e.KeyChar)
                startTimer();
        }
    }
}