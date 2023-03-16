using Lektion9Mars14DesignPatterns1.ChainOfResponsibility;
using Lektion9Mars14DesignPatterns1.Command;
using Lektion9Mars14DesignPatterns1.Composite;
using Lektion9Mars14DesignPatterns1.Decorator;
using Lektion9Mars14DesignPatterns1.FactoryMethod;
using Lektion9Mars14DesignPatterns1.Flyweight;
using Lektion9Mars14DesignPatterns1.Iterator;
using Lektion9Mars14DesignPatterns1.Proxy;
using Lektion9Mars14DesignPatterns1.Singleton;
using Lektion9Mars14DesignPatterns1.State;
using Lektion9Mars14DesignPatterns1.Visitor;

namespace Lektion9Mars14DesignPatterns1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FlyweightDemonstration flyweightDemonstration = new FlyweightDemonstration();
            //flyweightDemonstration.Run();
            CommandDemonstration commandDemonstration = new CommandDemonstration();
            //commandDemonstration.Run();
            StateDemonstration stateDemonstration = new StateDemonstration();
            //stateDemonstration.Run();
            ProxyDemonstration proxyDemonstration = new ProxyDemonstration();
            //proxyDemonstration.Run();
            DecoratorDemonstration decoratorDemonstration = new DecoratorDemonstration();
            //decoratorDemonstration.Run();
            ChainOfResponsibilityDemonstration chainOfResponsibilityDemonstration = new ChainOfResponsibilityDemonstration();
            //chainOfResponsibilityDemonstration.Run();
            VisitorDemonstration visitorDemonstration = new VisitorDemonstration();
            //visitorDemonstration.Run();
            SingletonDemonstration singletonDemonstration = new SingletonDemonstration();
            //singletonDemonstration.Run();
            CompositeDemonstration compositeDemonstration = new CompositeDemonstration();
            //compositeDemonstration.Run();
            FactoryMethodDemonstration factoryMethodDemonstration = new FactoryMethodDemonstration();
            //factoryMethodDemonstration.Run();
            IteratorDemonstration iteratorDemonstration = new IteratorDemonstration();
            iteratorDemonstration.Run();
        }
    }
}