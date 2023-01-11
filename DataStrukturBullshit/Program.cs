namespace DataStrukturBullshit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "cat", "something", "car", "fish", "boat", "potato" };
            string Change = "car";
            int Index = 2;

            //Opgave1_3(strings, Change, Index);
            Opgave5_2();

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
        static (bool, string[]) Opgave1_3(string[] zeArray, string zeString, int zeIndex)
        {
            string[] newArray = new string[zeArray.Length + 1];
            if (zeIndex <= zeArray.Length)
            {
                for (int i = 0; i < newArray.Length; i++)
                {
                    if (i == zeIndex)
                    {
                        newArray[i] = zeString;
                        continue;
                    }
                    if (zeIndex > i) newArray[i] = zeArray[i];
                    else newArray[i] = zeArray[i - 1];
                }
            }
            else
                return (false, zeArray);
            return (true, newArray);
        }
        static int Opgave2_1(int[] zeArray, int zeItem)
        {
            for (int i = 0; i < zeArray.Length; i++)
            {
                if (zeArray[i] == zeItem)
                {
                    return i;
                }
            }
            return -1;
        }
        static int Opgave2_2(int[] zeArray, int zeItem)
        {
            int low, high, mid;
            low = 0;
            high = zeArray.Length - 1;
            mid = (low + high) / 2;
            while (low <= high)
            {
                if (zeArray[mid] == zeItem)
                    return mid + 1;
                else
                    if (zeItem < zeArray[mid])
                    high = mid - 1;
                else
                    low = mid + 1;
                mid = (low + high) / 2;
            }
            return -1;

        }
        static void Opgave3_1()
        {
            List<int> values = new List<int>() { 10, 20, 30 };
            values.Add(40);
            values.Add(15);
            values.Sort();
            values.Reverse();
        }
        static void Opgave3_2()
        {
            List<char> chars = new List<char>();
            string strings = "Snakke bagvendt";
            for (int i = 0; i < strings.Length; i++)
            {
                chars.Add(strings[i]);
            }
            chars.Reverse();
        }
        static void Opgave4_1()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic = new Dictionary<string, string>() { { "docx", "Word" }, { "xlsx", "Excel" }, { "rtf", "Word" }, { "pptx", "PowerPoint" } };
            Console.WriteLine(dic["rtf"]);
        }
        static void Opgave5_1()
        {
            Stack<int> myStack = new Stack<int>();
            for (int i = 1; i < 6; i++)
            {
                myStack.Push(i);
            }

            while(myStack.Count > 0)
            {
                Console.Write(myStack.Pop() + ", ");
            }
            Console.WriteLine();
        }
        static void Opgave5_2()
        {
            Stack<char> myStack = new Stack<char>();
            string strings = "Snakke bagvendt";
            for (int i = 0; i < strings.Length; i++)
            {
                myStack.Push(strings[i]);
            }
            while (myStack.Count > 0)
            {
                Console.Write(myStack.Pop());
            }
        }

    }
}