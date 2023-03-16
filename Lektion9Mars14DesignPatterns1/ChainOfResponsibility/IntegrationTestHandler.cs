using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.ChainOfResponsibility
{
    public class IntegrationTestHandler : PipelineHandler
    {
        public IntegrationTestHandler(PipelineHandler next) : base(next)
        {
        }
        protected override bool handleRequest(Project project)
        {
            Console.WriteLine("Running Integration Tests...");
            Thread.Sleep(1000);
            bool success = project.PassesIntegrationTests;
            return success;
        }
    }
}
