using Infrastructure.Entities;
using Infrastructure.Factories;
using Infrastructure.Models;
using Infrastructure.Repositories;

namespace Infrastructure.Service;

public class AdressService(AdressRepository repository)
{
    private readonly AdressRepository _repository = repository;

    public async Task<ResponseResult> GetOrCreateAdressAsync(string streetName, string postalCode, string city)
    {
        try
        {
            var result = await GetAdressAsync(streetName, postalCode, city);
            if(result.StatusCode == StatusCodes.NOT_FOUND)
            {
                result = await CreateAdressAsync(streetName, postalCode, city);
                
            }
            return result;
        }
        catch (Exception ex)
        {
            return ResponseFactory.Error(ex.Message);
        }
    }

    public async Task<ResponseResult> CreateAdressAsync(string streetName, string postalCode, string city)
    {
        try
        {
            var exists = await _repository.AlreadyExistAsync(x => x.StreetName == streetName && x.PostalCode == postalCode && x.City == city);
            if (exists == null)
            {
                var result = await _repository.CreateAsync(AdressFactory.Create(streetName,postalCode,city));
                if (result.StatusCode == StatusCodes.OK)
                {
                    var response = ResponseFactory.Ok(AdressFactory.Create((AdressEntity)result.ContentResult!));
                    return response; 
                }
                else
                {
                    return result;
                }
                
            }
            return exists;
        }
        catch (Exception ex)
        {
            return ResponseFactory.Error(ex.Message);
        }
    }

    public async Task<ResponseResult> GetAdressAsync(string streetName, string postalCode, string city)
    {
        try
        {
            var result = await _repository.GetOneAsync(x => x.StreetName == streetName && x.PostalCode == postalCode && x.City == city);
            return result;

        }
        catch (Exception ex)
        {
            return ResponseFactory.Error(ex.Message);
        }
    }
}
