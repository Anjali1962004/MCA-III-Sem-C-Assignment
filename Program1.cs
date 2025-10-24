using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int sum=0;
        foreach(String arg in args) { 
            sum=sum+ int.Parse(arg);
        }
        Console.WriteLine(sum);
    }
}

