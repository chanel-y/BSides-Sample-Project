using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography; 

namespace CodeQL_Query_Writing_Demo
{
    //TODO: This file uses weak hashes, upgrade to use strong ones like SHA256 
	class WeakHashes { 
        public byte[] Case1()
        {
            SHA1 algorithm = SHA1.Create(); 
            byte[] bytes = Encoding.ASCII.GetBytes("This is a test string");
            byte[] hash = algorithm.ComputeHash(bytes);

            return hash;
        }

		public byte[] Case2()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("This is a test string");

			SHA1CryptoServiceProvider algorithm = new SHA1CryptoServiceProvider();
			byte[] hash = algorithm.ComputeHash(bytes);
            return hash;
        }

        public byte[] Case3() {
            HashAlgorithm MD5 = HashAlgorithm.Create("MD5");
            byte[] bytes = Encoding.ASCII.GetBytes("This is a test string");
            byte[] hash = MD5.ComputeHash(bytes); 
            return hash;
        }
	}
}
