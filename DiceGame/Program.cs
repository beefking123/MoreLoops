using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //m2ngus osaleb kaks m2ngijat - arvuti (GPU) ja kasutaja (user)
            //m6lemad m2ngijad viskavad t2ringuid;
            //programm kontrollib, kumb m2ngija viskas rohkem
            //m2ngija, kes viskab rohkem, ongi m2ngu v6itja
            //*t2ringud vastatakse kolm korda
            //programm kuulutab v6itjat




            for (int i = 0; i < 3; i++)
            {
                Random rnd = new Random();

                //arvuti vise
                int cpuRandom = rnd.Next(1, 7);
                //kasutaja vise
                int userRandom = rnd.Next(1, 7);

                int cpuScore = 0;
                int userScore = 0;

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on m2ngu v6itnud. Palju 6nne!");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on m2ngu v6itnud.");
                    cpuRandom = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("viik!");
                }
            }
        }
    }
}
