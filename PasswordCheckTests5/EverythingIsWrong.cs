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
    public class EverythingIsWrong
    {
        [TestMethod()]
        public void PasswordFieldCheckTest_nothing_result0()
        {
            //arrange - 
            string password = "";
            int resul_test = 0;
            //act
            int actual = PasswordFieldValidation.PasswordFieldCheck(password);
            //assert
            Assert.AreEqual(resul_test, actual);
        }
    }
}