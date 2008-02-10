namespace MiningReminder
{
    partial class minerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(minerMain));
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideOnTaskbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baloonAlertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChkTimerCtrl = new System.Windows.Forms.CheckBox();
            this.tbxInterval = new System.Windows.Forms.TextBox();
            this.cmsTimeList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.lblRunState = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsForNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmStopTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStartTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHide = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.cmsTimeList.SuspendLayout();
            this.cmsForNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(-5, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(164, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Miner Reminder";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(198, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(36, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notifyIconToolStripMenuItem,
            this.hideOnTaskbarToolStripMenuItem,
            this.baloonAlertToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.settingsToolStripMenuItem_DropDownItemClicked);
            // 
            // notifyIconToolStripMenuItem
            // 
            this.notifyIconToolStripMenuItem.CheckOnClick = true;
            this.notifyIconToolStripMenuItem.Name = "notifyIconToolStripMenuItem";
            this.notifyIconToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.notifyIconToolStripMenuItem.Text = "Use Notify Icon";
            // 
            // hideOnTaskbarToolStripMenuItem
            // 
            this.hideOnTaskbarToolStripMenuItem.CheckOnClick = true;
            this.hideOnTaskbarToolStripMenuItem.Name = "hideOnTaskbarToolStripMenuItem";
            this.hideOnTaskbarToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.hideOnTaskbarToolStripMenuItem.Text = "Hide On Taskbar";
            this.hideOnTaskbarToolStripMenuItem.ToolTipText = "Don\'t show on taskbar";
            // 
            // baloonAlertToolStripMenuItem
            // 
            this.baloonAlertToolStripMenuItem.CheckOnClick = true;
            this.baloonAlertToolStripMenuItem.Name = "baloonAlertToolStripMenuItem";
            this.baloonAlertToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.baloonAlertToolStripMenuItem.Text = "Baloon Alerts";
            this.baloonAlertToolStripMenuItem.ToolTipText = "Enables Alerts to show in notify icon balloon";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // ChkTimerCtrl
            // 
            this.ChkTimerCtrl.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkTimerCtrl.AutoSize = true;
            this.ChkTimerCtrl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ChkTimerCtrl.Location = new System.Drawing.Point(32, 112);
            this.ChkTimerCtrl.Name = "ChkTimerCtrl";
            this.ChkTimerCtrl.Size = new System.Drawing.Size(78, 23);
            this.ChkTimerCtrl.TabIndex = 2;
            this.ChkTimerCtrl.Text = "Push to Start";
            this.ChkTimerCtrl.UseVisualStyleBackColor = true;
            this.ChkTimerCtrl.CheckedChanged += new System.EventHandler(this.ChkTimerCtrl_CheckedChanged);
            // 
            // tbxInterval
            // 
            this.tbxInterval.BackColor = System.Drawing.Color.LightGray;
            this.tbxInterval.ContextMenuStrip = this.cmsTimeList;
            this.tbxInterval.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInterval.Location = new System.Drawing.Point(32, 76);
            this.tbxInterval.MaxLength = 5;
            this.tbxInterval.Name = "tbxInterval";
            this.tbxInterval.Size = new System.Drawing.Size(125, 23);
            this.tbxInterval.TabIndex = 3;
            this.tbxInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInterval_KeyPress);
            // 
            // cmsTimeList
            // 
            this.cmsTimeList.BackColor = System.Drawing.Color.LightGray;
            this.cmsTimeList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsTimeList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.cmsTimeList.Name = "cmsTimeList";
            this.cmsTimeList.Size = new System.Drawing.Size(182, 33);
            this.cmsTimeList.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTimeList_Opening);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "60",
            "120",
            "180",
            "300",
            "360",
            "420",
            "480",
            "540",
            "600"});
            this.toolStripComboBox1.MaxLength = 5;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.Tag = "Seconds";
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Activation Time/Duration (Seconds)";
            // 
            // lblCountDown
            // 
            this.lblCountDown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCountDown.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCountDown.Location = new System.Drawing.Point(32, 158);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(125, 20);
            this.lblCountDown.TabIndex = 5;
            this.lblCountDown.Text = "0";
            this.lblCountDown.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRunState
            // 
            this.lblRunState.AutoSize = true;
            this.lblRunState.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunState.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblRunState.Location = new System.Drawing.Point(123, 115);
            this.lblRunState.Name = "lblRunState";
            this.lblRunState.Size = new System.Drawing.Size(34, 20);
            this.lblRunState.TabIndex = 6;
            this.lblRunState.Text = "Idle";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "Miner Reminder";
            this.notifyIcon1.ContextMenuStrip = this.cmsForNotify;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Miner Reminder";
            // 
            // cmsForNotify
            // 
            this.cmsForNotify.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsForNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStopTimer,
            this.tsmStartTimer,
            this.tsmHide,
            this.tsmClose});
            this.cmsForNotify.Name = "cmsForNotify";
            this.cmsForNotify.Size = new System.Drawing.Size(144, 92);
            // 
            // tsmStopTimer
            // 
            this.tsmStopTimer.Name = "tsmStopTimer";
            this.tsmStopTimer.Size = new System.Drawing.Size(143, 22);
            this.tsmStopTimer.Text = "Stop Timer";
            this.tsmStopTimer.Click += new System.EventHandler(this.tsmStopTimer_Click);
            // 
            // tsmStartTimer
            // 
            this.tsmStartTimer.Name = "tsmStartTimer";
            this.tsmStartTimer.Size = new System.Drawing.Size(143, 22);
            this.tsmStartTimer.Text = "Start Timer";
            this.tsmStartTimer.Click += new System.EventHandler(this.tsmStartTimer_Click);
            // 
            // tsmHide
            // 
            this.tsmHide.Name = "tsmHide";
            this.tsmHide.Size = new System.Drawing.Size(143, 22);
            this.tsmHide.Text = "Hide";
            this.tsmHide.Click += new System.EventHandler(this.tsmHide_Click);
            // 
            // tsmClose
            // 
            this.tsmClose.Name = "tsmClose";
            this.tsmClose.Size = new System.Drawing.Size(143, 22);
            this.tsmClose.Text = "Quit";
            this.tsmClose.Click += new System.EventHandler(this.tsmClose_Click);
            // 
            // minerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(198, 229);
            this.Controls.Add(this.lblRunState);
            this.Controls.Add(this.tbxInterval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ChkTimerCtrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "minerMain";
            this.Text = "Miner Reminder";
            this.Load += new System.EventHandler(this.minerMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmsTimeList.ResumeLayout(false);
            this.cmsForNotify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.CheckBox ChkTimerCtrl;
        private System.Windows.Forms.TextBox tbxInterval;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Label lblRunState;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notifyIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip cmsForNotify;
        private System.Windows.Forms.ToolStripMenuItem tsmStopTimer;
        private System.Windows.Forms.ToolStripMenuItem tsmStartTimer;
        private System.Windows.Forms.ToolStripMenuItem tsmHide;
        private System.Windows.Forms.ToolStripMenuItem tsmClose;
        private System.Windows.Forms.ContextMenuStrip cmsTimeList;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem hideOnTaskbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baloonAlertToolStripMenuItem;
    }
}

