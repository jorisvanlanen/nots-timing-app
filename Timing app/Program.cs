using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Timing_app
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass();
            test.SetUp();
            test.StartTest();
        }
    }
}
