using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{

		}
		public static bool FirstMethod(string str)
		{
			int i = 0;
			int j = str.Length - 1;

			while (i < j)
			{
				if (str[i] != str[j])
					return false;

				i++;
				j--;
			}

			return true;
		}
	}
}
