using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LashLad.Model
{
    class Human : IMovable, IKillable
    {
        protected string name;
        protected int health;
        protected IKillable Killable;
        protected IMovable Movable;

        /// <summary>
        /// Creates a Human
        /// </summary>
        /// <param name="name">The name to display for this character</param>
        /// <param name="x">The starting x position</param>
        /// <param name="y">The starting y position</param>
        public Human(string name, int x, int y)
        {
            this.name = name;
            health = 100;
            Killable = new BasicKillable(100);
            Movable = new BasicMovable(50, 50);
        }


        #region IKillable
        public int InflictDamage(int amount, DamageType damageType = DamageType.normal)
        {
            int remainHealth = Killable.InflictDamage(amount, damageType);
            if (remainHealth == 0)
            {
                // death
            }

            return remainHealth;
        }

        public int Health
        {
            get { throw new NotImplementedException(); }
        }
        #endregion


        #region IMovable
        public bool MoveTo(int x, int y, int speed = 1)
        {
            return Movable.MoveTo(x, y, speed);
        }

        public bool TeleportTo(int x, int y)
        {
            return Movable.MoveTo(x, y);
        }

        public int X
        {
            get
            {
                return Movable.X;
            }
        }

        public int Y
        {
            get
            {
                return Movable.Y;
            }
        }

        #endregion
    }
}
