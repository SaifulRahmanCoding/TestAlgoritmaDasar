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
        for (int i = 1; i <= n; i++) // looping sebanyak n
        {
            for (int j = 0; j < i; j++) // looping sebanyak i
            {
                Console.Write(i); // menampilkan angka
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nB.");
        for (int i = 1; i <= n; i++) // looping sebanyak n
        {
            int number = i; // inisialiasi number sama dengan i untuk ditampilkan number nantinya
            for (int j = 0; j < i; j++)
            {
                Console.Write(number--); // tampilkan number di setiap pengulangan dikurangi 1
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nC.");
        int increment = 1; // inisialisasi angka yang akan ditampilkan
        Boolean status = true; // inisialisasi kondisi
        for (int i = 1; i <= n; i++) // looping sebanyak n
        {
            for (int j = 0; j < i; j++) // looping sebanyak i
            {
                if (increment == n) status = false; // jika increment sama dengan n maka status berubah jadi false
                if (increment == 1) status = true; // jika increment sama dengan n maka status berubah jadi false

                if (status) Console.Write(increment++); // jika status true, maka munculkan angka secara increment
                else Console.Write(increment--); // jika status true, maka munculkan angka secara decrement
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nD.");
        for (int i = 0; i < n; i++) // looping sebanyak n
        {
            for (int j = 0; j < n; j++) // looping sebanyak n
            {
                if (j % 2 == 0) Console.Write((1 + (j * n) + i) + " "); // jika nilai j genap, maka munculkan kode berikut
                else Console.Write(((j * n) + (n - i)) + " "); // jika nilai j tidak genap, maka munculkan kode berikut
            }

            Console.WriteLine();
        }
    }

    private static void RemoveMultipleOfThreeAndOrderAsc(int[] n)
    {
        List<int> newNumbers = []; // inisialisasi array baru dengan list
        for (int i = 0; i < n.Length; i++) // looping sebanyak panjang array n
        {
            if (n[i] % 3 != 0) // jika nilai bukan kelipatan 3
            {
                newNumbers.Add(n[i]); // tambahkan ke dalam array yang baru
            }
        }

        // sorting untuk menghasilkan urutan dari angka kecil ke besar
        for (int i = 0; i < newNumbers.Count - 1; i++) // looping sebanyak panjang array baru
        {
            for (int j = 0; j < (newNumbers.Count - i) - 1; j++)
            {
                if (newNumbers[j] > newNumbers[j + 1]) // jika nilai sekarang lebih besar dar nilai setelahnya, maka swap
                {
                    (newNumbers[j], newNumbers[j + 1]) = (newNumbers[j + 1], newNumbers[j]); // kode untuk swap
                }
            }
        }

        for (int i = 0; i < newNumbers.Count; i++)
        {
            Console.Write(newNumbers[i] + " "); // tampilkan isi array baru yang sudah di sorting
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