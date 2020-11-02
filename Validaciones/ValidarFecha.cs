using System;
using System.Windows.Controls;

namespace Hudelsis_P2_AP1.Validaciones
{
    public class ValidarFecha : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
           if(value != null){
                DateTime fecha = new DateTime();
                DateTime.TryParse(value.ToString(), out fecha);

                if(fecha > DateTime.Now)
                    return new ValidationResult(false,"Debes poner una fecha valida");

            return ValidationResult.ValidResult;
           }

           return new ValidationResult(false, "Debes poner una fecha");
        }
    }
}