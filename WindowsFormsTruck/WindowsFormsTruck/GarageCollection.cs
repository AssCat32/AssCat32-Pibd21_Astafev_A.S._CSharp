using System.Collections.Generic;
using System.Linq;
using WindowsFormsTruck;

namespace WindowsFormsCars
{
    /// <summary>
    /// Класс-коллекция парковок
    /// </summary>
    public class GarageCollection
    {
        /// <summary>
        /// Словарь (хранилище) с парковками
        /// </summary>
        readonly Dictionary<string, Garage<Vehicle>> garageStages;
        /// <summary>
        /// Возвращение списка названий праковок
        /// </summary>
        public List<string> Keys => garageStages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public GarageCollection(int pictureWidth, int pictureHeight)
        {
            garageStages = new Dictionary<string, Garage<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        /// <summary>
        /// Добавление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void AddGarage(string name)
        {
            if (garageStages.ContainsKey(name))
            {
                return;
            }
            garageStages.Add(name, new Garage<Vehicle>(pictureWidth, pictureHeight));
        }
        /// <summary>
        /// Удаление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void DelGarage(string name)
        {
            if (garageStages.ContainsKey(name))
            {
                garageStages.Remove(name);
            }
        }
        /// <summary>
        /// Доступ к парковке
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Garage<Vehicle> this[string ind]
        {
            get
            {
                return garageStages[ind];
            }
        }
    }
}