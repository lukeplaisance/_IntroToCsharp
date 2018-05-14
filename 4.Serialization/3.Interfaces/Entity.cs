using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Interfaces
{
    public interface IDamagable
    {
        bool TakeDamage(int amount);
        int ArmorClass { get; set; }
    }
    public interface IDamager
    {
        int HitModifier { get; set; }
        void DoDamage(IDamagable dealt);
    }

    public abstract class Entity : IDamagable
    {
        private int health;
        private string name;

        public abstract int ArmorClass { get; set; }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract bool TakeDamage(int amount);
    }
    public class Assassin : Entity, IDamagable
    {
        public int hitModifier;
        private int armor = 10;
        public override int ArmorClass
        {
            get { return armor; }
            set { armor = value; }
        }

        public int HitModifier
        {
            get { return hitModifier; }

            set { hitModifier = value; }
        }

        public override bool TakeDamage(int amount)
        {
            Random r = new Random();
            var roll = r.Next(1, 21);
            if (Health <= 0)
                return false;
            else if (roll > (ArmorClass - HitModifier))
            {
                var hitChance = 21 - (ArmorClass - HitModifier) / 20;
                Combat.GetStatus(hitChance * 100);
                Health -= amount;
            }
            return true;
        }
    }
    public class Ninja : Entity, IDamagable
    {
        public int hitModifier;
        private int armor = 8;
        public override int ArmorClass
        {
            get { return armor; }
            set { armor = value; }
        }

        public int HitModifier
        {
            get { return hitModifier; }

            set { hitModifier = value; }
        }
        public override bool TakeDamage(int amount)
        {
            Random r = new Random();
            var roll = r.Next(1, 21);
            if (Health <= 0)
                return false;
            else if (roll > (ArmorClass - HitModifier))
            {
                var hitChance = 21 - (ArmorClass - HitModifier) / 20;
                Combat.GetStatus(hitChance * 100);
                Health -= amount;
            }
            return true;
        }
    }
    public class Nord : Entity, IDamagable
    {
        public int hitModifier;
        private int armor = 16;
        public override int ArmorClass
        {
            get { return armor; }
            set { armor = value; }
        }

        public int HitModifier
        {
            get { return hitModifier; }

            set { hitModifier = value; }
        }
        public override bool TakeDamage(int amount)
        {
            Random r = new Random();
            var roll = r.Next(1, 21);
            if (Health <= 0)
                return false;
            else if (roll > (ArmorClass - HitModifier))
            {
                var hitChance = 21 - (ArmorClass - HitModifier) / 20;
                Combat.GetStatus(hitChance * 100);
                Health -= amount;
            }
            return true;
        }
    }
    public class Soldier : Entity, IDamagable
    {

        public int hitModifier;
        private int armor = 15;
        public override int ArmorClass
        {
            get { return armor; }
            set { armor = value; }
        }

        public int HitModifier
        {
            get { return hitModifier; }

            set { hitModifier = value; }
        }
        public override bool TakeDamage(int amount)
        {
            Random r = new Random();
            var roll = r.Next(1, 21);
            if (Health <= 0)
                return false;
            else if (roll > (ArmorClass - HitModifier))
            {
                var hitChance = 21 - (ArmorClass - HitModifier) / 20;
                Combat.GetStatus(hitChance * 100);
                Health -= amount;
            }
            return true;
        }
    }
    public class Robot : Entity, IDamager
    {
        public int hitModifier;
        private int armor = 16;
        public override int ArmorClass
        {
            get { return armor; }
            set { armor = value; }
        }

        public int HitModifier
        {
            get{ return hitModifier;}

            set { hitModifier = value; }
        }

        public void DoDamage(IDamagable damagable)
        {
            Random modifier = new Random();
            var roll = modifier.Next(1, 21);
            var percent = 21 - (ArmorClass - HitModifier) / 20;
            Console.WriteLine(Name + " is doing damage");
            var status = Combat.GetStatus(percent * 100);
            switch (status)
            {
                case Combat.HitStatus.CRITICAL_HIT:
                    break;
                case Combat.HitStatus.CRITICAL_MISS:
                    break;
                case Combat.HitStatus.HIT:
                    break;
                case Combat.HitStatus.MISS:
                    break;
                default:
                    break;
            }
        }

        public override bool TakeDamage(int amount)
        {
            Random r = new Random();
            var roll = r.Next(1, 21);
            if (Health <= 0)
                return false;
            else if (roll > (ArmorClass - HitModifier))
            {
                var hitChance = 21 - (ArmorClass - HitModifier) / 20;
                Combat.GetStatus(hitChance * 100);
                Health -= amount;
            }
            return true;
        }
    }
    public class Witcher : Entity, IDamager
    {
        public int hitModifier;
        private int armor = 12;
        public override int ArmorClass
        {
            get { return armor; }
            set { armor = value; }
        }

        public int HitModifier
        {
            get { return hitModifier; }

            set { hitModifier = value; }
        }

        public void DoDamage(IDamagable damagable)
        {
            Random modifier = new Random();
            var roll = modifier.Next(1, 21);
            var percent = 21 - (ArmorClass - HitModifier) / 20;
            Console.WriteLine(Name + " is doing damage");
            var status = Combat.GetStatus(percent * 100);
            switch (status)
            {
                case Combat.HitStatus.CRITICAL_HIT:
                    break;
                case Combat.HitStatus.CRITICAL_MISS:
                    break;
                case Combat.HitStatus.HIT:
                    break;
                case Combat.HitStatus.MISS:
                    break;
                default:
                    break;
            }
        }

        public override bool TakeDamage(int amount)
        {
            Random r = new Random();
            var roll = r.Next(1, 21);
            if (Health <= 0)
                return false;
            else if (roll > (ArmorClass - HitModifier))
            {
                var hitChance = 21 - (ArmorClass - HitModifier) / 20;
                Combat.GetStatus(hitChance * 100);
                Health -= amount;
            }
            return true;
        }
    }
    public class Spartan : Entity, IDamager
    {
        public int hitModifier;
        private int armor = 20;
        public override int ArmorClass
        {
            get { return armor; }
            set { armor = value; }
        }

        public int HitModifier
        {
            get { return hitModifier; }

            set { hitModifier = value; }
        }

        public void DoDamage(IDamagable damagable)
        {
            Random r = new Random();
            var roll = r.Next(1, 21);
            var percent = 21 - (ArmorClass - HitModifier) / 20;
            Console.WriteLine(Name + " is doing damage");
            var status = Combat.GetStatus(percent * 100);
            switch(status)
            {
                case Combat.HitStatus.CRITICAL_HIT:
                    break;
                case Combat.HitStatus.CRITICAL_MISS:
                    break;
                case Combat.HitStatus.HIT:
                    break;
                case Combat.HitStatus.MISS:
                    break;
                default:
                    break;
            }
        }

        public override bool TakeDamage(int amount)
        {
            Random r = new Random();
            var roll = r.Next(1, 21);
            if (Health <= 0)
                return false;
            else if(roll > (ArmorClass - HitModifier))
            {
                var hitChance = 21 - (ArmorClass - HitModifier) / 20;
                Combat.GetStatus(hitChance * 100);
                Health -= amount;
            }
            return true;
        }
    }
}
