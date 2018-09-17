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
        Console.WriteLine(lettersList.ToArray());

        int column = 1;
        int row = 1;

        int columnItemsCounter = 1;

        for(int i = 0; i < lettersList.Count; i++)
        {
            if (columnItemsCounter > 5)
            {
                columnItemsCounter = 1;
                row = row + 1;
                column = columnItemsCounter;
            } else
            {
                column = columnItemsCounter;
            }
            columnItemsCounter = columnItemsCounter + 1;
            Console.WriteLine("AlphabetLetter: " + lettersList[i] + "  CheckingLetter: " + letter);
            if (lettersList[i] == letter)
            {
                return (row).ToString() + (column).ToString();
            }
        }
        return letter.ToString();
    }
}
