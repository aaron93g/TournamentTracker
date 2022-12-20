namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.placementNumberTextBox = new System.Windows.Forms.TextBox();
            this.placementNumberLabel = new System.Windows.Forms.Label();
            this.placementNameTextBox = new System.Windows.Forms.TextBox();
            this.placementNameLabel = new System.Windows.Forms.Label();
            this.prizeAmountTextBox = new System.Windows.Forms.TextBox();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.versusLabel = new System.Windows.Forms.Label();
            this.prizePercentageTextBox = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.headerLabel.Location = new System.Drawing.Point(199, 9);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(209, 50);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Create Prize";
            // 
            // placementNumberTextBox
            // 
            this.placementNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.placementNumberTextBox.Location = new System.Drawing.Point(330, 156);
            this.placementNumberTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.placementNumberTextBox.Name = "placementNumberTextBox";
            this.placementNumberTextBox.Size = new System.Drawing.Size(159, 35);
            this.placementNumberTextBox.TabIndex = 14;
            // 
            // placementNumberLabel
            // 
            this.placementNumberLabel.AutoSize = true;
            this.placementNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.placementNumberLabel.Location = new System.Drawing.Point(124, 158);
            this.placementNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.placementNumberLabel.Name = "placementNumberLabel";
            this.placementNumberLabel.Size = new System.Drawing.Size(203, 30);
            this.placementNumberLabel.TabIndex = 13;
            this.placementNumberLabel.Text = "Placement Number:";
            // 
            // placementNameTextBox
            // 
            this.placementNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.placementNameTextBox.Location = new System.Drawing.Point(330, 225);
            this.placementNameTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.placementNameTextBox.Name = "placementNameTextBox";
            this.placementNameTextBox.Size = new System.Drawing.Size(159, 35);
            this.placementNameTextBox.TabIndex = 16;
            // 
            // placementNameLabel
            // 
            this.placementNameLabel.AutoSize = true;
            this.placementNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.placementNameLabel.Location = new System.Drawing.Point(147, 227);
            this.placementNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.placementNameLabel.Name = "placementNameLabel";
            this.placementNameLabel.Size = new System.Drawing.Size(180, 30);
            this.placementNameLabel.TabIndex = 15;
            this.placementNameLabel.Text = "Placement Name:";
            // 
            // prizeAmountTextBox
            // 
            this.prizeAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizeAmountTextBox.Location = new System.Drawing.Point(330, 293);
            this.prizeAmountTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.prizeAmountTextBox.Name = "prizeAmountTextBox";
            this.prizeAmountTextBox.Size = new System.Drawing.Size(159, 35);
            this.prizeAmountTextBox.TabIndex = 18;
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prizeAmountLabel.Location = new System.Drawing.Point(87, 295);
            this.prizeAmountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(240, 30);
            this.prizeAmountLabel.TabIndex = 17;
            this.prizeAmountLabel.Text = "Prize Amount Awarded:";
            this.prizeAmountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.versusLabel.Location = new System.Drawing.Point(223, 335);
            this.versusLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(70, 30);
            this.versusLabel.TabIndex = 19;
            this.versusLabel.Text = "- OR -";
            // 
            // prizePercentageTextBox
            // 
            this.prizePercentageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizePercentageTextBox.Location = new System.Drawing.Point(330, 371);
            this.prizePercentageTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.prizePercentageTextBox.Name = "prizePercentageTextBox";
            this.prizePercentageTextBox.Size = new System.Drawing.Size(159, 35);
            this.prizePercentageTextBox.TabIndex = 21;
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prizePercentageLabel.Location = new System.Drawing.Point(59, 371);
            this.prizePercentageLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(268, 30);
            this.prizePercentageLabel.TabIndex = 20;
            this.prizePercentageLabel.Text = "Prize Percentage Awarded:";
            this.prizePercentageLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.BackColor = System.Drawing.Color.DarkGray;
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createPrizeButton.Location = new System.Drawing.Point(218, 463);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(180, 39);
            this.createPrizeButton.TabIndex = 22;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = false;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(616, 581);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.prizePercentageTextBox);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.prizeAmountTextBox);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.placementNameTextBox);
            this.Controls.Add(this.placementNameLabel);
            this.Controls.Add(this.placementNumberTextBox);
            this.Controls.Add(this.placementNumberLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox placementNumberTextBox;
        private System.Windows.Forms.Label placementNumberLabel;
        private System.Windows.Forms.TextBox placementNameTextBox;
        private System.Windows.Forms.Label placementNameLabel;
        private System.Windows.Forms.TextBox prizeAmountTextBox;
        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.TextBox prizePercentageTextBox;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.Button createPrizeButton;
    }
}