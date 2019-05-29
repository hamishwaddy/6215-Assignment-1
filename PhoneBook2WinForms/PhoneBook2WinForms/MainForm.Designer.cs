namespace PhoneBook2WinForms
{
    partial class MainForm
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
            this.phonebookTitle = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.standardUser = new System.Windows.Forms.RadioButton();
            this.supervisor = new System.Windows.Forms.RadioButton();
            this.phonebookTable = new System.Windows.Forms.TableLayoutPanel();
            this.displayPhonebook = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearScreen = new System.Windows.Forms.Button();
            this.phonebookTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // phonebookTitle
            // 
            this.phonebookTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phonebookTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phonebookTitle.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonebookTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phonebookTitle.Location = new System.Drawing.Point(12, 9);
            this.phonebookTitle.Name = "phonebookTitle";
            this.phonebookTitle.Size = new System.Drawing.Size(290, 39);
            this.phonebookTitle.TabIndex = 0;
            this.phonebookTitle.Text = "PHONEBOOK";
            this.phonebookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "View Phonebook";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // standardUser
            // 
            this.standardUser.AutoSize = true;
            this.standardUser.Checked = true;
            this.standardUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardUser.Location = new System.Drawing.Point(6, 19);
            this.standardUser.Name = "standardUser";
            this.standardUser.Size = new System.Drawing.Size(127, 23);
            this.standardUser.TabIndex = 4;
            this.standardUser.TabStop = true;
            this.standardUser.Text = "Standard User";
            this.standardUser.UseVisualStyleBackColor = true;
            this.standardUser.CheckedChanged += new System.EventHandler(this.standardUser_CheckedChanged);
            // 
            // supervisor
            // 
            this.supervisor.AutoSize = true;
            this.supervisor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supervisor.Location = new System.Drawing.Point(6, 59);
            this.supervisor.Name = "supervisor";
            this.supervisor.Size = new System.Drawing.Size(102, 23);
            this.supervisor.TabIndex = 5;
            this.supervisor.Text = "Supervisor";
            this.supervisor.UseVisualStyleBackColor = true;
            // 
            // phonebookTable
            // 
            this.phonebookTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phonebookTable.AutoSize = true;
            this.phonebookTable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phonebookTable.ColumnCount = 1;
            this.phonebookTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.phonebookTable.Controls.Add(this.button2, 0, 0);
            this.phonebookTable.Controls.Add(this.displayPhonebook, 0, 1);
            this.phonebookTable.Location = new System.Drawing.Point(12, 154);
            this.phonebookTable.Name = "phonebookTable";
            this.phonebookTable.RowCount = 2;
            this.phonebookTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.phonebookTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.phonebookTable.Size = new System.Drawing.Size(290, 287);
            this.phonebookTable.TabIndex = 6;
            // 
            // displayPhonebook
            // 
            this.displayPhonebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.displayPhonebook.Location = new System.Drawing.Point(3, 47);
            this.displayPhonebook.Multiline = true;
            this.displayPhonebook.Name = "displayPhonebook";
            this.displayPhonebook.Size = new System.Drawing.Size(284, 237);
            this.displayPhonebook.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.standardUser);
            this.groupBox1.Controls.Add(this.supervisor);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 88);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select user type";
            // 
            // clearScreen
            // 
            this.clearScreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearScreen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearScreen.Location = new System.Drawing.Point(181, 448);
            this.clearScreen.Name = "clearScreen";
            this.clearScreen.Size = new System.Drawing.Size(118, 39);
            this.clearScreen.TabIndex = 9;
            this.clearScreen.Text = "Clear Screen";
            this.clearScreen.UseVisualStyleBackColor = true;
            this.clearScreen.Click += new System.EventHandler(this.clearScreen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 501);
            this.Controls.Add(this.clearScreen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.phonebookTable);
            this.Controls.Add(this.phonebookTitle);
            this.MinimumSize = new System.Drawing.Size(330, 540);
            this.Name = "Form1";
            this.Text = "Phonebook Application";
            this.phonebookTable.ResumeLayout(false);
            this.phonebookTable.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label phonebookTitle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton standardUser;
        private System.Windows.Forms.RadioButton supervisor;
        private System.Windows.Forms.TableLayoutPanel phonebookTable;
        private System.Windows.Forms.TextBox displayPhonebook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearScreen;
    }
}

