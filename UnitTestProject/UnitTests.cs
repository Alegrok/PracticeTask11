using Microsoft.VisualStudio.TestTools.UnitTesting;
using static PracticeTask11.Program;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod01()
        {
            string message = "1001011";
            string encryptedMessage = "1010001";
            Assert.AreEqual(encryptedMessage, GetEncryptedMessage(message));
        }

        [TestMethod]
        public void TestMethod02()
        {
            string encryptedMessage = "1010001";
            string decryptedMessage = "1001011";
            Assert.AreEqual(decryptedMessage, GetDecryptedMessage(encryptedMessage));
        }

        [TestMethod]
        public void TestMethod03()
        {
            string message = "1";
            bool check = CheckInputMessage(message);
            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void TestMethod04()
        {
            string message = "1010abc01";
            bool check = CheckInputMessage(message);
            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void TestMethod05()
        {
            string message = "1010001";
            bool check = CheckInputMessage(message);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestMethod06()
        {
            string message = "1010001101000110100011010001101000110100011010001101000110100011010001101000110100011010001101000110100011010001";
            bool check = CheckInputMessage(message);
            Assert.AreEqual(false, check);
        }
    }
}
