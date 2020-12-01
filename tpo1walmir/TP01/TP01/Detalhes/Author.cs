using System;
using System.Collections.Generic;
using System.Text;

namespace TP01.Detalhes
{
    class Author
    {
        private string name;
        private string email;
        private char gender;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public override string ToString()
        {
            return "Nome: " + name + " Email: " + email + " Gender: " + gender;
        }
    }
}
