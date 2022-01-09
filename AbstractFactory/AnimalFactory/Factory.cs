using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory.AnimalFactory
{
    public static class Factory
    {
        public static IFactory GetFactory(string factoryType)
        {
            if (factoryType == "Dog")
            {
                return new DogFactory();
            }
            else if (factoryType == "Cat")
            {
                return new CatFactory();
            }
            return null;
        }
    }
}
