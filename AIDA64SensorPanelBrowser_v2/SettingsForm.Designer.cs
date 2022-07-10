namespace AIDA64SensorPanelBrowser_v2
{
    partial class settingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.nightForm1 = new ReaLTaiizor.Forms.NightForm();
            this.linkPanel = new ReaLTaiizor.Controls.LostBorderPanel();
            this.linklblGithub = new ReaLTaiizor.Controls.NightLinkLabel();
            this.linklblRSLCDHome = new ReaLTaiizor.Controls.NightLinkLabel();
            this.linklblFacebook = new ReaLTaiizor.Controls.NightLinkLabel();
            this.linklblAida64 = new ReaLTaiizor.Controls.NightLinkLabel();
            this.actionsSettings = new ReaLTaiizor.Controls.ThunderGroupBox();
            this.btnCancel = new Sunny.UI.UISymbolButton();
            this.btnSave = new Sunny.UI.UISymbolButton();
            this.iAmOrionNightControlBox1 = new AIDA64SensorPanelBrowser_v2.IAmOrion_Custom_Controls.IAmOrionNightControlBox();
            this.thunderLabel1 = new ReaLTaiizor.Controls.ThunderLabel();
            this.applicationSettings = new ReaLTaiizor.Controls.ThunderGroupBox();
            this.lblPrimaryMonitor = new ReaLTaiizor.Controls.ThunderLabel();
            this.settingsShowOnPrimaryMonitor = new AIDA64SensorPanelBrowser_v2.IAmOrion_Custom_Controls.IAmOrionToggleSwitch();
            this.lblAlwaysOnTop = new ReaLTaiizor.Controls.ThunderLabel();
            this.settingsAlwaysOnTop = new AIDA64SensorPanelBrowser_v2.IAmOrion_Custom_Controls.IAmOrionToggleSwitch();
            this.lblRunAtStartup = new ReaLTaiizor.Controls.ThunderLabel();
            this.lblSnapping = new ReaLTaiizor.Controls.ThunderLabel();
            this.settingsSnapping = new AIDA64SensorPanelBrowser_v2.IAmOrion_Custom_Controls.IAmOrionToggleSwitch();
            this.settingsRunAtStartup = new AIDA64SensorPanelBrowser_v2.IAmOrion_Custom_Controls.IAmOrionToggleSwitch();
            this.panelSettings = new ReaLTaiizor.Controls.ThunderGroupBox();
            this.settingsURL = new ReaLTaiizor.Controls.CrownTextBox();
            this.settingsHeight = new ReaLTaiizor.Controls.CrownNumeric();
            this.settingsPort = new ReaLTaiizor.Controls.CrownNumeric();
            this.settingsWidth = new ReaLTaiizor.Controls.CrownNumeric();
            this.thunderLabel2 = new ReaLTaiizor.Controls.ThunderLabel();
            this.btnResetWindow = new Sunny.UI.UISymbolButton();
            this.lblURL = new ReaLTaiizor.Controls.ThunderLabel();
            this.lblHeight = new ReaLTaiizor.Controls.ThunderLabel();
            this.btnResetPanelSize = new Sunny.UI.UISymbolButton();
            this.lblWidth = new ReaLTaiizor.Controls.ThunderLabel();
            this.thunderLabel3 = new ReaLTaiizor.Controls.ThunderLabel();
            this.settingsSnappingDistance = new ReaLTaiizor.Controls.CrownNumeric();
            this.nightForm1.SuspendLayout();
            this.linkPanel.SuspendLayout();
            this.actionsSettings.SuspendLayout();
            this.applicationSettings.SuspendLayout();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsSnappingDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // nightForm1
            // 
            this.nightForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.nightForm1.Controls.Add(this.linkPanel);
            this.nightForm1.Controls.Add(this.actionsSettings);
            this.nightForm1.Controls.Add(this.iAmOrionNightControlBox1);
            this.nightForm1.Controls.Add(this.thunderLabel1);
            this.nightForm1.Controls.Add(this.applicationSettings);
            this.nightForm1.Controls.Add(this.panelSettings);
            this.nightForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nightForm1.DrawIcon = true;
            this.nightForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightForm1.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.nightForm1.Location = new System.Drawing.Point(0, 0);
            this.nightForm1.MinimumSize = new System.Drawing.Size(100, 42);
            this.nightForm1.Name = "nightForm1";
            this.nightForm1.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.nightForm1.Size = new System.Drawing.Size(476, 413);
            this.nightForm1.TabIndex = 0;
            this.nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            this.nightForm1.TitleBarTextColor = System.Drawing.Color.Gainsboro;
            // 
            // linkPanel
            // 
            this.linkPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.linkPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.linkPanel.Controls.Add(this.linklblGithub);
            this.linkPanel.Controls.Add(this.linklblRSLCDHome);
            this.linkPanel.Controls.Add(this.linklblFacebook);
            this.linkPanel.Controls.Add(this.linklblAida64);
            this.linkPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkPanel.ForeColor = System.Drawing.Color.White;
            this.linkPanel.Location = new System.Drawing.Point(5, 381);
            this.linkPanel.Name = "linkPanel";
            this.linkPanel.Padding = new System.Windows.Forms.Padding(5);
            this.linkPanel.ShowText = true;
            this.linkPanel.Size = new System.Drawing.Size(467, 28);
            this.linkPanel.TabIndex = 27;
            // 
            // linklblGithub
            // 
            this.linklblGithub.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.linklblGithub.AutoSize = true;
            this.linklblGithub.BackColor = System.Drawing.Color.Transparent;
            this.linklblGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklblGithub.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblGithub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linklblGithub.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.linklblGithub.Location = new System.Drawing.Point(411, 6);
            this.linklblGithub.Name = "linklblGithub";
            this.linklblGithub.Size = new System.Drawing.Size(48, 17);
            this.linklblGithub.TabIndex = 50;
            this.linklblGithub.TabStop = true;
            this.linklblGithub.Text = "GitHub";
            this.linklblGithub.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.linklblGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblGithub_LinkClicked);
            // 
            // linklblRSLCDHome
            // 
            this.linklblRSLCDHome.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.linklblRSLCDHome.AutoSize = true;
            this.linklblRSLCDHome.BackColor = System.Drawing.Color.Transparent;
            this.linklblRSLCDHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklblRSLCDHome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblRSLCDHome.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linklblRSLCDHome.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.linklblRSLCDHome.Location = new System.Drawing.Point(7, 6);
            this.linklblRSLCDHome.Name = "linklblRSLCDHome";
            this.linklblRSLCDHome.Size = new System.Drawing.Size(128, 17);
            this.linklblRSLCDHome.TabIndex = 52;
            this.linklblRSLCDHome.TabStop = true;
            this.linklblRSLCDHome.Text = "RSLCD Viewer Home";
            this.linklblRSLCDHome.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.linklblRSLCDHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblRSLCDHome_LinkClicked);
            // 
            // linklblFacebook
            // 
            this.linklblFacebook.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.linklblFacebook.AutoSize = true;
            this.linklblFacebook.BackColor = System.Drawing.Color.Transparent;
            this.linklblFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklblFacebook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblFacebook.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linklblFacebook.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.linklblFacebook.Location = new System.Drawing.Point(300, 6);
            this.linklblFacebook.Name = "linklblFacebook";
            this.linklblFacebook.Size = new System.Drawing.Size(64, 17);
            this.linklblFacebook.TabIndex = 53;
            this.linklblFacebook.TabStop = true;
            this.linklblFacebook.Text = "Facebook";
            this.linklblFacebook.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.linklblFacebook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblFacebook_LinkClicked);
            // 
            // linklblAida64
            // 
            this.linklblAida64.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.linklblAida64.AutoSize = true;
            this.linklblAida64.BackColor = System.Drawing.Color.Transparent;
            this.linklblAida64.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklblAida64.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblAida64.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linklblAida64.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.linklblAida64.Location = new System.Drawing.Point(168, 6);
            this.linklblAida64.Name = "linklblAida64";
            this.linklblAida64.Size = new System.Drawing.Size(91, 17);
            this.linklblAida64.TabIndex = 51;
            this.linklblAida64.TabStop = true;
            this.linklblAida64.Text = "AIDA64 Forum";
            this.linklblAida64.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.linklblAida64.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblAida64_LinkClicked);
            // 
            // actionsSettings
            // 
            this.actionsSettings.BackColor = System.Drawing.Color.Transparent;
            this.actionsSettings.BodyColorA = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.actionsSettings.BodyColorB = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.actionsSettings.BodyColorC = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.actionsSettings.BodyColorD = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
            this.actionsSettings.Controls.Add(this.btnCancel);
            this.actionsSettings.Controls.Add(this.btnSave);
            this.actionsSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.actionsSettings.Location = new System.Drawing.Point(3, 267);
            this.actionsSettings.Name = "actionsSettings";
            this.actionsSettings.Size = new System.Drawing.Size(470, 110);
            this.actionsSettings.TabIndex = 49;
            this.actionsSettings.TabStop = false;
            this.actionsSettings.Text = "Apply Settings:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnCancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnCancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(78)))));
            this.btnCancel.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.btnCancel.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnCancel.Location = new System.Drawing.Point(242, 41);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnCancel.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(78)))));
            this.btnCancel.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.btnCancel.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.btnCancel.Size = new System.Drawing.Size(210, 52);
            this.btnCancel.Style = Sunny.UI.UIStyle.LayuiRed;
            this.btnCancel.Symbol = 61527;
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSave.Location = new System.Drawing.Point(17, 41);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(210, 52);
            this.btnSave.Style = Sunny.UI.UIStyle.DarkBlue;
            this.btnSave.Symbol = 61639;
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save Changes";
            this.btnSave.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // iAmOrionNightControlBox1
            // 
            this.iAmOrionNightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iAmOrionNightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.iAmOrionNightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iAmOrionNightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.iAmOrionNightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iAmOrionNightControlBox1.DefaultLocation = true;
            this.iAmOrionNightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.iAmOrionNightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.iAmOrionNightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.iAmOrionNightControlBox1.EnableMaximizeButton = false;
            this.iAmOrionNightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.iAmOrionNightControlBox1.EnableMinimizeButton = false;
            this.iAmOrionNightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.iAmOrionNightControlBox1.Location = new System.Drawing.Point(337, 0);
            this.iAmOrionNightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iAmOrionNightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.iAmOrionNightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iAmOrionNightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.iAmOrionNightControlBox1.Name = "iAmOrionNightControlBox1";
            this.iAmOrionNightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.iAmOrionNightControlBox1.TabIndex = 47;
            this.iAmOrionNightControlBox1.TabStop = false;
            // 
            // thunderLabel1
            // 
            this.thunderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.thunderLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.thunderLabel1.Location = new System.Drawing.Point(32, 5);
            this.thunderLabel1.Name = "thunderLabel1";
            this.thunderLabel1.Size = new System.Drawing.Size(200, 25);
            this.thunderLabel1.TabIndex = 23;
            this.thunderLabel1.TabStop = false;
            this.thunderLabel1.Text = "Settings | RSLCD Viewer";
            // 
            // applicationSettings
            // 
            this.applicationSettings.BackColor = System.Drawing.Color.Transparent;
            this.applicationSettings.BodyColorA = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.applicationSettings.BodyColorB = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.applicationSettings.BodyColorC = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.applicationSettings.BodyColorD = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
            this.applicationSettings.Controls.Add(this.settingsSnappingDistance);
            this.applicationSettings.Controls.Add(this.thunderLabel3);
            this.applicationSettings.Controls.Add(this.lblPrimaryMonitor);
            this.applicationSettings.Controls.Add(this.settingsShowOnPrimaryMonitor);
            this.applicationSettings.Controls.Add(this.lblAlwaysOnTop);
            this.applicationSettings.Controls.Add(this.settingsAlwaysOnTop);
            this.applicationSettings.Controls.Add(this.lblRunAtStartup);
            this.applicationSettings.Controls.Add(this.lblSnapping);
            this.applicationSettings.Controls.Add(this.settingsSnapping);
            this.applicationSettings.Controls.Add(this.settingsRunAtStartup);
            this.applicationSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.applicationSettings.Location = new System.Drawing.Point(241, 36);
            this.applicationSettings.Name = "applicationSettings";
            this.applicationSettings.Size = new System.Drawing.Size(232, 227);
            this.applicationSettings.TabIndex = 44;
            this.applicationSettings.TabStop = false;
            this.applicationSettings.Text = "App Settings:";
            // 
            // lblPrimaryMonitor
            // 
            this.lblPrimaryMonitor.BackColor = System.Drawing.Color.Transparent;
            this.lblPrimaryMonitor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrimaryMonitor.Location = new System.Drawing.Point(12, 176);
            this.lblPrimaryMonitor.Name = "lblPrimaryMonitor";
            this.lblPrimaryMonitor.Size = new System.Drawing.Size(142, 35);
            this.lblPrimaryMonitor.TabIndex = 26;
            this.lblPrimaryMonitor.TabStop = false;
            this.lblPrimaryMonitor.Text = "Settings always on Primary Monitor:";
            // 
            // settingsShowOnPrimaryMonitor
            // 
            this.settingsShowOnPrimaryMonitor.AutoSize = true;
            this.settingsShowOnPrimaryMonitor.BackgroundColour = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.settingsShowOnPrimaryMonitor.Location = new System.Drawing.Point(163, 177);
            this.settingsShowOnPrimaryMonitor.MinimumSize = new System.Drawing.Size(45, 22);
            this.settingsShowOnPrimaryMonitor.Name = "settingsShowOnPrimaryMonitor";
            this.settingsShowOnPrimaryMonitor.OffBackColor = System.Drawing.Color.White;
            this.settingsShowOnPrimaryMonitor.OffToggleColor = System.Drawing.Color.Black;
            this.settingsShowOnPrimaryMonitor.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.settingsShowOnPrimaryMonitor.OnToggleColor = System.Drawing.Color.White;
            this.settingsShowOnPrimaryMonitor.Size = new System.Drawing.Size(45, 22);
            this.settingsShowOnPrimaryMonitor.TabIndex = 10;
            this.settingsShowOnPrimaryMonitor.UseVisualStyleBackColor = true;
            // 
            // lblAlwaysOnTop
            // 
            this.lblAlwaysOnTop.BackColor = System.Drawing.Color.Transparent;
            this.lblAlwaysOnTop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAlwaysOnTop.Location = new System.Drawing.Point(12, 142);
            this.lblAlwaysOnTop.Name = "lblAlwaysOnTop";
            this.lblAlwaysOnTop.Size = new System.Drawing.Size(103, 25);
            this.lblAlwaysOnTop.TabIndex = 24;
            this.lblAlwaysOnTop.TabStop = false;
            this.lblAlwaysOnTop.Text = "Always On Top:";
            // 
            // settingsAlwaysOnTop
            // 
            this.settingsAlwaysOnTop.AutoSize = true;
            this.settingsAlwaysOnTop.BackgroundColour = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.settingsAlwaysOnTop.Location = new System.Drawing.Point(163, 142);
            this.settingsAlwaysOnTop.MinimumSize = new System.Drawing.Size(45, 22);
            this.settingsAlwaysOnTop.Name = "settingsAlwaysOnTop";
            this.settingsAlwaysOnTop.OffBackColor = System.Drawing.Color.White;
            this.settingsAlwaysOnTop.OffToggleColor = System.Drawing.Color.Black;
            this.settingsAlwaysOnTop.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.settingsAlwaysOnTop.OnToggleColor = System.Drawing.Color.White;
            this.settingsAlwaysOnTop.Size = new System.Drawing.Size(45, 22);
            this.settingsAlwaysOnTop.TabIndex = 9;
            this.settingsAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // lblRunAtStartup
            // 
            this.lblRunAtStartup.BackColor = System.Drawing.Color.Transparent;
            this.lblRunAtStartup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRunAtStartup.Location = new System.Drawing.Point(12, 108);
            this.lblRunAtStartup.Name = "lblRunAtStartup";
            this.lblRunAtStartup.Size = new System.Drawing.Size(103, 25);
            this.lblRunAtStartup.TabIndex = 22;
            this.lblRunAtStartup.TabStop = false;
            this.lblRunAtStartup.Text = "Run at Startup:";
            // 
            // lblSnapping
            // 
            this.lblSnapping.BackColor = System.Drawing.Color.Transparent;
            this.lblSnapping.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSnapping.Location = new System.Drawing.Point(14, 41);
            this.lblSnapping.Name = "lblSnapping";
            this.lblSnapping.Size = new System.Drawing.Size(140, 25);
            this.lblSnapping.TabIndex = 21;
            this.lblSnapping.TabStop = false;
            this.lblSnapping.Text = "Window Snapping:";
            // 
            // settingsSnapping
            // 
            this.settingsSnapping.AutoSize = true;
            this.settingsSnapping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.settingsSnapping.BackgroundColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.settingsSnapping.Location = new System.Drawing.Point(163, 41);
            this.settingsSnapping.MinimumSize = new System.Drawing.Size(45, 22);
            this.settingsSnapping.Name = "settingsSnapping";
            this.settingsSnapping.OffBackColor = System.Drawing.Color.White;
            this.settingsSnapping.OffToggleColor = System.Drawing.Color.Black;
            this.settingsSnapping.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.settingsSnapping.OnToggleColor = System.Drawing.Color.White;
            this.settingsSnapping.Size = new System.Drawing.Size(45, 22);
            this.settingsSnapping.TabIndex = 7;
            this.settingsSnapping.UseVisualStyleBackColor = false;
            // 
            // settingsRunAtStartup
            // 
            this.settingsRunAtStartup.AutoSize = true;
            this.settingsRunAtStartup.BackgroundColour = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.settingsRunAtStartup.Location = new System.Drawing.Point(163, 108);
            this.settingsRunAtStartup.MinimumSize = new System.Drawing.Size(45, 22);
            this.settingsRunAtStartup.Name = "settingsRunAtStartup";
            this.settingsRunAtStartup.OffBackColor = System.Drawing.Color.White;
            this.settingsRunAtStartup.OffToggleColor = System.Drawing.Color.Black;
            this.settingsRunAtStartup.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.settingsRunAtStartup.OnToggleColor = System.Drawing.Color.White;
            this.settingsRunAtStartup.Size = new System.Drawing.Size(45, 22);
            this.settingsRunAtStartup.TabIndex = 8;
            this.settingsRunAtStartup.UseVisualStyleBackColor = true;
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.Transparent;
            this.panelSettings.BodyColorA = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panelSettings.BodyColorB = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelSettings.BodyColorC = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelSettings.BodyColorD = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
            this.panelSettings.Controls.Add(this.settingsURL);
            this.panelSettings.Controls.Add(this.settingsHeight);
            this.panelSettings.Controls.Add(this.settingsPort);
            this.panelSettings.Controls.Add(this.settingsWidth);
            this.panelSettings.Controls.Add(this.thunderLabel2);
            this.panelSettings.Controls.Add(this.btnResetWindow);
            this.panelSettings.Controls.Add(this.lblURL);
            this.panelSettings.Controls.Add(this.lblHeight);
            this.panelSettings.Controls.Add(this.btnResetPanelSize);
            this.panelSettings.Controls.Add(this.lblWidth);
            this.panelSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelSettings.Location = new System.Drawing.Point(3, 36);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(232, 227);
            this.panelSettings.TabIndex = 43;
            this.panelSettings.TabStop = false;
            this.panelSettings.Text = "Panel Settings:";
            // 
            // settingsURL
            // 
            this.settingsURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.settingsURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.settingsURL.Location = new System.Drawing.Point(103, 91);
            this.settingsURL.Name = "settingsURL";
            this.settingsURL.Size = new System.Drawing.Size(120, 20);
            this.settingsURL.TabIndex = 3;
            this.settingsURL.Text = "URL";
            this.settingsURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // settingsHeight
            // 
            this.settingsHeight.Location = new System.Drawing.Point(103, 60);
            this.settingsHeight.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.settingsHeight.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.settingsHeight.Name = "settingsHeight";
            this.settingsHeight.Size = new System.Drawing.Size(120, 20);
            this.settingsHeight.TabIndex = 2;
            this.settingsHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.settingsHeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // settingsPort
            // 
            this.settingsPort.Location = new System.Drawing.Point(103, 122);
            this.settingsPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.settingsPort.Name = "settingsPort";
            this.settingsPort.Size = new System.Drawing.Size(120, 20);
            this.settingsPort.TabIndex = 4;
            this.settingsPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // settingsWidth
            // 
            this.settingsWidth.Location = new System.Drawing.Point(103, 29);
            this.settingsWidth.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.settingsWidth.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.settingsWidth.Name = "settingsWidth";
            this.settingsWidth.Size = new System.Drawing.Size(120, 20);
            this.settingsWidth.TabIndex = 1;
            this.settingsWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.settingsWidth.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // thunderLabel2
            // 
            this.thunderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.thunderLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.thunderLabel2.Location = new System.Drawing.Point(9, 122);
            this.thunderLabel2.Name = "thunderLabel2";
            this.thunderLabel2.Size = new System.Drawing.Size(96, 25);
            this.thunderLabel2.TabIndex = 49;
            this.thunderLabel2.TabStop = false;
            this.thunderLabel2.Text = "TCP/IP Port:";
            // 
            // btnResetWindow
            // 
            this.btnResetWindow.BackColor = System.Drawing.Color.Transparent;
            this.btnResetWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetWindow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnResetWindow.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnResetWindow.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(78)))));
            this.btnResetWindow.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.btnResetWindow.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.btnResetWindow.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnResetWindow.Location = new System.Drawing.Point(9, 188);
            this.btnResetWindow.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnResetWindow.Name = "btnResetWindow";
            this.btnResetWindow.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnResetWindow.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(78)))));
            this.btnResetWindow.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.btnResetWindow.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.btnResetWindow.Size = new System.Drawing.Size(214, 29);
            this.btnResetWindow.Style = Sunny.UI.UIStyle.LayuiRed;
            this.btnResetWindow.Symbol = 262160;
            this.btnResetWindow.TabIndex = 6;
            this.btnResetWindow.Text = "Reset Position";
            this.btnResetWindow.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnResetWindow.Click += new System.EventHandler(this.btnResetWindow_Click);
            // 
            // lblURL
            // 
            this.lblURL.BackColor = System.Drawing.Color.Transparent;
            this.lblURL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblURL.Location = new System.Drawing.Point(9, 91);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(42, 25);
            this.lblURL.TabIndex = 23;
            this.lblURL.TabStop = false;
            this.lblURL.Text = "URL:";
            // 
            // lblHeight
            // 
            this.lblHeight.BackColor = System.Drawing.Color.Transparent;
            this.lblHeight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeight.Location = new System.Drawing.Point(9, 60);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(89, 25);
            this.lblHeight.TabIndex = 20;
            this.lblHeight.TabStop = false;
            this.lblHeight.Text = "Height:";
            // 
            // btnResetPanelSize
            // 
            this.btnResetPanelSize.BackColor = System.Drawing.Color.Transparent;
            this.btnResetPanelSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetPanelSize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnResetPanelSize.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnResetPanelSize.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(78)))));
            this.btnResetPanelSize.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.btnResetPanelSize.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.btnResetPanelSize.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnResetPanelSize.Location = new System.Drawing.Point(9, 153);
            this.btnResetPanelSize.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnResetPanelSize.Name = "btnResetPanelSize";
            this.btnResetPanelSize.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnResetPanelSize.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(78)))));
            this.btnResetPanelSize.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.btnResetPanelSize.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.btnResetPanelSize.Size = new System.Drawing.Size(214, 29);
            this.btnResetPanelSize.Style = Sunny.UI.UIStyle.LayuiRed;
            this.btnResetPanelSize.Symbol = 61666;
            this.btnResetPanelSize.TabIndex = 5;
            this.btnResetPanelSize.Text = "Reset Size";
            this.btnResetPanelSize.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnResetPanelSize.Click += new System.EventHandler(this.btnResetPanelSize_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.BackColor = System.Drawing.Color.Transparent;
            this.lblWidth.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblWidth.Location = new System.Drawing.Point(9, 29);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(89, 25);
            this.lblWidth.TabIndex = 19;
            this.lblWidth.TabStop = false;
            this.lblWidth.Text = "Width:";
            // 
            // thunderLabel3
            // 
            this.thunderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.thunderLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.thunderLabel3.Location = new System.Drawing.Point(12, 75);
            this.thunderLabel3.Name = "thunderLabel3";
            this.thunderLabel3.Size = new System.Drawing.Size(140, 25);
            this.thunderLabel3.TabIndex = 27;
            this.thunderLabel3.TabStop = false;
            this.thunderLabel3.Text = "Snapping Distance:";
            // 
            // settingsSnappingDistance
            // 
            this.settingsSnappingDistance.Location = new System.Drawing.Point(147, 75);
            this.settingsSnappingDistance.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.settingsSnappingDistance.Name = "settingsSnappingDistance";
            this.settingsSnappingDistance.Size = new System.Drawing.Size(67, 20);
            this.settingsSnappingDistance.TabIndex = 50;
            this.settingsSnappingDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.settingsSnappingDistance.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(476, 413);
            this.Controls.Add(this.nightForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1680, 1002);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "settingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dungeonForm1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.nightForm1.ResumeLayout(false);
            this.linkPanel.ResumeLayout(false);
            this.linkPanel.PerformLayout();
            this.actionsSettings.ResumeLayout(false);
            this.applicationSettings.ResumeLayout(false);
            this.applicationSettings.PerformLayout();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsSnappingDistance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private ReaLTaiizor.Controls.ThunderGroupBox applicationSettings;
        private ReaLTaiizor.Controls.ThunderLabel lblRunAtStartup;
        private ReaLTaiizor.Controls.ThunderLabel lblSnapping;
        private IAmOrion_Custom_Controls.IAmOrionToggleSwitch settingsSnapping;
        private ReaLTaiizor.Controls.ThunderGroupBox panelSettings;
        private Sunny.UI.UISymbolButton btnResetPanelSize;
        private ReaLTaiizor.Controls.ThunderLabel lblHeight;
        private ReaLTaiizor.Controls.ThunderLabel lblWidth;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel1;
        private IAmOrion_Custom_Controls.IAmOrionNightControlBox iAmOrionNightControlBox1;
        private IAmOrion_Custom_Controls.IAmOrionToggleSwitch settingsRunAtStartup;
        private ReaLTaiizor.Controls.ThunderLabel lblURL;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel2;
        private ReaLTaiizor.Controls.ThunderGroupBox actionsSettings;
        private Sunny.UI.UISymbolButton btnSave;
        private Sunny.UI.UISymbolButton btnCancel;
        private Sunny.UI.UISymbolButton btnResetWindow;
        private ReaLTaiizor.Controls.NightLinkLabel linklblGithub;
        private ReaLTaiizor.Controls.NightLinkLabel linklblRSLCDHome;
        private ReaLTaiizor.Controls.NightLinkLabel linklblAida64;
        private ReaLTaiizor.Controls.NightLinkLabel linklblFacebook;
        private ReaLTaiizor.Controls.ThunderLabel lblAlwaysOnTop;
        private IAmOrion_Custom_Controls.IAmOrionToggleSwitch settingsAlwaysOnTop;
        private ReaLTaiizor.Controls.ThunderLabel lblPrimaryMonitor;
        private IAmOrion_Custom_Controls.IAmOrionToggleSwitch settingsShowOnPrimaryMonitor;
        private ReaLTaiizor.Controls.CrownNumeric settingsPort;
        private ReaLTaiizor.Controls.CrownNumeric settingsHeight;
        private ReaLTaiizor.Controls.CrownNumeric settingsWidth;
        private ReaLTaiizor.Controls.CrownTextBox settingsURL;
        private ReaLTaiizor.Controls.LostBorderPanel linkPanel;
        private ReaLTaiizor.Controls.CrownNumeric settingsSnappingDistance;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel3;
    }
}