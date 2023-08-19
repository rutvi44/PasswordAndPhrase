namespace Rutvi_Inclass5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            btnAddNewUser = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnGetNewID = new Button();
            txtID = new TextBox();
            label1 = new Label();
            lblError = new Label();
            groupBox2 = new GroupBox();
            richTextBox = new RichTextBox();
            btnShowAllPhrase = new Button();
            btnSavePhrase = new Button();
            txtPhrase = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(btnAddNewUser);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnGetNewID);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(683, 519);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New User:";
            groupBox1.UseCompatibleTextRendering = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(190, 320);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(422, 34);
            dateTimePicker1.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(190, 235);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(421, 34);
            txtPassword.TabIndex = 8;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(190, 151);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(421, 34);
            txtUserName.TabIndex = 7;
            // 
            // btnAddNewUser
            // 
            btnAddNewUser.BackColor = SystemColors.ActiveCaption;
            btnAddNewUser.Location = new Point(221, 417);
            btnAddNewUser.Name = "btnAddNewUser";
            btnAddNewUser.Size = new Size(257, 63);
            btnAddNewUser.TabIndex = 6;
            btnAddNewUser.Text = "Add New User";
            btnAddNewUser.UseVisualStyleBackColor = false;
            btnAddNewUser.Click += btnAddNewUser_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 326);
            label4.Name = "label4";
            label4.Size = new Size(130, 28);
            label4.TabIndex = 5;
            label4.Text = "Date Created:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 235);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 157);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 3;
            label2.Text = "UserName:";
            // 
            // btnGetNewID
            // 
            btnGetNewID.BackColor = SystemColors.ActiveCaption;
            btnGetNewID.Location = new Point(453, 67);
            btnGetNewID.Name = "btnGetNewID";
            btnGetNewID.Size = new Size(167, 49);
            btnGetNewID.TabIndex = 2;
            btnGetNewID.Text = "Get New ID";
            btnGetNewID.UseVisualStyleBackColor = false;
            btnGetNewID.Click += btnGetNewID_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(190, 68);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 34);
            txtID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 71);
            label1.Name = "label1";
            label1.Size = new Size(35, 28);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(57, 619);
            lblError.Name = "lblError";
            lblError.Size = new Size(59, 28);
            lblError.TabIndex = 1;
            lblError.Text = "Error:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox);
            groupBox2.Controls.Add(btnShowAllPhrase);
            groupBox2.Controls.Add(btnSavePhrase);
            groupBox2.Controls.Add(txtPhrase);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(866, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(630, 518);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Other Stuff:";
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(59, 248);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(550, 192);
            richTextBox.TabIndex = 4;
            richTextBox.Text = "";
            // 
            // btnShowAllPhrase
            // 
            btnShowAllPhrase.BackColor = SystemColors.ActiveCaption;
            btnShowAllPhrase.Location = new Point(376, 156);
            btnShowAllPhrase.Name = "btnShowAllPhrase";
            btnShowAllPhrase.Size = new Size(233, 52);
            btnShowAllPhrase.TabIndex = 3;
            btnShowAllPhrase.Text = "Show All Phrase";
            btnShowAllPhrase.UseVisualStyleBackColor = false;
            btnShowAllPhrase.Click += btnShowAllPhrase_Click;
            // 
            // btnSavePhrase
            // 
            btnSavePhrase.BackColor = SystemColors.ActiveCaption;
            btnSavePhrase.Location = new Point(36, 156);
            btnSavePhrase.Name = "btnSavePhrase";
            btnSavePhrase.Size = new Size(193, 52);
            btnSavePhrase.TabIndex = 2;
            btnSavePhrase.Text = "Save Phrase";
            btnSavePhrase.UseVisualStyleBackColor = false;
            btnSavePhrase.Click += btnSavePhrase_Click;
            // 
            // txtPhrase
            // 
            txtPhrase.Location = new Point(156, 78);
            txtPhrase.Name = "txtPhrase";
            txtPhrase.Size = new Size(453, 34);
            txtPhrase.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 78);
            label5.Name = "label5";
            label5.Size = new Size(73, 28);
            label5.TabIndex = 0;
            label5.Text = "Phrase:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1632, 823);
            Controls.Add(groupBox2);
            Controls.Add(lblError);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnGetNewID;
        private TextBox txtID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAddNewUser;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label lblError;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox txtPhrase;
        private Button btnSavePhrase;
        private Button btnShowAllPhrase;
        private RichTextBox richTextBox;
        private DateTimePicker dateTimePicker1;
    }
}