using System;
using dio_banco_carrefour_desafio_rpg.src.Entities;

namespace dio_banco_carrefour_desafio_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando os objetos
            Kinight knight = new Kinight("Arus", 12, "Knight");
            Wizard wizard = new Wizard("Jenica", 23, "White Wizard");
            BlackWizard blackWizard = new BlackWizard("Topapa", 13, "Black Wizard");
            Ninja ninja = new Ninja("Wedge", 42, "Ninja");

            Console.WriteLine(knight.Attack());
            Console.WriteLine(wizard.Attack(8));
            Console.WriteLine(blackWizard.Attack(3));
            Console.WriteLine(ninja.Attack("super"));
        }
    }
}
