using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd2_trabalho_final.Classes
{
    class Person : Unique
    {
        private string name;

        public Person(int id, string name) : base(id)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
