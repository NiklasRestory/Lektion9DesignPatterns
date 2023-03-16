using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.ChainOfResponsibility
{
    public class ChainOfResponsibilityDemonstration
    {
        public void Run()
        {
            IntegrationTestHandler integrationTestHandler = new IntegrationTestHandler(null);
            UnitTestHandler unitTestHandler = new UnitTestHandler(integrationTestHandler);
            BuildHandler buildHandler = new BuildHandler(unitTestHandler);

            Project goodProject = new Project(true, true, true);

            buildHandler.Handle(goodProject);

            Console.WriteLine(" --- ");

            Project badProject = new Project(true, false, false);
            buildHandler.Handle(badProject);

            PipelineHandler buildHandler1 = new BuildHandler(null);
            PipelineHandler unitTestHandler1 = new UnitTestHandler(buildHandler1);
            PipelineHandler unitTestHandler2 = new UnitTestHandler(unitTestHandler1);
        }
    }
}
