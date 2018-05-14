using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.BackPack
{
    public interface IBackpackable
    {
        string Name { get; set; }
        void Store(BackPack item);
    }
    public abstract class Item : IBackpackable
    {
        public string Name { get; set; }
        public string Attribute { get; set; }
        public int Value { get;  set; }

        public Item(string name, string attribute, int value)
        {
            Name = name;
            Attribute = attribute;
            Value = value;
        }
        public override string ToString()
        {
            string data = Attribute + ": " + Value;
            return data;
        }

        public abstract void Store(BackPack item);
    }
    public class BackPack
    {
        public static List<IBackpackable> packables = new List<IBackpackable>()
        {
            new HealingDrink(name: "HealingDrink",attribute:"Heal",value: 15),
            new CombatKnife(name:"Combat_Knife",attribute:"Sharpness", value: 20 ),
            new AntidoteShot(name:"Antidote",attribute: "Cure", value: 10 ),
            new CombatShield(name:"CombatShield",attribute: "Toughness", value: 10 ),
            new BarettaM92(name:"M9", attribute:"Bullet Damage",value: 12 ),
            new KevlarVest(name:"KevlarVest",attribute:"Armor", value: 15 )
        };
    }
    public class HealingDrink : Item, IBackpackable
    {
        public HealingDrink(string name, string attribute, int value) : base(name, attribute, value)
        {
            Name = name;
            Attribute = attribute;
            Value = value;
        }
        public override void Store(BackPack item)
        {
            BackPack.packables.Add(this);
        }
    }
    public class CombatKnife : Item, IBackpackable
    {
        public CombatKnife(string name, string attribute, int value) : base(name, attribute, value)
        {
            Name = name;
            Attribute = attribute;
            Value = value;
        }
        public override void Store(BackPack item)
        {
            BackPack.packables.Add(this);
        }
    }
    public class AntidoteShot : Item, IBackpackable
    {
        public AntidoteShot(string name, string attribute, int value) : base(name, attribute, value)
        {
            Name = name;
            Attribute = attribute;
            Value = value;
        }
        public override void Store(BackPack item)
        {
            BackPack.packables.Add(this);
        }
    }
    public class CombatShield : Item, IBackpackable
    {
        public CombatShield(string name, string attribute, int value) : base(name, attribute, value)
        {
            Name = name;
            Attribute = attribute;
            Value = value;
        }
        public override void Store(BackPack item)
        {
            BackPack.packables.Add(this);
        }
    }
    public class BarettaM92 : Item, IBackpackable
    {
        public BarettaM92(string name, string attribute, int value) : base(name, attribute, value)
        {
            Name = name;
            Attribute = attribute;
            Value = value;
        }
        public override void Store(BackPack item)
        {
            BackPack.packables.Add(this);
        }
    }
    public class KevlarVest : Item, IBackpackable
    {
        public KevlarVest(string name, string attribute, int value) : base(name, attribute, value)
        {
            Name = name;
            Attribute = attribute;
            Value = value;
        }

        public override void Store(BackPack item)
        {
            BackPack.packables.Add(this);
        }
    }
}
