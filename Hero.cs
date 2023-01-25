using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameQuest
{
    internal class Hero
    {
        private int health=100;//Здоровье героя
        private int damage=10;//Жизни героя


        public int getHealth()//Получение здоровья
        {
            return health;
        }


        public void setHealth(int health)//Присваивает здоровье
        {
            this.health = health;
        }

        public int getDamage()//Получение количества жизней
        {
            return this.damage;
        }

        public void setDamage(int damage)//Присваивает количества жизней
        {
            this.damage = damage;
        }

    }
}
