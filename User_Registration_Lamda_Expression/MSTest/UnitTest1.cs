using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using User_Registration_Lamda_Expression;

namespace MSTest
{

    [TestClass]
    public class MSTestUserRegistration

    {
        private readonly User_Registration_Pattern User;
        public MSTestUserRegistration()
        {
            User = new User_Registration_Pattern(); //create object
        }
        //validate first name
        [TestMethod]
        public void validateFirstName()
        {
            var Result = User.ValidateFirstName("Nilima");
            Assert.AreEqual(true, Result);
        }
        [TestMethod]
        public void validateLastName()
        {
            var Result = User.ValidateLastName("Wadal");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateEmail()
        {
            var Result = User.ValidateEmail("naina@gmail.com");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateMobile()
        {
            var Result = User.ValidateMobile("91 9898989898");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidatePassword()
        {
            var Result = User.ValidatePassword("Nainu@12345");
            Assert.AreEqual(true, Result);

        }

        /// <summary>
        /// Validation using lambda expressions
        /// </summary>
        [TestMethod]
        public void FirstNameUsingLambdaExpression()
        {
            var Result = User.ValidateFirstName("Rushu");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void LastNameUsingLambdaExpression()
        {
            var Result = User.ValidateLastName("Shelke");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void EmailUsingLambdaExpression()
        {
            var Result = User.ValidateEmail("rushu@gmail.com");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void MobileNumberUsingLabdaExpression()
        {
            var Result = User.ValidateMobile("91 9988776655");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void PasswordUsingLambdaExpression()
        {
            var Result = User.ValidatePassword("Nilima@96");
            Assert.AreEqual(true, Result);
        }
    }
}
