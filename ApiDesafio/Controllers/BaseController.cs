using ApiDesafio.Models.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDesafio.Controllers {
    [ApiController]
    public abstract class BaseController : ApiResult {

        private readonly ICollection<string> _errors = new List<string>();

        protected ApiResult CustomResponse(object? result = null, int errorStatus = 400) {
            if (IsOperationValid()) {
                return SuccessResult(result);
            }

            return BadResult(errorStatus, new ValidationProblemDetails(new Dictionary<string, string[]>
            {
                { "Messages", _errors.ToArray() }
            }));
        }

        protected ApiResult CustomResponse(int errorStatus = 400) {
            return CustomResponse(null, errorStatus);
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
