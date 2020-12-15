using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace WindowsFormsTruck
{
    public interface ITransport
    {
        /// <summary>
        /// Установка позиции
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        void SetPosition(int x, int y, int width, int height);

        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="enumeration">Направление</param>
        void MoveTransport(Enumeration enumeration);

        /// <summary>
        /// Отрисовка
        /// </summary>
        /// <param name="g"></param>
        void DrawTransport(Graphics g);

        /// <summary>
        /// Смена основного цвета
        /// </summary>
        /// <param name="color"></param>
       void SetMainColor(Color color);
    }
}
