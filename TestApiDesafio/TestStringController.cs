using ApiDesafio.Controllers;
using ApiDesafio.Models;
using Xunit;

namespace TestApiDesafio {
    public class TestStringController {

        [Theory]
        [InlineData("sacada", "casada", true)]
        [InlineData("abcd", "cdab", true)]
        public void IsPrimeWord(string wordOne, string wordTwo, bool expectedResult) {
            WordController wordController = new();
            var data = wordController.IsPrimeWord(wordOne, wordTwo).Data;
            if (data != null) {
                Assert.Equal(expectedResult, ((Result)data).Status);
            } else {
                Assert.False(data == null);
            }
        }

        [Theory]
        [InlineData("oi!", "ola", false)]
        [InlineData("abcd", "dcba", false)]
        [InlineData("elvis", "lives", false)]
        public void IsNotPrimeWord(string wordOne, string wordTwo, bool expectedResult) {
            WordController wordController = new();
            var data = wordController.IsPrimeWord(wordOne, wordTwo).Data;
            if (data != null) {
                Assert.Equal(expectedResult, ((Result)data).Status);
            } else {
                Assert.False(data == null);
            }
        }
    }
}