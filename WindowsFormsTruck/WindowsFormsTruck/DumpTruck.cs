using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTruck
{
    //<summary>
    //Класс отрисовки спортивного автомобиля
    //</summary>
    class DumpTruck : Truck, IEquatable<DumpTruck>
    {
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
        public DumpTruck(int maxSpeed, float weight, Color mainColor, Color dopColor, bool trailer, bool cargo) : base(maxSpeed, weight, mainColor, 112, 42)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Trailer = trailer;
            Cargo = cargo;
        }

        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info"></param>
        public DumpTruck(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Trailer = Convert.ToBoolean(strs[4]);
                Cargo = Convert.ToBoolean(strs[5]);
            }
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

        /// <summary>
        /// Отрисовка грузовика
        /// </summary>
        /// <param name="g"></param>
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush br = new SolidBrush(MainColor);
            Brush brDop = new SolidBrush(DopColor);
            Brush brGray = new SolidBrush(Color.Gray);
            Brush brBlue = new SolidBrush(Color.LightBlue);
            Brush brWhite = new SolidBrush(Color.White);

            base.DrawTransport(g);


            //Груз
            if (Trailer)
            {
                Brush spoiler = new SolidBrush(DopColor);
                if (Cargo)
                {

                    g.FillRectangle(brGray, _startPosX + 10, _startPosY - 50, 34, 5);
                    g.FillRectangle(brGray, _startPosX + 7, _startPosY - 47, 41, 10);
                    g.FillRectangle(brGray, _startPosX + 1, _startPosY - 44, 70, 7);
                }
                g.FillRectangle(brDop, _startPosX - 2, _startPosY - 36, 74, 34);
                g.FillRectangle(brDop, _startPosX - 5, _startPosY - 38, 80, 30);
                g.FillRectangle(brDop, _startPosX + 55, _startPosY - 40, 30, 3);
            }
        }

        /// <summary>
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{Trailer}{separator}{Cargo}";
        }

        /// <summary>
        /// Метод интерфейса IEquatable для класса SportCar
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(DumpTruck other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Trailer != other.Trailer)
            {
                return false;
            }
            if (Cargo != other.Cargo)
            {
                return false;
            }
            return true;

        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is DumpTruck truckObj))
            {
                return false;
            }
            else
            {
                return Equals(truckObj);
            }
        }
    }
}
