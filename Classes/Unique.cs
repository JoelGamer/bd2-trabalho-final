using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd2_trabalho_final.Classes
{
    class Unique
    {
        private int id;

        public Unique(int id)
        {
            this.id = id;
        }

        public int Id
        {
            get 
            {
                if (id <= 0) throw new Exception("Register doesn't exist");
                return id;
            }
            set
            {
                if (id <= 0) throw new Exception("Invalid value!");
                id = value;
            }
        }
    }
}
