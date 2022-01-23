using ApiDesafio.Models;
using ApiDesafio.Models.Http;
using ApiDesafio.Services;
using ApiDesafio.Utils;
using Microsoft.AspNetCore.Mvc;

namespace ApiDesafio.Controllers {
    [Route("/api/test-words")]
    public class WordController : BaseController {

        private readonly IWordService _wordService;
        public WordController(IWordService wordService) {
            _wordService = wordService;
        }
        [HttpGet("{wordOne}/{wordTwo}")]
        public ApiResult IsPrimeWord(string wordOne, string wordTwo) {
            try {
                return CustomResponse(_wordService.IsPrimeWord(wordOne, wordTwo));
            } catch (Exception ex) {
                AddError(ex.Message);
                return CustomResponse(500);
            }
        }
    }
}
