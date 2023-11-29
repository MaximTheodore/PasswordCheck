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
    public class MoreThanSevenCharacters
    {
        [TestMethod()]
        public void PasswordFieldCheckTest_AMd1_tiger()
        {
            //arrange - 
            string password = "AMd1_tiger";
            int resul_test = 5;
            //act
            int actual = PasswordFieldValidation.PasswordFieldCheck(password);
            //assert
            Assert.AreEqual(resul_test, actual);
        }
    }
}