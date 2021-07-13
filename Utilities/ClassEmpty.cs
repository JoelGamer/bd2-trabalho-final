using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bd2_trabalho_final.Classes;

namespace bd2_trabalho_final.Utilities
{
    static class ClassEmpty
    {
        public static bool Validate(Unique unique)
        {
            if (unique == null) return false;
            if (unique.Id <= 0) return false;

            return true;
        }
    }
}
