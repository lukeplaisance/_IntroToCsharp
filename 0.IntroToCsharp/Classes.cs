using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.IntroToCsharp
{
    public abstract class Item
    {
        protected string Name;
        protected int Id;
    }

    public abstract class Weapon
    {
        public int Power;
        public virtual void DoDamage(int amount)
        {

        }
    }

    public abstract class Potion : Item
    {
        protected int Power;
        public virtual void Consume()
        {

        }
    }

    public class BusterSword : Weapon
    {
        BusterSword()
        {
        }
        public void Swing()
        {

        }
    }

    public class GatlingGun : Weapon
    {
        GatlingGun()
        {
        }
        public void Shoot()
        {

        }
    }

    public class Elixir : Potion
    {
        public Elixir()
        {
        }
    }

    public class Ether : Potion
    {
        Ether()
        {
        }
    }
}
