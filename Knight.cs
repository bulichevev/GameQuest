using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameQuest
{
    internal class Knight: Hero
    {
        public Knight(string name)//Конструктор класса рыцарь
        {
            this.setHealth(180);
            this.setDamage(35);
        }
    }
}
