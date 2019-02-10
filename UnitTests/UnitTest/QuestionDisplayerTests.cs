using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class QuestionDisplayerTests
    {


        [TestInitialize]
        public void TestInitialize()
        {

        }


        private QuestionDisplayer CreateQuestionDisplayer()
        {
            return new QuestionDisplayer();
        }

        [TestMethod]
        public void GetQuestion_StateUnderTest_ExpectedBehavior()
        {
           
            var unitUnderTest = this.CreateQuestionDisplayer();
            int i = 1;

         
            var result = unitUnderTest.GetQuestion(
                i);

            
            Assert.Fail();
        }

        [TestMethod]
        public void CheckAnswer_StateUnderTest_ExpectedBehavior()
        {
          
            var unitUnderTest = this.CreateQuestionDisplayer();
            Answer _currentAnswer = 0;
            Answer _correctAnswer = 0;

           
            var result = unitUnderTest.CheckAnswer(
                _currentAnswer,
                _correctAnswer);

        
            Assert.Fail();
        }
    }
}
