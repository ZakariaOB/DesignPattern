namespace DesignPatterns.StringUtility
{
    public static class StringExtensions
    {
        public static string ToUpperString(this string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return null;
            }

            return text.ToUpper();
        }

        public static string[] ToArray(this string text, char separator)
        {
            if (string.IsNullOrEmpty(text))
            {
                return null;
            }

            var tab = text.Split(new char[] { '-' });
            return tab;
        }
    }
}
