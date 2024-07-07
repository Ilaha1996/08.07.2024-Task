using CarShopEF.DAL;
using CarShopEF.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarShopEF;

internal class Program
{
    static void Main(string[] args)
    {

        //Console.WriteLine(GetModelById(2).Name);
        //Console.WriteLine(GetCarById(1));

        var cars = GetAllCars();
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }

    }



    // Car CRUD
    static void AddCar(Car car)
    {
        CarShopDBContext carShopDBContext = new CarShopDBContext();
        carShopDBContext.Cars.Add(car);
        carShopDBContext.SaveChanges();
    }

    static Car GetCarById(int id)
    {
        using (CarShopDBContext carShopDBContext = new CarShopDBContext())
        {
            var data = carShopDBContext.Cars.Include(c => c.Model).ThenInclude(m => m.Brand).Include(c => c.CarColours).ThenInclude(cc => cc.Colour).FirstOrDefault(x => x.Id == id);
            return data;
        }
    }

    static List<Car> GetAllCars()
    {
        CarShopDBContext carShopDBContext = new CarShopDBContext();
        return carShopDBContext.Cars.Include(c => c.Model).ThenInclude(m => m.Brand).Include(c => c.CarColours).ThenInclude(cc => cc.Colour).ToList();
    }
    static void UpdateCar(Car car)
    {
        CarShopDBContext carShopDBContext = new CarShopDBContext();
        var existcar= carShopDBContext.Cars.Find(car.Id);
        if (existcar == null)
        {
            throw new NullReferenceException();
        }
        else
        {
            existcar.FuelTankCapacity = car.FuelTankCapacity;
            existcar.DoorCount = car.DoorCount;
            existcar.Power = car.Power;
            existcar.MaxSpeed = car.MaxSpeed;
            carShopDBContext.SaveChanges();
        }
       
    }

    static void DeleteCar(int id)
    {
        CarShopDBContext carShopDBContext = new CarShopDBContext();
        Car wantedcar = carShopDBContext.Cars.Find(id);
        if (wantedcar == null)
        {
            throw new NullReferenceException();
        }
        else
        {
            carShopDBContext.Cars.Remove(wantedcar);
            carShopDBContext.SaveChanges(); 
        }

        
    }

    //Model Crud

    static void AddModel(Model model)
    {
        CarShopDBContext carShopDBContext = new CarShopDBContext();
        carShopDBContext.Models.Add(model);
        carShopDBContext.SaveChanges();
    }

    static Model GetModelById(int id)
    {
        CarShopDBContext carShopDBContext = new CarShopDBContext();
        var data = carShopDBContext.Models.FirstOrDefault(x => x.Id == id);
        return data;

    }
    static List<Model> GetAllModels()
    {
        CarShopDBContext carShopDBContext = new CarShopDBContext();
        return carShopDBContext.Models.ToList();
    }
    static void UpdateModel(Model model)
    {
        CarShopDBContext carShopDBContext = new CarShopDBContext();
        var existmodel = carShopDBContext.Models.Find(model.Id);
        if (existmodel == null)
        {
            throw new NullReferenceException();
        }
        else
        {
            existmodel.Name = model.Name;
            carShopDBContext.SaveChanges();
        }
        
    }

    static void DeleteModel(int id)
    {
        CarShopDBContext carShopDBContext = new CarShopDBContext();
        Model wantedmodel = carShopDBContext.Models.Find(id);
        if (wantedmodel == null)
        {
            throw new NullReferenceException();
        }
        else
        {
            carShopDBContext.Models.Remove(wantedmodel);
            carShopDBContext.SaveChanges();
        }

        
    }

    // Brand Crud 

    static void AddBrand(Brand brand)
    {
        CarShopDBContext carShopDBContext = new CarShopDBContext();
        carShopDBContext.Brands.Add(brand);
        carShopDBContext.SaveChanges();
    }

    static Brand GetBrandById(int id)
    {
        CarShopDBContext carShopDBContext = new CarShopDBContext();
        var data = carShopDBContext.Brands.FirstOrDefault(x => x.Id == id);
        return data;

    }
    static List<Brand> GetAllBrands()
    {
        CarShopDBContext carShopDBContext = new CarShopDBContext();
        return carShopDBContext.Brands.ToList();
    }
    static void UpdateBrand(Brand brand)
    {
        CarShopDBContext carShopDBContext = new CarShopDBContext();
        var existbrand = carShopDBContext.Brands.Find(brand.Id);
        if (existbrand == null)
        {
            throw new NullReferenceException();
        }
        else
        {
            existbrand.Name = brand.Name;
            carShopDBContext.SaveChanges();
        }
        
    }

    static void DeleteBrand(int id)
    {
        CarShopDBContext carShopDBContext = new CarShopDBContext();
        Brand wantedbrand = carShopDBContext.Brands.Find(id);
        if (wantedbrand == null)
        {
            throw new NullReferenceException();
        }
        else
        {
            carShopDBContext.Brands.Remove(wantedbrand);
            carShopDBContext.SaveChanges();
        }

    }

    //Colour Crud 


    static void AddColour(Colour colour)
    {
        CarShopDBContext carShopDBContext = new CarShopDBContext();
        carShopDBContext.Colours.Add(colour);
        carShopDBContext.SaveChanges();
    }

    static Colour GetColourById(int id)
    {
        CarShopDBContext carShopDBContext = new CarShopDBContext();
        var data = carShopDBContext.Colours.FirstOrDefault(x => x.Id == id);
        return data;

    }
    static List<Colour> GetAllColours()
    {
        CarShopDBContext carShopDBContext = new CarShopDBContext();
        return carShopDBContext.Colours.ToList();
    }
    static void UpdateColour(Colour colour)
    {
        CarShopDBContext carShopDBContext = new CarShopDBContext();
        var existcolour = carShopDBContext.Colours.Find(colour.Id);
        if (existcolour == null)
        {
            throw new NullReferenceException();
        }
        else
        {
            existcolour.Name = colour.Name;
            carShopDBContext.SaveChanges();
        }
        
    }

    static void DeleteColour(int id)
    {
        CarShopDBContext carShopDBContext = new CarShopDBContext();
        Colour wantedcolour = carShopDBContext.Colours.Find(id);
        if (wantedcolour == null)
        {
            throw new NullReferenceException();
        }
        else
        {
            carShopDBContext.Colours.Remove(wantedcolour);
            carShopDBContext.SaveChanges();
        }
                
    }

}
