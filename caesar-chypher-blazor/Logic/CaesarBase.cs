using Microsoft.AspNetCore.Blazor.Components;

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


    public void OnDecreaseKeyClick ()
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

    public void ConvertInputText ()
    {
        if(Operation == Operations.Encode)
        {
            Encode();
        }
        else if (Operation == Operations.Decode)
        {
            Decode();
        }
    }

    private void Encode ()
    {
        OutputText = "EncodedText";
    }

    private void Decode ()
    {
        OutputText = "DecodedText";
    }
}
