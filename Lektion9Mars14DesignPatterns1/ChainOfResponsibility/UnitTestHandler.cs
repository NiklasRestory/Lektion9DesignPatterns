using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.ChainOfResponsibility
{
    public class UnitTestHandler : PipelineHandler
    {
        public UnitTestHandler(PipelineHandler next) : base(next) { }

        protected override bool handleRequest(Project project)
        {
            Console.WriteLine("Running Unit Tests...");
            Thread.Sleep(1000);
            return project.PassesUnitTests;
        }
    }
}
