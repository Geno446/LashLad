using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LashLad.Model
{
    class BasicKillable : IKillable
    {
        public BasicKillable(int startHealth = 100)
        {
            Health = startHealth;
        }

        public int InflictDamage(int amount, DamageType damageType = DamageType.normal)
        {
            int delta = Health - amount;
            Health = delta < 0 ? 0 : delta;

            return Health;
        }


        public int Health
        { protected set; get; }
    }
}
