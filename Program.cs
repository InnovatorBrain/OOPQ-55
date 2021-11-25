using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        // (a)
      int a=3, b=4;
        {
          ++a * = b++;
          Console.WriteLine(++a);
          Console.ReadLine();
        }
        {
          // (b)
          ++a * = ++b;
          console.WriteLine(++a);
          console.ReadLine();
        }
        {
          // (c)
          a = a + 1;
          b = b + 1;
          a = a * b;
          console. WriteLine(a);
          console.ReadLine();
        }
      
     }
  }
}

