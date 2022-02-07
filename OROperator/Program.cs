using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on "Admin" ja sisestatud salasõna on "admin1234",
            //siis konsoolis kuvatakse "Tere tulemast.";
            //muul juhul kuvatakse "Vale kastuajatunnus või salasõna. Proovi uuesti.";

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Siseta salasõna:");
            string userPassword = Console.ReadLine();

            if (userName != "Admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti");
            }
            else Console.WriteLine("Tere tulemast.");

        }
    }
}
