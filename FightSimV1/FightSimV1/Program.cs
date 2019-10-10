using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimV1
{
    class Program
    {
        static void Main(string[] args)
        {
            //skapar två instanser av fighter
            Fighter A = new Fighter();
            Fighter B = new Fighter();
            //ger dom namn för jag är lat och orkar inte ge använderen frihet att namnge dom
            A.name = "Juan";
            B.name = "Carlos";
            //välkommnar användaren
            Console.WriteLine("Welcome to fight sim, just press enter and enojoy");
            //whilpe loop med hela spelet
            while (true)
            {
                //b tar skade av a attack och tvärtom för a
                B.Hurt(A.Attack());
                A.Hurt(B.Attack());
                //skriver ut namn samt hp för båda fighters
                Console.WriteLine(A.name + " Hp: " + A.GetHp() + " " + B.name + " Hp: " + B.GetHp());
                //if sats som kollar ifall dom lever och visar då vem som vann
                if(A.IsAlive() == true)
                {
                    Console.WriteLine(B.name + " Won !");
                    Console.ReadLine();
                    break;
                }
                else if(B.IsAlive() == true)
                {
                    Console.WriteLine(A.name + " Won !");
                    Console.ReadLine();
                    break;
                }


                Console.ReadLine();
            }
        }
    }
}
