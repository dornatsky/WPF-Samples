using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Validation
{
    public class PersonViewModel : IDataErrorInfo
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _email;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get 
            {
                string result = null;

                switch (columnName)
                {
                    case "FirstName":
                        if (string.IsNullOrEmpty(this.FirstName))
                            result = "First Name must not be empty.";
                        break;

                    case "LastName":
                        if (string.IsNullOrEmpty(this.LastName))
                            result = "Last Name must not be empty.";
                        break;
                    
                    case "Age":
                        if (Age<=0) result  ="Age should be a positive integer number.";
                        break;

                    case "Email":
                        if (string.IsNullOrEmpty(this.Email) || !Regex.IsMatch(this.Email, @"[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}", RegexOptions.IgnoreCase))
                            result = "Invalid email address.";
                        break;
                }

                return result;
            }
        }
    }
}
