using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTruck
{
    class GarageAlreadyHaveException : Exception
    {
        public GarageAlreadyHaveException() : base("В гараже уже есть такой грузовик!")
        {
        
        }
    }
}
