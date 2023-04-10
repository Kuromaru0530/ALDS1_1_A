using System;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var a = new int[n];
        var Input = Console.ReadLine().Split(' ');

        for(int i = 0; i < a.Length; i++)
        {
            a[i] = int.Parse(Input[i]);
        }

        for(int i = 0; i < n; i++)
        {
            var v = a[i];
            var j = i - 1;
            while(j >= 0 && a[j]>v)
            {
                a[j + 1] = a[j];
                j--;
            }
            a[j + 1] = v;
            Console.WriteLine(string.Join(' ', a));
        }
    }
}