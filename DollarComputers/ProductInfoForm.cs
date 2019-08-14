using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
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

                //cleanup
                inputStream.Close();
                inputStream.Dispose();

                ProductIDTextbox.Text = Program.products.productID.ToString();
                CostTextbox.Text = String.Format("{0:C}",Program.products.cost);
                ManufacturerTextbox.Text = Program.products.manufacturer;
                ModelTextbox.Text = Program.products.model;
                MemoryTextbox.Text = Program.products.RAM_size;
                LCDSizeTextbox.Text = Program.products.screensize;
                CPUBrandTextbox.Text = Program.products.CPU_brand;
                CPUTypeTextbox.Text = Program.products.CPU_type;
                CPUSpeedTextbox.Text = Program.products.CPU_speed;
                CPUNumberTextbox.Text = Program.products.CPU_number;
                ConditionTextbox.Text = Program.products.condition;
                OSTextBox.Text = Program.products.OS;
                PlatformTextbox.Text = Program.products.platform;
                HDDTextbox.Text = Program.products.HDD_size;
                GPUTypeTextbox.Text = Program.products.GPU_Type;
                WebCamTextbox.Text = Program.products.webcam;

            }
          

        }

    }

 }
