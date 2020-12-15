using NLog;
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
        /// 
  

        private readonly GarageCollection garageCollection;

        private readonly Logger logger;
        public FormGarage()
        {
            InitializeComponent();
            garageCollection = new GarageCollection(pictureBoxGarage.Width, pictureBoxGarage.Height);
            logger = LogManager.GetCurrentClassLogger();
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
                logger.Warn($"При добавлении гаража отсутствовало название");
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили парковку {textBoxNewLevelName.Text}");
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
                    logger.Info($"Удалили парковку {listBoxGarage.SelectedItem.ToString()}");
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
                            MessageBox.Show("Гаражи переполнены");
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
                try
                {
                    var truck = garageCollection[listBoxGarage.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                    if (truck != null)
                    {
                        FormTruck form = new FormTruck();
                        form.SetCar(truck);
                        form.ShowDialog();
                        logger.Info($"Изъят грузовик {truck} с места {maskedTextBox.Text}");
                        Draw();
                    }
                }
                catch (GarageNotFoundException ex)
                {
                    logger.Warn($"Грузовик по месту {maskedTextBox.Text} не найден");
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Возникла неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Draw();
        }
        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void listBoxGarage_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на парковку {listBoxGarage.SelectedItem.ToString()}");
            Draw();
        }

        /// <summary>
        /// Обработка нажатия кнопки "Добавить автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetCar_Click(object sender, EventArgs e)
        {
            var formCarConfig = new FormTruckConfig();
            formCarConfig.AddEvent(AddTruck);
            formCarConfig.Show();
        }
        /// <summary>
        /// Метод добавления машины
        /// </summary>
        /// <param name="car"></param>
        private void AddTruck(Vehicle truck)
        {
            if (truck != null && listBoxGarage.SelectedIndex > -1)
            {
                try
                {
                    if ((garageCollection[listBoxGarage.SelectedItem.ToString()]) + truck)
                    {
                        Draw();
                        logger.Info($"Добавлен грузовик {truck}");
                    }
                    else
                    {
                        logger.Warn("Грузовик не удалось добавить в гараж");
                        MessageBox.Show("Грузовик не удалось поставить");
                    }
                }
                catch (GarageOverflowException ex)
                {
                    logger.Warn("Произошло переполнение гаражей");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Возникла неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /// <summary>
        /// Обработка нажатия пункта меню "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try {
                    garageCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Возникла неизвестная ошибка при сохранении");
                }

            }
        }

        /// <summary>
        /// Обработка нажатия пункта меню "Загрузить"
        /// </summary>
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    garageCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (GarageOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Не удалось загрузить поезд в депо");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Возникла неизвестная ошибка при загрузке");
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormGarage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxGarage.SelectedIndex > -1)
            {
                garageCollection[listBoxGarage.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
        }
    }
}