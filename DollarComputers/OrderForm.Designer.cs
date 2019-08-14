namespace DollarComputers
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemComponentsLabel = new System.Windows.Forms.GroupBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ManufacturerTextbox = new System.Windows.Forms.TextBox();
            this.ModelTextbox = new System.Windows.Forms.TextBox();
            this.ConditionTextbox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ConditionOrderTextbox = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ConditionOrderLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.YourPriceGroupbox = new System.Windows.Forms.GroupBox();
            this.SeparaterLabel = new System.Windows.Forms.Label();
            this.SalesTaxTextbox = new System.Windows.Forms.TextBox();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.TotalTextbox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PriceTextbox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OrderFormMenuStrip.SuspendLayout();
            this.SystemComponentsLabel.SuspendLayout();
            this.YourPriceGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(784, 29);
            this.OrderFormMenuStrip.TabIndex = 0;
            this.OrderFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(137, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.backToolStripMenuItem.Text = "Back ";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SystemComponentsLabel
            // 
            this.SystemComponentsLabel.Controls.Add(this.ManufacturerLabel);
            this.SystemComponentsLabel.Controls.Add(this.ManufacturerTextbox);
            this.SystemComponentsLabel.Controls.Add(this.ModelTextbox);
            this.SystemComponentsLabel.Controls.Add(this.ConditionTextbox);
            this.SystemComponentsLabel.Controls.Add(this.ModelLabel);
            this.SystemComponentsLabel.Controls.Add(this.ConditionOrderTextbox);
            this.SystemComponentsLabel.Controls.Add(this.PlatformLabel);
            this.SystemComponentsLabel.Controls.Add(this.ConditionOrderLabel);
            this.SystemComponentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemComponentsLabel.Location = new System.Drawing.Point(13, 33);
            this.SystemComponentsLabel.Name = "SystemComponentsLabel";
            this.SystemComponentsLabel.Size = new System.Drawing.Size(409, 112);
            this.SystemComponentsLabel.TabIndex = 1;
            this.SystemComponentsLabel.TabStop = false;
            this.SystemComponentsLabel.Text = "System Components";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerLabel.Location = new System.Drawing.Point(6, 76);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(95, 18);
            this.ManufacturerLabel.TabIndex = 7;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // ManufacturerTextbox
            // 
            this.ManufacturerTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerTextbox.Location = new System.Drawing.Point(107, 73);
            this.ManufacturerTextbox.Name = "ManufacturerTextbox";
            this.ManufacturerTextbox.Size = new System.Drawing.Size(100, 24);
            this.ManufacturerTextbox.TabIndex = 8;
            // 
            // ModelTextbox
            // 
            this.ModelTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelTextbox.Location = new System.Drawing.Point(293, 73);
            this.ModelTextbox.Name = "ModelTextbox";
            this.ModelTextbox.Size = new System.Drawing.Size(100, 24);
            this.ModelTextbox.TabIndex = 5;
            // 
            // ConditionTextbox
            // 
            this.ConditionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionTextbox.Location = new System.Drawing.Point(293, 34);
            this.ConditionTextbox.Name = "ConditionTextbox";
            this.ConditionTextbox.Size = new System.Drawing.Size(100, 24);
            this.ConditionTextbox.TabIndex = 5;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.Location = new System.Drawing.Point(238, 76);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(49, 18);
            this.ModelLabel.TabIndex = 3;
            this.ModelLabel.Text = "Model";
            // 
            // ConditionOrderTextbox
            // 
            this.ConditionOrderTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionOrderTextbox.Location = new System.Drawing.Point(107, 34);
            this.ConditionOrderTextbox.Name = "ConditionOrderTextbox";
            this.ConditionOrderTextbox.Size = new System.Drawing.Size(100, 24);
            this.ConditionOrderTextbox.TabIndex = 6;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformLabel.Location = new System.Drawing.Point(223, 37);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(64, 18);
            this.PlatformLabel.TabIndex = 3;
            this.PlatformLabel.Text = "Platform";
            // 
            // ConditionOrderLabel
            // 
            this.ConditionOrderLabel.AutoSize = true;
            this.ConditionOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionOrderLabel.Location = new System.Drawing.Point(30, 37);
            this.ConditionOrderLabel.Name = "ConditionOrderLabel";
            this.ConditionOrderLabel.Size = new System.Drawing.Size(71, 18);
            this.ConditionOrderLabel.TabIndex = 4;
            this.ConditionOrderLabel.Text = "Condition";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 384);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // YourPriceGroupbox
            // 
            this.YourPriceGroupbox.Controls.Add(this.SeparaterLabel);
            this.YourPriceGroupbox.Controls.Add(this.SalesTaxTextbox);
            this.YourPriceGroupbox.Controls.Add(this.SalesTaxLabel);
            this.YourPriceGroupbox.Controls.Add(this.TotalTextbox);
            this.YourPriceGroupbox.Controls.Add(this.TotalLabel);
            this.YourPriceGroupbox.Controls.Add(this.PriceTextbox);
            this.YourPriceGroupbox.Controls.Add(this.PriceLabel);
            this.YourPriceGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourPriceGroupbox.Location = new System.Drawing.Point(444, 230);
            this.YourPriceGroupbox.Name = "YourPriceGroupbox";
            this.YourPriceGroupbox.Size = new System.Drawing.Size(328, 202);
            this.YourPriceGroupbox.TabIndex = 4;
            this.YourPriceGroupbox.TabStop = false;
            this.YourPriceGroupbox.Text = "Your Price";
            // 
            // SeparaterLabel
            // 
            this.SeparaterLabel.AutoSize = true;
            this.SeparaterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeparaterLabel.Location = new System.Drawing.Point(23, 120);
            this.SeparaterLabel.Name = "SeparaterLabel";
            this.SeparaterLabel.Size = new System.Drawing.Size(268, 22);
            this.SeparaterLabel.TabIndex = 2;
            this.SeparaterLabel.Text = "-------------------------------------------";
            // 
            // SalesTaxTextbox
            // 
            this.SalesTaxTextbox.Location = new System.Drawing.Point(186, 80);
            this.SalesTaxTextbox.Name = "SalesTaxTextbox";
            this.SalesTaxTextbox.Size = new System.Drawing.Size(100, 24);
            this.SalesTaxTextbox.TabIndex = 1;
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTaxLabel.Location = new System.Drawing.Point(23, 83);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(144, 22);
            this.SalesTaxLabel.TabIndex = 0;
            this.SalesTaxLabel.Text = "Sales Tax (13%)";
            // 
            // TotalTextbox
            // 
            this.TotalTextbox.Location = new System.Drawing.Point(186, 157);
            this.TotalTextbox.Name = "TotalTextbox";
            this.TotalTextbox.Size = new System.Drawing.Size(100, 24);
            this.TotalTextbox.TabIndex = 1;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(23, 160);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(51, 22);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "Total";
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.Location = new System.Drawing.Point(186, 37);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.Size = new System.Drawing.Size(100, 24);
            this.PriceTextbox.TabIndex = 1;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(23, 40);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(51, 22);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Price";
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(471, 483);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(60, 32);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(556, 483);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(76, 32);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.AutoSize = true;
            this.FinishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.Location = new System.Drawing.Point(662, 483);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(68, 32);
            this.FinishButton.TabIndex = 5;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DollarComputers.Properties.Resources.mac;
            this.pictureBox1.Location = new System.Drawing.Point(444, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.YourPriceGroupbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SystemComponentsLabel);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complete Your Order";
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.SystemComponentsLabel.ResumeLayout(false);
            this.SystemComponentsLabel.PerformLayout();
            this.YourPriceGroupbox.ResumeLayout(false);
            this.YourPriceGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox SystemComponentsLabel;
        private System.Windows.Forms.TextBox ConditionTextbox;
        private System.Windows.Forms.TextBox ConditionOrderTextbox;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ConditionOrderLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.TextBox ManufacturerTextbox;
        private System.Windows.Forms.TextBox ModelTextbox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox YourPriceGroupbox;
        private System.Windows.Forms.Label SeparaterLabel;
        private System.Windows.Forms.TextBox SalesTaxTextbox;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.TextBox TotalTextbox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox PriceTextbox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button FinishButton;
    }
}