using System.Dynamic;

namespace homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal taxRate = 0;
            decimal progressiveDifference = 0;
            decimal totalTax = 0;

            Console.Write("請輸入年收入：");
            decimal money = decimal.Parse(Console.ReadLine());

            if (money<0)
            {
                Console.WriteLine("請勿輸入0以下的數字");
            }

            if (money <= 540000)
            {
                taxRate = 0.05m;
                progressiveDifference = 0;
            }
            else if (money <= 1210000)
            {
                taxRate = 0.12m;
                progressiveDifference = 37800;
            }
            else if (money <= 2420000)
            {
                taxRate = 0.20m;
                progressiveDifference = 134600;
            }
            else if (money <= 4530000)
            {
                taxRate = 0.30m;
                progressiveDifference = 376600;
            }
            else if (money <= 10310000)
            {
                taxRate = 0.40m;
                progressiveDifference = 829600;
            }
            else
            {
                taxRate = 0.50m;
                progressiveDifference = 1860600;
            }

            totalTax = (money * taxRate) - progressiveDifference;

            Console.WriteLine(totalTax);
        }
    }
}
