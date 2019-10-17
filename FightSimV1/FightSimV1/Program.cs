﻿using System;
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
            //string a/b är får sitt namn får name metoden inom classen fighter
            string nameA = A.RandomName();
            string nameB = B.RandomName();
            //välkommnar användaren
            Console.WriteLine("Welcome to fight sim, just press enter and enojoy");
            //whilpe loop med hela spelet
            while (true)
            {
                A.Present();

                string input = Console.ReadLine();
                //skriver ut namn samt hp för båda fighters
                Console.WriteLine(nameA + " Hp: " + A.GetHp() + " " + nameB + " Hp: " + B.GetHp());
                if (input == "1")
                {
                    //b tar skade av a attack och tvärtom för a
                    B.Hurt(A.LightAttack());
                    A.Hurt(B.LightAttack());                   
                }
                else if(input == "2")
                {
                    B.Hurt(A.HeavyAttack());
                    A.Hurt(B.HeavyAttack());
                }
                //if sats som kollar ifall dom lever och visar då vem som vann
                if(A.IsAlive() == true)
                {
                    Console.WriteLine(nameB + " Won !");
                    Console.ReadLine();
                    break;
                }
                else if(B.IsAlive() == true)
                {
                    Console.WriteLine(nameA + " Won !");
                    Console.ReadLine();
                    break;
                }
                //Console.ReadLine();
            }
        }
    }
}
