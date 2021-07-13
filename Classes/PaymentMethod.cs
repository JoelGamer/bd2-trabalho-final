using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd2_trabalho_final.Classes
{
    class PaymentMethod : Unique
    {
        private string name;
        private long cardNumber;
        private DateTime expirationDate;
        private int securityNumber;
        private string cardOwnerName;

        public PaymentMethod(int id, string name, long cardNumber, DateTime expirationDate, int securityNumber, string cardOwnerName) : base(id)
        {
            this.name = name;
            this.cardNumber = cardNumber;
            this.expirationDate = expirationDate;
            this.securityNumber = securityNumber;
            this.cardOwnerName = cardOwnerName;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public long CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }

        public int SecurityNumber
        {
            get { return securityNumber; }
            set { securityNumber = value; }
        }

        public string CardOwnerName
        {
            get { return cardOwnerName; }
            set { cardOwnerName = value; }
        }
    }
}
