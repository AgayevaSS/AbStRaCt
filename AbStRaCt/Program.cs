using System;

namespace AbStRaCt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();

            character.name = "sh";

            Enemy enemy = new Enemy();

            enemy.name = "t";

            Item item = new Item();

            item.name = "r";



            Kalashnikov kalashnikov = new Kalashnikov
            {
                Damage = 100,
                Name = "Kalashnikov",
            };
            kalashnikov.Attack();


        }
    }
       


}
