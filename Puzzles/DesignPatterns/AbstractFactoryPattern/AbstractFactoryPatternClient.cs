using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    /// <summary>
    /// https://refactoring.guru/design-patterns/abstract-factory/csharp/example
    /// https://refactoring.guru/design-patterns/abstract-factory
    /// </summary>
    public class AbstractFactoryPatternClient
    {
        public static void AbstractFactoryClientMain()
        {
            AbstractFactoryManager manager = new AbstractFactoryManager();
            manager.FetchFamilyFactory(1);
        }
    }

    class AbstractFactoryManager
    {
        public void FetchFamilyFactory(int id)
        {
            if(id == 1)
            {
                var productA = new ConcreteFactoryOne().CreateProductA();
                var productB = new ConcreteFactoryOne().CreateProductB();
            }
        }
    }

    public interface IAbstractProductA
    {
        void UseProductA();
    }

    public class ConcreteProductAOne : IAbstractProductA
    {
        public void UseProductA()
        {
            throw new NotImplementedException();
        }
    }

    public class ConcreteProductATwo : IAbstractProductA
    {
        public void UseProductA()
        {
            throw new NotImplementedException();
        }
    }

    public interface IAbstractProductB
    {
        void UseProductB();
    }

    public class ConcreteProductBOne : IAbstractProductB
    {
        public void UseProductB()
        {
            throw new NotImplementedException();
        }
    }

    public class ConcreteProductBTwo : IAbstractProductB
    {
        public void UseProductB()
        {
            throw new NotImplementedException();
        }
    }

    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }

    public class ConcreteFactoryOne : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductAOne();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductBOne();
        }
    }

    public class ConcreteFactoryTwo : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductATwo();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductBTwo();
        }
    }
}
