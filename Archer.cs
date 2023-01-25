using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameQuest
{
    internal class Archer: Hero
    {
        public Archer(string name)//Конструктор класса лучник
        {
            this.setHealth(150);
            this.setDamage(20);
        }
    }
}
