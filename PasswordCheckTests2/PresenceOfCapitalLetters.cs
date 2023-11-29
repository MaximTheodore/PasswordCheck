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
    public class PresenceOfCapitalLetters
    {
        [TestMethod()]
        public void PasswordFieldCheckTest_AMDw1_result3()
        {
            //arrange - 
            string password = "AMDw1";
            int resul_test = 3;
            //act
            int actual = PasswordFieldValidation.PasswordFieldCheck(password);
            //assert
            Assert.AreEqual(resul_test, actual);
        }
    }
}