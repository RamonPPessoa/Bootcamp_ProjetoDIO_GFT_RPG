using System;
using ProjetoPOO.src.Models;

namespace ProjetoPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Knight knight = new Knight("Arus",23,"Knight");
            Wizard wizard = new Wizard("Morgana",23,"Wizard");
            Elf elf = new Elf("Thegolas",80,"Elf",350,"Velocidade e mestre em espada e arco/flecha");
            Console.WriteLine(knight.Attack());
             Console.WriteLine(wizard.Attack(10));
             Console.WriteLine(elf);
        }
    }
}
