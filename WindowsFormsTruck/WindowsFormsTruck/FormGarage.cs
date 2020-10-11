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
    public partial class FormGarage : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        private readonly Garage<Truck> parking;
        public FormGarage()
        {
            InitializeComponent();
            parking = new Garage<Truck>(pictureBoxGarage.Width,
            pictureBoxGarage.Height);
            Draw();
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxGarage.Width, pictureBoxGarage.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxGarage.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetTruck_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var truck = new Truck(100, 1000, dialog.Color);
                if (parking + truck)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать гоночный автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetDumpTruck_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var truck = new DumpTruck(100, 1000, dialog.Color, dialogDop.Color,
                    true, true);
                    if (parking + truck)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeTruck_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var truck = parking - Convert.ToInt32(maskedTextBox.Text);
                if (truck != null)
                {
                    FormTruck form = new FormTruck();
                    form.SetCar(truck);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void FormGarage_Load(object sender, EventArgs e)
        {

        }
    }
}
