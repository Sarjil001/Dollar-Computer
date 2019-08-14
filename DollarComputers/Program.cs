using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    static class Program
    {
        /// <summary>
        /// All the Static Membera
        /// </summary>
        public static SplashScreen splashScreen;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productinfoForm;
        public static OrderForm orderForm;
        public static AboutForm aboutForm;

        public static Products products;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            startForm = new StartForm();
            selectForm = new SelectForm();
            productinfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            splashScreen = new SplashScreen();
            aboutForm = new AboutForm();

            products = new Products();

            Application.Run(splashScreen);
        }
    }
}
