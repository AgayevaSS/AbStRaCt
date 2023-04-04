using System;
using System.Collections.Generic;
using System.Text;

namespace AbStRaCt
{
    internal class Kalashnikov : Weapon
    {
        public override void Attack()
        {
            Console.WriteLine($"{Name} is attack");
        }
    }
}
