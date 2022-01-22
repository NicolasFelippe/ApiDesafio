namespace ApiDesafio.Utils {
    public static class StringUtils {
        public static string GetOnlyEven (this string value) {
            return string.Concat(value.Where((c, i) => i.IsEven()));
        }

        public static string GetOnlyOdd(this string value) {
            return string.Concat(value.Where((c, i) => i.IsOdd()));
        }

        public static bool VerifyAllCharsIsOdd(this string value, string word) {
            return value.All(x => word.IndexOf(x).IsOdd());
        }

        public static bool VerifyAllCharsIsEven(this string value, string word) {
            return value.All(x => word.IndexOf(x).IsEven());
        }
        public static bool IsLengthsEquals(this string value, string word) {
            return value.Length == word.Length;
        }
    }
}
