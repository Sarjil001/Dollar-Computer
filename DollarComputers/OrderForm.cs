﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Student Name: SARJIL RAVAL
/// Student Number: 301043757
/// Description: This is the Order form, It shows the price of the Computer selected and also can save it 
///              for the Later. It is the Last Page of the Program.                           
/// </summary>

namespace DollarComputers
{
    public partial class OrderForm : Form
    {
        //Variables for the Tax
        public double Tax;
        public double Total;
        public double Cost;

        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the Event Handler for the BackButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.productinfoForm.Show();
            this.Hide();
        }

        /// <summary>
        /// This is the Event Handler for the CancelButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is the Event Handler for the FinishButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for Shopping from Dollar Computers" +
                "Your Order will be processed in 7-10 business days", "Order Confirmed",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// This is the Event Handler for the aboutToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //It will show about Dialog Box
            Program.aboutForm.ShowDialog();
        }

        /// <summary>
        /// This is the Event Handler for the OrderForm_load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Load(object sender, EventArgs e)
        {
            //open File To Stream to read
            using (StreamReader inputStream = new StreamReader(
                File.Open("Product.txt", FileMode.Open)))
            {
                //Read stuff to the file into the Student Object
                Program.products.productID = short.Parse(inputStream.ReadLine());
                Program.products.cost = decimal.Parse(inputStream.ReadLine());
                Program.products.manufacturer = inputStream.ReadLine();
                Program.products.model = inputStream.ReadLine();
                Program.products.RAM_size = inputStream.ReadLine();
                Program.products.screensize = inputStream.ReadLine();
                Program.products.CPU_brand = inputStream.ReadLine();
                Program.products.CPU_type = inputStream.ReadLine();
                Program.products.CPU_speed = inputStream.ReadLine();
                Program.products.CPU_number = inputStream.ReadLine();
                Program.products.condition = inputStream.ReadLine();
                Program.products.OS = inputStream.ReadLine();
                Program.products.platform = inputStream.ReadLine();
                Program.products.HDD_size = inputStream.ReadLine();
                Program.products.GPU_Type = inputStream.ReadLine();
                Program.products.webcam = inputStream.ReadLine();
                Program.products.width = inputStream.ReadLine();
                Program.products.height = inputStream.ReadLine();
                Program.products.moust_type = inputStream.ReadLine();
                Program.products.power = inputStream.ReadLine();
                    

                //cleanup
                inputStream.Close();
                inputStream.Dispose();

                //Calculation for the Sales Tax (13%)
                Tax = Math.Round((double)Program.products.cost, 2);
                Tax = Math.Round(Tax * 0.13, 2);
                Cost = Math.Round((double)Program.products.cost, 2);
                Total = Math.Round(Tax + Cost, 2);

                //Loading the values stored in the Product Form To the Label
                ProductIDTextBox.Text = Program.products.productID.ToString();
                ManufacturerTextbox.Text = Program.products.manufacturer;
                ModelTextbox.Text = Program.products.model;
                ScreenSizeTextBox.Text = Program.products.screensize;
                CPUBrandTextBox.Text = Program.products.CPU_brand;
                PlatformTextBox.Text = Program.products.platform;
                OSTextBox.Text = Program.products.OS;
                ConditionTextBox.Text = Program.products.condition;
                PowerTextBox.Text = Program.products.power;
                WidthTextBox.Text = Program.products.width;
                MouseTypeTextBox.Text = Program.products.moust_type;
                HeightTextBox.Text = Program.products.height;
                PriceTextbox.Text = String.Format("{0:C}", Program.products.cost);
                SalesTaxTextbox.Text = $"{Tax}";
                TotalTextbox.Text = $"{Total}";

            }
        }
    }
}
