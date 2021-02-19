using Microsoft.Extensions.Logging;
using System;
using WebPlataform.Src.Extensions;
using Xunit;

namespace WebPlataformTeste
{
    public class StringExtensionsTest
    {

        [Theory]
        [InlineData("Teste","Teste")]
        [InlineData("TESTE","Teste")]
        [InlineData("tESTE","Teste")]
        [InlineData("TES4te","Tes4te")]
        [InlineData("45Est", "45est")]
        public void ToCaptalizeTest(string arg,string result)
        {
            string temp = arg.ToCaptalize();
            Assert.Equal(arg.ToCaptalize(), result);
        }
    }
}
