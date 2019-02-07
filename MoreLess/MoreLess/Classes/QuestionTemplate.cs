using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLess
{
    public enum Answer
    {
        less,
        equals,
        more,
    }
    public class QuestionTemplate
    {
        public string text;
        public Answer correctAnswer;
        public int value;

        public QuestionTemplate(string _text, Answer _correctAnswer, int _value)
        {
            text = _text;
            correctAnswer = _correctAnswer;
            value = _value;

        }

    }
}
