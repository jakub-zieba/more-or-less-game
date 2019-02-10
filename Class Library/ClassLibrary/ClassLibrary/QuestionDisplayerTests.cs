using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace ClassLibrary
{
    [TestClass]
    public class QuestionDisplayerTests
    {
        private MockRepository mockRepository;



        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.mockRepository.VerifyAll();
        }

        private QuestionDisplayer CreateQuestionDisplayer()
        {
            return new QuestionDisplayer();
        }

        [TestMethod]
        public void GetQuestion_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateQuestionDisplayer();
            int i = TODO;

            // Act
            var result = unitUnderTest.GetQuestion(
                i);

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void CheckAnswer_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateQuestionDisplayer();
            Answer _currentAnswer = TODO;
            Answer _correctAnswer = TODO;

            // Act
            var result = unitUnderTest.CheckAnswer(
                _currentAnswer,
                _correctAnswer);

            // Assert
            Assert.Fail();
        }
    }
}
