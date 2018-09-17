 using CaesarCipherBlazor.Logic;
using System;
using System.Collections.Generic;
using Utils;

public class CaesarBase : Base
{


    protected override char EncodeLetter(char letter)
    {

        if ((Key > (Alphabet.Letters.Count - 1)) || (Key < 0))
        {
            throw new Exception("Key is too big or too small. Out of range error");
        }

        int letterIndex = Alphabet.GetLetterIndex(letter) + Alphabet.Letters.Count;


        List<char> doubleLettersList = new List<char> { };
        doubleLettersList.AddRange(Alphabet.Letters);
        doubleLettersList.AddRange(Alphabet.Letters);

        return doubleLettersList[letterIndex - Key];

    }

    protected override char DecodeLetter(char letter)
    {
        if ((Key > (Alphabet.Letters.Count - 1)) || (Key < 0))
        {
            throw new Exception("Key is too big or too small. Out of range error");
        }

        int letterIndex = Alphabet.GetLetterIndex(letter);

        List<char> doubleLettersList = new List<char> { };
        doubleLettersList.AddRange(Alphabet.Letters);
        doubleLettersList.AddRange(Alphabet.Letters);

        return doubleLettersList[letterIndex + Key];
    }

}


