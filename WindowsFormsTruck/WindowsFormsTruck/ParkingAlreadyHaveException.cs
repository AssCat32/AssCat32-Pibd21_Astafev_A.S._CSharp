using System;
namespace WindowsFormsCars
{
    /// <summary>
    /// Класс-ошибка "Если в гараже уже есть грузовик с такими же характеристиками"
    /// </summary>
    public class GarageAlreadyHaveException : Exception
    {
        public GarageAlreadyHaveException() : base("В гараже уже есть такая грузовик!")
        { }
    }
}
