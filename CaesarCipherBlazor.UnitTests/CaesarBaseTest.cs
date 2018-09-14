using System;
using Xunit;


namespace CaesarCipherBlazor.UnitTests
{
    public class CaesarBaseTest
    {
        [Fact]
        public void ConvertInputText_EncodeExampleStringEShift3_SetsOutputTextRight()
        {
            var caesarBase = new CaesarBase();
            caesarBase.InputText = "e";
            caesarBase.Key = 3;
            caesarBase.Operation = CaesarBase.Operations.Encode;
            caesarBase.ConvertInputText();
            Assert.Equal("b", caesarBase.OutputText);
        }

        [Fact]
        public void ConvertInputText_EncodeExampleStringEShift10_SetsOutputUString()
        {
            var caesarBase = new CaesarBase();
            caesarBase.InputText = "e";
            caesarBase.Key = 10;
            caesarBase.Operation = CaesarBase.Operations.Encode;
            caesarBase.ConvertInputText();
            Assert.Equal("u", caesarBase.OutputText);
        }

        [Fact]
        public void ConvertInputText_DecodeExampleStringEShift3_SetsOutputHString()
        {
            var caesarBase = new CaesarBase();
            caesarBase.InputText = "e";
            caesarBase.Key = 3;
            caesarBase.Operation = CaesarBase.Operations.Decode;
            caesarBase.ConvertInputText();
            Assert.Equal("h", caesarBase.OutputText);
        }

        [Fact]
        public void ConvertInputText_EncodeExampleStringShift3_SetsOutputTextRight()
        {
            var caesarBase = new CaesarBase();
            caesarBase.InputText = "example";
            caesarBase.Key = 3;
            caesarBase.Operation = CaesarBase.Operations.Encode;
            caesarBase.ConvertInputText();
            Assert.Equal("buxjmib", caesarBase.OutputText);
        }

        [Fact]
        public void ConvertInputText_EncodeExampleStringComplexShift3_SetsOutputTextRight()
        {
            var caesarBase = new CaesarBase();
            caesarBase.InputText = "Exampýle";
            caesarBase.Key = 3;
            caesarBase.Operation = CaesarBase.Operations.Encode;
            caesarBase.ConvertInputText();
            Assert.Equal("Buxjmýib", caesarBase.OutputText);
        }

    }
}
