namespace DesignPatterns.StringUtility
{
    public static class StringExtensions
    {
        public static string ToUpperString(this string text)
        {
            if (text == null)
            {
                return null;
            }

            return text.ToUpper();
        }
    }
}
