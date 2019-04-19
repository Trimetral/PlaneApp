using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneApp
{
    interface IPlanePart
    {
        string Name { get; set; }


        /// <summary>
        /// Получить имя части самолёта
        /// </summary>
        string GetName();

        /// <summary>
        /// Получить спецификацию части самолёта
        /// </summary>
        string GetSpecs();
    }
}
