using Assignment2.StateCommandMemento.MementoClass;
using Assignment2.StateCommandMemento.MachineClass;
using System;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */
        public Memento Memento { get; set; }
        public void Run()
        {
            Console.WriteLine("Press ENTER to turn the  Power of the machine on / off");
            Console.WriteLine("Press V to enter text");
            Console.WriteLine("Press S to save machine");
            Console.WriteLine("Press L to load machine");
            Machine machine = new();

            while (true)
            {
                var userInput = Console.ReadKey(true).Key;
                switch (userInput)
                {
                    case ConsoleKey.Enter:
                        machine.PowerSwitch();
                        break;
                    case ConsoleKey.V:
                        Console.WriteLine("Enter text to print");
                        string userText = Console.ReadLine();
                        machine.Print(userText);
                        break;
                    case ConsoleKey.S:
                        machine.CreateMemento();
                        Console.WriteLine("Saved");
                        break;
                    case ConsoleKey.L:
                        Memento.LoadMemento();
                        Console.WriteLine("Loaded");
                        break;
                    default:
                        Console.WriteLine("Unkown input");
                        break;
                }
            }
        }
    }
}