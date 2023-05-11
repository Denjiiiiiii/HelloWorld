using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
     class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HelloWorld");    
            //Console.WriteLine("HelloWorld");
            //Console.WriteLine("Modified in remote main branch");
            //Console.WriteLine("Creating conflict from the remote");
            // Console.WriteLine("Modifying in local");
            //object creation of human class
            //className objectVariable=new ClassName();
            Human human = new Human();
            Console.WriteLine("Please enter your name");
            human.name = Console.ReadLine();
            Console.WriteLine("Please enter your height");
            //string height = Console.ReadLine();
            human.height = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Please enter phone number");
            //string phoneNumber = Console.ReadLine();
            human.phoneNumber = Convert.ToInt64 (Console.ReadLine());
            human.Talk();
            human.HumanDetails();
            Console.ReadLine();


        }
     }
}

 