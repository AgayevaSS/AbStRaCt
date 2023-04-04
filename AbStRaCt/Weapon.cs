using System;
using System.Collections.Generic;
using System.Text;

namespace AbStRaCt
{
    abstract class Weapon 
    {
        public string Name { get; set; }
        public int Damage { get; set; }

        public abstract void Attack();
        
    }
}
