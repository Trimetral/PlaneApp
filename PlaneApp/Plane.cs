using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneAppLibrary
{
    public class Plane : Actions, IPlanePart
    {
        public readonly Engine Engine;
        public readonly Gear Gear;
        public readonly Wing Wing;

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

        public override string ToString() => $"Самолёт {Name}";

        /// <summary>
        /// Установить имя
        /// </summary>
        public void SetName(string newName) => Name = newName;

        public string GetName() => Name;

        public string GetSpecs() => $"{GetFullName(Engine)}\r\n\r\n{GetFullName(Gear)}\r\n\r\n{GetFullName(Wing)}";

    }
}
