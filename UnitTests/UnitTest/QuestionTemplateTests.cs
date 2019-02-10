using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class QuestionTemplateTests
    {
        private string less;
        private int more;
        private Answer equals;

    


        private QuestionTemplate CreateQuestionTemplate()
        {
            return new QuestionTemplate(
                less,
                equals,
                more);
        }

        [TestMethod]
        public void TestMethod1()
        {
           
            var unitUnderTest = this.CreateQuestionTemplate();

           

           
            Assert.Fail();
        }
    }
}
