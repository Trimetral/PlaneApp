using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneAppLibrary
{
    public abstract class Actions
    {
        /// <summary>
        /// Хранилище маршрутов для самолётов
        /// </summary>
        public Dictionary<int, double> Routes = new Dictionary<int, double>();


        /// <summary>
        /// Метод, запускающий самолёт в полёт, если все условия выполняются
        /// </summary>
        /// <param name="rate">Расход топлива</param>
        /// <param name="fuel">Количество топлива в баках</param>
        /// <param name="ID">ID самолёта</param>
        /// <returns>Возвращает истраченное количество топлива или 0, если полёт не совершился</returns>
        public double ToFly(double rate, double fuel, int ID, double countEng)
        {
            if (Routes.ContainsKey(ID))
            {
                double result = Routes[ID] / 900 * rate * countEng;
                if (result > fuel)
                {
                    MessageBox.Show("Самолёт не пролетит столько без дозаправок, выберите маршрут короче или дозаправьте самолёт!", "Ошибка!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }

                MessageBox.Show($"Самолёт пролетит {Routes[ID]} км примерно за {Routes[ID] / 900:##.##} ч и потратит {result / 1000:###.##} т топлива", "Полёт совершён",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                return result;
            }
            else
            {
                MessageBox.Show("Маршрут не задан!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }


        /// <summary>
        /// Метод, устанавливающий длину маршрута самолёта
        /// </summary>
        /// <param name="ID">ID самолёта</param>
        public void SetRoute(int ID)
        {
            if (Routes.ContainsKey(ID))
            {
                DialogResult dialogResult = MessageBox.Show("Маршрут уже существует, изменить его?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    AddRoute addRoute = new AddRoute();
                    addRoute.ShowDialog();
                    if (addRoute.Ready)
                    {
                        Routes[ID] = addRoute.route;
                        MessageBox.Show("Путь задан!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        /// <summary>
        /// Метод, выводящий длину маршрута самолёта
        /// </summary>
        /// <param name="ID">ID самолёта</param>
        /// <param name="Name">Название самолёта</param>
        public void GetRoute(int ID, string Name)
        {
            if (Routes.ContainsKey(ID))
                MessageBox.Show($"{Routes[ID]} км", $"Маршрут для {Name}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Маршрут не задан!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public string GetFullName(IPlanePart planePart) => $"{planePart.GetName()} :: {planePart.GetSpecs()}";
    }
}
