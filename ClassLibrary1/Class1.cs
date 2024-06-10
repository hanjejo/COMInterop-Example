using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [Guid("62ceb9c7-4ba7-4cf2-b441-de7cf4025470"),
        ClassInterface(ClassInterfaceType.AutoDual),
        ComVisible(true)]
    public class Class1
    {
        public string test()
        {
            File.Open("./test.txt",FileMode.OpenOrCreate).Close();
            return "test";
        }
    }
}
