using System;
using System.Runtime.Serialization;

namespace WindowsFormsTruck
{
    [Serializable]
    internal class GarageOccupiedPlaceException : Exception
    {
        public GarageOccupiedPlaceException() : base("Не удалось поставить грузовик в гараж!")
        { }
    }
}