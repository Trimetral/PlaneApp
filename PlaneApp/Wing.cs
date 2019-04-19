using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneApp
{
    /// <summary>
    /// Представляет методы и свойства класса "Крыло"
    /// </summary>
    class Wing : IPlanePart
    {
        public string Name { get; set; }
        double FuelLevel { get; set; }
        double FuelMax { get; }   

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="FuelLevel">Текущее количество топлива в баках</param>
        /// <param name="FuelMax">Максимальное количество топлива в баках</param>
        public Wing()
        {
            Name = "Крыло";
            this.FuelLevel = 0d;
            this.FuelMax = 0d;
        }

        /// <summary>
        /// Получить теккущее количество топлива в баках
        /// </summary>
        public double GetFuelLevel()
        {
            return FuelLevel;
        }


        /// <summary>
        /// Получить имя части самолёта
        /// </summary>
        public string GetName()
        {
            return Name;
        }


        /// <summary>
        /// Получить спецификацию части самолёта
        /// </summary>
        public string GetSpecs()
        {
            return $"Максимальное количество топлива: {FuelMax}; Топлива в баке на данный момент: {FuelLevel:0.00}";
        }


        /// <summary>
        /// Заправить самолёт
        /// </summary>
        public void Refuel()
        {
            FuelLevel = FuelMax;
            MessageBox.Show("Бак заправлен до конца");
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
                MessageBox.Show($"Бак заправлен, лишнее топливо: {extra}");
            }
            else
            {
                MessageBox.Show($"Бак заправлен на {FuelLevel / FuelMax * 100}%");
            }
        }


        public override string ToString()
        {
            return $"{GetName()} :: {GetSpecs()}";
        }
    }
}
