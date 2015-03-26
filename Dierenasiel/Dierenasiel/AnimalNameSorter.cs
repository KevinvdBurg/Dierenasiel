using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenasiel
{
    class AnimalNameSorter : IComparer<Animal>
    {
        public int Compare(Animal x, Animal y)
        {
            return x.Name.CompareTo(y.Name);   
        }
    }
}
