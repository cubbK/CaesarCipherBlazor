using CaesarCipherBlazor.Logic;
using System;
using System.Collections.Generic;
using Utils;

public class PolybiusBase : Base
{
    private readonly List<char> lettersList = Alphabet.Letters;
    public List<char> LettersShifted {
        get
        {
            Console.WriteLine(Key);
            List<char> shiftedList = new List<char> { };

            for(int i = Key; i < lettersList.Count; i++)
            {
                shiftedList.Add(lettersList[i]);
            }
            for(int i = 0; i < Key; i++)
            {
                shiftedList.Add(lettersList[i]);
            }

            return shiftedList;
        } 
    }

    protected override char DecodeLetter(char letter)
    {
        Console.WriteLine(letter);
        return 'a';
    }

    protected override char EncodeLetter(char letter)
    {
        Console.WriteLine(letter);
        return 'b';
    }
}
