using Checkers;


namespace CheskersTest
{
    [TestClass]
    public class UnitTest1
    {

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
        public void InRange_999_Min1000_Max5000_False() { }
        [TestMethod]
        public void InRange_1000_Min1000_Max5000_True() { }
        [TestMethod]
        public void Split_4_4_1() { }
        [TestMethod]
        public void Split_4_0_0() { }
        [TestMethod]
        public void VowelCounter_4vowel_4() { }
        [TestMethod]
        public void VowelsCounter_0vowel_0() { }
    }
}