using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLess
{
    public class testSettingQuestion
    {
        public string[] q;

        public testSettingQuestion()
        {
        q = new string[100];
        }

        public string Metoda()
        {
            q[0] = "o to jest pytanie nr 1";
            return q[0];
        }
    }
}
