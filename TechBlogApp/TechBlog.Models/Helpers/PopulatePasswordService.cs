using System.Security.Cryptography;
using System.Text;

namespace TechBlog.Models.Helpers
{
    public static class PopulatePasswordService
    {
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hMac = new HMACSHA512(passwordSalt))
            {
                var computerHash = hMac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computerHash.Length; i++)
                {
                    if (computerHash[i] != passwordHash[i]) return false;
                }
            }
            return true;
        }

        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hPass = new HMACSHA512())
            {
                passwordSalt = hPass.Key;
                passwordHash = hPass.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}