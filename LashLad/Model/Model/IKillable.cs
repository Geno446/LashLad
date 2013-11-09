using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LashLad.Model
{
    interface IKillable
    {
        /// <summary>
        ///  Damages the entity
        /// </summary>
        /// <param name="amount">The amount to damage</param>
        /// <param name="damageType">Optional damage type </param>
        /// <returns>The health remaining</returns>
        int InflictDamage(int amount, DamageType damageType = DamageType.Normal);

        int Health { get; }
    }
}
