using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneAppLibrary
{
    class Plane : Actions, IPlanePart
    {
        private readonly Engine Engine;
        private readonly Gear Gear;
        private readonly Wing Wing;

        public string Name { get; set; }
        public int ID = 0;

        public Plane(Engine engine, Gear gear, Wing wing, string name)
        {
            this.Engine = engine;
            this.Gear = gear;
            this.Wing = wing;

            this.Name = name;
            ID = GetHashCode();
        }

        /// <summary>
        /// Заправить самолёт
        /// </summary>
        public void Refuel() => Wing.Refuel();

        /// <summary>
        /// Заправить самолёт на конкретное количетво топлива
        /// </summary>
        /// <param name="capacity"></param>
        public void Refuel(double capacity) => Wing.Refuel(capacity);

        /// <summary>
        /// Потратить топливо
        /// </summary>
        /// <param name="capacity">Количество потраченного топлива</param>
        public void WasteFuel(double capacity) => Wing.WasteFuel(capacity);

        /// <summary>
        /// Получить расход топлива одного двигателя
        /// </summary>
        public double GetRate() => Engine.GetRate();

        /// <summary>
        /// Получить теккущее количество топлива в баках
        /// </summary>
        public double GetFuelLevel() => Wing.GetFuelLevel();

        public override string ToString() => $"Самолёт {Name}";

        public string GetName() => Name;

        public string GetSpecs() => $"{Engine}\r\n\r\n{Gear}\r\n\r\n{Wing}";

    }
}
