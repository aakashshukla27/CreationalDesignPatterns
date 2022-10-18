using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Products of one family are usually able to collaborate among themselves.
    // A family of products may have several variants, but the products
    // of one variant are incompatible with products of another.
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }
}
