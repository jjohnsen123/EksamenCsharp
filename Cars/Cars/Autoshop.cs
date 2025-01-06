using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Autoshop
    {
        private static List<Car> cars = new List<Car>();
        public static List<Car> Cars { get {  return cars; } }
        public static void AddCar(Car car)
        {
            cars.Add(car);
        }
        public static Car GetCar(int id)
        {
            return new Car();
        }
    }
}
