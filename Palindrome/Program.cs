using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
	class Program
	{
		static void Main(string[] args)
		{
			Palindrome();
			Bekle();

		}
		static void Bekle()
		{
			Console.ReadKey();
		}
		static void EkranaYaz(string metin)
		{
			Console.WriteLine(metin);
		}
		static void EkranaYaz(int sayi)
		{
			EkranaYaz(sayi.ToString());
		}
		static string EkrandanOku()
		{
			return Console.ReadLine();
		}

		static void Palindrome()
		{
			EkranaYaz("Bir tamsayı giriniz: ");
			string metin = EkrandanOku();
			int metin1;

			bool donustuMu = int.TryParse(metin, out metin1);

			if (!donustuMu)
			{
				EkranaYaz("Lütfen doğru formatta bir sayı yazınız.");
			}
			else
			{
				string revs = "";
				for (int i = metin.Length - 1; i >= 0; i--)
				{
					revs += metin[i].ToString();
				}
				if (revs == metin)
				{
					EkranaYaz("Girdiğiniz sayı bir palindromdur.");
				}
				else
				{
					EkranaYaz("Girdiğiniz sayı bir palindrom değildir.");
				}
			}
			if (metin=="exit")
			{
				Environment.Exit(0);
			}
		}
	}
}
	
