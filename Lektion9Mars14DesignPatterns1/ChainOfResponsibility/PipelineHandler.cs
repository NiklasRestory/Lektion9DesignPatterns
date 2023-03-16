using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.ChainOfResponsibility
{
    public abstract class PipelineHandler
    {
        PipelineHandler next;
        public PipelineHandler(PipelineHandler next)
        {
            this.next = next;
        }
        public bool Handle(Project project)
        {
            bool success = handleRequest(project);
            if (success == false)
            {
                Console.WriteLine("Failed.");
                return false;
            }
            if (next != null)
            {
                return next.Handle(project);
            }
            Console.WriteLine("Pipeline Success.");
            return true;
        }
        protected abstract bool handleRequest(Project project);
    }
}
