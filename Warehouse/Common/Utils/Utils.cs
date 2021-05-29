using System.Text;
using System.Text.RegularExpressions;

namespace Common
{
    class Utils
    {
        public const string phoneFormat = "+380ХХХХХХХХХ";
        private const string phoneRegex = @"\+380\d{9}$";
        static public string toMD5(string str)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(str);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        static public bool checkPhoneFormat(string phone)
        {
            if (!Regex.IsMatch(phone, phoneRegex))
            {
                return false;
            }
            return true;
        }
    }
}
