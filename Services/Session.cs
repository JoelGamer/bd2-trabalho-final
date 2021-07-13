using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bd2_trabalho_final.Classes.Persons.Users;

namespace bd2_trabalho_final.Services
{
    static class Session
    {
        private static Client currentClient = null;
        private static Operator currentOperator = null;

        public static Client Client
        {
            get
            {
                ValidateRetrival(false);
                return currentClient;
            }
            set
            {
                if (IsSessionDefined()) throw new Exception("Session is defined!");
                currentClient = value;
            }
        }

        public static Operator Operator
        {
            get
            {
                ValidateRetrival(true);
                return currentOperator;
            }
            set
            {
                if (IsSessionDefined()) throw new Exception("Session is defined!");
                currentOperator = value;
            }
        }

        public static string UserName
        {
            get
            {
                return IsLoggedUserOperator() ? Operator.Name : Client.Name;
            }
        }

        public static void Logout()
        {
            currentOperator = null;
            currentClient = null;
        }

        private static void ValidateRetrival(bool isFromOperator)
        {
            if (!IsSessionDefined()) throw new Exception("Session not instanciated!");

            if (isFromOperator) 
            {
                ValidateOperator();
                return;
            }

            ValidateClient();
        }

        private static void ValidateOperator()
        {
            if (!IsLoggedUserOperator()) throw new Exception("The logged user isn't a operator!");
            if (currentOperator == null) throw new Exception("The user isn't defined!");
        }

        private static void ValidateClient()
        {
            if (IsLoggedUserOperator()) throw new Exception("The logged user isn't a client!");
            if (currentClient == null) throw new Exception("The user isn't defined!");
        }

        private static bool IsSessionDefined()
        {
            return currentClient != null || currentOperator != null;
        }

        public static bool IsLoggedUserOperator()
        {
            if (!IsSessionDefined()) throw new Exception("Session not instanciated!");
            return currentOperator != null;
        }
    }
}
