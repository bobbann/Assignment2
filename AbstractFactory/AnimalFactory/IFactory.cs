using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory.AnimalFactory
{
    public interface IFactory
    {
        public IAnimal CreateAnimal(string name);
    }
}
