int i = 1, num, prev, k = 0;

Console.WriteLine("Введите числа:");
string num = Console.ReadLine();
while (num != -1)
{
    prev = num;
    string num = Console.ReadLine();
    if (k == 0 && prev == num) k = i;
    i++;
}

if (k) Console.WriteLine("k + 1");

system("pause");
return 0;
