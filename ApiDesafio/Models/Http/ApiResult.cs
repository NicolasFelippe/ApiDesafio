namespace ApiDesafio.Models.Http {
    public class ApiResult {
        public int StatusCode { get; set; } 
        public object? Data { get; set; }
        public bool Error { get; set; }

        protected ApiResult SuccessResult (object? data) {
            StatusCode = 200; 
            Data = data; 
            Error = false;
            return this;
        }

        protected ApiResult BadResult(int status, object? errors) {
            StatusCode = status;
            Data = errors;
            Error = true;
            return this;
        }
    }
}
