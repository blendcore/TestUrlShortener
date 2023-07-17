using System;
using Microsoft.AspNetCore.WebUtilities;

namespace TestUrlShortener.Helpers
{
    public class ShortUrlHelper
    {
        public static string Encode(int num)
        {
            return WebEncoders.Base64UrlEncode(BitConverter.GetBytes(num));
        }

        public static int Decode(string str)
        {
            return BitConverter.ToInt32(WebEncoders.Base64UrlDecode(str));
        }
    }
}