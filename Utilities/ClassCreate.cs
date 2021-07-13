using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bd2_trabalho_final.Enums;
using bd2_trabalho_final.Classes.Persons;
using bd2_trabalho_final.Classes.Persons.Users;

namespace bd2_trabalho_final.Utilities
{
    static class ClassCreate
    {
        public static User GenerateUser(string name, UserType userType, string username, string password)
        {
            Person person = new Person(0, name);
            return new User(0, person, userType, username, password);
        }

        public static Client GenerateClient(string name, string username, string password, long cpf)
        {
            User user = GenerateUser(name, UserType.Client, username, password);
            return new Client(0, user, cpf);
        }

        public static Operator GenerateOperator(string name, string username, string password, bool isAdministrator)
        {
            User user = GenerateUser(name, UserType.Operator, username, password);
            return new Operator(0, user, isAdministrator);
        }

        public static Operator GenerateOperator(int id, string name, string username, string password, bool isAdministrator)
        {
            User user = GenerateUser(name, UserType.Operator, username, password);
            return new Operator(id, user, isAdministrator);
        }
    }
}
