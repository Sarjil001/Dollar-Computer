namespace DollarComputers
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TitleOfDollar = new System.Windows.Forms.Label();
            this.Sale = new System.Windows.Forms.Label();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.DollarComputersImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DollarComputersImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleOfDollar
            // 
            this.TitleOfDollar.AutoSize = true;
            this.TitleOfDollar.BackColor = System.Drawing.Color.Silver;
            this.TitleOfDollar.ForeColor = System.Drawing.Color.Black;
            this.TitleOfDollar.Location = new System.Drawing.Point(45, 29);
            this.TitleOfDollar.Name = "TitleOfDollar";
            this.TitleOfDollar.Size = new System.Drawing.Size(406, 31);
            this.TitleOfDollar.TabIndex = 1;
            this.TitleOfDollar.Text = "Welcome To Dollar Computers !!";
            this.TitleOfDollar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sale
            // 
            this.Sale.AutoSize = true;
            this.Sale.BackColor = System.Drawing.Color.Silver;
            this.Sale.Location = new System.Drawing.Point(110, 444);
            this.Sale.Name = "Sale";
            this.Sale.Size = new System.Drawing.Size(250, 31);
            this.Sale.TabIndex = 2;
            this.Sale.Text = "We Sell For Less  :)";
            this.Sale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 3000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // DollarComputersImage
            // 
            this.DollarComputersImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DollarComputersImage.Image = global::DollarComputers.Properties.Resources.computer;
            this.DollarComputersImage.Location = new System.Drawing.Point(88, 81);
            this.DollarComputersImage.Name = "DollarComputersImage";
            this.DollarComputersImage.Size = new System.Drawing.Size(297, 341);
            this.DollarComputersImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DollarComputersImage.TabIndex = 0;
            this.DollarComputersImage.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.Sale);
            this.Controls.Add(this.TitleOfDollar);
            this.Controls.Add(this.DollarComputersImage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "SplashScreen";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DollarComputersImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DollarComputersImage;
        private System.Windows.Forms.Label TitleOfDollar;
        private System.Windows.Forms.Label Sale;
        private System.Windows.Forms.Timer SplashTimer;
    }
}