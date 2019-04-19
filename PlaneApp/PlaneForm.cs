using System;
using System.Collections.Generic;
using System.Windows.Forms;

using PlaneAppLibrary;

namespace PlaneApp
{
    public partial class PlaneForm : Form
    {
        List<Plane> Planes = new List<Plane>();
        Plane selectedPlane;

        public PlaneForm()
        {
            InitializeComponent();

            SetRoute.Enabled = false;
            ShowRoute.Enabled = false;
            FullRefuel.Enabled = false;
            Refuel.Enabled = false;
            ToFlyPlane.Enabled = false;
        }


        /// <summary>
        /// Добавление нового самолёта
        /// </summary>
        private void CreatePlaneButton_Click(object sender, EventArgs e)
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

                planesListBox.DataSource = null;
                planesListBox.DataSource = Planes;
            }

            if (Planes.Count == 1)
            {
                SetRoute.Enabled = true;
                ShowRoute.Enabled = true;
                FullRefuel.Enabled = true;
                Refuel.Enabled = true;
                ToFlyPlane.Enabled = true;
            }
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
        }


        /// <summary>
        /// Запуск самолёта на полёт
        /// </summary>
        private void ToFlyPlane_Click(object sender, EventArgs e)
        {
            double result = selectedPlane.ToFly(selectedPlane.GetRate(), selectedPlane.GetFuelLevel(), selectedPlane.ID);
            if (result > 0)
            {
                selectedPlane.WasteFuel(result);
                Update();
            }
        }


        /// <summary>
        /// Показать маршрут
        /// </summary>
        private void ShowRoute_Click(object sender, EventArgs e)
        {
            selectedPlane.GetRoute(selectedPlane.ID, selectedPlane.Name);
        }


        /// <summary>
        /// Установить маршрут
        /// </summary>
        private void SetRoute_Click(object sender, EventArgs e)
        {          
            selectedPlane.SetRoute(selectedPlane.ID);
        }


        /// <summary>
        /// Полностью дозаправить самолёт
        /// </summary>
        private void FullRefuel_Click(object sender, EventArgs e)
        {
            Plane selPlane = (Plane)planesListBox.SelectedItem;
            selPlane.Refuel();
            Update();
        }


        /// <summary>
        /// Дозаправить самолёт на определённое количество топлива
        /// </summary>
        private void Refuel_Click(object sender, EventArgs e)
        {
            AddFuel addFuel = new AddFuel(selectedPlane.GetRate());
            addFuel.ShowDialog();

            if (addFuel.Ready)
            {
                selectedPlane.Refuel(addFuel.Capasity);
                Update();
            }
        }


        /// <summary>
        /// Обновить содержимое листа
        /// </summary>
        public new void Update()
        {
            planesListBox.DataSource = null;
            planesListBox.DataSource = Planes;
        }
    }
}
