using static System.Net.Mime.MediaTypeNames;

namespace homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入有意義的英文敘述字串");
            string words = Console.ReadLine();
            var result = words.ToLower().Split(' ').GroupBy(w => w);

            Console.WriteLine(string.Join("\n",result.Select(x => $"{x.Key} : {x.Count()}")));
        }
    }
}
