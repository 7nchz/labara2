namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i;
            }

            for (int i = 2; i < a.Length; i *= 2)
            {
                Console.Write(a[i] + " ");
            }

            Console.ReadKey();
        }
    }
}