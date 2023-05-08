using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld");
            Console.WriteLine("Modified in remote main branch");
<<<<<<< HEAD
            Console.WriteLine("Modifying in local");

=======
            Console.WriteLine("Creating conflict from the remote");
            
>>>>>>> e45b8d1bde9aaad42ce5ea4549e735defa555fba

        }
    }
}
