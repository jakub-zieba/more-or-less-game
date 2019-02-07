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
        public class QuestionTemplate
        {
            string text;
            Answer correctAnswer;
            int value;
            public enum Answer
                {
                less,
                equals,
                more,
            }
            public QuestionTemplate(string _text, Answer _correctAnswer, int _value)
            {
                text = _text;
                correctAnswer = _correctAnswer;
                value = _value;

            }

        }
        public QuestionTemplate[] q;
        public bool nextQuestion;
        int value;

        public QuestionTemplate.Answer less = QuestionTemplate.Answer.less;
        public QuestionTemplate.Answer equals = QuestionTemplate.Answer.equals;
        public QuestionTemplate.Answer more = QuestionTemplate.Answer.more;

        public testSettingQuestion()
        {
            q = new QuestionTemplate[100];
            value = 0;
        }
        public string Question(int i)
        {
            q[0] = new QuestionTemplate ("Spanish-flu killed 150 million people.", less , 4);
            q[1] = new QuestionTemplate("Freddie Mercury died in 1992.",;
            q[2] = "the highest point on the world has - 8848m ";
            q[3] = "the lowest point on the worls has 9873m ";
            q[4] = "the heviest  animal on the world wieighs - 100 tons ";
            q[5] = "the smallest country in the world has 1 square kilometer.   ";
            q[6] = "water surface on the planet is 65%  ";
            q[7] = "the highest man in the world was ";
            q[8] = "amazon has 7100km lenght";
            q[9] = "the number of facebook users is 1,500,000,000 ";
            q[10] = "Poland was under 110 years of partition  ";
            q[11] = "the population in Mongolia is 3 millions ";
            q[12] = "elephants live 50 years ";
            q[13] = "43 million people live in Poland ";
            q[14] = "1,5 billions people have no access to water ";

            return q[i];
        }
    }
    
   
}
