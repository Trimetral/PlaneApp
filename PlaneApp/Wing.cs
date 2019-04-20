using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneAppLibrary
{
    /// <summary>
    /// Представляет методы и свойства класса "Крыло"
    /// </summary>
    public class Wing : IPlanePart
    {
        public string Name { get; set; }
        public double FuelLevel { get; set; }
        public double FuelMax { get; set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="FuelLevel">Текущее количество топлива в баках</param>
        /// <param name="FuelMax">Максимальное количество топлива в баках</param>
        public Wing()
        {
            Name = "Крыло";
            this.FuelLevel = 1.232342d;
            this.FuelMax = 0d;
        }

        /// <summary>
        /// Получить текущее количество топлива в баках
        /// </summary>
        public double GetFuelLevel() => FuelLevel;

        /// <summary>
        /// Изменить текущее количество топлива в баках
        /// </summary>
        public double SetFuelLevel(double Fuel) => FuelLevel = Fuel;


        /// <summary>
        /// Получить максимальное количество топлива в баках
        /// </summary>
        public double GetFuelLevelMax() => FuelMax;

        /// <summary>
        /// Изменить максимальное количество топлива в баках
        /// </summary>
        public double SetFuelLevelMax(double Fuel) => FuelMax = Fuel;


        /// <summary>
        /// Получить имя части самолёта
        /// </summary>
        public string GetName() => Name;


        /// <summary>
        /// Получить спецификацию части самолёта
        /// </summary>
        public string GetSpecs() => $"\r\n\tМаксимальное количество топлива: {FuelMax:0.##} кг; \r\n\tТоплива в баке на данный момент: {FuelLevel:0.##} кг;";


        /// <summary>
        /// Заправить самолёт
        /// </summary>
        public void Refuel()
        {
            double diff = (FuelMax - FuelLevel) * 50;
            FuelLevel = FuelMax;
            MessageBox.Show($"Бак заправлен до конца, цена: {diff:### ### ### ###} руб.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// <summary>
        /// Заправить самолёт на конкретное количетво топлива
        /// </summary>
        /// <param name="capacity"></param>
        public void Refuel(double capacity)
        {
            FuelLevel += capacity;
            if (FuelLevel > FuelMax)
            {
                double extra = FuelLevel - FuelMax;
                FuelLevel = FuelMax;
                MessageBox.Show($"Бак заправлен полностью, цена: {(capacity - extra) * 50:### ### ### ##0} руб.\r\nЛишнее топливо: {extra / 1000} т", "Предупреждение!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Бак заправлен на {FuelLevel / FuelMax * 100:##.##}%, цена {capacity * 50:### ### ### ###} руб.", "Предупреждение!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// Потратить топливо
        /// </summary>
        /// <param name="capacity">Количество потраченного топлива</param>
        public void WasteFuel(double capacity) => FuelLevel -= capacity;


        public override string ToString() => $"{GetName()} :: {GetSpecs()}";

    }
}
