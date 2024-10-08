﻿using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;

namespace Infrastructure.Helpers;

public class PasswordHasher
{
    public static (string,string) GenerateSecurePassword(string password)
    {
        using var hmac = new HMACSHA512();
        var securityKey = hmac.Key;

        var hashedPassword = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

        return (Convert.ToBase64String(securityKey), Convert.ToBase64String(hashedPassword));
    }

    //public static bool ValidateSecurePassword (string password, string hash ,string securityKey)
    //{
    //    var userPassword = Convert.


    //    using var hmac = new HMACSHA512(Convert.FromBase64String(securityKey));
    //    var hashedPassword = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

    //    var userPassword = Convert.FromBase64String(hash);
    //    for(var i= 0; i< hashedPassword.Length; i++)
    //    {
    //        if (hashedPassword[i] != userPassword[i])
    //            return false;

    //    }
    //    return true;
    //}
}
