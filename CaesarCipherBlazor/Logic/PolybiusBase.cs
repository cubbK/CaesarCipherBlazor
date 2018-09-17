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

    private readonly int NumberOfColumns = 5;
    private readonly int NumberOfRows = 6;

    protected override string TransformLetter(char letter, Operations operation)
    {
        // in polybius case if there is only a char then there need to be a encoding operation
        if (Alphabet.HasLetter(letter))
        {
            char lowerCaseLetter = Char.ToLower(letter);
            string encodedLetter = EncodeLetter(lowerCaseLetter);
            return encodedLetter;
        }
        else
        {
            return letter.ToString();
        }
    }

    protected override char DecodeLetter(char letter)
    {
        Console.WriteLine(letter);
        return 'a';
    }


    protected new string EncodeLetter(char letter)
    {
        for(int column = 0; column < NumberOfColumns; column++)
        {
            for(int row=0; row < NumberOfRows; row++)
            {
                int letterPos = column * row;
                if (lettersList[letterPos] == letter)
                {
                    return (column + 1).ToString() + (row+1).ToString();
                }
            }
        }
        return letter.ToString();
    }
}
