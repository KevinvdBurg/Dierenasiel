using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenasiel
{
    public class NoMapException : Exception
    {
        public NoMapException(string canNotSelectNoMap, string saveFileDialog)
        {
            Console.WriteLine(canNotSelectNoMap, saveFileDialog);
            //throw new NotImplementedException();
        }
    }
}
