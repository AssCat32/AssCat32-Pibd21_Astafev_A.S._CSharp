using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsTruck.Program;

namespace WindowsFormsTruck
{
    public partial class FormTruckConfig : Form
    {

        Vehicle truck = null;

        /// <summary>
        /// Событие
        /// </summary>
        private event Action<Vehicle> eventAddTruck;
        public FormTruckConfig()
        {
            InitializeComponent();

            foreach (var color in groupBoxColor.Controls)
            {
                if (color is Panel)
                {
                    ((Panel)color).MouseDown += panelColor_MouseDown;
                }
            }

            buttonReset.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void labelTruck_ClickDown(object sender, MouseEventArgs e)
        {
            labelTruck.DoDragDrop(labelTruck.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelDumpTruck_ClickDown(object sender, MouseEventArgs e)
        {
            labelDumpTruck.DoDragDrop(labelDumpTruck.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelTruck_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Грузовик":
                    truck = new Truck(100, 100, Color.White);
                    break;
                case "Самосвал":
                    truck = new DumpTruck(100, 100, Color.White, Color.Black, true, true);
                    break;
            }
            DrawTruck();
        }

        private void panelTruck_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void DrawTruck()
        {
            if (truck != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTruck.Width, pictureBoxTruck.Height);
                Graphics gr = Graphics.FromImage(bmp);
                truck.SetPosition(5, 60, pictureBoxTruck.Width, pictureBoxTruck.Height);
                truck.DrawTransport(gr);
                pictureBoxTruck.Image = bmp;
            }
        }

        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddTruck == null)
            {
                eventAddTruck = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddTruck += ev;
            }
        }

        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            ((Panel)sender).DoDragDrop(((Panel)sender).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void mainColor_DragDrop(object sender, DragEventArgs e)
        {
            truck?.SetMainColor((Color)(e.Data.GetData(typeof(Color))));
            DrawTruck();
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainColor_DragEnter(object sender, DragEventArgs e)
        { 
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }      

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (truck is DumpTruck)
            {
                (truck as DumpTruck).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                DrawTruck();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddTruck?.Invoke(truck);
            Close();
        }

    }
}
