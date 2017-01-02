using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciseCheck
{
    class name
    {
        public string[] getId;

        public void userName(string inputName)
        {
            string[] files = System.IO.Directory.GetFiles(inputName, "*", System.IO.SearchOption.AllDirectories);
            //string[] files2 = System.IO.Directory.GetFiles(inputName, "*.jsp", System.IO.SearchOption.AllDirectories);
            //Array.Copy(files2, files, files2.Length);
            getId = files;
        }
        
    }
}