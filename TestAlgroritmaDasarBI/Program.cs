namespace TestAlgroritmaDasarBI;

public class Program
{
    private static void ChangeMultipleOkYes(int n)
    {
        for (int i = 1; i <= n; i++) // melooping sebanyak n
        {
            if (i % 3 == 0 && i % 4 == 0) // kondisi jika kelipatan 3 dan 4 
            {
                Console.Write("OKYES ");
            }
            else if (i % 4 == 0) // kondisi jika kelipatan 4
            {
                Console.Write("YES ");
            }
            else if (i % 3 == 0) // kondisi jika kelipatan 3
            {
                Console.Write("OK ");
            }
            else // kondisi bukan kelipatan 3 dan 4
            {
                Console.Write(i + " ");
            }
        }
    }

    private static void MakeAlgorithmNumber(int n)
    {
        Console.WriteLine("A.");
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(i);
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nB.");
        for (int i = 1; i <= n; i++)
        {
            int number = i;
            for (int j = 0; j < i; j++)
            {
                Console.Write(number--);
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nC.");
        int increment = 1;
        Boolean status = true;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (increment == n) status = false;
                if (increment == 1) status = true;

                if (status) Console.Write(increment++);
                else Console.Write(increment--);
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nD.");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j % 2 == 0) Console.Write((1 + (j * n) + i) + " ");
                else Console.Write(((j * n) + (n - i)) + " ");
            }

            Console.WriteLine();
        }
    }

    private static void RemoveMultipleOfThreeAndOrderAsc(int[] n)
    {
        List<int> newNumbers = [];
        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] % 3 != 0)
            {
                newNumbers.Add(n[i]);
            }
        }

        for (int i = 0; i < newNumbers.Count - 1; i++)
        {
            for (int j = 0; j < (newNumbers.Count - i) - 1; j++)
            {
                if (newNumbers[j] > newNumbers[j + 1])
                {
                    (newNumbers[j], newNumbers[j + 1]) = (newNumbers[j + 1], newNumbers[j]);
                }
            }
        }

        for (int i = 0; i < newNumbers.Count; i++)
        {
            Console.Write(newNumbers[i] + " ");
        }
    }


    public static void Main(string[] args)
    {
        Console.WriteLine("SOAL NO 1");
        ChangeMultipleOkYes(15);
        Console.WriteLine("\n\nSOAL NO 2");
        MakeAlgorithmNumber(5);
        Console.WriteLine("\nSOAL NO 3");
        RemoveMultipleOfThreeAndOrderAsc([12, 9, 13, 6, 10, 4, 7, 2]);
    }
}