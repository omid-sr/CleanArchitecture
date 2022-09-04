namespace Application.Contract.Extensions
{
    public static class StringExtensions
    {
        public static string ToEnglishNumbers(this string input)
        {
            string[] persian = new string[10] { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };

            for (int j = 0; j < persian.Length; j++)
                input = input.Replace(persian[j], j.ToString());

            return input;
        }

        public static string ToPersianNumbers(this string input)
        {
            string[] persian = new string[10] { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };

            for (int j = 0; j < persian.Length; j++)
                input = input.Replace(j.ToString(), persian[j]);

            return input;
        }

        /// <summary>
        /// Indicates whether the specified string is null or an empty string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>true if the value of the string is null or an empty string, otherwise false.</returns>
        public static bool IsEmpty(this string input)
        {
            return string.IsNullOrEmpty(input);
        }

        /// <summary>
        /// Indicates whether the specified string is null or an empty string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>true if the value of the string is neither null nor an empty string, otherwise false.</returns>
        public static bool IsNotEmpty(this string input)
        {
            return !string.IsNullOrEmpty(input);
        }
    }
}
