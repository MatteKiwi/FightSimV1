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

        public string name()
        {
            List<string> names = new List<string> { "Carlos", "Juan", "Felle", "Olivia", "Erik", "Magnus", "Ryu", "Ken", "Svante", "Vincent", "Sebbe", "Olle", "Markus" };
            int i = gen.Next(0, 12);
            return names[i];
        }

        //generara en random nummer för attack
        public int Attack()
        {
           int i = gen.Next(5, 30);
           return i;
        }
        //tar bort hp
        public void Hurt(int amount)
        {
            hp -= amount;
        }
        //kollar ifall fighter lever
        public bool IsAlive()
        {
            if (hp < 0)
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

        
    }
}
