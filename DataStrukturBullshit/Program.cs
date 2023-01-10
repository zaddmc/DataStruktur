using System.Globalization;

namespace DataStrukturBullshit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "cat", "something", "car", "fish", "boat", "potato" };
            string index = "car";
            int chanI = 2;

            Console.WriteLine(Opgave1_1(strings, index));

        }
        static private int Opgave1_1(string[] zeArray, string zeString)
        {
            int zeIndex = -1;
            for (int i = 0; i < zeArray.Length; i++)
            {
                if (zeArray[i] == zeString)
                {
                    zeIndex = i;
                    break;
                }
            }
            return zeIndex;
        }
        static private (bool, string[]) Opgave1_2(string[] zeArray, int zeIndex)
        {
            string[] newArray = new string[zeArray.Length - 1];

            if (zeIndex <= zeArray.Length)
            {
                for (int i = 0; i < zeArray.Length; i++)
                {
                    if (i == zeIndex)
                        continue;
                    if (zeIndex > i)
                        newArray[i] = zeArray[i];
                    else
                        newArray[i - 1] = zeArray[i];
                }
            }
            else
                return (false, zeArray);
            return (true, newArray);            
        }
        static void Opgave3_1()
        {
            List<int> values= new List<int>();
            values.Add(10);
            values.Add(20);
            values.Add(30);
            values.Add(40);
            values.Add(15);
            values.Sort();
            values.Reverse();

        }
        static void Opgave3_2()
        {




        }
    }
}