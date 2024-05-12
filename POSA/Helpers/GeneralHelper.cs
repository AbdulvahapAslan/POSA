using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSA.Helpers
{
    public static class GeneralHelper
    {
        public static string MD5(this string s)
        {
            var md = System.Security.Cryptography.MD5.Create();
            byte[] data = md.ComputeHash(Encoding.UTF8.GetBytes(s));
            StringBuilder sb = new StringBuilder();
            foreach (var t in data)
                sb.Append(t.ToString("x2"));
            return sb.ToString();
        }
        public static string Base64(this string s)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
        }
        public static string Base64Decrypt(this string s)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(s));
        }
        public static bool TryBase64Decrypt(this string s, out string Veri)
        {
            Veri = string.Empty;
            try
            {
                Veri = Encoding.UTF8.GetString(Convert.FromBase64String(s));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static string ReverseString(this string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
