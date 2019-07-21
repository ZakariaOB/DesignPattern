namespace DesignPatterns.StringUtility
{
    public static class StringExtensions
    {
        public static string ToWhatever(this string text)
        {
            var next = "Last comment";
            return text + next + "Zakaria";
        }

        public static string ToUpperString(this string text)
        {
            return text.ToUpper();
        }

        public static string WhatEver()
        {
            return "Zakaria Oka";
        }

        public static string ToUpperString2(this string text)
        {
            if (text == null)
            {
                return null;
            }

            return text.ToUpper();
        }

        public static string ToRemove()
        {
            return "To remove";
        }

        public static string toUpdate()
        {
            return "To update";
        }
    }
}
