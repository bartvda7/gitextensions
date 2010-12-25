﻿namespace GitUI
{
    partial class FormPush
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
			this.BrowseSource = new System.Windows.Forms.Button();
			this.Push = new System.Windows.Forms.Button();
			this.PushDestination = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Branch = new System.Windows.Forms.ComboBox();
			this.PushAllBranches = new System.Windows.Forms.CheckBox();
			this.ForcePushBranches = new System.Windows.Forms.CheckBox();
			this.ForcePushTags = new System.Windows.Forms.CheckBox();
			this.Pull = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.PullFromUrl = new System.Windows.Forms.RadioButton();
			this.PullFromRemote = new System.Windows.Forms.RadioButton();
			this.AddRemote = new System.Windows.Forms.Button();
			this.Remotes = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelTo = new System.Windows.Forms.Label();
			this.RemoteBranch = new System.Windows.Forms.ComboBox();
			this.LoadSSHKey = new System.Windows.Forms.Button();
			this.TagComboBox = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.PushAllTags = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TabControlTagBranch = new System.Windows.Forms.TabControl();
			this.BranchTab = new System.Windows.Forms.TabPage();
			this.TagTab = new System.Windows.Forms.TabPage();
			this.MultipleBranchTab = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.BranchGrid = new System.Windows.Forms.DataGridView();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.PushColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ForceColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.LocalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RemoteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DeleteColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.TabControlTagBranch.SuspendLayout();
			this.BranchTab.SuspendLayout();
			this.TagTab.SuspendLayout();
			this.MultipleBranchTab.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BranchGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// BrowseSource
			// 
			this.BrowseSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BrowseSource.Enabled = false;
			this.BrowseSource.Location = new System.Drawing.Point(431, 45);
			this.BrowseSource.Name = "BrowseSource";
			this.BrowseSource.Size = new System.Drawing.Size(101, 23);
			this.BrowseSource.TabIndex = 13;
			this.BrowseSource.Text = "Browse";
			this.BrowseSource.UseVisualStyleBackColor = true;
			this.BrowseSource.Click += new System.EventHandler(this.BrowseSourceClick);
			// 
			// Push
			// 
			this.Push.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Push.Image = global::GitUI.Properties.Resources._31;
			this.Push.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Push.Location = new System.Drawing.Point(447, 347);
			this.Push.Name = "Push";
			this.Push.Size = new System.Drawing.Size(101, 23);
			this.Push.TabIndex = 15;
			this.Push.Text = "&Push";
			this.Push.UseVisualStyleBackColor = true;
			this.Push.Click += new System.EventHandler(this.PushClick);
			// 
			// PushDestination
			// 
			this.PushDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.PushDestination.Enabled = false;
			this.PushDestination.FormattingEnabled = true;
			this.PushDestination.Location = new System.Drawing.Point(128, 46);
			this.PushDestination.Name = "PushDestination";
			this.PushDestination.Size = new System.Drawing.Size(297, 23);
			this.PushDestination.TabIndex = 16;
			this.PushDestination.DropDown += new System.EventHandler(this.PushDestinationDropDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 15);
			this.label2.TabIndex = 17;
			this.label2.Text = "Branch to push";
			// 
			// Branch
			// 
			this.Branch.FormattingEnabled = true;
			this.Branch.Location = new System.Drawing.Point(127, 19);
			this.Branch.Name = "Branch";
			this.Branch.Size = new System.Drawing.Size(173, 23);
			this.Branch.TabIndex = 0;
			this.Branch.DropDown += new System.EventHandler(this.BranchDropDown);
			this.Branch.SelectedValueChanged += new System.EventHandler(this.BranchSelectedValueChanged);
			// 
			// PushAllBranches
			// 
			this.PushAllBranches.AutoSize = true;
			this.PushAllBranches.Location = new System.Drawing.Point(127, 51);
			this.PushAllBranches.Name = "PushAllBranches";
			this.PushAllBranches.Size = new System.Drawing.Size(110, 17);
			this.PushAllBranches.TabIndex = 2;
			this.PushAllBranches.Text = "Push &all branches";
			this.PushAllBranches.UseVisualStyleBackColor = true;
			this.PushAllBranches.CheckedChanged += new System.EventHandler(this.PushAllBranchesCheckedChanged);
			// 
			// ForcePushBranches
			// 
			this.ForcePushBranches.AutoSize = true;
			this.ForcePushBranches.Location = new System.Drawing.Point(127, 74);
			this.ForcePushBranches.Name = "ForcePushBranches";
			this.ForcePushBranches.Size = new System.Drawing.Size(80, 17);
			this.ForcePushBranches.TabIndex = 3;
			this.ForcePushBranches.Text = "&Force Push";
			this.ForcePushBranches.UseVisualStyleBackColor = true;
			this.ForcePushBranches.CheckedChanged += new System.EventHandler(this.ForcePushBranchesCheckedChanged);
			// 
			// ForcePushTags
			// 
			this.ForcePushTags.AutoSize = true;
			this.ForcePushTags.Location = new System.Drawing.Point(127, 74);
			this.ForcePushTags.Name = "ForcePushTags";
			this.ForcePushTags.Size = new System.Drawing.Size(80, 17);
			this.ForcePushTags.TabIndex = 19;
			this.ForcePushTags.Text = "&Force Push";
			this.ForcePushTags.UseVisualStyleBackColor = true;
			this.ForcePushTags.CheckedChanged += new System.EventHandler(this.ForcePushTagsCheckedChanged);
			// 
			// Pull
			// 
			this.Pull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Pull.Location = new System.Drawing.Point(12, 347);
			this.Pull.Name = "Pull";
			this.Pull.Size = new System.Drawing.Size(101, 23);
			this.Pull.TabIndex = 20;
			this.Pull.Text = "Pull";
			this.Pull.UseVisualStyleBackColor = true;
			this.Pull.Click += new System.EventHandler(this.PullClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.PullFromUrl);
			this.groupBox2.Controls.Add(this.PullFromRemote);
			this.groupBox2.Controls.Add(this.AddRemote);
			this.groupBox2.Controls.Add(this.Remotes);
			this.groupBox2.Controls.Add(this.BrowseSource);
			this.groupBox2.Controls.Add(this.PushDestination);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(541, 80);
			this.groupBox2.TabIndex = 21;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Push to";
			// 
			// PullFromUrl
			// 
			this.PullFromUrl.AutoSize = true;
			this.PullFromUrl.Location = new System.Drawing.Point(7, 47);
			this.PullFromUrl.Name = "PullFromUrl";
			this.PullFromUrl.Size = new System.Drawing.Size(38, 17);
			this.PullFromUrl.TabIndex = 19;
			this.PullFromUrl.Text = "Url";
			this.toolTip1.SetToolTip(this.PullFromUrl, "Url to push to");
			this.PullFromUrl.UseVisualStyleBackColor = true;
			this.PullFromUrl.CheckedChanged += new System.EventHandler(this.PullFromUrlCheckedChanged);
			// 
			// PullFromRemote
			// 
			this.PullFromRemote.AutoSize = true;
			this.PullFromRemote.Checked = true;
			this.PullFromRemote.Location = new System.Drawing.Point(7, 19);
			this.PullFromRemote.Name = "PullFromRemote";
			this.PullFromRemote.Size = new System.Drawing.Size(62, 17);
			this.PullFromRemote.TabIndex = 18;
			this.PullFromRemote.TabStop = true;
			this.PullFromRemote.Text = "Remote";
			this.toolTip1.SetToolTip(this.PullFromRemote, "Remote repository to push to");
			this.PullFromRemote.UseVisualStyleBackColor = true;
			this.PullFromRemote.CheckedChanged += new System.EventHandler(this.PullFromRemoteCheckedChanged);
			// 
			// AddRemote
			// 
			this.AddRemote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddRemote.Location = new System.Drawing.Point(431, 18);
			this.AddRemote.Name = "AddRemote";
			this.AddRemote.Size = new System.Drawing.Size(101, 23);
			this.AddRemote.TabIndex = 17;
			this.AddRemote.Text = "Manage remotes";
			this.AddRemote.UseVisualStyleBackColor = true;
			this.AddRemote.Click += new System.EventHandler(this.AddRemoteClick);
			// 
			// Remotes
			// 
			this.Remotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.Remotes.FormattingEnabled = true;
			this.Remotes.Location = new System.Drawing.Point(128, 19);
			this.Remotes.Name = "Remotes";
			this.Remotes.Size = new System.Drawing.Size(297, 23);
			this.Remotes.TabIndex = 16;
			this.Remotes.DropDown += new System.EventHandler(this.RemotesDropDown);
			this.Remotes.SelectedIndexChanged += new System.EventHandler(this.RemotesUpdated);
			this.Remotes.TextUpdate += new System.EventHandler(this.RemotesUpdated);
			this.Remotes.Validated += new System.EventHandler(this.RemotesValidated);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelTo);
			this.groupBox1.Controls.Add(this.RemoteBranch);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.Branch);
			this.groupBox1.Controls.Add(this.PushAllBranches);
			this.groupBox1.Controls.Add(this.ForcePushBranches);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(527, 211);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Branch";
			// 
			// labelTo
			// 
			this.labelTo.AutoSize = true;
			this.labelTo.Location = new System.Drawing.Point(306, 21);
			this.labelTo.Name = "labelTo";
			this.labelTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.labelTo.Size = new System.Drawing.Size(18, 15);
			this.labelTo.TabIndex = 21;
			this.labelTo.Text = "to";
			this.labelTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RemoteBranch
			// 
			this.RemoteBranch.FormattingEnabled = true;
			this.RemoteBranch.Location = new System.Drawing.Point(348, 19);
			this.RemoteBranch.Name = "RemoteBranch";
			this.RemoteBranch.Size = new System.Drawing.Size(162, 23);
			this.RemoteBranch.TabIndex = 1;
			this.RemoteBranch.DropDown += new System.EventHandler(this.RemoteBranchDropDown);
			// 
			// LoadSSHKey
			// 
			this.LoadSSHKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LoadSSHKey.Image = global::GitUI.Properties.Resources.putty;
			this.LoadSSHKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.LoadSSHKey.Location = new System.Drawing.Point(313, 347);
			this.LoadSSHKey.Name = "LoadSSHKey";
			this.LoadSSHKey.Size = new System.Drawing.Size(123, 23);
			this.LoadSSHKey.TabIndex = 23;
			this.LoadSSHKey.Text = "Load SSH key";
			this.LoadSSHKey.UseVisualStyleBackColor = true;
			this.LoadSSHKey.Click += new System.EventHandler(this.LoadSshKeyClick);
			// 
			// TagComboBox
			// 
			this.TagComboBox.FormattingEnabled = true;
			this.TagComboBox.Location = new System.Drawing.Point(127, 19);
			this.TagComboBox.Name = "TagComboBox";
			this.TagComboBox.Size = new System.Drawing.Size(297, 23);
			this.TagComboBox.TabIndex = 18;
			this.TagComboBox.DropDown += new System.EventHandler(this.TagDropDown);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.PushAllTags);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.ForcePushTags);
			this.groupBox3.Controls.Add(this.TagComboBox);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(3, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(527, 211);
			this.groupBox3.TabIndex = 23;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Tag";
			// 
			// PushAllTags
			// 
			this.PushAllTags.AutoSize = true;
			this.PushAllTags.Location = new System.Drawing.Point(127, 51);
			this.PushAllTags.Name = "PushAllTags";
			this.PushAllTags.Size = new System.Drawing.Size(86, 17);
			this.PushAllTags.TabIndex = 22;
			this.PushAllTags.Text = "Push &all tags";
			this.PushAllTags.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 15);
			this.label1.TabIndex = 17;
			this.label1.Text = "Tag to push";
			// 
			// TabControlTagBranch
			// 
			this.TabControlTagBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.TabControlTagBranch.Controls.Add(this.BranchTab);
			this.TabControlTagBranch.Controls.Add(this.TagTab);
			this.TabControlTagBranch.Controls.Add(this.MultipleBranchTab);
			this.TabControlTagBranch.HotTrack = true;
			this.TabControlTagBranch.ItemSize = new System.Drawing.Size(57, 18);
			this.TabControlTagBranch.Location = new System.Drawing.Point(12, 98);
			this.TabControlTagBranch.Multiline = true;
			this.TabControlTagBranch.Name = "TabControlTagBranch";
			this.TabControlTagBranch.SelectedIndex = 0;
			this.TabControlTagBranch.ShowToolTips = true;
			this.TabControlTagBranch.Size = new System.Drawing.Size(541, 243);
			this.TabControlTagBranch.TabIndex = 24;
			this.TabControlTagBranch.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControlTagBranch_Selected);
			// 
			// BranchTab
			// 
			this.BranchTab.BackColor = System.Drawing.Color.Transparent;
			this.BranchTab.Controls.Add(this.groupBox1);
			this.BranchTab.Location = new System.Drawing.Point(4, 22);
			this.BranchTab.Name = "BranchTab";
			this.BranchTab.Padding = new System.Windows.Forms.Padding(3);
			this.BranchTab.Size = new System.Drawing.Size(533, 217);
			this.BranchTab.TabIndex = 0;
			this.BranchTab.Text = "Push branches";
			this.BranchTab.ToolTipText = "Push branches and commits to remote repository.";
			this.BranchTab.UseVisualStyleBackColor = true;
			// 
			// TagTab
			// 
			this.TagTab.BackColor = System.Drawing.Color.Transparent;
			this.TagTab.Controls.Add(this.groupBox3);
			this.TagTab.Location = new System.Drawing.Point(4, 22);
			this.TagTab.Name = "TagTab";
			this.TagTab.Padding = new System.Windows.Forms.Padding(3);
			this.TagTab.Size = new System.Drawing.Size(533, 217);
			this.TagTab.TabIndex = 1;
			this.TagTab.Text = "Push tags";
			this.TagTab.ToolTipText = "Push tags to remote repository";
			this.TagTab.UseVisualStyleBackColor = true;
			// 
			// MultipleBranchTab
			// 
			this.MultipleBranchTab.Controls.Add(this.groupBox4);
			this.MultipleBranchTab.Location = new System.Drawing.Point(4, 22);
			this.MultipleBranchTab.Name = "MultipleBranchTab";
			this.MultipleBranchTab.Padding = new System.Windows.Forms.Padding(3);
			this.MultipleBranchTab.Size = new System.Drawing.Size(533, 217);
			this.MultipleBranchTab.TabIndex = 2;
			this.MultipleBranchTab.Text = "Push multiple branches";
			this.MultipleBranchTab.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.BranchGrid);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.Location = new System.Drawing.Point(3, 3);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(527, 211);
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Select Branches to Push";
			// 
			// BranchGrid
			// 
			this.BranchGrid.AllowUserToAddRows = false;
			this.BranchGrid.AllowUserToDeleteRows = false;
			this.BranchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.BranchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PushColumn,
            this.ForceColumn,
            this.LocalColumn,
            this.RemoteColumn,
            this.DeleteColumn});
			this.BranchGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BranchGrid.Location = new System.Drawing.Point(3, 19);
			this.BranchGrid.Name = "BranchGrid";
			this.BranchGrid.RowHeadersVisible = false;
			this.BranchGrid.Size = new System.Drawing.Size(521, 189);
			this.BranchGrid.TabIndex = 0;
			// 
			// PushColumn
			// 
			this.PushColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.PushColumn.DataPropertyName = "Push";
			this.PushColumn.HeaderText = "Push";
			this.PushColumn.Name = "PushColumn";
			this.PushColumn.Width = 39;
			// 
			// ForceColumn
			// 
			this.ForceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ForceColumn.DataPropertyName = "Force";
			this.ForceColumn.HeaderText = "Force";
			this.ForceColumn.Name = "ForceColumn";
			this.ForceColumn.Width = 42;
			// 
			// LocalColumn
			// 
			this.LocalColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.LocalColumn.DataPropertyName = "Local";
			this.LocalColumn.HeaderText = "Local Branch";
			this.LocalColumn.Name = "LocalColumn";
			// 
			// RemoteColumn
			// 
			this.RemoteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.RemoteColumn.DataPropertyName = "Remote";
			this.RemoteColumn.HeaderText = "Remote Branch";
			this.RemoteColumn.Name = "RemoteColumn";
			// 
			// DeleteColumn
			// 
			this.DeleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.DeleteColumn.HeaderText = "Delete Remote Branch";
			this.DeleteColumn.Name = "DeleteColumn";
			this.DeleteColumn.Width = 117;
			// 
			// FormPush
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 382);
			this.Controls.Add(this.TabControlTagBranch);
			this.Controls.Add(this.LoadSSHKey);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.Push);
			this.Controls.Add(this.Pull);
			this.MinimizeBox = false;
			this.Name = "FormPush";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Push";
			this.Load += new System.EventHandler(this.FormPushLoad);
			this.Shown += new System.EventHandler(this.FormPush_Shown);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.TabControlTagBranch.ResumeLayout(false);
			this.BranchTab.ResumeLayout(false);
			this.TagTab.ResumeLayout(false);
			this.MultipleBranchTab.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.BranchGrid)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BrowseSource;
        private System.Windows.Forms.Button Push;
        private System.Windows.Forms.ComboBox PushDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Branch;
        private System.Windows.Forms.CheckBox PushAllBranches;
        private System.Windows.Forms.CheckBox ForcePushBranches;
        private System.Windows.Forms.CheckBox ForcePushTags;
        private System.Windows.Forms.Button Pull;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton PullFromUrl;
        private System.Windows.Forms.RadioButton PullFromRemote;
        private System.Windows.Forms.Button AddRemote;
        private System.Windows.Forms.ComboBox Remotes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LoadSSHKey;
        private System.Windows.Forms.ComboBox TagComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TabControlTagBranch;
        private System.Windows.Forms.TabPage BranchTab;
        private System.Windows.Forms.TabPage TagTab;
        private System.Windows.Forms.CheckBox PushAllTags;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.ComboBox RemoteBranch;
		private System.Windows.Forms.TabPage MultipleBranchTab;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView BranchGrid;
		private System.Windows.Forms.DataGridViewCheckBoxColumn PushColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ForceColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LocalColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn RemoteColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn DeleteColumn;
    }
}