using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsTruck
{
    public class Truck : Vehicle
    {

        //<summary>
        //Ширина и высота отрисовки самосвала
        //</summary>
        protected readonly int truckWidth = 112;
        protected readonly int truckHeight = 42;

        protected readonly char separator = ';';
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public Truck(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public Truck(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        /// <summary>
        /// Конструкторс изменением размеров машины
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="carWidth">Ширина отрисовки автомобиля</param>
        /// <param name="carHeight">Высота отрисовки автомобиля</param>
        protected Truck(int maxSpeed, float weight, Color mainColor, int truckWidth, int truckHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.truckWidth = truckWidth;
            this.truckHeight = truckHeight;
        }
        public override void MoveTransport(Enumeration enumeration)
        {
            float step = MaxSpeed * 100 / Weight;
            int truckLeftIndent = 1;
            int truckDownIndent = 12;
            switch (enumeration)
            {
                //вправо
                case Enumeration.Right:
                    if (_startPosX + step < _pictureWidth - truckWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Enumeration.Left:
                    if (_startPosX - step > truckLeftIndent)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Enumeration.Up:
                    if (_startPosY - step > truckHeight)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Enumeration.Down:
                    if (_startPosY + step < _pictureHeight - truckDownIndent)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush br = new SolidBrush(MainColor);
            Brush brGreen = new SolidBrush(Color.Green);
            Brush brGray = new SolidBrush(Color.Gray);
            Brush brBlue = new SolidBrush(Color.LightBlue);
            Brush brWhite = new SolidBrush(Color.White);

            //Прицеп грузовика     
            g.FillRectangle(br, _startPosX, _startPosY, 110, 5);
            g.FillRectangle(brGray, _startPosX + 46, _startPosY + 3, 30, 5);

            //Кабина грузовика
            g.FillRectangle(brGreen, _startPosX + 79, _startPosY - 24, 35, 25);
            g.FillRectangle(brGreen, _startPosX + 79, _startPosY - 31, 33, 7);
            g.FillRectangle(brGreen, _startPosX + 79, _startPosY - 35, 31, 4);

            //Стекла грузовика
            g.FillRectangle(brBlue, _startPosX + 88, _startPosY - 30, 10, 15);
            g.FillRectangle(brBlue, _startPosX + 100, _startPosY - 27, 8, 14);

            //Первое колесо
            g.FillEllipse(br, _startPosX + 2, _startPosY - 2, 18, 18);
            g.FillEllipse(brWhite, _startPosX + 6, _startPosY + 2, 10, 10);

            //Второе колесо
            g.FillEllipse(br, _startPosX + 86, _startPosY - 2, 18, 18);
            g.FillEllipse(brWhite, _startPosX + 90, _startPosY + 2, 10, 10);


            //Третье колесо
            g.FillEllipse(br, _startPosX + 20, _startPosY - 2, 18, 18);
            g.FillEllipse(brWhite, _startPosX + 24, _startPosY + 2, 10, 10);

        }

        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }
    }
}
