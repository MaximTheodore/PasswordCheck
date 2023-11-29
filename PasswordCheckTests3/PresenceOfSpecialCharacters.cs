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
    public class PresenceOfSpecialCharacters
    {
        [TestMethod()]
        public void PasswordFieldCheckTest_AMd1_()
        {
            //arrange - 
            string password = "AMd1_";
            int resul_test = 4;
            //act
            int actual = PasswordFieldValidation.PasswordFieldCheck(password);
            //assert
            Assert.AreEqual(resul_test, actual);
        }
    }
}