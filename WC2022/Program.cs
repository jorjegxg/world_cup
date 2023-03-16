using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WC2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var comp = new Competition("WC" , 20);


            Console.WriteLine(comp.name + " " + comp.numberOfTeams);

        }
    }
}
