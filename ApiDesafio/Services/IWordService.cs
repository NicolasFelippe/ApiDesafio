using ApiDesafio.Models;

namespace ApiDesafio.Services {
    public interface IWordService {

        public Result IsPrimeWord(string wordOne, string wordTwo);
    }
}
