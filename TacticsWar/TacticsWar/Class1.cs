using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacticsWar
{
    public abstract class Unit
    {
        private int HealthPool;
        private int Attack;
        private int Defense;

        public Unit(int InitHealth, int InitAttack, int InitDefense)
        {
            this.HealthPool = InitHealth;
            this.Attack = InitAttack;
            this.Defense = InitDefense;
        }

        public void SetHealth(int ChangeHealthBy)
        {
            this.HealthPool += ChangeHealthBy;
        }

        public int GetHealth()
        {
            return this.HealthPool;
        }
    }

    public class Warrior : Unit
    {
        private static int BaseHealth = 100, BaseAttack = 70, BaseDefense = 50;

        public Warrior() : base(BaseHealth, BaseAttack, BaseDefense)
        {

        }
    }

    public class Archer
    {
        private static int BaseHealth = 100, BaseAttack = 70, BaseDefense = 50;
    }

    public class Mage
    {
        private static int BaseHealth = 100, BaseAttack = 70, BaseDefense = 50;
    }

    public class Healer
    {
        private static int BaseHealth = 100, BaseAttack = 70, BaseDefense = 50;
    }
}
