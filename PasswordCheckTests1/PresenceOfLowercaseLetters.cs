using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordCheck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCheck.Tests
{
    [TestClass()]
    public class PresenceOfLowercaseLetters
    {
        [TestMethod()]
        public void PasswordFieldCheckTest_qwert1_result2()
        {
            //arrange - 
            string password = "qwert1";
            int resul_test = 2;
            //act
            int actual = PasswordFieldValidation.PasswordFieldCheck(password);
            //assert
            Assert.AreEqual(resul_test, actual);
        }
    }
}