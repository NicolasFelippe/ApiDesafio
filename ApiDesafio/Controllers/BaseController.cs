using ApiDesafio.Models.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDesafio.Controllers {
    public abstract class BaseController : ApiResult {

        private readonly ICollection<string> _errors = new List<string>();

        protected ApiResult CustomResponse(object? result = null) {
            if (IsOperationValid()) {
                return SuccessResult(result);
            }

            return BadResult(400 ,new ValidationProblemDetails(new Dictionary<string, string[]>
            {
                { "Messages", _errors.ToArray() }
            }));
        }

        protected bool IsOperationValid() {
            return !_errors.Any();
        }

        protected void AddError(string erro) {
            _errors.Add(erro);
        }

        protected void ClearErrors() {
            _errors.Clear();
        }
    }
}
