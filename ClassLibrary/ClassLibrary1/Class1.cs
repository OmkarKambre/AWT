using System.Runtime.CompilerServices;

namespace ClassLibrary1
{
    public static class Class1
    {
        public static bool StartsWithUpper(this string? str)
        {
            if (string.IsNullOrEmpty(str)) return false;
            return char.IsUpper(str[0]);
        }
    }
}