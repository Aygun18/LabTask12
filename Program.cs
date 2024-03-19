using System.Xml;

namespace LabTask12
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ededi daxil edin: ");
			int num= Convert.ToInt32(Console.ReadLine());
			GetNum(num);

        }
		static void GetNum(int num)
		{

			int num1=0;

			while (num>0)
			{
				//num1=num%10;
				//Console.WriteLine(num1);
				//num /= 10;
				num1 = num1 * 10;
				num1=num1+num%10;
				num = num / 10;
			}
			Console.WriteLine(num1);
           
        }
	}
}