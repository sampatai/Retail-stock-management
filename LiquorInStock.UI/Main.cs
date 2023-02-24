using Microsoft.Extensions.Logging;

namespace LiquorInStock.UI
{
    public partial class Main : Form
    {
        //public Form1()
        //{
            

        //}
        private readonly ILogger _logger;
        public Main(ILogger<Main> logger)
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

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dailySalesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}