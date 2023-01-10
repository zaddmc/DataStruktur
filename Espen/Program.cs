class Program

{


    static int Opgave11Resultat;


    static void Main()

    {
        int[] Tal = { 1, 2, 3, 3 };
        Opgave11(3, Tal);
        Opgave12();
        Opgave13();










    }

    static void Opgave11(int Mål, int[] Tal)

    {

        for (int i = 0; i < Tal.Length; i++)
        {
            if (Tal[i] == Mål)
            {
                int Opgave11Resultat = i;
                goto Complete;
            }
        }
        Console.Write("Opgave 1 = NONE");
    Complete:;
        Console.WriteLine("Opgave11 = DONE , og index er = " + Opgave11Resultat);


    }



    static void Opgave12()

    {
        int Fund = 0;
        int indexgoal = 5;
        int[] Array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] ArrayRemoved = new int[Array.Length - 1];


        for (int i = 0; i < Array.Length; i++)
        {
            if (i != indexgoal)
            {
                ArrayRemoved[i - Fund] = Array[i];
            }
            else
            {
                Fund = 1;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Opgave2 =");
        foreach (var item in Array)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine();
        foreach (var item in ArrayRemoved)
        {
            Console.Write(item + ", ");
        }




    }

    static void Opgave13()
    {
        int Fund = 0;
        int indexgoal = 5;
        int Indsæt = 4;
        int[] Array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] ArrayRemoved = new int[Array.Length + 1];


        for (int i = 0; i < Array.Length; i++)
        {
            if (i != indexgoal)
            {
                ArrayRemoved[i] = Array[i - Fund];
            }
            else
            {
                ArrayRemoved[i] = Indsæt;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Opgave3 =");
        foreach (var item in Array)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine();
        foreach (var item in ArrayRemoved)
        {
            Console.Write(item + ", ");
        }
    }

    static void Opgave22()
    {
        int Mål = 8;
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int Pos = array.Length / 2;
        while (array[Pos] != Mål)
        {
            if (Mål > array[Pos])
            {
                Pos = Pos + array.Length / 2;
                Console.WriteLine(Pos);
            }
            if (Mål < array[Pos])
            {
                Pos = Pos / 2;
                Console.WriteLine(Pos);
            }

        }
        Console.WriteLine("opgave22 er " + Pos);


    }
    public int KanelSnegl(int mål)
    {

        return 10;
    }

}