using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kysib kasutajal sisestada kasutajatunnus ja salas6na;
            //kui sisestatud kasutajatunnus on "admin' ja sisestatud salas6na on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!"
            //muul konsoolis kuvatakse "Vale kasutajatunnus v6i salas6na. Proovi uuesti."

            //OR (v6i) || (pipes)

            // true || true --> true
            // false || true --> true
            // true || false --> true
            // false || false --> false

            Console.WriteLine("Sisesta kasutajatunnus:");
            string username = Console.ReadLine();
            Console.WriteLine("Sisesta salas6na:");
            string userpassword = Console.ReadLine();

            if (username != "admin" || userpassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus v6i salas6na. Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }

            // "admin1" != "admin" || "admin1234" != "admin1234" --> true || false --> true
            // "admin" != "admin" || "admin123" != "admin1234" --> false || true --> true
            // "admin1" != "admin" || "admin123" != "admin1234" --> true || true --> true
            // "admin" != "admin" || "admin1234" != "admin1234" --> false || false --> false

        }
    }
}
