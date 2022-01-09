using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    public class AdapterClass
    {
        public void PrintingStringAsInts()
        {
            ReturningStrings returningStrings = new ReturningStrings();
            PrintingInts printingInts = new PrintingInts();

            var inputString = returningStrings.ReturnString();
            var stringToInt = Int32.Parse(inputString);

            printingInts.Print(stringToInt);
        }
    }
}
