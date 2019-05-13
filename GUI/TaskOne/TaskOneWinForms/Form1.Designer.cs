namespace TaskOneWinForms
{
    partial class Form1
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
            this.regFormTitle = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.generateUserName = new System.Windows.Forms.Button();
            this.password1Text = new System.Windows.Forms.TextBox();
            this.enterPword = new System.Windows.Forms.Label();
            this.password2Text = new System.Windows.Forms.TextBox();
            this.confirmPword = new System.Windows.Forms.Label();
            this.regDetails = new System.Windows.Forms.Button();
            this.allUsersList = new System.Windows.Forms.Button();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regFormTitle
            // 
            this.regFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regFormTitle.BackColor = System.Drawing.SystemColors.MenuText;
            this.regFormTitle.Font = new System.Drawing.Font("Tahoma", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regFormTitle.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.regFormTitle.Location = new System.Drawing.Point(0, 0);
            this.regFormTitle.Margin = new System.Windows.Forms.Padding(6);
            this.regFormTitle.Name = "regFormTitle";
            this.regFormTitle.Size = new System.Drawing.Size(1217, 79);
            this.regFormTitle.TabIndex = 0;
            this.regFormTitle.Text = "REGISTRATION FORM";
            this.regFormTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstName
            // 
            this.firstName.BackColor = System.Drawing.SystemColors.Control;
            this.firstName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(13, 105);
            this.firstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(321, 58);
            this.firstName.TabIndex = 1;
            this.firstName.Text = "First name:";
            this.firstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastName
            // 
            this.lastName.BackColor = System.Drawing.SystemColors.Control;
            this.lastName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(20, 168);
            this.lastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(314, 65);
            this.lastName.TabIndex = 2;
            this.lastName.Text = "Last name:";
            this.lastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstNameText
            // 
            this.firstNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameText.Location = new System.Drawing.Point(359, 105);
            this.firstNameText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(834, 58);
            this.firstNameText.TabIndex = 3;
            this.firstNameText.TextChanged += new System.EventHandler(this.firstNameText_TextChanged);
            // 
            // lastNameText
            // 
            this.lastNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameText.Location = new System.Drawing.Point(359, 175);
            this.lastNameText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(834, 58);
            this.lastNameText.TabIndex = 4;
            this.lastNameText.TextChanged += new System.EventHandler(this.lastNameText_TextChanged);
            // 
            // emailText
            // 
            this.emailText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailText.Location = new System.Drawing.Point(359, 251);
            this.emailText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(834, 58);
            this.emailText.TabIndex = 6;
            this.emailText.TextChanged += new System.EventHandler(this.emailText_TextChanged);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.Control;
            this.email.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(13, 251);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(321, 58);
            this.email.TabIndex = 5;
            this.email.Text = "Email:";
            this.email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.SystemColors.Control;
            this.userName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(13, 329);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(321, 58);
            this.userName.TabIndex = 7;
            this.userName.Text = "Username:";
            this.userName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // generateUserName
            // 
            this.generateUserName.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateUserName.Location = new System.Drawing.Point(359, 325);
            this.generateUserName.Name = "generateUserName";
            this.generateUserName.Size = new System.Drawing.Size(123, 66);
            this.generateUserName.TabIndex = 9;
            this.generateUserName.Text = "click to generate";
            this.generateUserName.UseVisualStyleBackColor = true;
            this.generateUserName.Click += new System.EventHandler(this.generateUserName_Click);
            // 
            // password1Text
            // 
            this.password1Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password1Text.Location = new System.Drawing.Point(359, 402);
            this.password1Text.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.password1Text.Name = "password1Text";
            this.password1Text.Size = new System.Drawing.Size(834, 58);
            this.password1Text.TabIndex = 11;
            this.password1Text.TextChanged += new System.EventHandler(this.password1Text_TextChanged);
            // 
            // enterPword
            // 
            this.enterPword.BackColor = System.Drawing.SystemColors.Control;
            this.enterPword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPword.Location = new System.Drawing.Point(13, 402);
            this.enterPword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enterPword.Name = "enterPword";
            this.enterPword.Size = new System.Drawing.Size(321, 58);
            this.enterPword.TabIndex = 10;
            this.enterPword.Text = "Enter password:";
            this.enterPword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // password2Text
            // 
            this.password2Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password2Text.Location = new System.Drawing.Point(359, 474);
            this.password2Text.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.password2Text.Name = "password2Text";
            this.password2Text.Size = new System.Drawing.Size(834, 58);
            this.password2Text.TabIndex = 13;
            this.password2Text.TextChanged += new System.EventHandler(this.password2Text_TextChanged);
            // 
            // confirmPword
            // 
            this.confirmPword.BackColor = System.Drawing.SystemColors.Control;
            this.confirmPword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPword.Location = new System.Drawing.Point(13, 474);
            this.confirmPword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmPword.Name = "confirmPword";
            this.confirmPword.Size = new System.Drawing.Size(321, 58);
            this.confirmPword.TabIndex = 12;
            this.confirmPword.Text = "Confirm password:";
            this.confirmPword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // regDetails
            // 
            this.regDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.regDetails.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regDetails.Location = new System.Drawing.Point(627, 581);
            this.regDetails.Name = "regDetails";
            this.regDetails.Size = new System.Drawing.Size(240, 48);
            this.regDetails.TabIndex = 14;
            this.regDetails.Text = "Registration Details";
            this.regDetails.UseVisualStyleBackColor = true;
            // 
            // allUsersList
            // 
            this.allUsersList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.allUsersList.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allUsersList.Location = new System.Drawing.Point(360, 581);
            this.allUsersList.Name = "allUsersList";
            this.allUsersList.Size = new System.Drawing.Size(240, 48);
            this.allUsersList.TabIndex = 15;
            this.allUsersList.Text = "View all users";
            this.allUsersList.UseVisualStyleBackColor = true;
            // 
            // userNameLbl
            // 
            this.userNameLbl.Location = new System.Drawing.Point(502, 325);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(465, 58);
            this.userNameLbl.TabIndex = 16;
            // 
            // submit
            // 
            this.submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.submit.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(953, 575);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(240, 66);
            this.submit.TabIndex = 17;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 684);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.allUsersList);
            this.Controls.Add(this.regDetails);
            this.Controls.Add(this.password2Text);
            this.Controls.Add(this.confirmPword);
            this.Controls.Add(this.password1Text);
            this.Controls.Add(this.enterPword);
            this.Controls.Add(this.generateUserName);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.regFormTitle);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1020, 755);
            this.Name = "Form1";
            this.Text = "Registration Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox regFormTitle;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button generateUserName;
        private System.Windows.Forms.TextBox password1Text;
        private System.Windows.Forms.Label enterPword;
        private System.Windows.Forms.TextBox password2Text;
        private System.Windows.Forms.Label confirmPword;
        private System.Windows.Forms.Button regDetails;
        private System.Windows.Forms.Button allUsersList;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Button submit;
    }
}

