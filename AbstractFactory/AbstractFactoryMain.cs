using Assignment2.AbstractFactory.AnimalFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den ena fabriken ska skapa en hund och den andra en katt skapa sedan en abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på ett sträng argument
        
        public void Run()
        {
            var dog = Factory.GetFactory("Dog");
            var dog1 = dog.CreateAnimal("Jakob");
            var cat = Factory.GetFactory("Cat");
            var cat1 = cat.CreateAnimal("Omar");

            Console.WriteLine(dog1.Name + " " + cat1.Name);

        }
    }
}
