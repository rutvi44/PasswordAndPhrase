
using System;
using System.Collections.Generic;
using System.Linq;

namespace Users
{
    public class Users
    {
        private static List<int> existingIds = new List<int>();

        public int Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public DateTime DateCreated { get; private set; }

        public Users(int id, string username, string password, DateTime dateCreated)
        {
            ValidateId(id);
            ValidateUsername(username);
            ValidatePassword(password);
            ValidateDateCreated(dateCreated);

            Id = id;
            Username = username;
            Password = password;
            DateCreated = dateCreated;
            existingIds.Add(id);
        }

        private void ValidateId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id must be a positive integer.");
            }

            if (existingIds.Contains(id))
            {
                throw new ArgumentException("Id must be unique across all User objects.");
            }
        }

        private void ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Username is required and cannot be empty.");
            }
        }

        private void ValidatePassword(string password)
        {
            if (password.Length < 6)
            {
                throw new ArgumentException("Password must be 6 characters or more.");
            }

            if (!HasLetter(password) || !HasDigit(password) || !HasPunctuation(password))
            {
                throw new ArgumentException("Password must contain at least one letter, one digit, and one punctuation symbol.");
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

        private void ValidateDateCreated(DateTime dateCreated)
        {
            if (dateCreated > DateTime.Now)
            {
                throw new ArgumentException("DateCreated cannot be in the future.");
            }
        }

        public override string ToString()
        {
            return $"{Id};{Username};{Password};{DateCreated}";
        }
    }
}
