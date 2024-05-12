using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    public class Logger
    {
        public void LogError(string message)
        {
            System.IO.File.WriteAllText("E:\\System Design\\SOLID", message);
        }
    }
}
