using AbStRaCt;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbStRaCt
{
    public class WeaponBase
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public WeaponBase(string name)
        {
            Name = name;
        }
    }
   
}
        public class Sword : WeaponBase
        {
        public Sword(string name) : base(name)
        { 
        }  
   
        }

