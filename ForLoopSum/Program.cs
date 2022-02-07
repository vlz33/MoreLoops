using System;

namespace ForLoopSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisetada kolm numbrit;
            //programm kuvab nende summa;

            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Sisesta arv");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                sum = sum + userNumber;

                
            }
            
            Console.WriteLine($"Your total is: {sum}");
        }
    }
}
