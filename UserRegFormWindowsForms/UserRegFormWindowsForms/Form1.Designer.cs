namespace UserRegFormWindowsForms
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pwordText = new System.Windows.Forms.TextBox();
            this.enterPword = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.confirmPword = new System.Windows.Forms.Label();
            this.regDetails = new System.Windows.Forms.Button();
            this.allUsersList = new System.Windows.Forms.Button();
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
            this.regFormTitle.Size = new System.Drawing.Size(991, 79);
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
            this.firstNameText.Size = new System.Drawing.Size(608, 58);
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
            this.lastNameText.Size = new System.Drawing.Size(608, 58);
            this.lastNameText.TabIndex = 4;
            // 
            // emailText
            // 
            this.emailText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailText.Location = new System.Drawing.Point(359, 251);
            this.emailText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(608, 58);
            this.emailText.TabIndex = 6;
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
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(489, 329);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(478, 58);
            this.textBox2.TabIndex = 8;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(359, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 66);
            this.button1.TabIndex = 9;
            this.button1.Text = "click to generate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pwordText
            // 
            this.pwordText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pwordText.Location = new System.Drawing.Point(359, 402);
            this.pwordText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pwordText.Name = "pwordText";
            this.pwordText.Size = new System.Drawing.Size(608, 58);
            this.pwordText.TabIndex = 11;
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
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(359, 474);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(608, 58);
            this.textBox3.TabIndex = 13;
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
            this.regDetails.Location = new System.Drawing.Point(456, 581);
            this.regDetails.Name = "regDetails";
            this.regDetails.Size = new System.Drawing.Size(240, 66);
            this.regDetails.TabIndex = 14;
            this.regDetails.Text = "Registration Details";
            this.regDetails.UseVisualStyleBackColor = true;
            // 
            // allUsersList
            // 
            this.allUsersList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.allUsersList.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allUsersList.Location = new System.Drawing.Point(727, 581);
            this.allUsersList.Name = "allUsersList";
            this.allUsersList.Size = new System.Drawing.Size(240, 66);
            this.allUsersList.TabIndex = 15;
            this.allUsersList.Text = "View all users";
            this.allUsersList.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 684);
            this.Controls.Add(this.allUsersList);
            this.Controls.Add(this.regDetails);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.confirmPword);
            this.Controls.Add(this.pwordText);
            this.Controls.Add(this.enterPword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pwordText;
        private System.Windows.Forms.Label enterPword;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label confirmPword;
        private System.Windows.Forms.Button regDetails;
        private System.Windows.Forms.Button allUsersList;
    }
}

