namespace Client
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Busy form
    /// </summary>
    public partial class BusyForm : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public BusyForm()
        {
            InitializeComponent();           
        }

        /// <summary>
        /// Disable parent When loaded
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Arguments</param>
        private void BusyForm_Load(object sender, EventArgs e)
        {
            ((BusyForm)sender).Owner.Enabled = false;
        }

        /// <summary>
        /// Enable parent when closed
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Arguments</param>
        private void BusyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((BusyForm)sender).Owner.Enabled = true;
        }
    }
}
