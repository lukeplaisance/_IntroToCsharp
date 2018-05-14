using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Interfaces
{
    public class Combat
    {
        public static void Attackers(List<IDamager> attackers)
        {
            attackers.Add(new Robot() { Name = "Zero", Health = 100 });
            attackers.Add(new Witcher() { Name = "Geralt", Health = 100 });
            attackers.Add(new Spartan() { Name = "John", Health = 100 });
        }
        public static void Defenders(List<IDamagable> defenders)
        {
            defenders.Add(new Assassin() { Name = "Ezio", Health = 100 });
            defenders.Add(new Ninja() { Name = "Scorpion", Health = 100 });
            defenders.Add(new Nord() { Name = "Dragon Born", Health = 100 });
            defenders.Add(new Soldier() { Name = "Shepard", Health = 100 });
        }

        public enum HitStatus
        {
            CRITICAL_HIT = 3,
            HIT = 2,
            MISS = 1,
            CRITICAL_MISS = 0
        }
        public static HitStatus GetStatus(float result)
        {
            return (result > 0 && result < 25) ? HitStatus.CRITICAL_MISS :
                    (result > 25 && result < 50) ? HitStatus.MISS :
                    (result > 50 && result < 75) ? HitStatus.HIT : HitStatus.CRITICAL_HIT;
        }

        public bool Fight()
        {
            int numPlayers = 7;
            for (var i = 0; i < 7; i++)
            {
                Random nextPlayer = new Random();
                nextPlayer.Next(1, 8);
                //IDamager attacker = Attackers(new List<IDamager>());

            }

            return true;

        }
    }
}

