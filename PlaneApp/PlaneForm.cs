using System;
using System.Collections.Generic;
using System.Windows.Forms;

using PlaneAppLibrary;

namespace PlaneApp
{
    public partial class PlaneForm : Form
    {
        List<Plane> Planes = new List<Plane>();
        List<Plane> PlanesToShow = new List<Plane>();
        Plane selectedPlane;

        public PlaneForm()
        {
            InitializeComponent();

            ToFlyPlane.Enabled = false;

            маршрутToolStripMenuItem.Enabled = false;
            топливоToolStripMenuItem.Enabled = false;
            изменитьСамолётToolStripMenuItem.Enabled = false;
            удалитьToolStripMenuItem.Enabled = false;
        }
       


        /// <summary>
        /// При изменении выделенного объекта в листе, изменяется окно с описанием самолёта
        /// </summary>
        private void planesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (planesListBox.SelectedIndex > -1)
            {
                selectedPlane = (Plane)planesListBox.SelectedItem;
                specsTextBox.Text = selectedPlane.GetSpecs();
            }
            else
            {
                specsTextBox.Text = "";
            }
        }


        /// <summary>
        /// Запуск самолёта на полёт
        /// </summary>
        private void ToFlyPlane_Click(object sender, EventArgs e)
        {
            double result = selectedPlane.ToFly(selectedPlane.Engine.GetRate(), selectedPlane.Wing.GetFuelLevel(), selectedPlane.ID, selectedPlane.Engine.GetEnginesCount());
            if (result > 0)
            {
                selectedPlane.Wing.WasteFuel(result);
                Update();
            }
        }


        /// <summary>
        /// Обновить содержимое листа и состояния кнопок
        /// </summary>
        public new void Update()
        {
            PlanesToShow = new List<Plane>();
            foreach (Plane plane in Planes)
            {
                if (plane != null)
                    PlanesToShow.Add(plane);
            }

            planesListBox.DataSource = null;
            planesListBox.DataSource = PlanesToShow;

            if (PlanesToShow.Count > 0)
            {
                ToFlyPlane.Enabled = true;

                маршрутToolStripMenuItem.Enabled = true;
                топливоToolStripMenuItem.Enabled = true;
                изменитьСамолётToolStripMenuItem.Enabled = true;
                удалитьToolStripMenuItem.Enabled = true;
            }
            else
            {
                ToFlyPlane.Enabled = false;

                маршрутToolStripMenuItem.Enabled = false;
                топливоToolStripMenuItem.Enabled = false;
                изменитьСамолётToolStripMenuItem.Enabled = false;
                удалитьToolStripMenuItem.Enabled = false;
            }
        }


        #region Кнопки


        /// <summary>
        /// Добавление нового самолёта
        /// </summary>
        private void добавитьСамолётToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddingPlane adding = new AddingPlane(Planes.Count);
            adding.ShowDialog();

            if (adding.Ready)
            {
                Plane newPlane = new Plane(
                    new Engine(adding.eRate, adding.engineName, adding.eCount),
                    new Gear() { Count = adding.gerCount, Diam = adding.gerDiam },
                    new Wing() { FuelLevel = adding.curFuel, FuelMax = adding.maxFuel },
                    adding.planeName);

                Planes.Add(newPlane);

                Update();
            }
        }


        /// <summary>
        /// Изменение выбранного самолёта
        /// </summary>
        private void изменитьСамолётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddingPlane adding = new AddingPlane(selectedPlane);
            adding.ShowDialog();

            if (adding.Ready)
            {
                Planes[Planes.IndexOf(selectedPlane)] = adding.Plane;
                Update();
            }
        }


        /// <summary>
        /// Удаление самолёта из списка
        /// </summary>
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planes[Planes.IndexOf(selectedPlane)] = null;
            Update();
        }


        /// <summary>
        /// Установить маршрут
        /// </summary>
        private void задатьМаршрутToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedPlane.SetRoute(selectedPlane.ID);
        }


        /// <summary>
        /// Показать маршрут
        /// </summary>
        private void показатьМаршрутToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedPlane.GetRoute(selectedPlane.ID, selectedPlane.Name);
        }


        /// <summary>
        /// Полностью дозаправить самолёт
        /// </summary>
        private void заправитьДоКонцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plane selPlane = (Plane)planesListBox.SelectedItem;
            selPlane.Wing.Refuel();
            Update();
        }


        /// <summary>
        /// Дозаправить самолёт на 1 тонну
        /// </summary>
        private void тToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plane selPlane = (Plane)planesListBox.SelectedItem;
            selPlane.Wing.Refuel(1000);
            Update();
        }


        /// <summary>
        /// Дозаправить самолёт на 5 тонн
        /// </summary>
        private void тToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Plane selPlane = (Plane)planesListBox.SelectedItem;
            selPlane.Wing.Refuel(5000);
            Update();
        }


        /// <summary>
        /// Дозаправить самолёт на определённое количество топлива
        /// </summary>
        private void своёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFuel addFuel = new AddFuel(selectedPlane.Engine.GetRate(), selectedPlane.Engine.GetEnginesCount());
            addFuel.ShowDialog();

            if (addFuel.Ready)
            {
                selectedPlane.Wing.Refuel(addFuel.Capasity);
                Update();
            }
        }



        #endregion

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа 'Управление самолётами' предназначена для добавления самолётов в базу и управления ими." +
                "\r\nДля добавления самолёта нажмите в меню 'Самолёты' и 'Добавить самолёт'. " +
                "В открывшемся окне появятся характеристики нового самолёта, при этом, присутствуют 4 готовые комплектации." +
                "\r\nДля изменения какого-либо самолёта или удаления, нажмите 'Самолёты' и 'Изменить самолёт' или 'Удалить' соответственно." +
                "\r\n\r\nЧтобы самолёт совершил полёт, у него должно быть достаточно топлива и должен быть задан маршрут. " +
                "\r\nЗаправить самолёт можно нажав в меню кнопку 'Топливо' и выбрать нужное количество. Для более точного количества выберите 'Заправить на...' и 'Другое'." +
                "\r\nВ открывшемся окне можно рассчитать количество топлива для самолёта по заданному расстоянию." +
                "\r\n\r\nДля задания маршрута нажмите в меню 'Маршрут' и 'Задать маршрут', в котором нужно ввести необходимое количество километров." +
                "\r\nПосле этого, по нажатию кнопки 'Полёт', выведется результат полёт, если все условия были удовлетворены.", 
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
