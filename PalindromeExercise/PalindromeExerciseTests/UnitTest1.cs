using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("blank", false)]
        [InlineData("Hannah", true)]
        [InlineData("Robert", false)]
        public void MyTest(string word, bool expected)
        {
            var test = new Palindrome();

            bool actual = test.IsAPalindrome(word);

            Assert.Equal(expected, actual); 
        }
    }
}
