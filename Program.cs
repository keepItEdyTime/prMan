using PrGer.Presenters;
using PrGer.Repositories;
using PrGer.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrGer
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            ProductPage productPage = new ProductPage();
            ProductRepository productRepository = new ProductRepository(sqlConnectionString);
            ApiRepository apiRepository = new ApiRepository();
            new ProductPresenter(productPage,productRepository, apiRepository);
            
            Application.Run(productPage);
        }
    }
}
