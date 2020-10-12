using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsCars;

namespace WindowsFormsTruck
{
    public partial class FormGarage : Form
    {
        /// <summary>
        /// Объект от класса-коллекции парковок
        /// </summary>
        private readonly GarageCollection garageCollection;
        public FormGarage()
        {
            InitializeComponent();
            garageCollection = new GarageCollection(pictureBoxGarage.Width, pictureBoxGarage.Height);
        }
        /// <summary>
        /// Заполнение listBoxLevels
        /// </summary>
        private void ReloadLevels()
        {
            int index = listBoxGarage.SelectedIndex;
            listBoxGarage.Items.Clear();
            for (int i = 0; i < garageCollection.Keys.Count; i++)
            {
                listBoxGarage.Items.Add(garageCollection.Keys[i]);
            }
            if (listBoxGarage.Items.Count > 0 && (index == -1 || index >= listBoxGarage.Items.Count))
            {
                listBoxGarage.SelectedIndex = 0;
            }
            else if (listBoxGarage.Items.Count > 0 && index > -1 && index < listBoxGarage.Items.Count)
            {
                listBoxGarage.SelectedIndex = index;
            }
            Draw();
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            if (listBoxGarage.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxGarage.Width, pictureBoxGarage.Height);
                Graphics gr = Graphics.FromImage(bmp);
                garageCollection[listBoxGarage.SelectedItem.ToString()].Draw(gr);
                pictureBoxGarage.Image = bmp;
            }
            else
            {
                Bitmap bmp = new Bitmap(pictureBoxGarage.Width, pictureBoxGarage.Height);
                Graphics gr = Graphics.FromImage(bmp);
                pictureBoxGarage.Image = bmp;
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Добавить парковку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddGarage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            garageCollection.AddGarage(textBoxNewLevelName.Text);
            ReloadLevels();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Удалить парковку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelParking_Click(object sender, EventArgs e)
        {
            if (listBoxGarage.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку {textBoxNewLevelName.Text}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    garageCollection.DelGarage(textBoxNewLevelName.Text);
                    ReloadLevels();
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetTruck_Click(object sender, EventArgs e)
        {
            if (listBoxGarage.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var truck = new Truck(100, 1000, dialog.Color);
                    if (garageCollection[listBoxGarage.SelectedItem.ToString()] + truck)
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
        /// Обработка нажатия кнопки "Припарковать гоночный автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetDumpTruck_Click(object sender, EventArgs e)
        {
            if (listBoxGarage.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var truck = new DumpTruck(100, 1000, dialog.Color, dialogDop.Color, true, true);
                        if (garageCollection[listBoxGarage.SelectedItem.ToString()] + truck)
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
        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeTruck_Click(object sender, EventArgs e)
        {
            if (listBoxGarage.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                var car = garageCollection[listBoxGarage.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                if (car != null)
                {
                    FormTruck form = new FormTruck();
                    form.SetCar(car);
                    form.ShowDialog();
                }
                Draw();
            }
        }
        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void listBoxGarage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}