namespace ApiDesafio.Models {
    public class Result {

        public Result(bool status) {
            Status = status;
            Message = "Palavras são primas!";
            if (!status) {
                Message = "Palavras não são primas!";
            }
        }
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
