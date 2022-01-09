using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.MachineClass
{
    internal class MachineStateOff : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Power is OFF");
        }

        public void Print(string text)
        {
            Console.WriteLine("Can't when power is OFF");
        }
    }
}
