using System;
using CSharp.StdLib;
using Xunit;

namespace CSharp.Tests
{
    public class HelloWorldUnitTest
    {
        [Fact]
        public void PrintHelloWorldTest()
        {
            var helloWorldService = new HelloWorldService();
            Assert.Equal("Hello, World!", helloWorldService.PrintHelloWorld());
        }
    }
}
