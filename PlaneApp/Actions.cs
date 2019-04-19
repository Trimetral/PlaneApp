using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneAppLibrary
{
    abstract class Actions
    {
        public Dictionary<int, double> Routes = new Dictionary<int, double>();

        public double ToFly(double rate, double fuel, int ID)
        {
            if (Routes.ContainsKey(ID))
            {
                double result = Routes[ID] / 900 * rate;
                if (result > fuel)
                {
                    MessageBox.Show("Самолёт не пролетит столько без дозаправок, выберите маршрут короче или дозаправьте самолёт", "Предупреждение");
                    return 0;
                }

                MessageBox.Show($"Самолёт пролетит {Routes[ID]} км примерно за {Routes[ID] / 900:##.##} ч и потратит {result / 1000:###.##} т топлива", "Полёт совершён");
                return result;
            }
            else
            {
                MessageBox.Show("Маршрут не задан", "Предупреждение");
                return 0;
            }
        }

        public void SetRoute(int ID)
        {
            if (Routes.ContainsKey(ID))
            {
                DialogResult dialogResult = MessageBox.Show("Маршрут уже существует, изменить его?", "Предупреждение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    AddRoute addRoute = new AddRoute();
                    addRoute.ShowDialog();
                    if (addRoute.Ready)
                    {
                        Routes.Add(ID, addRoute.route);
                    }
                }
            }
            else
            {
                AddRoute addRoute = new AddRoute();
                addRoute.ShowDialog();
                if (addRoute.Ready)
                {
                    Routes.Add(ID, addRoute.route);
                }
            }
        }

        public void GetRoute(int ID, string Name)
        {
            if (Routes.ContainsKey(ID))
                MessageBox.Show($"{Routes[ID]} км", $"Маршрут для {Name}");
            else
                MessageBox.Show("Маршрут не задан", "Предупреждение");
        }
    }
}
