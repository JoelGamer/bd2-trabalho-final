using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd2_trabalho_final.Classes.Persons.Users
{
    class Client : Unique
    {
        private readonly User user;
        private long cpf;
        private List<Address> addresses = new List<Address>();
        private List<PaymentMethod> paymentMethods = new List<PaymentMethod>();

        public Client(int id, User user, long cpf) : base(id)
        {
            this.user = user;
            this.cpf = cpf;
        }

        public Client(int id, User user, long cpf, List<Address> addresses, List<PaymentMethod> paymentMethods) : base(id)
        {
            this.user = user;
            this.cpf = cpf;
            this.addresses = addresses;
            this.paymentMethods = paymentMethods;
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

        public long CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public List<Address> Addresses
        {
            get { return addresses; }
            set { addresses = value; }
        }

        public List<PaymentMethod> PaymentMethods
        {
            get { return paymentMethods; }
            set { paymentMethods = value; }
        }
    }
}
