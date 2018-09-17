using System;
using Xunit;

namespace CaesarCipherBlazor.UnitTests
{
    public class PolybiusBaseTest
    {
        [Fact]
        public void Encode_AShift0_OutputTextIs11()
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

        [Fact]
        public void Encode_EShift0_OutputTextIs15()
        {
            var polybiusBase = new PolybiusBase
            {
                InputText = "e",
                Key = 0,
                Operation = PolybiusBase.Operations.Encode
            };
            polybiusBase.Encode();
            Assert.Equal("15", polybiusBase.OutputText);
        }

        [Fact]
        public void Encode_HShift0_OutputTextIs23()
        {
            var polybiusBase = new PolybiusBase
            {
                InputText = "h",
                Key = 0,
                Operation = PolybiusBase.Operations.Encode
            };
            polybiusBase.Encode();
            Assert.Equal("23", polybiusBase.OutputText);
        }

        [Fact]
        public void Encode_ACapitalizedShift0_OutputTextIs11()
        {
            var polybiusBase = new PolybiusBase
            {
                InputText = "A",
                Key = 0,
                Operation = PolybiusBase.Operations.Encode
            };
            polybiusBase.Encode();
            Assert.Equal("11", polybiusBase.OutputText);
        }
    }
}
