using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimV1
{
    class Fighter
    {
        private int hp = 100;
        public string name;
        public static Random gen = new Random();

        public int Attack()
        {
           int i = gen.Next(5, 30);
           return i;
        }
        
        public void Hurt(int amount)
        {
            hp -= amount;
        }

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

        public int GetHp()
        {
            int x = hp;
            return x;
        }

        
    }
}
