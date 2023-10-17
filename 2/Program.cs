using System;

namespace Program1 {
    class test1 {
    Public static void Main() {
int i, j, n1, n2, temp;

  Console.WriteLine("Enter n1 & n2:");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("__________________________");


 for (i = n1; i <= n2; i++)
            {
                if (i == 1 || i == 0)
                    continue;
                temp = 1;
 
 
                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        temp = 0;
                        break;
                    }
                }
                if (temp == 1)
                    Console.WriteLine(i);
            }
        }
    }
}
