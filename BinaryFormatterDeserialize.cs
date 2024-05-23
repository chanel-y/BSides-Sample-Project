using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.AspNetCore.Http;

namespace CodeQL_Query_Writing_Demo
{
	//TODO: Switch to a safe deserializer
	class BinaryFormatterDeserialize
	{
		public object DoDeserialize(byte[] bytes)
		{
#pragma warning disable SYSLIB0011 // Type or member is obsolete
			BinaryFormatter binaryFormatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
			return binaryFormatter.Deserialize(new MemoryStream(bytes)); 
		}

		public object DoDeserializeHttpReq(HttpRequest req)
		{
#pragma warning disable SYSLIB0011 // Type or member is obsolete
			var formatter = new BinaryFormatter();
            string userInput = req.Body.ToString(); 
            FileStream fs = new FileStream(userInput, FileMode.Create); 

            return formatter.Deserialize(fs);
		}
	}
}
