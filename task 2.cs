int n = Convert.ToInt32(Console.ReadLine());
Random r = new Random();
int[] mass = new int[n];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = r.Next(-10, 10);
    Console.WriteLine(mass[i]);
}
int j = 1;
while (j < n)
{
    Console.WriteLine("element {0}: index {1}", mass[j], j);
    j *= 2;
}
" ");