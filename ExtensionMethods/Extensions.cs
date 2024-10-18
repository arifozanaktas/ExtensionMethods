using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods;
internal static class Extensions
{
    public static string GetFirstCharacter(this string input)
    {
        return input.Substring(0, 1);
    }
    public static string GetSeoUrl(this string text)
    {
        text = text.Replace(" ","-").ToLower();
        return text;
    }
}
