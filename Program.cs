using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Tarea8Cap8
{
    class Program
    {//Convertir de decimal a binario
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Enter one number: ");
            n = Convert.ToInt32(Console.ReadLine());
            int newNumber = n;

            Stack binary = new Stack();

            while(newNumber != 1)
            {
                binary.Push(newNumber % 2);
                newNumber = newNumber / 2;
                if(newNumber == 1)
                {
                    binary.Push(newNumber);
                }
            }

            int number = 0;
            while(binary.Count != 0)
            {
                number = (int)binary.Pop();
                Console.Write("{0}", number);
            }

            Console.ReadKey();
        }
        
    }
}
