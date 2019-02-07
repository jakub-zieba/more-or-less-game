using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace MoreLess
{
    public class testSettingQuestion
    {
        public string[] q;
        public bool nextQuestion;
        public testSettingQuestion()
        {
        q = new string[100];
        }
        public string Question(int i)
        {
            q[0] = "o to jest pytanie nr 1";
            q[1] = "costam costam xD iks de de de de";
            return q[i];
            
        }
        public string Metoda(int i)
        {
            return Question(i);
        }
            
    }
}
