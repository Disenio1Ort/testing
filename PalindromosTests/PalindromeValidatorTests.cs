using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromosTests
{
    [TestFixture]
    public class PalindromeValidatorTests
    {
        PalindromeValidator validator;
        string connectionString;

        public class TestIsPalindrome : PalindromeValidatorTests
        {
            [Test]
            public void TestEmptyStringIsPalindrome()
            {
                bool result = validator.IsPalindrome(string.Empty);
                Assert.IsTrue(result);
            }

            [Test]
            public void TestSingleLetterIsPalindrome()
            {
                bool result = validator.IsPalindrome("a");
                Assert.IsTrue(result);
            }

            [Test]
            public void TestTwoSameLettersIsPalindrome()
            {
                bool result = validator.IsPalindrome("AA");
                Assert.IsTrue(result);
            }

            [Test]
            public void TestTwoDifferentLettersIsNotPalindrome()
            {
                bool result = validator.IsPalindrome("AB");
                Assert.IsFalse(result);
            }

            [Test]
            public void TestThreeLettersFirstAndLastEqualIsPalindrome()
            {
                bool result = validator.IsPalindrome("ABA");
                Assert.IsTrue(result);
            }

            [Test]
            public void TestThreeLettersFirstAndLastDifferentIsNotPalindrome()
            {
                bool result = validator.IsPalindrome("ABC");
                Assert.IsFalse(result);
            }

            [Test]
            public void TestNRandomLettersIsNotPalindrome()
            {
                bool result = validator.IsPalindrome("AABBIWBBAA");
                Assert.IsFalse(result);
            }

            [Test]
            public void TestNLengthPalindromeIsCorrectlyValidated()
            {
                bool result = validator.IsPalindrome("AABBDECCEDBBAA");
                Assert.IsTrue(result);
            }

            [Test]
            public void TestNullArgumentThrowsException()
            {
                Assert.Throws<ArgumentNullException>(CallWithNullArgument);
            }

            public void CallWithNullArgument()
            {
                validator.IsPalindrome(null);
            }
        }

        [OneTimeSetUp]
        public void InitializeTests()
        {
            connectionString = "database=;user;password;";
        }

        [SetUp]
        public void Setup()
        {
            //inicializo DB
            validator = new PalindromeValidator();
        }

        [TearDown]
        public void TearDown()
        {
            //limpio DB
        }
    }
}
