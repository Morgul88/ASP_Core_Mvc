using Infrastructure.Entities;
using Infrastructure.Models;

namespace Infrastructure.Factories;

public class AdressFactory
{
    public static AdressEntity Create()
    {
        try
        {
            return new AdressEntity();
        }
        catch (Exception ex)
        {
            return null!;
        }
    }
    public static AdressEntity Create(string streetName, string postalCode, string city)
    {
        try
        {
            return new AdressEntity
            {
                StreetName = streetName,
                PostalCode = postalCode,
                City = city
            };
        }
        catch (Exception ex)
        {
            return null!;
        }
    }

    public static Addressmodel Create(AdressEntity entity)
    {
        try
        {
            return new Addressmodel
            {
                Id= entity.Id,
                StreetName = entity.StreetName,
                PostalCode = entity.PostalCode,
                City = entity.City
            };
        }
        catch (Exception ex)
        {
            return null!;
        }
    }
}
