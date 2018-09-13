using Microsoft.AspNetCore.Blazor.Components;
using System;
using System.Collections.Generic;
using Utils;

public class CaesarBase : BlazorComponent
{
    public enum Operations
    {
        Decode,
        Encode
    }

    private enum LetterShiftMode
    {
        Left,
        Right
    }

    public string InputText { get; set; } = "Example String";
    public int Key { get; set; } = 0;
    public Operations Operation { get; set; } = Operations.Encode;
    public string OutputText { get; set; } = null;

    public int LettersCount = Alphabet.Letters.Count;


    public void ConvertInputText()
    {
        if (Operation == Operations.Encode)
        {
            Encode();
        }
        else if (Operation == Operations.Decode)
        {
            Decode();
        }
    }

    private void Encode()
    {
        OutputText = "";
        foreach (char letter in InputText)
        {
            OutputText = OutputText + TransformLetter(letter, LetterShiftMode.Left);
        }
    }

    private void Decode()
    {


        OutputText = "";
        foreach (char letter in InputText)
        {
            OutputText = OutputText + TransformLetter(letter, LetterShiftMode.Right);
        }
    }

    private char TransformLetter(char letter, LetterShiftMode shiftMode)
    {
        if (Alphabet.HasLetter(letter))
        {
            char lowerCaseLetter = Char.ToLower(letter);
            char shiftedLetter = shiftMode == LetterShiftMode.Left ? ShiftLetterLeft(lowerCaseLetter) : ShiftLetterRight(lowerCaseLetter);

            if (Alphabet.IsUpper(letter))
            {
                return Char.ToUpper(shiftedLetter);
            }
            else
            {
                return shiftedLetter;
            }
        }
        else
        {
            return letter;
        }


    }

    private char ShiftLetterLeft(char letter)
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

    private char ShiftLetterRight(char letter)
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


