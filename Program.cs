namespace Set3Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vector: ");
            string input = Console.ReadLine();
            int[] v = Array.ConvertAll(input.Split(" "), int.Parse);

            Console.WriteLine("Vectorul inainte de insertion sort: ");
            printArray(v);

            InsertionSort(v);

            Console.WriteLine("Codul dupa sortare: ");
            printArray(v);

        }

        static void InsertionSort(int[] v)
        {
            int n = v.Length;
            for(int i = 1; i < n; i++)
            {
                int elemCurent = v[i];
                int j = i - 1;
                while(j >= 0 && v[j] > elemCurent)
                {
                    v[j+1] = v[j];
                    j--;
                }
                v[j+1] = elemCurent;

                Console.WriteLine($"Pasil {i}: ");
                printArray(v);

            }
        }

        static void printArray(int[] v)
        {
            Console.WriteLine(String.Join(" ", v));
            Console.WriteLine();
        }
    }
}
