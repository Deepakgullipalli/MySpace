using DesignPatterns.FactoryMethodPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern.Client
{
    public class FactoryMethodClient
    {
        public static void FactoryMethodClientMain()
        {
            FactoryMethodManager manager = new FactoryMethodManager();
            var x = manager.FetchFactoryMethodFactory(1);
            x.DoConcreteCreatorOperation();
        }
    }

    public class FactoryMethodManager
    {
        public FactoryMethodCreator FetchFactoryMethodFactory(int empId)
        {
            if(empId == 1)
            {
                return new ConcreteCreatorOne();
            }
            return new ConcreteCreatorTwo();

        }
    }

    public abstract class FactoryMethodCreator
    {
        public abstract IProduct FetchProduct();

        public void DoConcreteCreatorOperation()
        {
            var product = FetchProduct();
            product.DoProductOperation();
        }
    }

    public interface IProduct
    {
        void DoProductOperation();
    }

    class ConcreteProductOne : IProduct
    {
        public void DoProductOperation()
        {
            throw new NotImplementedException();
        }
    }

    class ConcreteProductTwo : IProduct
    {
        public void DoProductOperation()
        {
            throw new NotImplementedException();
        }
    }

    public class ConcreteCreatorOne : FactoryMethodCreator
    {
        public override IProduct FetchProduct()
        {
            return new ConcreteProductOne();
        }
    }

    public class ConcreteCreatorTwo : FactoryMethodCreator
    {
        public override IProduct FetchProduct()
        {
            return new ConcreteProductTwo();
        }
    }
}
