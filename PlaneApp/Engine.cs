using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneApp
{
    /// <summary>
    /// Представляет методы и свойства класса "Двигатель"
    /// </summary>
    class Engine : IPlanePart
    {
        public string Name { get; set; }
        double Rate { get; set; }
        int Count { get; set; }


        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="Rate">Расход топлива для одного двигателя</param>
        /// <param name="Name">Название двигателя</param>
        /// <param name="Count">Количество двигателей</param>
        public Engine(double Rate, string Name, int Count)
        {
            if (Name.ToLowerInvariant().Contains("двигатель"))
                this.Name = Name;
            else
                this.Name = $"Двигатель {Name.Trim()}";

            this.Rate = Rate;
            this.Count = Count;
        }


        /// <summary>
        /// Получить расход топлива одного двигателя
        /// </summary>
        public double GetRate() => Rate;


        /// <summary>
        /// Установить расход топлива одного двигателя
        /// </summary>
        public void SetRate(double newRate)
        {
            Rate = newRate;
            MessageBox.Show($"Расход топлива установлен на {Rate}");
        }


        /// <summary>
        /// Получить количество двигателей
        /// </summary>
        public int GetEnginesCount() => Count;


        /// <summary>
        /// Установить количество двигателей
        /// </summary>
        public void SetEnginesCount(int newCount)
        {
            Count = newCount;
            MessageBox.Show($"Количество двигателей изменено на {Count}");
        }


        /// <summary>
        /// Получить имя двигателя
        /// </summary>
        public string GetName()
        {
            return Name;
        }


        /// <summary>
        /// Получить спецификацию двигателя
        /// </summary>
        public string GetSpecs()
        {
            return $"Расход топлива для одного двигателя: {Rate}; Количество двигателей: {Count}";
        }


        public override string ToString()
        {
            return $"{GetName()} :: {GetSpecs()}";
        }
    }
}
