using ApiDesafio.Models;
using ApiDesafio.Utils;

namespace ApiDesafio.Services {
    public class WordService : IWordService {
        public Result IsPrimeWord(string wordOne, string wordTwo) {
            bool isLengthsEquals = wordOne.IsLengthsEquals(wordTwo);
            if (!isLengthsEquals) {
                return new Result(isLengthsEquals);
            }

            return new Result(isLengthsEquals &&
                wordOne.GetOnlyOdd().VerifyAllCharsIsOdd(wordTwo) &&
                wordOne.GetOnlyEven().VerifyAllCharsIsEven(wordTwo));
        }
    }
}
