using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.MachineClass
{
    internal class MachineStateOn : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Power is ON");
        }

        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
