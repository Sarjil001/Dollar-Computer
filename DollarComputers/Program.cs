using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Student Name: SARJIL RAVAL
/// Student Number: 301043757
/// Description: This Program is on Selling Computers and making a app for Company named Dollar Computers
///              It allows user to select the type of computer by showing it's Specification 
///              After that it pop ups the Product info Form and confirms the order.
///              Last page is the Final Page where it shows price with all the taxes added.
///              There are others functions like open file dialog and save file dialog.
/// </summary>


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
