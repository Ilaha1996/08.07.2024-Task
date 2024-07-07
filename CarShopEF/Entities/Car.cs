namespace CarShopEF.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public decimal MaxSpeed { get; set; }
        public decimal FuelTankCapacity { get; set; }
        public decimal Power { get; set; }
        public int DoorCount { get; set; }

        public Model Model { get; set; }

        public List<CarColours> CarColours { get; set; }

        public override string ToString()
        {
            string modelInfo = Model != null ? $"{Model.Brand.Name} - {Model.Name}" : "No Model";

            string coloursInfo = CarColours != null && CarColours.Count > 0
                                 ? string.Join(", ", CarColours.Select(cc => cc.Colour.Name))
                                 : "No Colours";
            return $"{Id} - {MaxSpeed} - {DoorCount} - {FuelTankCapacity} - {Power} - {modelInfo} - Colours: {coloursInfo}";
        }
    }
}

