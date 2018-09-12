using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoloCreator
{
    public partial class frmSettings : Form
    {
        Properties.Settings settings = Properties.Settings.Default;
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnResetDefaults_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset to default values?",  "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                settings.Reset();
                ResetFromSettings();
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            ResetFromSettings();
        }

        private void ResetFromSettings()
        {
            chkSortNewestFirst.Checked = settings.SortNewestFirst;
            chkSortByType.Checked = settings.SortByType;

            chkIncludeApprehensions.Checked = settings.IncludeApprehensions;
            chkIncludePmrs.Checked = settings.IncludePmrs;
            chkIncludeKtrs.Checked = settings.IncludeKtrs;
            chkIncludeMisc.Checked = settings.IncludeMisc;

            txtAppFolderName.Text = settings.ApprehensionFolderName;
            txtPmrFolderName.Text = settings.PmrFolderName;
            txtKtrFolderName.Text = settings.KtrFolderName;

            foreach (string keyword in settings.SkipKeywords)
            {
                lbExclusionList.Items.Add(keyword);
            }
        }

        private void chkSortNewestFirst_CheckedChanged(object sender, EventArgs e)
        {
            settings.SortNewestFirst = chkSortNewestFirst.Checked;
        }

        private void chkSortByType_CheckedChanged(object sender, EventArgs e)
        {
            settings.SortByType = chkSortByType.Checked;
        }

        private void chkIncludeApprehensions_CheckedChanged(object sender, EventArgs e)
        {
            settings.IncludeApprehensions = chkIncludeApprehensions.Checked;
        }

        private void chkIncludePmrs_CheckedChanged(object sender, EventArgs e)
        {
            settings.IncludePmrs = chkIncludePmrs.Checked;
        }

        private void chkIncludeKtrs_CheckedChanged(object sender, EventArgs e)
        {
            settings.IncludeKtrs = chkIncludeKtrs.Checked;
        }

        private void chkIncludeMisc_CheckedChanged(object sender, EventArgs e)
        {
            settings.IncludeMisc = chkIncludeMisc.Checked;
        }

        private void txtAppFolderName_Leave(object sender, EventArgs e)
        {
            settings.ApprehensionFolderName = txtAppFolderName.Text;
        }

        private void txtPmrFolderName_Leave(object sender, EventArgs e)
        {
            settings.PmrFolderName = txtPmrFolderName.Text;
        }

        private void txtKtrFolderName_Leave(object sender, EventArgs e)
        {
            settings.KtrFolderName = txtKtrFolderName.Text;
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Would you like to save your changes to the settings?", "Confirm Exit", MessageBoxButtons.YesNoCancel);
            if (r == DialogResult.Yes)
            {
                settings.Save();
                MessageBox.Show("Changes saved.");
            } else if (r == DialogResult.No)
            {
                MessageBox.Show("Changes discarded.");
            } else
            {
                e.Cancel = true;
            }
        }
    }
}
