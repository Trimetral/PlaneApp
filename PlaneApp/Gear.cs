using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneAppLibrary
{
    /// <summary>
    /// Представляет методы и свойства класса "Шасси"
    /// </summary>
    class Gear : IPlanePart
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double Diam { get; set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Gear()
        {
            this.Count = 3;
            this.Diam = 400d;
            this.Name = "Шасси";
        }

        public string GetName() => "Шасси";

        public string GetSpecs() => $"\r\n\tКоличество шасси: {Count};\r\n\tДиаметр: {Diam} мм;";


        public override string ToString()
        {
            return $"{GetName()} :: {GetSpecs()}";
        }
    }
}
