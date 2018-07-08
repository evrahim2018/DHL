namespace WindowsFormsApp1
{
    partial class PersonalInformation
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
            this.saveButton = new System.Windows.Forms.Button();
            this.showbutton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.namebutton = new System.Windows.Forms.Button();
            this.parentsButton = new System.Windows.Forms.Button();
            this.AddressButton = new System.Windows.Forms.Button();
            this.motherTextBox = new System.Windows.Forms.TextBox();
            this.fatherTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(111, 262);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(217, 262);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(133, 23);
            this.showbutton.TabIndex = 1;
            this.showbutton.Text = "Show All Information";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click_1);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(199, 51);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.firstNameTextBox.TabIndex = 2;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(199, 90);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.lastNameTextBox.TabIndex = 3;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // namebutton
            // 
            this.namebutton.Location = new System.Drawing.Point(79, 308);
            this.namebutton.Name = "namebutton";
            this.namebutton.Size = new System.Drawing.Size(75, 23);
            this.namebutton.TabIndex = 4;
            this.namebutton.Text = "Name";
            this.namebutton.UseVisualStyleBackColor = true;
            this.namebutton.Click += new System.EventHandler(this.namebutton_Click);
            // 
            // parentsButton
            // 
            this.parentsButton.Location = new System.Drawing.Point(183, 308);
            this.parentsButton.Name = "parentsButton";
            this.parentsButton.Size = new System.Drawing.Size(90, 23);
            this.parentsButton.TabIndex = 5;
            this.parentsButton.Text = "Parents Name";
            this.parentsButton.UseVisualStyleBackColor = true;
            this.parentsButton.Click += new System.EventHandler(this.parentsButton_Click);
            // 
            // AddressButton
            // 
            this.AddressButton.Location = new System.Drawing.Point(304, 308);
            this.AddressButton.Name = "AddressButton";
            this.AddressButton.Size = new System.Drawing.Size(75, 23);
            this.AddressButton.TabIndex = 6;
            this.AddressButton.Text = "Address";
            this.AddressButton.UseVisualStyleBackColor = true;
            this.AddressButton.Click += new System.EventHandler(this.AddressButton_Click);
            // 
            // motherTextBox
            // 
            this.motherTextBox.Location = new System.Drawing.Point(199, 169);
            this.motherTextBox.Name = "motherTextBox";
            this.motherTextBox.Size = new System.Drawing.Size(151, 20);
            this.motherTextBox.TabIndex = 8;
            // 
            // fatherTextBox
            // 
            this.fatherTextBox.Location = new System.Drawing.Point(199, 130);
            this.fatherTextBox.Name = "fatherTextBox";
            this.fatherTextBox.Size = new System.Drawing.Size(151, 20);
            this.fatherTextBox.TabIndex = 7;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(199, 209);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(151, 20);
            this.addressTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Father\'s Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mother\'s Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Address";
            // 
            // PersonalInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.motherTextBox);
            this.Controls.Add(this.fatherTextBox);
            this.Controls.Add(this.AddressButton);
            this.Controls.Add(this.parentsButton);
            this.Controls.Add(this.namebutton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.showbutton);
            this.Controls.Add(this.saveButton);
            this.Name = "PersonalInformation";
            this.Text = "Personal Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showbutton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button namebutton;
        private System.Windows.Forms.Button parentsButton;
        private System.Windows.Forms.Button AddressButton;
        private System.Windows.Forms.TextBox motherTextBox;
        private System.Windows.Forms.TextBox fatherTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

