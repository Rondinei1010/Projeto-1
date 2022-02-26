using Projeto1.src.Entities;

namespace Projeto1
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 23, "Knight");
            Wizard Wizard = new Wizard("Jennica", 23, "White Wizard");
            Ninja Wedge = new Ninja("Wedge", 35, "Ninja");
            BlackWizard Tapapa = new BlackWizard("Tapapa", 24, "Black Wizard");
           

            Console.WriteLine(Arus.Attack());
            Console.WriteLine(Wedge.Defense());
            Console.WriteLine(Wizard.Attack(6));
            Console.WriteLine(Tapapa.Defense());
            Console.WriteLine(Wedge.Attack());
            Console.WriteLine(Wizard.Defense());
            Console.WriteLine(Tapapa.Attack());
            
            Console.WriteLine("E a luta continua sem fim");
            

        }
    }
}