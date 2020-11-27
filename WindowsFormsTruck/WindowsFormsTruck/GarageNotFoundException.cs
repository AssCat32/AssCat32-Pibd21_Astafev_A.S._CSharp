using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTruck
{
    class GarageNotFoundException : Exception
    {
        public GarageNotFoundException(int i) : base("Не найден грузовик по месту " + i)
        { }
    }
}
