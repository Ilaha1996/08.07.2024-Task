namespace CarShopEF.Entities;

public class Colour
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<CarColours> CarColours { get; set; }
}
