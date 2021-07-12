using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bd2_trabalho_final.Enums;

namespace bd2_trabalho_final.Classes.Persons.Users
{
    class User : Unique
    {
        private readonly Person person;
        private UserType userType;

        public User(int id, Person person, UserType userType) : base(id)
        {
            this.person = person;
            this.userType = userType;
        }

        public Person Person
        {
            get { return person; }
        }

        public string Name
        {
            get { return person.Name; }
            set { person.Name = value; }
        }

        public UserType UserType
        {
            get { return userType; }
            set { userType = value; }
        }
    }
}
