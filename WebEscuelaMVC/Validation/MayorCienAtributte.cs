using System.ComponentModel.DataAnnotations;

namespace WebEscuelaMVC.Validation
{

        public class MayorCienAtributte : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                int numero = (int)value;

                if (numero > 100)
                {
                    return new ValidationResult("Solo se aceptan precios mayores a 100");
                }
                return ValidationResult.Success;

            }
        }

    
}
