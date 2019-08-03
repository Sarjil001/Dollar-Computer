namespace DollarComputers
{
    partial class SelectForm
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
            this.ComputerListLabel = new System.Windows.Forms.Label();
            this.ComputerListDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectionShowingLabel = new System.Windows.Forms.Label();
            this.DispalyOfSelectionTextbox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ComputerListLabel
            // 
            this.ComputerListLabel.AutoSize = true;
            this.ComputerListLabel.BackColor = System.Drawing.Color.White;
            this.ComputerListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerListLabel.Location = new System.Drawing.Point(13, 13);
            this.ComputerListLabel.Name = "ComputerListLabel";
            this.ComputerListLabel.Size = new System.Drawing.Size(311, 24);
            this.ComputerListLabel.TabIndex = 0;
            this.ComputerListLabel.Text = "Choose your Computer form the List";
            this.ComputerListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComputerListDataGridView
            // 
            this.ComputerListDataGridView.AllowUserToAddRows = false;
            this.ComputerListDataGridView.AllowUserToDeleteRows = false;
            this.ComputerListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComputerListDataGridView.Location = new System.Drawing.Point(13, 48);
            this.ComputerListDataGridView.Name = "ComputerListDataGridView";
            this.ComputerListDataGridView.ReadOnly = true;
            this.ComputerListDataGridView.Size = new System.Drawing.Size(759, 464);
            this.ComputerListDataGridView.TabIndex = 1;
            // 
            // SelectionShowingLabel
            // 
            this.SelectionShowingLabel.AutoSize = true;
            this.SelectionShowingLabel.BackColor = System.Drawing.Color.White;
            this.SelectionShowingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionShowingLabel.Location = new System.Drawing.Point(9, 528);
            this.SelectionShowingLabel.Name = "SelectionShowingLabel";
            this.SelectionShowingLabel.Size = new System.Drawing.Size(133, 24);
            this.SelectionShowingLabel.TabIndex = 2;
            this.SelectionShowingLabel.Text = "Your Selection";
            // 
            // DispalyOfSelectionTextbox
            // 
            this.DispalyOfSelectionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DispalyOfSelectionTextbox.Location = new System.Drawing.Point(148, 525);
            this.DispalyOfSelectionTextbox.Name = "DispalyOfSelectionTextbox";
            this.DispalyOfSelectionTextbox.Size = new System.Drawing.Size(389, 29);
            this.DispalyOfSelectionTextbox.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(557, 525);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(89, 29);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.White;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(664, 525);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(89, 29);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DispalyOfSelectionTextbox);
            this.Controls.Add(this.SelectionShowingLabel);
            this.Controls.Add(this.ComputerListDataGridView);
            this.Controls.Add(this.ComputerListLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer";
            ((System.ComponentModel.ISupportInitialize)(this.ComputerListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ComputerListLabel;
        private System.Windows.Forms.DataGridView ComputerListDataGridView;
        private System.Windows.Forms.Label SelectionShowingLabel;
        private System.Windows.Forms.TextBox DispalyOfSelectionTextbox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
    }
}