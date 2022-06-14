using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kysib kasutajal sisestada kasutajatunnus ja salas6na
            //kui sisestatud kasutajatunnus opn 'admin' ja sisestatud salas6na on 'admin1234'
            //siis konsoolis kuvatakse 'tere tulemast!'
            //muul konsoolis kuvatakse 'Vale kasutajatunnus v6i salas6na. Proovi uuesti.'

            Console.WriteLine("Sisesta kasutajatunnus:");
            string username = Console.ReadLine();
            Console.WriteLine("Sisesta salas6na:");
            string userpassword = Console.ReadLine();

            //AND  (&&) v6i OR

            //"admin" AND "admin1234" --> true
            //"admin1" AND "admin1234" --> false
            //"admin" AND "admin12345" --> false
            //"admin1" AND "admin123" --> false

            if (username == "admin" && userpassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale kasutatunnus v6i salas6na. Proovi uuesti.");
            }
        }
    }
}
