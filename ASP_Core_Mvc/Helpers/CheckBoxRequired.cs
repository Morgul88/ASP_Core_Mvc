using System.ComponentModel.DataAnnotations;
namespace ASP_Core_Mvc.Helpers;

public class CheckBoxRequired : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        return value is bool b && b;
    }
}
