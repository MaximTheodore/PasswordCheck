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
    public class PresenceOfDigits
    {
        [TestMethod()]
        public void PasswordFieldCheckTest_7869_result1()
        {
            //arrange - 
            string password = "7869";
            int resul_test = 1;
            //act
            int actual = PasswordFieldValidation.PasswordFieldCheck(password);
            //assert
            Assert.AreEqual(resul_test, actual);
        }
    }
}