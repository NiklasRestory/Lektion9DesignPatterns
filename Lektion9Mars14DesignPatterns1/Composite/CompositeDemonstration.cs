using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Composite
{
    public class CompositeDemonstration
    {
        public void Run()
        {
            Folder folder = new Folder("Folder 1");

            File regularFile = new File("Regular file");
            folder.AddComponent(regularFile);

            Folder schoolMemories = new Folder("School Memories");
            File graduationPhoto = new File("GraduationPhoto");

            folder.AddComponent(schoolMemories);
            schoolMemories.AddComponent(graduationPhoto);

            File otherFile = new File("OtherFile");
            folder.AddComponent(otherFile);

            folder.PrintContents();
        }
    }
}
