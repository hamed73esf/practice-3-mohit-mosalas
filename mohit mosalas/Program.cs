using System;
using System.Runtime.CompilerServices;
class mosalas
{
    public static void Main(string[] args)
    {
        string a= Console.ReadLine();
        string b= Console.ReadLine();
        string c= Console.ReadLine();
        int x= Convert.ToInt32(a);
        int y= Convert.ToInt32(b);
        int z= Convert.ToInt32(c);
        if(x+y>z && x+z>y && y+z>z)
        {
            mosalas.Mohit(x,y,z);
        }
        else
        {
            Console.WriteLine("no");
        }

    }
    private static void Mohit(int x, int y, int z)
    {
        int Out = x + y + z;
        Console.WriteLine(Out);
    }
}