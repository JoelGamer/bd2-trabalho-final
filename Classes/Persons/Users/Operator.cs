using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd2_trabalho_final.Classes.Persons.Users
{
    class Operator : Unique
    {
        private readonly User user;
        private bool isAdministrator;

        public Operator(int id, User user, bool isAdministrator) : base(id)
        {
            this.user = user;
            this.isAdministrator = isAdministrator;
        }

        public User User
        {
            get { return user; }
        }

        public string Name
        {
            get { return user.Name; }
            set { user.Name = value; }
        }

        public string Username
        {
            get { return user.Username; }
            set { user.Username = value; }
        }

        public string Password
        {
            get { return user.Password; }
            set { user.Password = value; }
        }

        public bool IsAdministrator
        {
            get { return isAdministrator; }
            set { isAdministrator = value; }
        }
    }
}
