namespace Client
{
    using System.Threading.Tasks;
    using System;
    using System.Windows.Forms;
    using LemonWayService;
    using NLog;
     
    /// <summary>
    ///  UI
    /// </summary>
    public partial class ClientUI : Form
    {
        /// <summary>
        /// busy form
        /// </summary>
        BusyForm waitingForm;

        /// <summary>
        /// logger
        /// </summary>
        protected static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Constructor
        /// </summary>
        public ClientUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fibonacci btn click handler
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Arguments</param>
        private async void btnFibonacci_Click(object sender, EventArgs e)
        {
            int value = 0;
            
            if ( int.TryParse(txtFibonacci.Text, out value))
            {
                ShowBusyForm();             
                long result = await Task.Run( () => callFibonacciService(value));             
                CloseBusyForm();
                MessageBox.Show(string.Concat("Fibonacci(", value.ToString(), ") = ", result.ToString()), "Result");
            }
            else
            {
                MessageBox.Show("Please, enter a numeric value !");
                txtFibonacci.Text = "10";
            }    
        }
           
        /// <summary>
        /// XmlToJson Btn click handler
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Arguments</param>
        private async void btnXmlToJson_Click(object sender, EventArgs e)
        {
            ShowBusyForm();
            string result =  await Task.Run(() => CallXmlToJsonService(txtXml.Text));          
            CloseBusyForm();
            MessageBox.Show(string.Concat("Json value : " , result), "Result");
        }
        
        /// <summary>
        /// Call the fibonacci method
        /// </summary>
        /// <param name="value">Value</param>
        /// <returns>Result</returns>
        private long callFibonacciService(int value)
        {
            try
            {
               LemonWayServiceSoapClient client = new LemonWayServiceSoapClient();
               return client.Fibonacci(value);
            }
            catch(Exception ex)
            {
               logger.Error(ex);
               return -1;
            }
       }

        /// <summary>
        /// Call the xmlToJson method
        /// </summary>
        /// <param name="value">Xml value</param>
        /// <returns>Result</returns>
        private string CallXmlToJsonService(string value)
        {   
            try
            {
                LemonWayServiceSoapClient client = new LemonWayServiceSoapClient();
                return client.XmlToJson(value);
            }
            catch(Exception ex)
            {
                logger.Error(ex);
                return string.Empty;
            }
        }        
        
        /// <summary>
        /// Show busyForm
        /// </summary>
        private void ShowBusyForm()
        {
            waitingForm = new BusyForm();    
            waitingForm.Show(this);
        }  
        
        /// <summary>
        /// Close busyForm
        /// </summary>
        private void CloseBusyForm()
        {
            if (waitingForm != null)
            {
                waitingForm.Close();
            }
        } 
    }
}
