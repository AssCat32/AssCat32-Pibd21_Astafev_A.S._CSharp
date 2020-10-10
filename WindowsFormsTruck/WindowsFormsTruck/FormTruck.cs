using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTruck
{
    public partial class FormTruck : Form
    {

        private ITransport truck;

        /// <summary>
        /// Конструктор
        /// </summary>
        public FormTruck()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Передача машины на форму
        /// </summary>
        /// <param name="truck"></param>
        public void SetCar(ITransport truck)
        {
            this.truck = truck;
            Draw();
        }

        /// <summary>
        /// Метод отрисовки машины
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTruck.Width, pictureBoxTruck.Height);
            Graphics gr = Graphics.FromImage(bmp);
            truck?.DrawTransport(gr);
            pictureBoxTruck.Image = bmp;
        }

        private void buttonCreateDumpTruck_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            truck = new DumpTruck(rnd.Next(100, 300), rnd.Next(1000, 3000), Color.Black, Color.Orange, true, true);
            truck.SetPosition(rnd.Next(10, 60), rnd.Next(100, 400), pictureBoxTruck.Width, pictureBoxTruck.Height);
            Draw();
        }

        private void buttonCreateTruck_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            truck = new Truck(rnd.Next(100, 300), rnd.Next(1000, 3000), Color.Black);
            truck.SetPosition(rnd.Next(10, 60), rnd.Next(100, 400), pictureBoxTruck.Width, pictureBoxTruck.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    truck.MoveTransport(Enumeration.Up);
                    break;
                case "buttonDown":
                    truck.MoveTransport(Enumeration.Down);
                    break;
                case "buttonLeft":
                    truck.MoveTransport(Enumeration.Left);
                    break;
                case "buttonRight":
                    truck.MoveTransport(Enumeration.Right);
                    break;
            }
            Draw();
        }

        private void FormTruck_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxTruck_Click(object sender, EventArgs e)
        {

        }
    }
}
