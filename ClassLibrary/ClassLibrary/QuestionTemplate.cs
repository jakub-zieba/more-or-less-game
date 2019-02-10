using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Zawiera wzór dla pytań używanych w całej aplikacji a także enum będący podstawą
    /// mechanik które funkcjonują w klasach operujących na pytaniach
    /// </summary>
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
