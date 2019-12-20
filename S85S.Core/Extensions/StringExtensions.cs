using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace S85S.Core.Extensions
{
    public static class StringExtensions
    {
        public static T FromJSON<T>(this string s, T defaultValue)
        {
            if (s.IsEmpty())
                return defaultValue;
            try
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(s);
            }
            catch { }
            return defaultValue;
        }

        public static T FromJSON<T>(this string s)
        {
            return s.FromJSON(default(T));
        }

        public static string ReadFileContent(this string s)
        {
            if (s.IsEmpty())
                return string.Empty;
            return File.ReadAllText(s);
        }

        public async static Task<string> ReadFileContentAsync(this string s, Action<string> callBack = null)
        {
            if (s.IsEmpty())
                return string.Empty;
            var content = "";
            await Task.Run(() =>
            {
                content = File.ReadAllText(s);
            });
            callBack?.Invoke(content);
            return content;
        }

        public static void WriteFileContent(this string s, string content)
        {
            if (s.IsEmpty())
                return;
            File.WriteAllText(s, content);
        }

        public async static void WriteFileContentAsync(this string s, string content, Action callBack = null)
        {
            if (s.IsEmpty())
                return;
            await Task.Run(() =>
            {
                File.WriteAllText(s, content);
            });
            callBack?.Invoke();
        }

        public static string MD5Hash(this string s)
        {
            if (s.IsEmpty())
                return s;
            using (var md5 = MD5.Create())
            {
                var result = md5.ComputeHash(Encoding.UTF8.GetBytes(s));
                return Encoding.UTF8.GetString(result);
            }
        }

        public static bool IsEmpty(this string s)
        {
            return s == null || string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s);
        }

        public static bool IsEmail(this string s)
        {
            return s == null || string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s);
        }
    }
}
