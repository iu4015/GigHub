using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHubMVC.ViewModels
{
    public class DateFuture : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "dd.mm.yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out _);

            return isValid;
        }
    }
}