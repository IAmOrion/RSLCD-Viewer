namespace AIDA64SensorPanelBrowser_v2
{
    partial class IAmOrionPopperContainer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                if (m_IAmOrionPoppedContainer != null)
                {
                    System.Windows.Forms.Control _content = m_IAmOrionPoppedContainer;
                    m_IAmOrionPoppedContainer = null;
                    _content.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }

        #endregion
    }
}
