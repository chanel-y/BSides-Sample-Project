using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CodeQL_Query_Writing_Demo
{
	class HardcodedEncryptionKey
	{
		public void Case1()
		{
			string someHardcodedString = "thisisabadhardcodedkeybadbadbad";
			byte[] badHardcodedKey = Encoding.ASCII.GetBytes(someHardcodedString);
			AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			aesCryptoServiceProvider.Key = badHardcodedKey;
		}

		public byte[] Case2(byte[] iv, byte[] rawPlaintext, byte[] cipherText)
		{
			string someHardcodedString = "thisisabadhardcodedkeybadbadbad";
			byte[] badHardcodedKey = Encoding.ASCII.GetBytes(someHardcodedString);
			
            using (Aes aes = new AesCng())
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(badHardcodedKey, iv), CryptoStreamMode.Write))
                    {
                        cs.Write(rawPlaintext, 0, rawPlaintext.Length);
                    }

                    cipherText = ms.ToArray();
                }

                return cipherText;
            }
		}
	}
}
