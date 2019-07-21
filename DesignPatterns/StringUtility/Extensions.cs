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

        public static string AddExtension2()
        {
            return "Extension 2, to know as important as it is";
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

        public static string AddExtension()
        {
            return "Extension 1";
        }
    }
}
