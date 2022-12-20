namespace TrackerUI
{
    partial class TournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundComboBox = new System.Windows.Forms.ComboBox();
            this.unplayedGamesCheckBox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneNameLabel = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoreValueTextBox = new System.Windows.Forms.TextBox();
            this.teamTwoScoreValueTextBox = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoNameLabel = new System.Windows.Forms.Label();
            this.versusLabel = new System.Windows.Forms.Label();
            this.submitMatchupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.headerLabel.Location = new System.Drawing.Point(86, 52);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(214, 50);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.tournamentNameLabel.Location = new System.Drawing.Point(306, 62);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(276, 37);
            this.tournamentNameLabel.TabIndex = 1;
            this.tournamentNameLabel.Text = "<TournamentName>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.Location = new System.Drawing.Point(62, 149);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(88, 32);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round:";
            // 
            // roundComboBox
            // 
            this.roundComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundComboBox.FormattingEnabled = true;
            this.roundComboBox.Location = new System.Drawing.Point(156, 148);
            this.roundComboBox.Name = "roundComboBox";
            this.roundComboBox.Size = new System.Drawing.Size(62, 38);
            this.roundComboBox.TabIndex = 3;
            // 
            // unplayedGamesCheckBox
            // 
            this.unplayedGamesCheckBox.AutoSize = true;
            this.unplayedGamesCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedGamesCheckBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unplayedGamesCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.unplayedGamesCheckBox.Location = new System.Drawing.Point(62, 215);
            this.unplayedGamesCheckBox.Name = "unplayedGamesCheckBox";
            this.unplayedGamesCheckBox.Size = new System.Drawing.Size(156, 24);
            this.unplayedGamesCheckBox.TabIndex = 4;
            this.unplayedGamesCheckBox.Text = "only show unplayed";
            this.unplayedGamesCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.ForeColor = System.Drawing.Color.Green;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 30;
            this.matchupListBox.Location = new System.Drawing.Point(30, 245);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(296, 272);
            this.matchupListBox.TabIndex = 5;
            // 
            // teamOneNameLabel
            // 
            this.teamOneNameLabel.AutoSize = true;
            this.teamOneNameLabel.ForeColor = System.Drawing.Color.Green;
            this.teamOneNameLabel.Location = new System.Drawing.Point(403, 209);
            this.teamOneNameLabel.Name = "teamOneNameLabel";
            this.teamOneNameLabel.Size = new System.Drawing.Size(127, 30);
            this.teamOneNameLabel.TabIndex = 6;
            this.teamOneNameLabel.Text = "<teamOne>";
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneScoreLabel.Location = new System.Drawing.Point(418, 250);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(82, 30);
            this.teamOneScoreLabel.TabIndex = 7;
            this.teamOneScoreLabel.Text = "SCORE:";
            // 
            // teamOneScoreValueTextBox
            // 
            this.teamOneScoreValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamOneScoreValueTextBox.Location = new System.Drawing.Point(500, 250);
            this.teamOneScoreValueTextBox.Name = "teamOneScoreValueTextBox";
            this.teamOneScoreValueTextBox.Size = new System.Drawing.Size(100, 35);
            this.teamOneScoreValueTextBox.TabIndex = 8;
            // 
            // teamTwoScoreValueTextBox
            // 
            this.teamTwoScoreValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamTwoScoreValueTextBox.Location = new System.Drawing.Point(500, 453);
            this.teamTwoScoreValueTextBox.Name = "teamTwoScoreValueTextBox";
            this.teamTwoScoreValueTextBox.Size = new System.Drawing.Size(100, 35);
            this.teamTwoScoreValueTextBox.TabIndex = 11;
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(418, 453);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(82, 30);
            this.teamTwoScoreLabel.TabIndex = 10;
            this.teamTwoScoreLabel.Text = "SCORE:";
            // 
            // teamTwoNameLabel
            // 
            this.teamTwoNameLabel.AutoSize = true;
            this.teamTwoNameLabel.ForeColor = System.Drawing.Color.Green;
            this.teamTwoNameLabel.Location = new System.Drawing.Point(403, 412);
            this.teamTwoNameLabel.Name = "teamTwoNameLabel";
            this.teamTwoNameLabel.Size = new System.Drawing.Size(125, 30);
            this.teamTwoNameLabel.TabIndex = 9;
            this.teamTwoNameLabel.Text = "<teamTwo>";
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versusLabel.Location = new System.Drawing.Point(475, 329);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(72, 37);
            this.versusLabel.TabIndex = 12;
            this.versusLabel.Text = "-VS-";
            // 
            // submitMatchupButton
            // 
            this.submitMatchupButton.BackColor = System.Drawing.Color.DarkGray;
            this.submitMatchupButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.submitMatchupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.submitMatchupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.submitMatchupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitMatchupButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitMatchupButton.Location = new System.Drawing.Point(635, 322);
            this.submitMatchupButton.Name = "submitMatchupButton";
            this.submitMatchupButton.Size = new System.Drawing.Size(100, 45);
            this.submitMatchupButton.TabIndex = 13;
            this.submitMatchupButton.Text = "Submit";
            this.submitMatchupButton.UseVisualStyleBackColor = false;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(763, 543);
            this.Controls.Add(this.submitMatchupButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.teamTwoScoreValueTextBox);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamTwoNameLabel);
            this.Controls.Add(this.teamOneScoreValueTextBox);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamOneNameLabel);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedGamesCheckBox);
            this.Controls.Add(this.roundComboBox);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundComboBox;
        private System.Windows.Forms.CheckBox unplayedGamesCheckBox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamOneNameLabel;
        private System.Windows.Forms.Label teamOneScoreLabel;
        private System.Windows.Forms.TextBox teamOneScoreValueTextBox;
        private System.Windows.Forms.TextBox teamTwoScoreValueTextBox;
        private System.Windows.Forms.Label teamTwoScoreLabel;
        private System.Windows.Forms.Label teamTwoNameLabel;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.Button submitMatchupButton;
    }
}

