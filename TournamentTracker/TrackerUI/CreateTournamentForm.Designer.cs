namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameTextBox = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeTextBox = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamComboBox = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizebutton = new System.Windows.Forms.Button();
            this.tournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.tournamentPlayerslabel = new System.Windows.Forms.Label();
            this.Prizeslabel = new System.Windows.Forms.Label();
            this.PrizelistBox = new System.Windows.Forms.ListBox();
            this.deleteTeamButton = new System.Windows.Forms.Button();
            this.deletePrizeButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.headerLabel.Location = new System.Drawing.Point(399, 18);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(317, 50);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameTextBox
            // 
            this.tournamentNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentNameTextBox.Location = new System.Drawing.Point(62, 157);
            this.tournamentNameTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tournamentNameTextBox.Name = "tournamentNameTextBox";
            this.tournamentNameTextBox.Size = new System.Drawing.Size(382, 35);
            this.tournamentNameTextBox.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLabel.Location = new System.Drawing.Point(57, 120);
            this.tournamentNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(197, 30);
            this.tournamentNameLabel.TabIndex = 9;
            this.tournamentNameLabel.Text = "Tournament Name:";
            // 
            // entryFeeTextBox
            // 
            this.entryFeeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entryFeeTextBox.Location = new System.Drawing.Point(234, 221);
            this.entryFeeTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.entryFeeTextBox.Name = "entryFeeTextBox";
            this.entryFeeTextBox.Size = new System.Drawing.Size(70, 35);
            this.entryFeeTextBox.TabIndex = 13;
            this.entryFeeTextBox.Text = "0";
            this.entryFeeTextBox.TextChanged += new System.EventHandler(this.teamTwoScoreValueTextBox_TextChanged);
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLabel.Location = new System.Drawing.Point(128, 223);
            this.entryFeeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(108, 30);
            this.entryFeeLabel.TabIndex = 12;
            this.entryFeeLabel.Text = "Entry Fee:";
            // 
            // selectTeamComboBox
            // 
            this.selectTeamComboBox.FormattingEnabled = true;
            this.selectTeamComboBox.Location = new System.Drawing.Point(81, 323);
            this.selectTeamComboBox.Name = "selectTeamComboBox";
            this.selectTeamComboBox.Size = new System.Drawing.Size(363, 38);
            this.selectTeamComboBox.TabIndex = 15;
            this.selectTeamComboBox.SelectedIndexChanged += new System.EventHandler(this.roundComboBox_SelectedIndexChanged);
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamLabel.Location = new System.Drawing.Point(75, 288);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(142, 32);
            this.selectTeamLabel.TabIndex = 14;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // createNewLinkLabel
            // 
            this.createNewLinkLabel.AutoSize = true;
            this.createNewLinkLabel.Location = new System.Drawing.Point(274, 290);
            this.createNewLinkLabel.Name = "createNewLinkLabel";
            this.createNewLinkLabel.Size = new System.Drawing.Size(170, 30);
            this.createNewLinkLabel.TabIndex = 16;
            this.createNewLinkLabel.TabStop = true;
            this.createNewLinkLabel.Text = "Create new team";
            // 
            // addTeamButton
            // 
            this.addTeamButton.BackColor = System.Drawing.Color.DarkGray;
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamButton.Location = new System.Drawing.Point(154, 367);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(180, 39);
            this.addTeamButton.TabIndex = 17;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = false;
            // 
            // createPrizebutton
            // 
            this.createPrizebutton.BackColor = System.Drawing.Color.DarkGray;
            this.createPrizebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.createPrizebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.createPrizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizebutton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizebutton.Location = new System.Drawing.Point(703, 490);
            this.createPrizebutton.Name = "createPrizebutton";
            this.createPrizebutton.Size = new System.Drawing.Size(180, 52);
            this.createPrizebutton.TabIndex = 18;
            this.createPrizebutton.Text = "Create Prize";
            this.createPrizebutton.UseVisualStyleBackColor = false;
            // 
            // tournamentTeamsListBox
            // 
            this.tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentTeamsListBox.ForeColor = System.Drawing.Color.Green;
            this.tournamentTeamsListBox.FormattingEnabled = true;
            this.tournamentTeamsListBox.ItemHeight = 30;
            this.tournamentTeamsListBox.Location = new System.Drawing.Point(615, 153);
            this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            this.tournamentTeamsListBox.Size = new System.Drawing.Size(354, 152);
            this.tournamentTeamsListBox.TabIndex = 19;
            // 
            // tournamentPlayerslabel
            // 
            this.tournamentPlayerslabel.AutoSize = true;
            this.tournamentPlayerslabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentPlayerslabel.Location = new System.Drawing.Point(685, 120);
            this.tournamentPlayerslabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tournamentPlayerslabel.Name = "tournamentPlayerslabel";
            this.tournamentPlayerslabel.Size = new System.Drawing.Size(200, 30);
            this.tournamentPlayerslabel.TabIndex = 20;
            this.tournamentPlayerslabel.Text = "Tournament Teams:";
            // 
            // Prizeslabel
            // 
            this.Prizeslabel.AutoSize = true;
            this.Prizeslabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prizeslabel.Location = new System.Drawing.Point(705, 334);
            this.Prizeslabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Prizeslabel.Name = "Prizeslabel";
            this.Prizeslabel.Size = new System.Drawing.Size(178, 30);
            this.Prizeslabel.TabIndex = 22;
            this.Prizeslabel.Text = "Placement Prizes:";
            // 
            // PrizelistBox
            // 
            this.PrizelistBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizelistBox.ForeColor = System.Drawing.Color.Green;
            this.PrizelistBox.FormattingEnabled = true;
            this.PrizelistBox.ItemHeight = 30;
            this.PrizelistBox.Location = new System.Drawing.Point(635, 367);
            this.PrizelistBox.Name = "PrizelistBox";
            this.PrizelistBox.Size = new System.Drawing.Size(334, 92);
            this.PrizelistBox.TabIndex = 21;
            // 
            // deleteTeamButton
            // 
            this.deleteTeamButton.BackColor = System.Drawing.Color.DarkGray;
            this.deleteTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.deleteTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.deleteTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTeamButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTeamButton.Location = new System.Drawing.Point(1007, 194);
            this.deleteTeamButton.Name = "deleteTeamButton";
            this.deleteTeamButton.Size = new System.Drawing.Size(113, 52);
            this.deleteTeamButton.TabIndex = 23;
            this.deleteTeamButton.Text = "Delete";
            this.deleteTeamButton.UseVisualStyleBackColor = false;
            // 
            // deletePrizeButton
            // 
            this.deletePrizeButton.BackColor = System.Drawing.Color.DarkGray;
            this.deletePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deletePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.deletePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.deletePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePrizeButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePrizeButton.Location = new System.Drawing.Point(1007, 388);
            this.deletePrizeButton.Name = "deletePrizeButton";
            this.deletePrizeButton.Size = new System.Drawing.Size(113, 52);
            this.deletePrizeButton.TabIndex = 24;
            this.deletePrizeButton.Text = "Delete";
            this.deletePrizeButton.UseVisualStyleBackColor = false;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.Color.DarkGray;
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.Location = new System.Drawing.Point(118, 490);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(229, 52);
            this.createTournamentButton.TabIndex = 25;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1228, 592);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deletePrizeButton);
            this.Controls.Add(this.deleteTeamButton);
            this.Controls.Add(this.Prizeslabel);
            this.Controls.Add(this.PrizelistBox);
            this.Controls.Add(this.tournamentPlayerslabel);
            this.Controls.Add(this.tournamentTeamsListBox);
            this.Controls.Add(this.createPrizebutton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewLinkLabel);
            this.Controls.Add(this.selectTeamComboBox);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeTextBox);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameTextBox);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox tournamentNameTextBox;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox entryFeeTextBox;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ComboBox selectTeamComboBox;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel createNewLinkLabel;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizebutton;
        private System.Windows.Forms.ListBox tournamentTeamsListBox;
        private System.Windows.Forms.Label tournamentPlayerslabel;
        private System.Windows.Forms.Label Prizeslabel;
        private System.Windows.Forms.ListBox PrizelistBox;
        private System.Windows.Forms.Button deleteTeamButton;
        private System.Windows.Forms.Button deletePrizeButton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}