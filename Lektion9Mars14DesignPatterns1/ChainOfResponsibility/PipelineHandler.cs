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
        // In Chain of Responsibility, we want to chain Handlers. Each
        // handler will call the next handler in the process. However,
        // it should only do so if it is successful in its own task.
        // Should any point of the chain fail, the whole chain should
        // fail and the next handler is not called.
        public bool Handle(Project project)
        {
            bool success = handleRequest(project); // Do the unique implementation of this specific handler.
            if (success == false) // If we fail
            {
                Console.WriteLine("Failed.");
                return false; // Fail the whole chain and stop.
            }
            if (next != null) // If we succeed, we check if there's another handler in the chain.
            {
                return next.Handle(project); // If there is, call that one's Handler, and return if it fails or succeeds.
            }
            Console.WriteLine("Pipeline Success.");
            return true; // If this was the end, then it means we succeeded the whole chain, and the pipeline returns true for success.
        }
        // Abstract function must be implemented by classes that
        // inherit from this object.
        protected abstract bool handleRequest(Project project);
    }
}
