using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;

namespace AIDA64SensorPanelBrowser_v2
{
    public partial class settingsForm : Form
    {
        const int MF_BYPOSITION = 0x400;

        [DllImport("User32")]
        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("User32")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("User32")]
        private static extern int GetMenuItemCount(IntPtr hWnd);

        public settingsForm()
        {
            InitializeComponent();
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AlwaysShowSettingsOnPrimaryMonitor == true)
            {
                var primaryMonitor = Screen.AllScreens.Where(s => s.Primary).FirstOrDefault();
                var secondaryScreens = Screen.AllScreens.Where(s => !s.Primary).ToList();
                var screenSizeWidth = primaryMonitor.WorkingArea.Width;
                var screenSizeHeight = primaryMonitor.WorkingArea.Height;
                var frmTopPos = ((screenSizeHeight - 413) / 2);
                var frmLeftPos = ((screenSizeWidth - 476) / 2);
                this.Location = primaryMonitor.WorkingArea.Location;
                this.Top = frmTopPos; this.Left = frmLeftPos;
            }

            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int menuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);
            settingsWidth.Value = Properties.Settings.Default.Size.Width;
            settingsHeight.Value = Properties.Settings.Default.Size.Height;
            settingsURL.Text = Properties.Settings.Default.URL;
            settingsPort.Value = Properties.Settings.Default.Port;
            settingsRunAtStartup.Checked = Properties.Settings.Default.RunAtStartup;
            settingsSnapping.Checked = Properties.Settings.Default.Snapping;
            settingsAlwaysOnTop.Checked = Properties.Settings.Default.AlwaysOnTop;
            settingsShowOnPrimaryMonitor.Checked = Properties.Settings.Default.AlwaysShowSettingsOnPrimaryMonitor;
            settingsSnappingDistance.Value = Properties.Settings.Default.SnappingDistance;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateURL())
            {
                int setWidth = Decimal.ToInt32(settingsWidth.Value);
                int setHeight = Decimal.ToInt32(settingsHeight.Value);
                Properties.Settings.Default.Size = new Size(setWidth, setHeight);
                Properties.Settings.Default.URL = settingsURL.Text;
                Properties.Settings.Default.Port = settingsPort.Value;
                Properties.Settings.Default.RunAtStartup = settingsRunAtStartup.Checked;
                Properties.Settings.Default.Snapping = settingsSnapping.Checked;
                Properties.Settings.Default.AlwaysOnTop = settingsAlwaysOnTop.Checked;
                Properties.Settings.Default.SnappingDistance = (int)settingsSnappingDistance.Value;
                Properties.Settings.Default.AlwaysShowSettingsOnPrimaryMonitor = settingsShowOnPrimaryMonitor.Checked;
                Properties.Settings.Default.Save();
                Program.changesMade = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                InvalidURL();
            }
        }


        private void resetButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Location = new Point(0, 0);
        }

        private void btnResetPanelSize_Click(object sender, EventArgs e)
        {
            settingsWidth.Value = Program.defaultWidth;
            settingsHeight.Value = Program.defaultHeight;
            int setWidth = Decimal.ToInt32(settingsWidth.Value);
            int setHeight = Decimal.ToInt32(settingsHeight.Value);
            Properties.Settings.Default.Size = new Size(setWidth, setHeight);
            Properties.Settings.Default.Save();
        }

        private void btnResetWindow_Click(object sender, EventArgs e)
        {
            Program.didResetPosition = true;
            Properties.Settings.Default.Location = new Point(0,0);
            Properties.Settings.Default.Save();
        }

        private void linklblRSLCDHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Program.RSLCDHomeURL);
        }

        private void linklblAida64_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Program.ForumURL);
        }

        private void linklblFacebook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult visitFacebook = MessageBox.Show("Please don't send me random friend requests - I won't accept them!", "Facebook", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (visitFacebook == DialogResult.OK)
            {
                Process.Start(Program.FacebookURL);
            }
        }

        private void linklblGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Program.GitHubURL);
        }

        private bool ValidateURL()
        {
            if (settingsURL.Text.StartsWith("http://") || settingsURL.Text.StartsWith("https://"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void InvalidURL()
        {
            MessageBox.Show("You must enter a valid url starting with http:// or https://", "URL Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            settingsURL.Focus();
        }
    }
}
