namespace CarShopEF.Entities;

public class CarColours
{
    public int Id { get; set; }
    public int ColourId { get; set; }
    public int CarId { get; set; }
    public Car Car { get; set; }
    public Colour Colour { get; set; }  

}
