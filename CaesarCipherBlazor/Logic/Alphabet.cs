using System;
using System.Collections.Generic;

namespace Utils
{
    class Alphabet
    {
        public static List<char> Letters = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        public static bool HasLetter(char letter)
        {
            char lowerLetter = Char.ToLower(letter);
            if(Letters.FindIndex(f => f == lowerLetter) > -1)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static bool IsUpper (char letter)
        {
            if(Char.ToUpper(letter) == letter)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static int GetLetterIndex (char letter)
        {
            char lowerLetter = Char.ToLower(letter);
            return Letters.FindIndex(f => f == lowerLetter);
        } 
    }
  
}
