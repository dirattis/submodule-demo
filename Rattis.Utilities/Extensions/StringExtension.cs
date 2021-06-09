using System.Text.RegularExpressions;

namespace Rattis.Utilities.Extensions
{
    public static class StringExtension
    {
        public static string OnlyNumbers(this string text)
        {
            return Regex.Replace(text, "\\.+|-+", "");
        }
    }
}
