using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Command
{
    public class Village
    {
        public int Food { get; set; }
        public int Wood { get; set; }

        public List<Worker> workers = new List<Worker>();

        public void AddWorker(ICommand command)
        {
            workers.Add(new Worker(command));
        }

        public void Day()
        {
            foreach (Worker worker in workers)
            {
                worker.DoWork();
            }
        }
    }
}
