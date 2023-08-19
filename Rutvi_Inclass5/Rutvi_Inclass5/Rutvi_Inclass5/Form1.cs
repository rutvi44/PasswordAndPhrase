
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Users;

namespace Rutvi_Inclass5
{
    public partial class Form1 : Form
    {
        private UserManager userManager = new UserManager();
        private List<string> phrases = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGetNewID_Click(object sender, EventArgs e)
        {
            int newId = userManager.GetNewId();
            txtID.Text = newId.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            DateTime dateCreated = dateTimePicker1.Value;

            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(username))
            {
                errors.Add("Username is required.");
            }

            if (password.Length < 6 || !HasLetter(password) || !HasDigit(password) || !HasPunctuation(password))
            {
                errors.Add("Password must be 6 characters or more and contain at least one letter, one digit, and one punctuation symbol.");
            }

            if (dateCreated > DateTime.Now)
            {
                errors.Add("DateCreated cannot be in the future.");
            }

            if (errors.Any())
            {
                lblError.Text = string.Join("\n", errors);
                return;
            }

            lblError.Text = string.Empty; 
            
            int id = int.Parse(txtID.Text);
            Users.Users user = new Users.Users(id, username, password, dateCreated);

            try
            {
                userManager.AddNewUser(user);
                lblError.Text = "User added successfully.";
            }
            catch (Exception ex)
            {
                lblError.Text = $"Error adding user: {ex.Message}";
            }
        }

        private bool HasLetter(string input)
        {
            return input.Any(c => char.IsLetter(c));
        }

        private bool HasDigit(string input)
        {
            return input.Any(c => char.IsDigit(c));
        }

        private bool HasPunctuation(string input)
        {
            return input.Any(c => char.IsPunctuation(c) && !char.IsLetterOrDigit(c));
        }

        private void btnSavePhrase_Click(object sender, EventArgs e)
        {
            string phrase = txtPhrase.Text.Trim();
            phrases.Add(phrase);
            txtPhrase.Clear();
        }

        private void btnShowAllPhrase_Click(object sender, EventArgs e)
        {
            string[] phrasesArray = phrases.ToArray();
            for (int i = 0; i < phrasesArray.Length; i++)
            {
                phrasesArray[i] = RemovePunctuation(phrasesArray[i]);
            }

            Array.Reverse(phrasesArray);

            richTextBox.Text = string.Join("\n", phrasesArray.Select((p, i) => $"{i}: {p}"));
        }

        private string RemovePunctuation(string input)
        {
            return new string(input.Where(c => !char.IsPunctuation(c)).ToArray());
        }
    }
}
