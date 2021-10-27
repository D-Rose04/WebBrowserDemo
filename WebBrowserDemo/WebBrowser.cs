using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserDemo
{
    public partial class WebBrowser : Form
    {
        private bool Maximized;
        private bool mouseDown;
        private Point lastLocation;
        private int BrowserVer, RegVal;
  
        public WebBrowser()
        {
            InitializeComponent();
            MaximizeBox = true;
            WindowState = FormWindowState.Maximized;

            // get the installed IE version
            using (System.Windows.Forms.WebBrowser Wb = new System.Windows.Forms.WebBrowser())
                BrowserVer = Wb.Version.Major;
            {
                if (BrowserVer >= 11)
                    RegVal = 11001;
                else if (BrowserVer == 10)
                    RegVal = 10001;
                else if (BrowserVer == 9)
                    RegVal = 9999;
                else if (BrowserVer == 8)
                    RegVal = 8888;
                else
                    RegVal = 7000;

            }
            

            using (RegistryKey Key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", RegistryKeyPermissionCheck.ReadWriteSubTree))
                if (Key.GetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe") == null)
                    Key.SetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe", RegVal, RegistryValueKind.DWord);
            
            webBrowser.Navigate("Google.com");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void FwdButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void SearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(Keys.Enter))) 
            {
                string url = SearchBar.Text;
                webBrowser.Navigate(url);
            }
        }

        private void Tab_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Tab_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void Tab_MouseUp(object sender, MouseEventArgs e)
        {

            mouseDown = false;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            Maximized = WindowState == FormWindowState.Maximized ?
                true : false;

            WindowState = Maximized ?
                FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
