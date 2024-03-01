using Infrastructure.Entities;
using Infrastructure.Factories;
using Infrastructure.Helpers;
using Infrastructure.Models;
using Infrastructure.Repositories;

namespace Infrastructure.Service;

public class UserService(UserRepository repository, AdressService adressService)
{
    private readonly UserRepository _repository = repository;
    private readonly AdressService _adressService = adressService;

    public async Task<ResponseResult> CreateUserAsync(SignUpModel model)
    {
        try
        {
            var exists = await _repository.AlreadyExistAsync(x => x.Email == model.EmailAdress);
            if(exists.StatusCode == StatusCodes.EXISTS) 
                return exists;

            var result = await _repository.CreateAsync(UserFactory.Create(model));
            if (exists.StatusCode != StatusCodes.OK)
                return result;

            return ResponseFactory.Ok("User was created successfully");

            
        }
        catch (Exception ex)
        {
            return ResponseFactory.Error(ex.Message);
        }
    }

    //public async Task<ResponseResult> SignInUserAsync(SignInModel model)
    //{
    //    try
    //    {
    //        var result = await _repository.GetOneAsync(x => x.Email == model.EmailAdress);
    //        if (result.StatusCode == StatusCodes.OK && result.ContentResult != null)
    //        {
    //            var userEntity = (UserEntity)result.ContentResult;

    //            if (PasswordHasher.ValidateSecurePassword(model.Password, userEntity.Password, userEntity.SecurityKey))
    //                return ResponseFactory.Ok();

    //        }
    //        return ResponseFactory.Error("Incorrect email or password");

    //    }
    //    catch (Exception ex)
    //    {
    //        return ResponseFactory.Error(ex.Message);
    //    }
    //}
}
