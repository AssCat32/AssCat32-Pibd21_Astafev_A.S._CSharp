using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    //<summary>
    //Класс отрисовки спортивного автомобиля
    //</summary>
    class DumpTruck
    {
        //<summary>
        //Стартовые координаты автомобиля X Y 
        //</summary>
        private float startPosX;
        private float startPosY;

        //<summary>
        //Ширина и высота самосвала
        //</summary>
        private int pictureWidth = 900;
        private int pictureHeight = 500;

        //<summary>
        //Ширина и высота отрисовки самосвала
        //</summary>
        private readonly int truckWidth = 112;
        private readonly int truckHeight = 42;

        //<summary>
        //Максимальная скорость самосвала
        //</summary>
        public int MaxSpeed { private set; get; }

        //<summary>
        //Вес самосвала
        //</summary>
        public float Weight { private set; get; }

        //<summary>
        //Основной цвет самосвала
        //</summary>
        public Color MainColor { private set; get; }

        //<summary>
        //Дополнительный цвет самосвала
        //</summary>
        public Color DopColor { private set; get; }

        //<summary>
        //Признак наличия прицепа
        //</summary>
        public bool Trailer { private set; get; }

        //<summary>
        //Признак наличия груза
        //</summary>
        public bool Cargo { private set; get; }

        //<summary>
        //Конструктор
        //</summary>
        public DumpTruck(int maxSpeed, float weight, Color mainColor, Color dopColor, bool trailer, bool cargo)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Trailer = trailer;
            Cargo = cargo;
        }

        //<summary>
        //Установка позиции грузовика
        //</summary>
        public void SetPosition(int x, int y, int width, int height)
        {
            startPosX = x;
            startPosY = y;
            pictureWidth = width;
            pictureHeight = height;
        }

        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTruck(Enumeration enumeration)
        {
            float step = MaxSpeed * 100 / Weight;
            int truckLeftIndent = 1;
            int truckDownIndent = 12;
            switch (enumeration)
            {
                //вправо
                case Enumeration.Right:
                    if (startPosX + step < pictureWidth - truckWidth)
                    {
                        startPosX += step;
                    }
                    break;
                //влево
                case Enumeration.Left:
                    if (startPosX - step > truckLeftIndent)
                    {
                        startPosX -= step;
                    }
                    break;
                //вверх
                case Enumeration.Up:
                    if (startPosY - step > truckHeight)
                    {
                        startPosY -= step;
                    }
                    break;
                //вниз
                case Enumeration.Down:
                    if (startPosY + step < pictureHeight - truckDownIndent)
                    {
                        startPosY += step;
                    }
                    break;
            }
        }

        /// <summary>
        /// Отрисовка грузовика
        /// </summary>
        /// <param name="g"></param>
        public void DrawTruck(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush br = new SolidBrush(MainColor);
            Brush brDop = new SolidBrush(DopColor);
            Brush brGray = new SolidBrush(Color.Gray);
            Brush brBlue = new SolidBrush(Color.LightBlue);
            Brush brWhite = new SolidBrush(Color.White);

            //Прицеп грузовика     
            g.FillRectangle(br, startPosX, startPosY, 110, 5);
            g.FillRectangle(brGray, startPosX + 46, startPosY + 3, 30, 5);

            //Кабина грузовика
            g.FillRectangle(brDop, startPosX + 79, startPosY - 24, 35, 25);
            g.FillRectangle(brDop, startPosX + 79, startPosY - 31, 33, 7);
            g.FillRectangle(brDop, startPosX + 79, startPosY - 35, 31, 4);

            //Стекла грузовика
            g.FillRectangle(brBlue, startPosX + 88, startPosY - 30, 10, 15);
            g.FillRectangle(brBlue, startPosX + 100, startPosY - 27, 8, 14);

            //Первое колесо
            g.FillEllipse(br, startPosX + 2, startPosY - 2, 18, 18);
            g.FillEllipse(brWhite, startPosX + 6, startPosY + 2, 10, 10);

            //Второе колесо
            g.FillEllipse(br, startPosX + 86, startPosY - 2, 18, 18);
            g.FillEllipse(brWhite, startPosX + 90, startPosY + 2, 10, 10);

    
            //Третье колесо
            g.FillEllipse(br, startPosX + 20, startPosY - 2, 18, 18);
            g.FillEllipse(brWhite, startPosX + 24, startPosY + 2, 10, 10);
                

            //Груз
            if (Trailer)
            {
                Brush spoiler = new SolidBrush(DopColor);
                if (Cargo)
                {

                    g.FillRectangle(brGray, startPosX + 10, startPosY - 50, 34, 5);
                    g.FillRectangle(brGray, startPosX + 7, startPosY - 47, 41, 10);
                    g.FillRectangle(brGray, startPosX + 1, startPosY - 44, 70, 7);
                }
                g.FillRectangle(brDop, startPosX - 2, startPosY - 36, 74, 34);
                g.FillRectangle(brDop, startPosX - 5, startPosY - 38, 80, 30);
                g.FillRectangle(brDop, startPosX + 55, startPosY - 40, 30, 3);
            }
        }
    }
}


