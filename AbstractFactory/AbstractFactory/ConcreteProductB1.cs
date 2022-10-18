using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ConcreteProductB1 : IAbstractProductB
    {
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();
            return $"The result of the B1 collaborating with the ({result})";
        }

        public string UsefulFunctionB()
        {
            return "The result of product B1.";
        }
    }
}
