
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Users
{
    public class UserManager
    {
        private string filename = "users.txt";

        public UserManager()
        {
            if (!File.Exists(filename))
            {        
                File.Create(filename).Close();
            }
        }

        public int GetNewId()
        {
            int newId = 1;

            if (File.ReadAllLines(filename).Length == 0)
            {
                return newId;
            }

            List<Users> existingUsers = ReadUsersFromFile();

            if (existingUsers.Count > 0)
            {
                int maxId = existingUsers.Max(user => user.Id);
                newId = maxId + 1;
            }

            return newId;
        }

        public void AddNewUser(Users user)
        {
            try
            {
                File.AppendAllLines(filename, new[] { user.ToString() });
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding user.", ex);
            }
        }

        private List<Users> ReadUsersFromFile()
        {
            List<Users> users = new List<Users>();

            try
            {
                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');

                    if (parts.Length == 4)
                    {
                        int id = int.Parse(parts[0]);
                        string username = parts[1];
                        string password = parts[2];
                        DateTime dateCreated = DateTime.Parse(parts[3]);

                        Users user = new Users(id , username, password, dateCreated);
                        users.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading users from file.", ex);
            }

            return users;
        }
    }
}
