using System;

public class BaseTruck: Truck
{

    //<summary>
    //Ширина и высота отрисовки самосвала
    //</summary>
    protected readonly int truckWidth = 112;
    protected readonly int truckHeight = 42;
   
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="maxSpeed">Максимальная скорость</param>
    /// <param name="weight">Вес автомобиля</param>
    /// <param name="mainColor">Основной цвет кузова</param>
    public Car(int maxSpeed, float weight, Color mainColor)
    {
        MaxSpeed = maxSpeed;
        Weight = weight;
        MainColor = mainColor;
    }
    /// <summary>
    /// Конструкторс изменением размеров машины
    /// </summary>
    /// <param name="maxSpeed">Максимальная скорость</param>
    /// <param name="weight">Вес автомобиля</param>
    /// <param name="mainColor">Основной цвет кузова</param>
    /// <param name="carWidth">Ширина отрисовки автомобиля</param>
    /// <param name="carHeight">Высота отрисовки автомобиля</param>
    protected Car(int maxSpeed, float weight, Color mainColor, int carWidth, int carHeight)
    {
        MaxSpeed = maxSpeed;
        Weight = weight;
        MainColor = mainColor;
        this.carWidth = carWidth;
        this.carHeight = carHeight;
    }
    public override void MoveTruck(Enumeration enumeration)
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
    public override void DrawTruck(Graphics g)
    {
        Pen pen = new Pen(Color.Black);
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

    }
}
