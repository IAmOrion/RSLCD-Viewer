//#define DEBUG_URL
//#define DEBUG_HEADERS

using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace AIDA64SensorPanelBrowser_v2
{
    [StructLayout(LayoutKind.Sequential)]
    public struct LtrbRectangle
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;

        public LtrbRectangle(int left, int top, int right, int bottom)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        public Rectangle ToRectangle()
        {
            return Rectangle.FromLTRB(Left, Top, Right, Bottom);
        }

        public static LtrbRectangle FromRectangle(Rectangle rect)
        {
            return new LtrbRectangle(rect.X, rect.Y, rect.X + rect.Width, rect.Y + rect.Height);
        }

        public override string ToString()
        {
            return "{Left=" + Left + ",Top=" + Top + ",Right=" + Right + ",Bottom=" + Bottom + "}";
        }
    }

    public partial class Main : Form
    {
        IAmOrionContextMenu m_IAmOrionPoppedContainerForPanel;
        IAmOrionPopperContainer m_IAmOrionPopperContainerForPanel;

        private const int WmEnterSizeMove = 0x0231;
        private const int WmMoving = 0x0216;
        private const int WmSize = 0x0005;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        private const UInt32 NOTOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private SnapLocation _snapAnchor;
        private int _dragOffsetX;
        private int _dragOffsetY;


        public Main()
        {
            #if DEBUG
                Debug.WriteLine("\n\n\n\n\n\n");
            #endif

            InitializeComponent();

            webView.EnsureCoreWebView2Async();

            //Properties.Settings.Default.PropertyChanged += SettingChanged;

            m_IAmOrionPoppedContainerForPanel = new IAmOrionContextMenu();
            m_IAmOrionPopperContainerForPanel = new IAmOrionPopperContainer(m_IAmOrionPoppedContainerForPanel);
            m_IAmOrionPoppedContainerForPanel.btnSettings.Click += new System.EventHandler(btnSettings_Click);
            m_IAmOrionPoppedContainerForPanel.btnResetDefaults.Click += new System.EventHandler(btnResetDefaults_Click);
            m_IAmOrionPoppedContainerForPanel.btnExit.Click += new System.EventHandler(btnExit_Click);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (!(DesignMode || _isHandleInitialized))
            {
                _isHandleInitialized = true;
                checkURL();

            }
        }
        bool _isHandleInitialized = false;

        private void btnSettings_Click(object sender, EventArgs e)
        {
            m_IAmOrionPopperContainerForPanel.Close();
            ShowSettings();
        }

        private void ShowSettings()
        {
            Program.isTaskPaused = true;
            settingsForm frmSettings = new settingsForm();
            if (frmSettings.ShowDialog(this) == DialogResult.OK)
            {
                #if DEBUG
                    Debug.WriteLine("Settings Saved");
                #endif
                Program.isTaskPaused = false;
                Program.changesMade = true;
                SettingChanged();
            }
            else
            {
                #if DEBUG
                    Debug.WriteLine("Settings Changes Cancelled");
                #endif
                Program.isTaskPaused = false;
                Program.changesMade = false;
            }
            frmSettings.Dispose();
        }

        private void btnResetDefaults_Click(object sender, EventArgs e)
        {
            m_IAmOrionPopperContainerForPanel.Close();

            DialogResult confirmReset = MessageBox.Show("This will reset all settings and window position back to default. The program will automatically restart.\nAre you sure you wish to continue?","Reset Defaults", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (confirmReset == DialogResult.OK)
            {
                Properties.Settings.Default.Location = new Point(0, 0);
                int setWidth = Decimal.ToInt32(Program.defaultWidth);
                int setHeight = Decimal.ToInt32(Program.defaultHeight);
                Properties.Settings.Default.Size = new Size(setWidth, setHeight);
                Properties.Settings.Default.Port = System.Convert.ToDecimal(Program.defaultPort);
                Properties.Settings.Default.URL = Program.defaultURL;
                Properties.Settings.Default.RunAtStartup = Program.defaultRunAtStartup;
                Properties.Settings.Default.Snapping = Program.defaultSnapping;
                Properties.Settings.Default.AlwaysOnTop = Program.defaultAlwaysOnTop;
                Properties.Settings.Default.SnappingDistance = Program.defaultSnappingDistance;
                Properties.Settings.Default.Save();
                Application.Restart();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            m_IAmOrionPopperContainerForPanel.Close();
            Application.Exit();
        }

        private void webView_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            Program.isTaskPaused = true;
        #if DEBUG
            #if DEBUG_URL
                Debug.WriteLine("Navigating to = " + webView.Source.ToString());
            #endif
        #endif
        }

        private void webView_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            Debug.WriteLine("NavigationCompleted\n");
            if (e.IsSuccess)
            {
                ((Microsoft.Web.WebView2.WinForms.WebView2)sender).ExecuteScriptAsync("document.querySelector('body').style.overflow='hidden'");
            }
             else if (!e.IsSuccess)
            {
                webView.DefaultBackgroundColor = Color.Blue;
            }
            Program.currentURL = webView.Source.ToString();
            #if DEBUG
                #if DEBUG_URL
                    Debug.WriteLine("currentURL = " + Program.currentURL);
                #endif
            #endif
            Program.isTaskPaused = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ShowInTaskbar = false;

            if (Properties.Settings.Default.Maximised)
            {
                Location = Properties.Settings.Default.Location;
                WindowState = FormWindowState.Maximized;
                Size = Properties.Settings.Default.Size;
            }
            else if (Properties.Settings.Default.Minimised)
            {
                Location = Properties.Settings.Default.Location;
                WindowState = FormWindowState.Minimized;
                Size = Properties.Settings.Default.Size;
            }
            else
            {
                Location = Properties.Settings.Default.Location;
                Size = Properties.Settings.Default.Size;
            }
            webView.Size = Properties.Settings.Default.Size;
            Overlay.Size = Properties.Settings.Default.Size;
            Program.snappingEnabled = Properties.Settings.Default.Snapping;
            Program.alwaysOnTop = Properties.Settings.Default.AlwaysOnTop;
            if (Program.alwaysOnTop == true)
            {
                SetWindowPos(Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            }
            else if (Program.alwaysOnTop == false)
            {
                SetWindowPos(Handle, HWND_NOTOPMOST, 0, 0, 0, 0, NOTOPMOST_FLAGS);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                Properties.Settings.Default.Location = RestoreBounds.Location;
                Properties.Settings.Default.Size = RestoreBounds.Size;
                Properties.Settings.Default.Maximised = true;
                Properties.Settings.Default.Minimised = false;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.Location = Location;
                Properties.Settings.Default.Size = Size;
                Properties.Settings.Default.Maximised = false;
                Properties.Settings.Default.Minimised = false;
            }
            else
            {
                Properties.Settings.Default.Location = RestoreBounds.Location;
                Properties.Settings.Default.Size = RestoreBounds.Size;
                Properties.Settings.Default.Maximised = false;
                Properties.Settings.Default.Minimised = true;
            }
            Properties.Settings.Default.Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }

        //void SettingChanged(object sender, PropertyChangedEventArgs e)
        void SettingChanged()
        {
            if (Program.changesMade == true)
            {
                #if DEBUG
                    Debug.WriteLine("Settings Changed fired");
                #endif
                Size = Properties.Settings.Default.Size;
                webView.Size = Properties.Settings.Default.Size;
                Overlay.Size = Properties.Settings.Default.Size;
                if (Program.didResetPosition)
                {
                    Location = Properties.Settings.Default.Location;
                    Program.didResetPosition = false;

                }
                Program.snappingEnabled = Properties.Settings.Default.Snapping;
                Program.alwaysOnTop = Properties.Settings.Default.AlwaysOnTop;
                if (Properties.Settings.Default.RunAtStartup == true)
                {
                    Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    key.SetValue("RSLCD Viewer", Application.ExecutablePath);
                }
                else if (Properties.Settings.Default.RunAtStartup == false)
                {
                    Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    key.DeleteValue("RSLCD Viewer", false);
                }

                if (Program.alwaysOnTop == true)
                {
                    SetWindowPos(Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
                }
                else if (Program.alwaysOnTop == false)
                {
                    SetWindowPos(Handle, HWND_NOTOPMOST, 0, 0, 0, 0, NOTOPMOST_FLAGS);
                }
                SnapDistance = Properties.Settings.Default.SnappingDistance;

                Debug.WriteLine("Settings Changed!\nSnapping Enabled: " + Program.snappingEnabled + "\nSnap Distance: " + SnapDistance);

                Program.changesMade = false;
            }
        }

        private void Overlay_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
            else if (e.Button == MouseButtons.Right)
            {
                m_IAmOrionPopperContainerForPanel.Show(this, e.Location);
            }
        }

        /// <summary>
        /// Flags specifying which edges to anchor the form at.
        /// </summary>
        [Flags]
        public enum SnapLocation
        {
            None = 0,
            Left = 1 << 0,
            Top = 1 << 1,
            Right = 1 << 2,
            Bottom = 1 << 3,
            All = Left | Top | Right | Bottom
        }

        /// <summary>
        /// How far from the screen edge to anchor the form.
        /// </summary>
        [Browsable(true)]
        [DefaultValue(10)]
        [Description("The distance from the screen edge to anchor the form.")]
        //public virtual int AnchorDistance { get; set; } = 10;
        public virtual int AnchorDistance { get; set; } = 0;

        /// <summary>
        /// Gets or sets how close the form must be to the
        /// anchor point to snap to it. A higher value gives
        /// a more noticable "snap" effect.
        /// </summary>
        [Browsable(true)]
        [DefaultValue(20)]
        [Description("The maximum form snapping distance.")]
        public virtual int SnapDistance { get; set; } = 20;

        /// <summary>
        /// Re-snaps the control to its current anchor points.
        /// This can be useful for re-positioning the form after
        /// the screen resolution changes.
        /// </summary>
        public void ReSnap()
        {
            SnapTo(_snapAnchor);
        }

        /// <summary>
        /// Forces the control to snap to the specified edges.
        /// </summary>
        /// <param name="anchor">The screen edges to snap to.</param>
        public void SnapTo(SnapLocation anchor)
        {
            Screen currentScreen = Screen.FromPoint(Location);
            Rectangle workingArea = currentScreen.WorkingArea;
            if ((anchor & SnapLocation.Left) != 0)
            {
                Left = workingArea.Left + AnchorDistance;
            }
            else if ((anchor & SnapLocation.Right) != 0)
            {
                Left = workingArea.Right - AnchorDistance - Width;
            }
            if ((anchor & SnapLocation.Top) != 0)
            {
                Top = workingArea.Top + AnchorDistance;
            }
            else if ((anchor & SnapLocation.Bottom) != 0)
            {
                Top = workingArea.Bottom - AnchorDistance - Height;
            }
            _snapAnchor = anchor;
        }

        private bool InSnapRange(int a, int b)
        {
            return Math.Abs(a - b) < SnapDistance;
        }

        private SnapLocation FindSnap(ref Rectangle effectiveBounds)
        {
            Screen currentScreen = Screen.FromPoint(effectiveBounds.Location);
            Rectangle workingArea = currentScreen.WorkingArea;
            SnapLocation anchor = SnapLocation.None;
            if (InSnapRange(effectiveBounds.Left, workingArea.Left + AnchorDistance))
            {
                effectiveBounds.X = workingArea.Left + AnchorDistance;
                anchor |= SnapLocation.Left;
            }
            else if (InSnapRange(effectiveBounds.Right, workingArea.Right - AnchorDistance))
            {
                effectiveBounds.X = workingArea.Right - AnchorDistance - effectiveBounds.Width;
                anchor |= SnapLocation.Right;
            }
            if (InSnapRange(effectiveBounds.Top, workingArea.Top + AnchorDistance))
            {
                effectiveBounds.Y = workingArea.Top + AnchorDistance;
                anchor |= SnapLocation.Top;
            }
            else if (InSnapRange(effectiveBounds.Bottom, workingArea.Bottom - AnchorDistance))
            {
                effectiveBounds.Y = workingArea.Bottom - AnchorDistance - effectiveBounds.Height;
                anchor |= SnapLocation.Bottom;
            }
            return anchor;
        }

        protected override void WndProc(ref Message m)
        {
            if (Program.snappingEnabled == true)
            {
                switch (m.Msg)
                {
                    case WmEnterSizeMove:
                    case WmSize:
                        // Need to handle window size changed as well when
                        // un-maximizing the form by dragging the title bar.
                        _dragOffsetX = Cursor.Position.X - Left;
                        _dragOffsetY = Cursor.Position.Y - Top;
                        break;
                    case WmMoving:
                        LtrbRectangle boundsLtrb = Marshal.PtrToStructure<LtrbRectangle>(m.LParam);
                        Rectangle bounds = boundsLtrb.ToRectangle();
                        // This is where the window _would_ be located if snapping
                        // had not occurred. This prevents the cursor from sliding
                        // off the title bar if the snap distance is too large.
                        Rectangle effectiveBounds = new Rectangle(
                            Cursor.Position.X - _dragOffsetX,
                            Cursor.Position.Y - _dragOffsetY,
                            bounds.Width,
                            bounds.Height);
                        _snapAnchor = FindSnap(ref effectiveBounds);
                        LtrbRectangle newLtrb = LtrbRectangle.FromRectangle(effectiveBounds);
                        Marshal.StructureToPtr(newLtrb, m.LParam, false);
                        m.Result = new IntPtr(1);
                        break;
                }
            }
            base.WndProc(ref m);
        }

        private string BuildURL()
        {
            string webViewURL;
            string stringURL = Properties.Settings.Default.URL;
            string stringPort = Properties.Settings.Default.Port.ToString();
            string stringURLPORT = $"{stringURL}:{stringPort}";
            if (stringPort.Equals("80"))
            {
                webViewURL = stringURL;
            }
            else
            {
                webViewURL = stringURLPORT;
            }
            if (!webViewURL.EndsWith("/")) { webViewURL += "/"; }

            #if DEBUG
                #if DEBUG_URL
                    Debug.WriteLine("BuildURL returns: " + webViewURL);
                #endif
            #endif

            return webViewURL;
        }

        void checkURL()
        {
            Task.Run(() =>
            {
                while (!DisposeCheckURL.IsCancellationRequested)
                {
                    if (Program.isTaskPaused == false && Program.webViewIsInitialised == true)
                    {
                        string webViewURL = BuildURL();

                        try
                        {
                            #pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
                            if (Uri.TryCreate(webViewURL, UriKind.Absolute, out Uri? uri)
                                && (uri.Scheme == Uri.UriSchemeHttp ||
                                uri.Scheme == Uri.UriSchemeHttps))
                            {
                                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(webViewURL);
                                request.AllowAutoRedirect = false; // find out if this site is up and don't follow a redirector
                                request.Method = "HEAD";
                                request.Timeout = 1500;

                                using (var response = request.GetResponse())
                                {
                                    #if DEBUG
                                        #if DEBUG_HEADERS
                                            Debug.WriteLine("Response Headers: " + response.Headers);
                                        #endif
                                    #endif
                                    Program.isWebSiteUp = true;
                                }
                            }
                            else
                            {
                                #if DEBUG
                                    Invoke(() => Debug.WriteLine($"{DateTime.Now}: Invalid URI: try 'http://"));
                                #endif
                            }
                            #pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
                        }
                        catch (WebException exception)
                        {
                            #if DEBUG
                                Debug.WriteLine("WebException Thrown: " + exception.Message);
                            #endif
                            if (exception.Message.Contains("(401) Unauthorized"))
                            {
                                Program.isWebSiteUp = false;
                            }
                            else
                            {
                                Program.isWebSiteUp = false;
                            }
                        }
                        catch (Exception exception)
                        {
                            #if DEBUG
                                Debug.WriteLine("Exception Thrown: " + exception.Message);
                            #endif
                            Program.isWebSiteUp = false;
                        }

                        if (Program.isWebSiteUp == true && webView.Source.ToString().StartsWith("file://"))
                        {
                            #if DEBUG
                                Debug.WriteLine("Code Marker:1");
                                Debug.WriteLine("isWebSiteUp = true, webView.Source = " + webView.Source.ToString());
                            #endif
                            Invoke(() => webView.CoreWebView2.Navigate(webViewURL));
                        }
                        else if (Program.isWebSiteUp == true && !webView.Source.ToString().Equals(webViewURL))
                        {
                            #if DEBUG
                                Debug.WriteLine("Code Marker:2");
                                Debug.WriteLine("isWebSiteUp = true\nwebView.Source = " + webView.Source.ToString() + "\nwebViewURL = " + webViewURL + "\nWebView Source == webViewURL: " + webView.Source.ToString().Equals(webViewURL) + "\n");
                            #endif
                            Invoke(() => webView.CoreWebView2.Navigate(webViewURL));
                        }
                        else if (Program.isWebSiteUp == false && !webView.Source.ToString().Contains("bsod.html"))
                        {
                            #if DEBUG
                                Debug.WriteLine("Code Marker:3");
                                Debug.WriteLine("This SHOULD be reloading the BSOD page!");
                            #endif

                            Invoke(() => webView.Source = new Uri(Path.Combine(Environment.CurrentDirectory, @"Resources\bsod.html")));

                        }
                        Task.Delay(1000).Wait();
                    }
                }
            }, DisposeCheckURL.Token);
        }

        private void Invoke(Action action)
        {
            Invoke((MethodInvoker)delegate
            {
                action();
            });
        }

        public CancellationTokenSource DisposeCheckURL { get; } = new CancellationTokenSource();

        private void webView_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            Program.webViewIsInitialised = true;
        }
    }
}
