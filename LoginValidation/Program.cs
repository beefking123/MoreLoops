using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kysib kasutajal sisestada kasutajatunnus ja salas6na
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salas6na on "admin1234"
            //siis konsoolis kuvatakse "tere Tulemast!"
            //muul konsoolis kuvatakse "Vale kasutajatunnus v6i salas6na. Proovi uuesti.
            //kasutajal on kolm katset


            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string username = Console.ReadLine();
                Console.WriteLine("Sisesta salas6na:");
                string userpassword = Console.ReadLine();
               
                if (username != "admin" || userpassword != "admin1234")
                {
                    i++;
                    Console.WriteLine("Vale kasutajatunnus v6i salas6na. Proovi uuesti.");

                }
                else
                {
                    Console.WriteLine("Tere Tulemast!");
                    break; ;
                }
            }
        }
    }
    
}
