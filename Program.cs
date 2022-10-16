using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Return_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of your venue?");
            string venue = args[0];
            Announce(venue);

        }

        static void Announce(string venue)
        {
            Console.WriteLine(venue + "will have band performing tonight!");
        }
    }
}

        
    

