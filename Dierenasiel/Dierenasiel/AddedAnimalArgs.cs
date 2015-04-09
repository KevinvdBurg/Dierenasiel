using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenasiel
{
    public class AddedAnimalArgs : EventArgs
    {
        public List<Animal> animals = new List<Animal>();
    }
}
