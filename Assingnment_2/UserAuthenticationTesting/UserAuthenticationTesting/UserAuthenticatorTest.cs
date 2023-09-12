using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuthenticationTesting
{
    [TestFixture]
    public class UserAuthenticatorTest
    {
        public UserAuthenticator authenticator;

        [SetUp]
        public void Setup()
        {
            authenticator = new UserAuthenticator();
        }

        [Test]
        public void TestUserRegistration()
        {
            Assert.IsTrue(authenticator.RegisterUser("user1", "password1"));
            Assert.IsFalse(authenticator.RegisterUser("user1", "password2")); // User already registered
        }

        [Test]
        public void TestUserLogin()
        {
            authenticator.RegisterUser("user3", "password3");

            Assert.IsTrue(authenticator.LoginUser("user3", "password3"));
            Assert.IsFalse(authenticator.LoginUser("user3", "wrongpassword")); // Invalid password
            Assert.IsFalse(authenticator.LoginUser("nonexistentuser", "password")); // User does not exist
        }

        [Test]
        public void TestPasswordReset()
        {
            authenticator.RegisterUser("user4", "password4");

            Assert.IsTrue(authenticator.ResetPassword("user4", "newpassword"));
            Assert.IsFalse(authenticator.ResetPassword("nonexistentuser", "newpassword")); // User does not exist
        }
    }
}
