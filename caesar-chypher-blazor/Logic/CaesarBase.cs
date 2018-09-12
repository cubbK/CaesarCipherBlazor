using Microsoft.AspNetCore.Blazor.Components;

public class CaesarBase : BlazorComponent
{

    public string InputText { get; set; } = "Example String";
    public int Key { get; set; } = 1;
    public string OutputText { get; set; } = "";

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
}
