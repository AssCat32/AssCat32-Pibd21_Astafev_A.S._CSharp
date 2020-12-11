using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

        private readonly char separator = ':';
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
                if (garageStages.ContainsKey(ind))
                {
                    return garageStages[ind];
                }
                else {
                    return null;
                } 
            }
        }

        /// <summary>
        /// Сохранение информации по автомобилям на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            using (StreamWriter sw = new StreamWriter(filename, false))
            {
                sw.WriteLine($"GarageCollection", sw);
                foreach (var level in garageStages)
                {
                    sw.WriteLine($"Garage{separator}{level.Key}", sw);
                    ITransport truck = null;
                    for (int i = 0; (truck = level.Value.GetNext(i)) != null; i++)
                    {
                        if (truck != null)
                        {
                            //если место не пустое
                        //Записываем тип машины
                        if (truck.GetType().Name == "Truck")
                        {
                            sw.WriteLine($"Truck{separator}", sw);

                        }
                        if (truck.GetType().Name == "DumpTruck")
                        {
                            sw.WriteLine($"DumpTruck{separator}", sw);
                        }
                        //Записываемые параметры
                            
                        sw.Write(truck + sw.NewLine, sw);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                if ((line = sr.ReadLine()) != null) {
                    if (line.Contains("GarageCollection"))
                    {
                        //очищаем записи
                        garageStages.Clear();
                    }
                    else
                    {
                        //если нет такой записи, то это не те данные
                        throw new FileFormatException();
                    }
                    Vehicle truck = null;
                    string key = string.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains("Garage"))
                        {
                            //начинаем новую парковку
                            key = line.Split(separator)[1];
                            garageStages.Add(key, new Garage<Vehicle>(pictureWidth, pictureHeight));
                            continue;
                        }
                        if (string.IsNullOrEmpty(line))
                        {
                            continue;
                        }
                        if (line.Split(separator)[0] == "Truck")
                        {
                            truck = new Truck(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "DumpTruck")
                        {
                            truck = new DumpTruck(line.Split(separator)[1]);
                        }
                        var result = garageStages[key] + truck;
                        if (!result)
                        {
                            throw new GarageOccupiedPlaceException();
                        }
                    }
                }
            }
        }
    }
}