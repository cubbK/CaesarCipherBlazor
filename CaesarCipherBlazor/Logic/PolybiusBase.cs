using Microsoft.AspNetCore.Blazor.Components;
using System;
using System.Collections.Generic;
using Utils;

public class PolybiusBase : BlazorComponent
{
    public enum Operations
    {
        Decode,
        Encode
    }

    public string InputText { get; set; } = "Example String";
    public int Key { get; set; } = 0;
    public Operations Operation { get; set; } = Operations.Encode;
    public string OutputText { get; set; } = null;
    public List<char> alphabetLetters = Alphabet.Letters;
}
