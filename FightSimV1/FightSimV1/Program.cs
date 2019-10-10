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
            Fighter A = new Fighter();
            Fighter B = new Fighter();

            A.name = "Juan";
            B.name = "Carlos";
          

            while (true)
            {
                B.Hurt(A.Attack());
                A.Hurt(B.Attack());

                Console.WriteLine(A.name + " Hp: " + A.GetHp() + " " + B.name + " Hp: " + B.GetHp());

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
