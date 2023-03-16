using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.ChainOfResponsibility
{
    public class Project
    {
        public bool CanBuild { get; set; }
        public bool PassesUnitTests { get; set; }
        public bool PassesIntegrationTests { get; set; }
        public Project(bool canBuild, bool passesUnitTests, bool passesIntegrationTests)
        {
            CanBuild = canBuild;
            PassesUnitTests = passesUnitTests;
            PassesIntegrationTests = passesIntegrationTests;
        }
    }
}
