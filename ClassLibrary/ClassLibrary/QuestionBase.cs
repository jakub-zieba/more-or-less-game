﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Klasa zawierająca bazę pytań do wykorzystania w grze
    /// </summary>
    public class QuestionBase
    {
        public QuestionTemplate[] questionBase;
        public int possibleQuestionsAmount = 15;

        Answer less = Answer.less;
        Answer equals = Answer.equals;
        Answer more = Answer.more;

        public QuestionBase() {
            
        questionBase = new QuestionTemplate[possibleQuestionsAmount];
        questionBase[0] = new QuestionTemplate("Spanish-flu killed 150 million people.", less, 4);
        questionBase[1] = new QuestionTemplate("Freddie Mercury died in 1992.", less, 1);
        questionBase[2] = new QuestionTemplate("the highest point on the world has - 8848m ", equals, 3);
        questionBase[3] = new QuestionTemplate("the lowest point on the worls has 9873m ", more, 2);
        questionBase[4] = new QuestionTemplate("the heviest  animal on the world wieighs - 100 tons", more, 4);
        questionBase[5] = new QuestionTemplate("the smallest country in the world has 1 square kilometer.", less, 3);
        questionBase[6] = new QuestionTemplate("water surface on the planet is 65%", more, 4);
        questionBase[7] = new QuestionTemplate("the highest man in the world was 272cm ", equals, 3);
        questionBase[8] = new QuestionTemplate("amazon has 7100km lenght", less, 4);
        questionBase[9] = new QuestionTemplate("the number of facebook users is 1,500,000,000", more, 4);
        questionBase[10] = new QuestionTemplate("Poland was under 110 years of partition", more, 5);
        questionBase[11] = new QuestionTemplate("the population in Mongolia is 3 millions", equals, 2);
        questionBase[12] = new QuestionTemplate("elephants live 50 years ", more, 5);
        questionBase[13] = new QuestionTemplate("43 million people live in Poland", less, 4);
        questionBase[14] = new QuestionTemplate("1,5 billions people have no access to water", more, 3);
    }


    }
}
