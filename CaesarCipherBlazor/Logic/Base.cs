using Microsoft.AspNetCore.Blazor.Components;
using System;
using Utils;

namespace CaesarCipherBlazor.Logic
{
    public abstract class Base: BlazorComponent
    {
        public int LettersCount = Alphabet.Letters.Count;

        public enum Operations
        {
            Decode,
            Encode
        }

        public string InputText { get; set; } = "Example String";
        public string OutputText { get; set; } = null;
        public int Key { get; set; } = 2;
        public Operations Operation { get; set; } = Operations.Encode;


        public virtual void ConvertInputText()
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

        public virtual void Encode()
        {
            OutputText = "";
            foreach (char letter in InputText)
            {
                OutputText = OutputText + TransformLetter(letter, Operations.Encode);
            }
        }
        public virtual void Decode()
        {
            OutputText = "";
            foreach (char letter in InputText)
            {
                OutputText = OutputText + TransformLetter(letter, Operations.Decode);
            }
        }

        protected virtual string TransformLetter(char letter, Operations operation)
        {
            if (Alphabet.HasLetter(letter))
            {
                char lowerCaseLetter = Char.ToLower(letter);
                char shiftedLetter = operation == Operations.Encode ? EncodeLetter(lowerCaseLetter) : DecodeLetter(lowerCaseLetter);

                if (Alphabet.IsUpper(letter))
                {
                    return Char.ToUpper(shiftedLetter).ToString();
                }
                else
                {
                    return shiftedLetter.ToString();
                }
            }
            else
            {
                return letter.ToString();
            }
        }
        protected virtual string TransfromLetter(string letterSequence, Operations operation)
        {
            throw new NotImplementedException();
        }

        protected virtual char EncodeLetter(char letter)
        {
            throw new NotImplementedException();
        }
        protected virtual char DecodeLetter(char letter)
        {
            throw new NotImplementedException();
        }
    }
}
