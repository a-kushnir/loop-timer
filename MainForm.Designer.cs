namespace LoopTimer
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
            this.labelTimeLeft = new System.Windows.Forms.Label();
            this.niMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cnsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer72ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonReset = new System.Windows.Forms.Button();
            this.cnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTimeLeft
            // 
            this.labelTimeLeft.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeLeft.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeLeft.ForeColor = System.Drawing.Color.White;
            this.labelTimeLeft.Location = new System.Drawing.Point(12, 10);
            this.labelTimeLeft.Name = "labelTimeLeft";
            this.labelTimeLeft.Size = new System.Drawing.Size(120, 48);
            this.labelTimeLeft.TabIndex = 3;
            this.labelTimeLeft.Text = "00:00";
            this.labelTimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTimeLeft.Enter += new System.EventHandler(this.MainForm_MouseEnter);
            this.labelTimeLeft.Leave += new System.EventHandler(this.MainForm_MouseLeave);
            this.labelTimeLeft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            // 
            // niMain
            // 
            this.niMain.ContextMenuStrip = this.cnsMain;
            this.niMain.Icon = ((System.Drawing.Icon)(resources.GetObject("niMain.Icon")));
            this.niMain.Text = "Loop Timer";
            this.niMain.Visible = true;
            // 
            // cnsMain
            // 
            this.cnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timer72ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.hideToolStripMenuItem,
            this.showToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.cnsMain.Name = "contextMenuStrip1";
            this.cnsMain.Size = new System.Drawing.Size(135, 148);
            this.cnsMain.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // timer72ToolStripMenuItem
            // 
            this.timer72ToolStripMenuItem.Enabled = false;
            this.timer72ToolStripMenuItem.Name = "timer72ToolStripMenuItem";
            this.timer72ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.timer72ToolStripMenuItem.Text = "Loop Timer";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(131, 6);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.HideToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorunToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // autorunToolStripMenuItem
            // 
            this.autorunToolStripMenuItem.CheckOnClick = true;
            this.autorunToolStripMenuItem.Name = "autorunToolStripMenuItem";
            this.autorunToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.autorunToolStripMenuItem.Text = "Autorun";
            this.autorunToolStripMenuItem.Click += new System.EventHandler(this.AutorunToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(131, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Image = global::LoopTimer.Properties.Resources.reset;
            this.buttonReset.Location = new System.Drawing.Point(128, 16);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(36, 36);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.TabStop = false;
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            this.buttonReset.Enter += new System.EventHandler(this.MainForm_MouseEnter);
            this.buttonReset.Leave += new System.EventHandler(this.MainForm_MouseLeave);
            this.buttonReset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 69);
            this.Controls.Add(this.labelTimeLeft);
            this.Controls.Add(this.buttonReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer72";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MainForm_MouseLeave);
            this.cnsMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelTimeLeft;
        private System.Windows.Forms.NotifyIcon niMain;
        private System.Windows.Forms.ContextMenuStrip cnsMain;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timer72ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorunToolStripMenuItem;
    }
}

