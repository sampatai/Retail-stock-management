using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Retail.Stock.Application.Common;
using Retail.Stock.Infrastructure.Repositories;
using Retail.Stock.Shared.SeedWork;
using Retail.Stock.UI;
using System.Security.Principal;

namespace LiquorInStock.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<LoginForm>();
             
                // Authenticate the user

                // Show the login form
                Application.Run(form1);


            }
            //Application.Run(new Form1());
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<ILiteDatabaseProvider>(new FileBasedLiteDatabaseProvider("Stock.db"));


            services.AddLogging(configure => configure.AddConsole())
                .AddScoped<LoginForm>()
                .AddScoped<ICategoryRepository, CategoryRepository>();


            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<IProductPriceRepository, ProductPriceRepository>();
            services.AddScoped<IProductSalesRepository, ProductSalesRepository>();
        }
    }
}