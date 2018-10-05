using System;

namespace PalindromosTests
{
    public class PalindromeValidator
    {
        public bool IsPalindrome(string testString)
        {
            if (testString == null)
                throw new ArgumentNullException("String cannot be null");

            for(var i = 0; i < testString.Length / 2; i++)
            {
                if (testString[i] != testString[testString.Length - i - 1])
                    return false;
            }
            return true;
        }
    }
}