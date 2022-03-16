using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class User
    {
        private string _username;
        private string _password;
        public User(string username)
        {
            UserName = username;
        }
        public string UserName
        {
            get
            {
                return this._username;
            }
            set
            {
                if (value.Length >= 6 && value.Length <= 25 && !string.IsNullOrWhiteSpace(value))
                    this._username = value;
            }
        }
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                if (value.Length >= 8 && value.Length <= 25 && HasDigit(value) && HasLower(value) && HasUpper(value) && !string.IsNullOrWhiteSpace(value))
                    this._password = value;
            }
        }
        public
        static bool HasDigit(string pasword)
        {
            for (int i = 0; i < pasword.Length; i++)
            {
                if (char.IsDigit(pasword[i]))
                    return true;
            }

            return false;
        }
        static bool HasLower(string pasword)
        {
            for (int i = 0; i < pasword.Length; i++)
            {
                if (char.IsLower(pasword[i]))
                    return true;
            }

            return false;
        }
        static bool HasUpper(string pasword)
        {
            for (int i = 0; i < pasword.Length; i++)
            {
                if (char.IsUpper(pasword[i]))
                    return true;
            }

            return false;
        }
    }
}

