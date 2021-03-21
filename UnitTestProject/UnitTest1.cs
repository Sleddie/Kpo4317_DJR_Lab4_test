using System;
using ApplicationLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodRun()
        {
            var target = new ApplicationClass();

            string current_status = target.DirectRun("Jamil");
            string expected_status = "success";
            Assert.AreEqual(expected_status, current_status);
        }

        [TestMethod]
        public void TestLauncherRun()
        {
            var target = new ApplicationClass();

            string current_status = target.RunLauncher();
            string expected_status = "success";
            Assert.AreEqual(expected_status, current_status);
        }

        [TestMethod]
        public void HypotenuseCalculatingTest()
        {
            var target = new ApplicationClass();

            double expected = 5.0;
            double actual = target.Hypotenuse(3.0, 4.0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DecoderTest()
        {
            var target = new ApplicationClass();

            char expected = 'A';
            char actual = target.SymbolFromCode(65);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToSecondsTest()
        {
            var target = new ApplicationClass();

            int expected = 645782463;
            int[] time_array = new int[5] { 20, 174, 8, 1, 3 };
            int actual = target.HowmuchSeconds(time_array);
            Assert.AreEqual(expected, actual);
        }
    }
}
