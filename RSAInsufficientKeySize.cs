using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography; 

namespace CodeQL_Query_Writing_Demo
{
	class RSAInsufficientKeySize
	{
		//TODO: this file creates weak keys, update keysize to be >2048
		public RSA CreateWeakKey1()
		{
			int weakKeySize = 1024; 
			RSA key = RSA.Create(weakKeySize);
			return key; 
		}

		public RSA CreateWeakKey2()
		{
			int weakKeySize = 1024; 
			RSA key  = CreateKey(weakKeySize);
			return key;
		}

		public RSA CreateKey(int size)
		{
			RSA key = RSA.Create(size);
			return key; 
		}

		public RSA CreateStrongKey()
		{
			int weakKeySize = 2048; 
			RSA key = RSA.Create(weakKeySize);
			return key; 
		}
	}
}
