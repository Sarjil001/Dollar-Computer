using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Student Name: SARJIL RAVAL
/// Student Number: 301043757
/// Description: This is the StartForm, It will show options for the New Computer or Load the Saved one
/// </summary>

namespace DollarComputers
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the Event Handler for the NewOrderButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        /// <summary>
        /// This is the Event Handler for the SavedOrderButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavedOrderButton_Click(object sender, EventArgs e)
        {
            //confgure the file dialog
            OpenFileDialogBox.FileName = "Product.txt";
            OpenFileDialogBox.InitialDirectory = Directory.GetCurrentDirectory();
            OpenFileDialogBox.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";
            //open the file dialog
            var result = OpenFileDialogBox.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    //open file stream to read
                    using (StreamReader inputStream = new StreamReader(File.Open(OpenFileDialogBox.FileName, FileMode.Open)))
                    {
                        // read stuff from the file
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
                    }
                }
                catch (IOException exception)
                {
                    //Will show error
                    Debug.WriteLine("ERROR " + exception.Message);
                    MessageBox.Show("ERROR " + exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Program.productinfoForm.Show();
            this.Hide();
        }

        /// <summary>
        /// This is the Event Handler for ExitButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
