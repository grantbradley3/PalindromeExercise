using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class Palindrome
    {
        public bool IsAPalindrome(string word)
        {
            var lowerWord = word.ToLower();
            var reversed = "";

            for ( int i = word.Length - 1; i>= 0; i--) 
            {
                reversed += word[i];
            }

            if(reversed.ToLower() == lowerWord)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }

    }
}
