using _732_1Reverser;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Reverse_12345_54321()
        {
            string input = "12345";
            string required = "54321";

            ReverseManager reverser = new ReverseManager();
            string fact_res = reverser.Reverse(input);

            Assert.AreEqual(required, fact_res);
        }

        [TestMethod]
        public void Reverse_ASDFG_GFDSA()
        {
            string input = "ASDFG";
            string required = "GFDSA";

            ReverseManager reverser = new ReverseManager();
            string fact_res = reverser.Reverse(input);

            Assert.AreEqual(required, fact_res);
        }

        [TestMethod]
        public void Reverse_Reverse()
        {
            string input = "qwerty";

            ReverseManager reverser = new ReverseManager();
            string reversed = reverser.Reverse(input);
            string fact_res = reverser.Reverse(reversed);

            Assert.AreEqual(input, fact_res);
        }
    }
}