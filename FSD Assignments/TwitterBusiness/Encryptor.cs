using System.Security.Cryptography;
using System.Text;

namespace FSD_Assignments.Common
{
    public class Encryptor
    {
        internal static byte[] MD5Hash(string passwordHash)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(passwordHash));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return result;
        }
    }
}