﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierenasiel
{
    public class AnimalEventArgs : EventArgs
    {
        public List<Animal> animals { get; set; }
    }
}
