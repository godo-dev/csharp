using System;
using CSharp.StdLib;
using Xunit;

namespace CSharp.Tests
{
    public class Base64UnitTest
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("Man is distinguished, not only by his reason, but by this singular passion from other animals, which is a lust of the mind, that by a perseverance of delight in the continued and indefatigable generation of knowledge, exceeds the short vehemence of any carnal pleasure.", "TWFuIGlzIGRpc3Rpbmd1aXNoZWQsIG5vdCBvbmx5IGJ5IGhpcyByZWFzb24sIGJ1dCBieSB0aGlzIHNpbmd1bGFyIHBhc3Npb24gZnJvbSBvdGhlciBhbmltYWxzLCB3aGljaCBpcyBhIGx1c3Qgb2YgdGhlIG1pbmQsIHRoYXQgYnkgYSBwZXJzZXZlcmFuY2Ugb2YgZGVsaWdodCBpbiB0aGUgY29udGludWVkIGFuZCBpbmRlZmF0aWdhYmxlIGdlbmVyYXRpb24gb2Yga25vd2xlZGdlLCBleGNlZWRzIHRoZSBzaG9ydCB2ZWhlbWVuY2Ugb2YgYW55IGNhcm5hbCBwbGVhc3VyZS4=")]
        [InlineData("The quick brown fox jumps over the lazy dog", "VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZw==")]
        public void Base64EncodingTest(string text, string expectedOutput)
        {
            var base64 = new Base64Service();
            Console.WriteLine(base64.Base64StringEncode(text));
            Assert.Equal(expectedOutput, base64.Base64StringEncode(text));
        }

        [Theory]
        [InlineData("", "")]
        //[InlineData("123", "")]
        [InlineData("VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZw==", "The quick brown fox jumps over the lazy dog")]
        public void Base64DecodingTest(string text, string expectedOutput)
        {
            var base64 = new Base64Service();

            Assert.Equal(expectedOutput, base64.Base64StringDecode(text));
        }
    }
}
