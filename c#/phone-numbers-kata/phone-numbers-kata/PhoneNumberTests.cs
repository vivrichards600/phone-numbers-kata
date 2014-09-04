using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PhoneNumberTests
{

    [TestMethod]
    [ExpectedException(typeof(System.Exception))]
    public void Phone_Number_Must_Be_More_Than_1_Digit()
    {
        Validate.PhoneNumber("1");
    }

}