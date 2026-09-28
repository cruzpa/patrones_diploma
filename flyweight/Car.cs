namespace flyweight
{
    public class Car
    {
        public string Owner { get; set; }

        public string Number { get; set; }

        public string Company { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public string Description()
        {
            return "Owner: " + ValueOrEmpty(Owner)
                + ", Number: " + ValueOrEmpty(Number)
                + ", Company: " + ValueOrEmpty(Company)
                + ", Model: " + ValueOrEmpty(Model)
                + ", Color: " + ValueOrEmpty(Color);
        }

        private string ValueOrEmpty(string value)
        {
            return string.IsNullOrEmpty(value) ? "sin dato" : value;
        }
    }
}
