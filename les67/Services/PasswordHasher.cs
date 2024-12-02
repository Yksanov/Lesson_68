using System;
using System.Security.Cryptography;
using System.Text;

namespace WebApplication3.Services
{
    public class PasswordHasher
    {
        /// <summary>
        /// Метод принимает в себя пароль, после чего производит его хеширование в MD5
        /// </summary>
        /// <param name="password"></param>
        public byte[] Md5HashPassword(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                return md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        /// <summary>
        /// Метод принимает в себя MD5 hash (массив байт)
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns>Возвращается значение хэша в hexCode</returns>
        public string ToHex(byte[] bytes)
        {
            string result = "";
            foreach (byte b in bytes)
            {
                result += b.ToString("x");
            }

            return result;
        }
    }
}