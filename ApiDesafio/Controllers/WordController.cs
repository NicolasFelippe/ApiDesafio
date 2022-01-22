using ApiDesafio.Models;
using ApiDesafio.Models.Http;
using ApiDesafio.Utils;

namespace ApiDesafio.Controllers {
    public class WordController : BaseController {

        public ApiResult IsPrimeWord(string wordOne, string wordTwo) {
            try {
                bool isLengthsEquals = wordOne.IsLengthsEquals(wordTwo);
                if (!isLengthsEquals) {
                    return CustomResponse(new Result(isLengthsEquals));
                }

                return CustomResponse(new Result(isLengthsEquals &&
                    wordOne.GetOnlyOdd().VerifyAllCharsIsOdd(wordTwo) &&
                    wordOne.GetOnlyEven().VerifyAllCharsIsEven(wordTwo)));

            } catch (Exception ex) {
                AddError(ex.Message);
                return CustomResponse();
            }
        }
    }
}
