using System.Collections.Generic;

namespace flyweight
{
    public class Flyweight
    {
        private Car sharedState;

        public Flyweight(Car car)
        {
            sharedState = car;
        }

        public List<string> Operation(Car uniqueState)
        {
            List<string> result = new List<string>();

            result.Add("Flyweight: estado compartido -> " + sharedState.Description());
            result.Add("Flyweight: estado unico -> " + uniqueState.Description());

            return result;
        }
    }
}
