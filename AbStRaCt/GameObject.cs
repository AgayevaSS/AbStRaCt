using System;
using System.Collections.Generic;
using System.Text;

namespace AbStRaCt
{
    internal class GameObject
    {
        public string name { get; set; }
        public string positiion { get; set; }
        public int rotation { get; set; }
        public string scale { get; set; }

    }
    class Character : GameObject
    {

    }
    class Enemy : GameObject
    {

    }
    class Item : GameObject
    {

    }
}
