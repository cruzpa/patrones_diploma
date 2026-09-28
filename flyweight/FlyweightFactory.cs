using System.Collections.Generic;

namespace flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> flyweights;

        public FlyweightFactory(params Car[] cars)
        {
            flyweights = new Dictionary<string, Flyweight>();

            foreach (Car car in cars)
            {
                flyweights.Add(GetKey(car), new Flyweight(car));
            }
        }

        public int Count
        {
            get { return flyweights.Count; }
        }

        public string GetKey(Car key)
        {
            List<string> elements = new List<string>();

            elements.Add(key.Model);
            elements.Add(key.Color);
            elements.Add(key.Company);

            if (key.Owner != null && key.Number != null)
            {
                elements.Add(key.Number);
                elements.Add(key.Owner);
            }

            elements.Sort();
            return string.Join("_", elements);
        }

        public Flyweight GetFlyweight(Car sharedState, List<string> log)
        {
            string key = GetKey(sharedState);

            if (!flyweights.ContainsKey(key))
            {
                log.Add("FlyweightFactory: no encontro un flyweight, crea uno nuevo.");
                flyweights.Add(key, new Flyweight(sharedState));
            }
            else
            {
                log.Add("FlyweightFactory: reutiliza un flyweight existente.");
            }

            return flyweights[key];
        }

        public List<string> ListFlyweights()
        {
            List<string> result = new List<string>();

            result.Add("FlyweightFactory: tengo " + Count + " flyweights:");

            foreach (string key in flyweights.Keys)
            {
                result.Add(key);
            }

            return result;
        }
    }
}
