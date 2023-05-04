using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    internal class poikkeus: Exception
{
    public poikkeus(string message) : base(message)
    {
        Console.WriteLine();
        Console.WriteLine("--VIRHE--");
        Console.WriteLine("Virhe: " + message);
        Console.WriteLine("--VIRHE--");
        Console.WriteLine();
    }
}

