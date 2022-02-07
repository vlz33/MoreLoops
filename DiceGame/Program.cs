using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (CPU) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib kumb mängija viskas suurema summa;
            //mängija, kes viskas rohkem, on mängu võitja;
            //täringuid visatakse kolm korda;
            //programm kuulutab võitja välja

            Random rnd = new Random();

            int userScore = 0;
            int CPUScore = 0;
            for (int i = 0; i < 5; i++)
            {

                int CPURandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);
                Console.WriteLine($"Arvuti viskas: {CPURandom}");
                Console.WriteLine($"Kasutaja viskas: {userRandom}");
                if (CPURandom < userRandom)
                {
                    Console.WriteLine("Võitsid mängu.");
                    userScore++;
                }
                else if (CPURandom > userRandom)
                {
                    Console.WriteLine("Arvuti võitis.");
                    CPUScore++;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }

            }
            if (CPUScore < userScore)
            {
                Console.WriteLine($"Võitsid seeria {userScore} : {CPUScore}");
            }
            else if (CPUScore > userScore)
            {
                Console.WriteLine($"Arvuti võitis seeria {CPUScore} : {userScore}");
            }
            else
            {
                Console.WriteLine("Uskumatu lugu, jäite viiki!");
            }

            

            
     
            
        }
    }
}
