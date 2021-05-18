using System;
using System.Collections.Generic;
using System.Text;

namespace testprojekt.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public bool CheckInformation()
        {
            var isUserNameOk = String.IsNullOrWhiteSpace(Username) ? false : Username.Equals("Leon", StringComparison.InvariantCultureIgnoreCase);
            var isPassWordOk = String.IsNullOrWhiteSpace(Password) ? false : Password.Equals("Test", StringComparison.CurrentCulture);

            //var isOk = false;
            //if (String.IsNullOrWhiteSpace(Username))
            //{
            //    isOk = false;
            //}
            //else
            //{
            //    isOk = Username.Equals("Leon", StringComparison.InvariantCultureIgnoreCase);
            //}

            return isUserNameOk && isPassWordOk;
        }
    }
}
