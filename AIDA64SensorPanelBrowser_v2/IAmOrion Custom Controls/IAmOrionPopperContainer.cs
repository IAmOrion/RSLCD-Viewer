using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AIDA64SensorPanelBrowser_v2
{
    public partial class IAmOrionPopperContainer : ToolStripDropDown
    {
        private Control m_IAmOrionPoppedContainer;
        private ToolStripControlHost m_host;
        private bool m_fade = true;

        public IAmOrionPopperContainer(Control IAmOrionPoppedControl)
        {
            InitializeComponent();

            if (IAmOrionPoppedControl == null)
                throw new ArgumentNullException("content");

            this.m_IAmOrionPoppedContainer = IAmOrionPoppedControl;

            this.m_fade = SystemInformation.IsMenuAnimationEnabled && SystemInformation.IsMenuFadeEnabled;

            this.m_host = new ToolStripControlHost(IAmOrionPoppedControl);
            m_host.AutoSize = false;

            Padding = Margin = m_host.Padding = m_host.Margin = Padding.Empty;

            IAmOrionPoppedControl.Location = Point.Empty;

            this.Items.Add(m_host);

            IAmOrionPoppedControl.Disposed += delegate (object sender, EventArgs e)
            {
                IAmOrionPoppedControl = null;
                Dispose(true);
            };
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {//prevent alt from closing it and allow alt+menumonic to work
            if ((keyData & Keys.Alt) == Keys.Alt)
                return false;

            return base.ProcessDialogKey(keyData);
        }

        public void Show(Control control)
        {
            if (control == null)
                throw new ArgumentNullException("control");

            Show(control, control.ClientRectangle);
        }

        public void Show(Form f, Point p)
        {
            this.Show(f, new Rectangle(p, new Size(0, 0)));

        }

        private void Show(Control control, Rectangle area)
        {
            if (control == null)
                throw new ArgumentNullException("control");


            Point location = control.PointToScreen(new Point(area.Left, area.Top + area.Height));

            Rectangle screen = Screen.FromControl(control).WorkingArea;

            if (location.X + Size.Width > (screen.Left + screen.Width))
                location.X = (screen.Left + screen.Width) - Size.Width;

            if (location.Y + Size.Height > (screen.Top + screen.Height))
                location.Y -= Size.Height + area.Height;

            location = control.PointToClient(location);

            Show(control, location, ToolStripDropDownDirection.BelowRight);
        }

        private const int frames = 5;
        private const int totalduration = 100;
        private const int frameduration = totalduration / frames;

        protected override void SetVisibleCore(bool visible)
        {
            double opacity = Opacity;
            if (visible && m_fade) Opacity = 0;
            base.SetVisibleCore(visible);
            if (!visible || !m_fade) return;
            for (int i = 1; i <= frames; i++)
            {
                if (i > 1)
                {
                    System.Threading.Thread.Sleep(frameduration);
                }
                Opacity = opacity * (double)i / (double)frames;
            }
            Opacity = opacity;
        }

        protected override void OnOpening(CancelEventArgs e)
        {
            if (m_IAmOrionPoppedContainer.IsDisposed || m_IAmOrionPoppedContainer.Disposing)
            {
                e.Cancel = true;
                return;
            }
            base.OnOpening(e);
        }

        protected override void OnOpened(EventArgs e)
        {
            m_IAmOrionPoppedContainer.Focus();

            base.OnOpened(e);
        }

        /*
        public IAmOrionPopperContainer(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        */
    }
}
