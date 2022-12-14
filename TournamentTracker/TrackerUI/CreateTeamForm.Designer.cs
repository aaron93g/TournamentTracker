namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.selectTeamMemberComboBox = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.cellPhoneTextBox = new System.Windows.Forms.TextBox();
            this.cellPhoneLabel = new System.Windows.Forms.Label();
            this.teamPlayersListBox = new System.Windows.Forms.ListBox();
            this.createTeambutton = new System.Windows.Forms.Button();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.deleteMemberButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamNameTextBox.Location = new System.Drawing.Point(42, 96);
            this.teamNameTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(321, 35);
            this.teamNameTextBox.TabIndex = 12;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLabel.Location = new System.Drawing.Point(37, 59);
            this.teamNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(132, 30);
            this.teamNameLabel.TabIndex = 11;
            this.teamNameLabel.Text = "Team Name:";
            // 
            // selectTeamMemberComboBox
            // 
            this.selectTeamMemberComboBox.FormattingEnabled = true;
            this.selectTeamMemberComboBox.Location = new System.Drawing.Point(42, 189);
            this.selectTeamMemberComboBox.Name = "selectTeamMemberComboBox";
            this.selectTeamMemberComboBox.Size = new System.Drawing.Size(321, 38);
            this.selectTeamMemberComboBox.TabIndex = 17;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(36, 154);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(240, 32);
            this.selectTeamMemberLabel.TabIndex = 16;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addMemberButton
            // 
            this.addMemberButton.BackColor = System.Drawing.Color.DarkGray;
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberButton.Location = new System.Drawing.Point(134, 233);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(180, 39);
            this.addMemberButton.TabIndex = 18;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = false;
            // 
            // addNewMemberGroupBox
            // 
            this.addNewMemberGroupBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addNewMemberGroupBox.Controls.Add(this.createMemberButton);
            this.addNewMemberGroupBox.Controls.Add(this.cellPhoneTextBox);
            this.addNewMemberGroupBox.Controls.Add(this.cellPhoneLabel);
            this.addNewMemberGroupBox.Controls.Add(this.emailTextBox);
            this.addNewMemberGroupBox.Controls.Add(this.emailLabel);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameTextBox);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameTextBox);
            this.addNewMemberGroupBox.Controls.Add(this.FirstNameLabel);
            this.addNewMemberGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewMemberGroupBox.Location = new System.Drawing.Point(42, 303);
            this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            this.addNewMemberGroupBox.Size = new System.Drawing.Size(363, 356);
            this.addNewMemberGroupBox.TabIndex = 19;
            this.addNewMemberGroupBox.TabStop = false;
            this.addNewMemberGroupBox.Text = "Add New Member";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTextBox.Location = new System.Drawing.Point(170, 48);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(151, 35);
            this.firstNameTextBox.TabIndex = 12;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(36, 48);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(122, 30);
            this.FirstNameLabel.TabIndex = 11;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameTextBox.Location = new System.Drawing.Point(170, 97);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(151, 35);
            this.lastNameTextBox.TabIndex = 14;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(36, 97);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(119, 30);
            this.lastNameLabel.TabIndex = 13;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Location = new System.Drawing.Point(41, 192);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(267, 35);
            this.emailTextBox.TabIndex = 16;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(82, 155);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(152, 30);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "Email Address:";
            // 
            // cellPhoneTextBox
            // 
            this.cellPhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cellPhoneTextBox.Location = new System.Drawing.Point(143, 241);
            this.cellPhoneTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cellPhoneTextBox.Name = "cellPhoneTextBox";
            this.cellPhoneTextBox.Size = new System.Drawing.Size(165, 35);
            this.cellPhoneTextBox.TabIndex = 18;
            // 
            // cellPhoneLabel
            // 
            this.cellPhoneLabel.AutoSize = true;
            this.cellPhoneLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellPhoneLabel.Location = new System.Drawing.Point(9, 241);
            this.cellPhoneLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cellPhoneLabel.Name = "cellPhoneLabel";
            this.cellPhoneLabel.Size = new System.Drawing.Size(118, 30);
            this.cellPhoneLabel.TabIndex = 17;
            this.cellPhoneLabel.Text = "Cell Phone:";
            // 
            // teamPlayersListBox
            // 
            this.teamPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamPlayersListBox.ForeColor = System.Drawing.Color.Green;
            this.teamPlayersListBox.FormattingEnabled = true;
            this.teamPlayersListBox.ItemHeight = 30;
            this.teamPlayersListBox.Location = new System.Drawing.Point(504, 96);
            this.teamPlayersListBox.Name = "teamPlayersListBox";
            this.teamPlayersListBox.Size = new System.Drawing.Size(295, 392);
            this.teamPlayersListBox.TabIndex = 20;
            // 
            // createTeambutton
            // 
            this.createTeambutton.BackColor = System.Drawing.Color.DarkGray;
            this.createTeambutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeambutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.createTeambutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.createTeambutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeambutton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeambutton.Location = new System.Drawing.Point(538, 587);
            this.createTeambutton.Name = "createTeambutton";
            this.createTeambutton.Size = new System.Drawing.Size(224, 61);
            this.createTeambutton.TabIndex = 21;
            this.createTeambutton.Text = "Create Team";
            this.createTeambutton.UseVisualStyleBackColor = false;
            // 
            // createMemberButton
            // 
            this.createMemberButton.BackColor = System.Drawing.Color.DarkGray;
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMemberButton.Location = new System.Drawing.Point(87, 295);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(180, 39);
            this.createMemberButton.TabIndex = 19;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = false;
            // 
            // deleteMemberButton
            // 
            this.deleteMemberButton.BackColor = System.Drawing.Color.DarkGray;
            this.deleteMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.deleteMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.deleteMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMemberButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMemberButton.Location = new System.Drawing.Point(563, 495);
            this.deleteMemberButton.Name = "deleteMemberButton";
            this.deleteMemberButton.Size = new System.Drawing.Size(180, 39);
            this.deleteMemberButton.TabIndex = 22;
            this.deleteMemberButton.Text = "Delete Member";
            this.deleteMemberButton.UseVisualStyleBackColor = false;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(869, 671);
            this.Controls.Add(this.deleteMemberButton);
            this.Controls.Add(this.createTeambutton);
            this.Controls.Add(this.teamPlayersListBox);
            this.Controls.Add(this.addNewMemberGroupBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberComboBox);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameTextBox);
            this.Controls.Add(this.teamNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addNewMemberGroupBox.ResumeLayout(false);
            this.addNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.ComboBox selectTeamMemberComboBox;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.GroupBox addNewMemberGroupBox;
        private System.Windows.Forms.TextBox cellPhoneTextBox;
        private System.Windows.Forms.Label cellPhoneLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.ListBox teamPlayersListBox;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.Button createTeambutton;
        private System.Windows.Forms.Button deleteMemberButton;
    }
}