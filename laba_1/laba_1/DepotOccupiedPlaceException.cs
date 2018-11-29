using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    class DepotOccupiedPlaceException : Exception
    {
        public DepotOccupiedPlaceException(int i) : base("На месте " + i + " уже стоит поезд")
        { }
    }
}
