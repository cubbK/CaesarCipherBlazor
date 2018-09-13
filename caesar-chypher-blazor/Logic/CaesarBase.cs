using Microsoft.AspNetCore.Blazor.Components;
using System;
using Utils;

public class CaesarBase : BlazorComponent
{
    public enum Operations
    {
        Decode,
        Encode
    }
    public string InputText { get; set; } = "Example String";
    public int Key { get; set; } = 1;
    public Operations Operation { get; set; } = Operations.Encode;
    public string OutputText { get; set; } = null;


    public void OnDecreaseKeyClick()
    {
        if (Key > 0)
        {
            Key = Key - 1;
        }
    }

    public void OnIncreaseKeyClick()
    {
        Key = Key + 1;
    }

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
            OutputText = OutputText + EncodeLetter(letter);
        }
    }

    private void Decode()
    {


        OutputText = "DecodedText";
    }

    private char EncodeLetter(char letter)
    {
        if(Alphabet.HasLetter(letter))
        {
            char lowerCaseLetter = Char.ToLower(letter);
            char shiftedLetter =  ShiftLetter(lowerCaseLetter);

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

    private char ShiftLetter (char letter)
    {
        int letterIndex = Alphabet.GetLetterIndex(letter);
        char[] concatenedLettersArray = Alphabet.Letters;


        // remaining letters are enough. No need to concatenate arrays
        if ((Alphabet.Letters.Length - letterIndex) > Key)
        {
            
        }
        return 'a';
    }


}


