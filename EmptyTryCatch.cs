using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQL_Query_Writing_Demo
{
	internal class EmptyTryCatch
	{
		//TODO: make the catch do something
		public void SomethingCanGoWrong()
		{
			try
			{
				Console.WriteLine("Hello World");
			}
			catch (Exception ex) { }
		}
	}
}
