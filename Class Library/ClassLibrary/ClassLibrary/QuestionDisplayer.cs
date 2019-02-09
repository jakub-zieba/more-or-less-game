using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ClassLibrary
{
    /// <summary>
    /// Rdzeń mechaniczny gry
    /// Zawiera:
    ///   - tworzenie listy losowych pytań z bazy
    ///   - metody wykorzystywane w GameWindow
    ///   - dziedziczy bazę pytań z kalasy nadrzędnej QuestionBase
    /// </summary>
    public class QuestionDisplayer : QuestionBase
    {
        private QuestionTemplate[] questionsToServe;
        private int usedQuestionsAmount = 10;

        public QuestionDisplayer()
        {
            // TODO zamiast statycznie wypełnionej tablicy skorzystać z bazy np
            GenerateQuestionsToServeTable();
        }

        public QuestionTemplate GetQuestion(int i)
        {
            return questionsToServe[i];
        }

        public bool CheckAnswer(Answer _currentAnswer, Answer _correctAnswer)
        {
            if (_currentAnswer == _correctAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void GenerateQuestionsToServeTable()
        {
            questionsToServe = new QuestionTemplate[usedQuestionsAmount + 1];
            List<int> randomNumbers = GenerateRandom(usedQuestionsAmount, possibleQuestionsAmount - 1);

            int i = 0;
            foreach (int number in randomNumbers)
            {
                questionsToServe[i] = questionBase[number];
                i++;
            }

        }

        // https://codereview.stackexchange.com/questions/61338/generate-random-numbers-without-repetitions
        private static List<int> GenerateRandom(int count, int max)
        {
            Random random = new Random();
            // generate count random values.
            HashSet<int> candidates = new HashSet<int>();
            while (candidates.Count < count)
            {
                // May strike a duplicate.
                candidates.Add(random.Next(0, max));
            }

            // load them in to a list.
            List<int> result = new List<int>();
            result.AddRange(candidates);

            // shuffle the results:
            int i = result.Count;
            while (i > 1)
            {
                i--;
                int k = random.Next(i + 1);
                int value = result[k];
                result[k] = result[i];
                result[i] = value;
            }
            return result;
        }
    }
    
   
}
