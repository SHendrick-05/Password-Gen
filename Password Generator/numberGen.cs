using System;
using System.Security.Cryptography;
using System.Text;

namespace Password_Generator
{
    public static class numberGen
    {
        // Keyset for checkboxes
        private static string[] keySetArr = new string[4]
        {
            "qwertyuiopasdfghjklzxcvbnm",
            "QWERTYUIOPASDFGHJKLZXCVBNM",
            "0123456789",
            "!\"£$%^&*()-=_+[]{};'#:@~,./<>?"
        };

        // Cryptographically secure random number generator
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

        // Generate an int with an exclusive upper bound, and a lower bound of 0.
        private static int genNumber(int max)
        {
            byte[] buffer = new byte[4];
            rngCsp.GetBytes(buffer);
            int value = Math.Abs(BitConverter.ToInt32(buffer, 0));
            return value % max;
        }

        // Generate a password with the above tools.
        public static string genPassword(int len, bool lower, bool upper, bool num, bool symb)
        {
            // A SB var to hold the result
            StringBuilder result = new StringBuilder();
            // A string form of the keyset using the passed params.
            string keySet =
                (lower ? keySetArr[0] : "")
              + (upper ? keySetArr[1] : "")
              + (num ? keySetArr[2] : "")
              + (symb ? keySetArr[3] : "");
            // Var used for the len of the keyset.
            int setLen = keySet.Length;

            for (int i = 0; i < len; i++)
            {
                // Add random characters from the keyset every time.
                result.Append(keySet[genNumber(setLen)]);
            }
            // Return the result.
            return result.ToString();
        }
    }
}
