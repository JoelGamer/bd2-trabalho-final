using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd2_trabalho_final.Classes
{
    class Address : Unique
    {
        private string name;
        private string street;
        private string number;
        private string complement;
        private string observation;

        public Address(int id, string name, string street, string number, string complement, string observation) : base(id)
        {
            this.name = name;
            this.street = street;
            this.number = number;
            this.complement = complement;
            this.observation = observation;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Complement
        {
            get { return complement; }
            set { complement = value; }
        }

        public string Observation
        {
            get { return observation; }
            set { observation = value; }
        }
    }
}
