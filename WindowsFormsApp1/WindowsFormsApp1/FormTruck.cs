using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormTruck : Form
    {
        private DumpTruck truck;

        /// <summary>
        /// Конструктор
        /// </summary>
        public FormTruck()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод отрисовки машины
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCar.Width, pictureBoxCar.Height);
            Graphics gr = Graphics.FromImage(bmp);
            truck.DrawTruck(gr);
            pictureBoxCar.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            truck = new DumpTruck(rnd.Next(100, 300), rnd.Next(1000, 3000), Color.Black, Color.Orange, true, true);
            truck.SetPosition(rnd.Next(10, 60), rnd.Next(100, 400), pictureBoxCar.Width, pictureBoxCar.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    truck.MoveTruck(Enumeration.Up);
                    break;
                case "buttonDown":
                    truck.MoveTruck(Enumeration.Down);
                    break;
                case "buttonLeft":
                    truck.MoveTruck(Enumeration.Left);
                    break;
                case "buttonRight":
                    truck.MoveTruck(Enumeration.Right);
                    break;
            }
            Draw();
        }
    }
}
