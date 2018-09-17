using System;
using Xunit;

namespace CaesarCipherBlazor.UnitTests
{
    public class PolybiusBaseTest
    {
        [Fact]
        public void ConvertInputText_EncodeExampleStringAShift0_SetsOutputTextRight()
        {
            var polybiusBase = new PolybiusBase
            {
                InputText = "a",
                Key = 0,
                Operation = PolybiusBase.Operations.Encode
            };
            polybiusBase.Encode();
            Assert.Equal("11", polybiusBase.OutputText);
        }
    }
}
