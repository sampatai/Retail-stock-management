using Microsoft.Extensions.Logging;

namespace LiquorInStock.UI
{
    public partial class Form1 : Form
    {
        //public Form1()
        //{
            

        //}
        private readonly ILogger _logger;
        public Form1(ILogger<Form1> logger)
        {
            InitializeComponent();
            _logger = logger;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _logger.LogInformation("Form1 {BusinessLayerEvent} at {dateTime}", "Started", DateTime.UtcNow);
                // Perform Business Logic here 

                MessageBox.Show("Hello .NET Core 3.1.This is First Forms app in .NET Core");
                _logger.LogInformation("Form1 {BusinessLayerEvent} at {dateTime}", "Ended", DateTime.UtcNow);
            }
            catch (Exception ex)
            {
                //Log technical exception 
                _logger.LogError(ex.Message);
            }
        }
    }
}