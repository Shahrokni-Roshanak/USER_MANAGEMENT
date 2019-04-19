namespace MyApplication.Admin
{
    partial class UsersListForm
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
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.ForeColor = System.Drawing.Color.White;
            this.fullNameLabel.Location = new System.Drawing.Point(12, 15);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(75, 17);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.Text = "&Full Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(93, 42);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 27);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteUserButton.Location = new System.Drawing.Point(15, 289);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(154, 31);
            this.deleteUserButton.TabIndex = 2;
            this.deleteUserButton.Text = "&Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // usersListBox
            // 
            this.usersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ItemHeight = 17;
            this.usersListBox.Location = new System.Drawing.Point(15, 75);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.usersListBox.Size = new System.Drawing.Size(505, 208);
            this.usersListBox.TabIndex = 3;
            this.usersListBox.DoubleClick += new System.EventHandler(this.UsersListBox_DoubleClick);
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameTextBox.Location = new System.Drawing.Point(93, 12);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(427, 24);
            this.fullNameTextBox.TabIndex = 4;
            // 
            // UsersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(532, 342);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.fullNameLabel);
            this.Name = "UsersListForm";
            this.Text = "Users List";
            this.Load += new System.EventHandler(this.UsersListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
    }
}