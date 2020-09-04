using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using x3.IO;

namespace x3.GSpecific.Border
{
    public class Border_ForThisImplementation:ISomeBorder
    {
        public Border_ForThisImplementation(IBox box)
        {
            Box=box;
        }

        public IBox Box { get; }

        public void Do()
        {
            Box.Display();
        }
    }
}
