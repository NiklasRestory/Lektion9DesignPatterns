using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.ChainOfResponsibility
{
    public class BuildHandler : PipelineHandler
    {
        public BuildHandler(PipelineHandler next) : base(next)
        {
        }

        protected override bool handleRequest(Project project)
        {
            Console.WriteLine("Attempting to build project...");
            Thread.Sleep(1000);
            bool success = project.CanBuild;
            return success;
        }
    }
}
