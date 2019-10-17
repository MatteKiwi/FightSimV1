using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimV1
{
    class Fighter
    {
        //variabler 
        private int hp = 100;
        public static Random gen = new Random();
        //random namn till spelarna
        public string RandomName()
        {
            List<string> names = new List<string> { "Carlos", "Juan", "Felle", "Olivia", "Erik", "Magnus", "Ryu", "Ken", "Svante", "Vincent", "Sebbe", "Olle", "Markus" };
            int i = gen.Next(0, 12);
            return names[i];
        }
        //generara en random nummer för attack
        public int LightAttack()
        {
           int i = gen.Next(5, 30);
           return i;
        }
        //20 % chans att man kan få in en heavyattack som skadar 90
        public int HeavyAttack()
        {
            int x = gen.Next(1, 100);

            if(x <= 80)
            {
                int i = 0;
                Console.WriteLine("Miss!");
                return i;
            }
            else
            {
                int i = 90;
                Console.WriteLine("Hit");
                return i;
            }         
        }
        //tar bort hp
        public void Hurt(int amount)
        {
            hp -= amount;
        }
        //kollar ifall fighter lever
        public bool IsAlive()
        {
            if (hp <= 0)
            {
                hp = 0;
                return true;
            }
            else
            {
                return false;
            }
        }
        //retunerar hp
        public int GetHp()
        {
            int x = hp;
            
            return x;
        }   
        
        public void Present()
        {
            Console.WriteLine("Press 1 to perform a !Light Attack!\nPress 2 to perform a !Heavy Attack! (hard to hit)");
        }
    }
}
