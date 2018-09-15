using CaesarCipherBlazor.Logic;
using System.Collections.Generic;
using Utils;

public class PolybiusBase : Base
{
    public List<char> alphabetLetters = Alphabet.Letters;
    protected override char DecodeLetter(char letter)
    {
        return 'a';
    }

    protected override char EncodeLetter(char letter)
    {
        return 'b';
    }
}
