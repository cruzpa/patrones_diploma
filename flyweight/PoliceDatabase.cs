using System.Collections.Generic;

namespace flyweight
{
    public class PoliceDatabase
    {
        private FlyweightFactory factory;

        public PoliceDatabase(FlyweightFactory factory)
        {
            this.factory = factory;
        }

        public List<string> AddCar(Car car)
        {
            List<string> result = new List<string>();

            result.Add("Cliente: agrega un auto a la base de datos.");

            Flyweight flyweight = factory.GetFlyweight(new Car
            {
                Color = car.Color,
                Model = car.Model,
                Company = car.Company
            }, result);

            result.AddRange(flyweight.Operation(car));

            return result;
        }
    }
}
