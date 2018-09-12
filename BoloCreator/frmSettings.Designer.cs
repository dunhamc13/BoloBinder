namespace BoloCreator
{
    partial class frmSettings
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
            this.chkSortNewestFirst = new System.Windows.Forms.CheckBox();
            this.chkIncludeApprehensions = new System.Windows.Forms.CheckBox();
            this.chkIncludePmrs = new System.Windows.Forms.CheckBox();
            this.chkIncludeKtrs = new System.Windows.Forms.CheckBox();
            this.chkIncludeMisc = new System.Windows.Forms.CheckBox();
            this.chkSortByType = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblAppFolderName = new System.Windows.Forms.Label();
            this.lblPmrFolderName = new System.Windows.Forms.Label();
            this.lblKtrFolderName = new System.Windows.Forms.Label();
            this.txtAppFolderName = new System.Windows.Forms.TextBox();
            this.txtPmrFolderName = new System.Windows.Forms.TextBox();
            this.txtKtrFolderName = new System.Windows.Forms.TextBox();
            this.grpSorting = new System.Windows.Forms.GroupBox();
            this.grpInclusion = new System.Windows.Forms.GroupBox();
            this.grpFolderNames = new System.Windows.Forms.GroupBox();
            this.grpExclusion = new System.Windows.Forms.GroupBox();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.txtAddWord = new System.Windows.Forms.TextBox();
            this.btnRemoveWord = new System.Windows.Forms.Button();
            this.lbExclusionList = new System.Windows.Forms.ListBox();
            this.lblExclusionList = new System.Windows.Forms.Label();
            this.btnResetDefaults = new System.Windows.Forms.Button();
            this.grpSorting.SuspendLayout();
            this.grpInclusion.SuspendLayout();
            this.grpFolderNames.SuspendLayout();
            this.grpExclusion.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkSortNewestFirst
            // 
            this.chkSortNewestFirst.AutoSize = true;
            this.chkSortNewestFirst.Checked = true;
            this.chkSortNewestFirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSortNewestFirst.Location = new System.Drawing.Point(6, 19);
            this.chkSortNewestFirst.Name = "chkSortNewestFirst";
            this.chkSortNewestFirst.Size = new System.Drawing.Size(106, 17);
            this.chkSortNewestFirst.TabIndex = 0;
            this.chkSortNewestFirst.Text = "Sort Newest First";
            this.toolTip1.SetToolTip(this.chkSortNewestFirst, "If checked, shows newest to oldest.  If unchecked, shows oldest to newest.");
            this.chkSortNewestFirst.UseVisualStyleBackColor = true;
            this.chkSortNewestFirst.CheckedChanged += new System.EventHandler(this.chkSortNewestFirst_CheckedChanged);
            // 
            // chkIncludeApprehensions
            // 
            this.chkIncludeApprehensions.AutoSize = true;
            this.chkIncludeApprehensions.Checked = true;
            this.chkIncludeApprehensions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeApprehensions.Location = new System.Drawing.Point(6, 19);
            this.chkIncludeApprehensions.Name = "chkIncludeApprehensions";
            this.chkIncludeApprehensions.Size = new System.Drawing.Size(134, 17);
            this.chkIncludeApprehensions.TabIndex = 0;
            this.chkIncludeApprehensions.Text = "Include Apprehensions";
            this.toolTip1.SetToolTip(this.chkIncludeApprehensions, "If unchecked, apprehensions will not be shown. ");
            this.chkIncludeApprehensions.UseVisualStyleBackColor = true;
            this.chkIncludeApprehensions.CheckedChanged += new System.EventHandler(this.chkIncludeApprehensions_CheckedChanged);
            // 
            // chkIncludePmrs
            // 
            this.chkIncludePmrs.AutoSize = true;
            this.chkIncludePmrs.Checked = true;
            this.chkIncludePmrs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludePmrs.Location = new System.Drawing.Point(6, 43);
            this.chkIncludePmrs.Name = "chkIncludePmrs";
            this.chkIncludePmrs.Size = new System.Drawing.Size(93, 17);
            this.chkIncludePmrs.TabIndex = 1;
            this.chkIncludePmrs.Text = "Include PMRs";
            this.toolTip1.SetToolTip(this.chkIncludePmrs, "If unchecked, PMRs will not be shown.");
            this.chkIncludePmrs.UseVisualStyleBackColor = true;
            this.chkIncludePmrs.CheckedChanged += new System.EventHandler(this.chkIncludePmrs_CheckedChanged);
            // 
            // chkIncludeKtrs
            // 
            this.chkIncludeKtrs.AutoSize = true;
            this.chkIncludeKtrs.Checked = true;
            this.chkIncludeKtrs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeKtrs.Location = new System.Drawing.Point(6, 67);
            this.chkIncludeKtrs.Name = "chkIncludeKtrs";
            this.chkIncludeKtrs.Size = new System.Drawing.Size(91, 17);
            this.chkIncludeKtrs.TabIndex = 2;
            this.chkIncludeKtrs.Text = "Include KTRs";
            this.toolTip1.SetToolTip(this.chkIncludeKtrs, "If unchecked, KTRs will not be shown. ");
            this.chkIncludeKtrs.UseVisualStyleBackColor = true;
            this.chkIncludeKtrs.CheckedChanged += new System.EventHandler(this.chkIncludeKtrs_CheckedChanged);
            // 
            // chkIncludeMisc
            // 
            this.chkIncludeMisc.AutoSize = true;
            this.chkIncludeMisc.Checked = true;
            this.chkIncludeMisc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeMisc.Location = new System.Drawing.Point(6, 90);
            this.chkIncludeMisc.Name = "chkIncludeMisc";
            this.chkIncludeMisc.Size = new System.Drawing.Size(131, 17);
            this.chkIncludeMisc.TabIndex = 3;
            this.chkIncludeMisc.Text = "Include Miscellaneous";
            this.toolTip1.SetToolTip(this.chkIncludeMisc, "If unchecked, miscellaneous will not be shown. ");
            this.chkIncludeMisc.UseVisualStyleBackColor = true;
            this.chkIncludeMisc.CheckedChanged += new System.EventHandler(this.chkIncludeMisc_CheckedChanged);
            // 
            // chkSortByType
            // 
            this.chkSortByType.AutoSize = true;
            this.chkSortByType.Checked = true;
            this.chkSortByType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSortByType.Location = new System.Drawing.Point(6, 43);
            this.chkSortByType.Name = "chkSortByType";
            this.chkSortByType.Size = new System.Drawing.Size(87, 17);
            this.chkSortByType.TabIndex = 1;
            this.chkSortByType.Text = "Sort By Type";
            this.toolTip1.SetToolTip(this.chkSortByType, "If checked, will group APPs, PMRs, KTRs, and Miscellaneous separately.");
            this.chkSortByType.UseVisualStyleBackColor = true;
            this.chkSortByType.CheckedChanged += new System.EventHandler(this.chkSortByType_CheckedChanged);
            // 
            // lblAppFolderName
            // 
            this.lblAppFolderName.AutoSize = true;
            this.lblAppFolderName.Location = new System.Drawing.Point(6, 25);
            this.lblAppFolderName.Name = "lblAppFolderName";
            this.lblAppFolderName.Size = new System.Drawing.Size(138, 13);
            this.lblAppFolderName.TabIndex = 0;
            this.lblAppFolderName.Text = "Apprehension Folder Name:";
            this.toolTip1.SetToolTip(this.lblAppFolderName, "Files found in folders with this name will be sorted as apprehensions.");
            // 
            // lblPmrFolderName
            // 
            this.lblPmrFolderName.AutoSize = true;
            this.lblPmrFolderName.Location = new System.Drawing.Point(6, 51);
            this.lblPmrFolderName.Name = "lblPmrFolderName";
            this.lblPmrFolderName.Size = new System.Drawing.Size(97, 13);
            this.lblPmrFolderName.TabIndex = 2;
            this.lblPmrFolderName.Text = "PMR Folder Name:";
            this.toolTip1.SetToolTip(this.lblPmrFolderName, "Files found in folders with this name will be sorted as PMRs.");
            // 
            // lblKtrFolderName
            // 
            this.lblKtrFolderName.AutoSize = true;
            this.lblKtrFolderName.Location = new System.Drawing.Point(6, 77);
            this.lblKtrFolderName.Name = "lblKtrFolderName";
            this.lblKtrFolderName.Size = new System.Drawing.Size(95, 13);
            this.lblKtrFolderName.TabIndex = 9;
            this.lblKtrFolderName.Text = "KTR Folder Name:";
            this.toolTip1.SetToolTip(this.lblKtrFolderName, "Files found in folders with this name will be sorted as KTRs.");
            // 
            // txtAppFolderName
            // 
            this.txtAppFolderName.Location = new System.Drawing.Point(150, 22);
            this.txtAppFolderName.Name = "txtAppFolderName";
            this.txtAppFolderName.Size = new System.Drawing.Size(100, 20);
            this.txtAppFolderName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtAppFolderName, "Files found in folders with this name will be sorted as apprehensions.");
            this.txtAppFolderName.Leave += new System.EventHandler(this.txtAppFolderName_Leave);
            // 
            // txtPmrFolderName
            // 
            this.txtPmrFolderName.Location = new System.Drawing.Point(150, 48);
            this.txtPmrFolderName.Name = "txtPmrFolderName";
            this.txtPmrFolderName.Size = new System.Drawing.Size(100, 20);
            this.txtPmrFolderName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtPmrFolderName, "Files found in folders with this name will be sorted as PMRs.");
            this.txtPmrFolderName.Leave += new System.EventHandler(this.txtPmrFolderName_Leave);
            // 
            // txtKtrFolderName
            // 
            this.txtKtrFolderName.Location = new System.Drawing.Point(150, 74);
            this.txtKtrFolderName.Name = "txtKtrFolderName";
            this.txtKtrFolderName.Size = new System.Drawing.Size(100, 20);
            this.txtKtrFolderName.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtKtrFolderName, "Files found in folders with this name will be sorted as KTRs.");
            this.txtKtrFolderName.Leave += new System.EventHandler(this.txtKtrFolderName_Leave);
            // 
            // grpSorting
            // 
            this.grpSorting.Controls.Add(this.chkSortNewestFirst);
            this.grpSorting.Controls.Add(this.chkSortByType);
            this.grpSorting.Location = new System.Drawing.Point(13, 12);
            this.grpSorting.Name = "grpSorting";
            this.grpSorting.Size = new System.Drawing.Size(118, 116);
            this.grpSorting.TabIndex = 0;
            this.grpSorting.TabStop = false;
            this.grpSorting.Text = "Sorting";
            // 
            // grpInclusion
            // 
            this.grpInclusion.Controls.Add(this.chkIncludeApprehensions);
            this.grpInclusion.Controls.Add(this.chkIncludePmrs);
            this.grpInclusion.Controls.Add(this.chkIncludeKtrs);
            this.grpInclusion.Controls.Add(this.chkIncludeMisc);
            this.grpInclusion.Location = new System.Drawing.Point(137, 12);
            this.grpInclusion.Name = "grpInclusion";
            this.grpInclusion.Size = new System.Drawing.Size(151, 116);
            this.grpInclusion.TabIndex = 1;
            this.grpInclusion.TabStop = false;
            this.grpInclusion.Text = "Inclusion";
            // 
            // grpFolderNames
            // 
            this.grpFolderNames.Controls.Add(this.lblAppFolderName);
            this.grpFolderNames.Controls.Add(this.lblPmrFolderName);
            this.grpFolderNames.Controls.Add(this.lblKtrFolderName);
            this.grpFolderNames.Controls.Add(this.txtKtrFolderName);
            this.grpFolderNames.Controls.Add(this.txtAppFolderName);
            this.grpFolderNames.Controls.Add(this.txtPmrFolderName);
            this.grpFolderNames.Location = new System.Drawing.Point(294, 12);
            this.grpFolderNames.Name = "grpFolderNames";
            this.grpFolderNames.Size = new System.Drawing.Size(268, 116);
            this.grpFolderNames.TabIndex = 2;
            this.grpFolderNames.TabStop = false;
            this.grpFolderNames.Text = "Folder Names";
            // 
            // grpExclusion
            // 
            this.grpExclusion.Controls.Add(this.lblExclusionList);
            this.grpExclusion.Controls.Add(this.lbExclusionList);
            this.grpExclusion.Controls.Add(this.btnRemoveWord);
            this.grpExclusion.Controls.Add(this.txtAddWord);
            this.grpExclusion.Controls.Add(this.btnAddWord);
            this.grpExclusion.Location = new System.Drawing.Point(13, 135);
            this.grpExclusion.Name = "grpExclusion";
            this.grpExclusion.Size = new System.Drawing.Size(397, 303);
            this.grpExclusion.TabIndex = 3;
            this.grpExclusion.TabStop = false;
            this.grpExclusion.Text = "Exclusion";
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(313, 32);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(80, 23);
            this.btnAddWord.TabIndex = 3;
            this.btnAddWord.Text = "Add Keyword";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // txtAddWord
            // 
            this.txtAddWord.Location = new System.Drawing.Point(179, 34);
            this.txtAddWord.Name = "txtAddWord";
            this.txtAddWord.Size = new System.Drawing.Size(128, 20);
            this.txtAddWord.TabIndex = 2;
            // 
            // btnRemoveWord
            // 
            this.btnRemoveWord.Enabled = false;
            this.btnRemoveWord.Location = new System.Drawing.Point(179, 61);
            this.btnRemoveWord.Name = "btnRemoveWord";
            this.btnRemoveWord.Size = new System.Drawing.Size(149, 23);
            this.btnRemoveWord.TabIndex = 4;
            this.btnRemoveWord.Text = "Remove Selected Keyword";
            this.btnRemoveWord.UseVisualStyleBackColor = true;
            this.btnRemoveWord.Click += new System.EventHandler(this.btnRemoveWord_Click);
            // 
            // lbExclusionList
            // 
            this.lbExclusionList.FormattingEnabled = true;
            this.lbExclusionList.Location = new System.Drawing.Point(6, 32);
            this.lbExclusionList.Name = "lbExclusionList";
            this.lbExclusionList.Size = new System.Drawing.Size(164, 264);
            this.lbExclusionList.TabIndex = 1;
            this.lbExclusionList.SelectedIndexChanged += new System.EventHandler(this.lbExclusionList_SelectedIndexChanged);
            // 
            // lblExclusionList
            // 
            this.lblExclusionList.AutoSize = true;
            this.lblExclusionList.Location = new System.Drawing.Point(6, 16);
            this.lblExclusionList.Name = "lblExclusionList";
            this.lblExclusionList.Size = new System.Drawing.Size(164, 13);
            this.lblExclusionList.TabIndex = 0;
            this.lblExclusionList.Text = "Keywords to exclude from results:";
            // 
            // btnResetDefaults
            // 
            this.btnResetDefaults.Location = new System.Drawing.Point(447, 415);
            this.btnResetDefaults.Name = "btnResetDefaults";
            this.btnResetDefaults.Size = new System.Drawing.Size(118, 23);
            this.btnResetDefaults.TabIndex = 4;
            this.btnResetDefaults.Text = "Reset To Defaults";
            this.btnResetDefaults.UseVisualStyleBackColor = true;
            this.btnResetDefaults.Click += new System.EventHandler(this.btnResetDefaults_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.btnResetDefaults);
            this.Controls.Add(this.grpExclusion);
            this.Controls.Add(this.grpFolderNames);
            this.Controls.Add(this.grpInclusion);
            this.Controls.Add(this.grpSorting);
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.toolTip1.SetToolTip(this, "Folder and file names that contain items in this list will not be returned in res" +
        "ults.");
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.grpSorting.ResumeLayout(false);
            this.grpSorting.PerformLayout();
            this.grpInclusion.ResumeLayout(false);
            this.grpInclusion.PerformLayout();
            this.grpFolderNames.ResumeLayout(false);
            this.grpFolderNames.PerformLayout();
            this.grpExclusion.ResumeLayout(false);
            this.grpExclusion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSortNewestFirst;
        private System.Windows.Forms.CheckBox chkIncludeApprehensions;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkIncludePmrs;
        private System.Windows.Forms.CheckBox chkIncludeKtrs;
        private System.Windows.Forms.CheckBox chkIncludeMisc;
        private System.Windows.Forms.CheckBox chkSortByType;
        private System.Windows.Forms.Label lblAppFolderName;
        private System.Windows.Forms.Label lblPmrFolderName;
        private System.Windows.Forms.Label lblKtrFolderName;
        private System.Windows.Forms.TextBox txtAppFolderName;
        private System.Windows.Forms.TextBox txtPmrFolderName;
        private System.Windows.Forms.TextBox txtKtrFolderName;
        private System.Windows.Forms.GroupBox grpSorting;
        private System.Windows.Forms.GroupBox grpInclusion;
        private System.Windows.Forms.GroupBox grpFolderNames;
        private System.Windows.Forms.GroupBox grpExclusion;
        private System.Windows.Forms.Label lblExclusionList;
        private System.Windows.Forms.ListBox lbExclusionList;
        private System.Windows.Forms.Button btnRemoveWord;
        private System.Windows.Forms.TextBox txtAddWord;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button btnResetDefaults;
    }
}