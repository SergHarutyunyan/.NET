using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnNET.Type_Conversion_Operator
{
    class Car
    {
        public int ProductionYear { get; set; }
        public string Modelname { get; set; }

        public static implicit operator Vehicle(Car car)            // We can do it also with explicit, but then
        {                                                           // you must write Vehicle v = new (Car)bmw;
            return new Vehicle { productionYear = car.ProductionYear };
        }
    }
}
