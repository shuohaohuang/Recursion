using Checkers;


namespace CheskersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Name_
        [TestMethod]
        public void String_1_False()
        {
            //arrange
            int length = 1;
            bool result;
            //act
            result = Checker.String(length);

            //assert
            Assert.IsFalse(result);

        }
        [TestMethod]
        public void String_2_True() { }

        [TestMethod]
        public void String_Ints_True() { }
        [TestMethod]
        public void String_SpecialChars_False() { }
        

        [TestMethod]
        public void InRange_999_False() { }
        [TestMethod]
        public void InRange_1000_True() { }



    }
}