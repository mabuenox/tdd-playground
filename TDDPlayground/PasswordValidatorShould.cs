using FluentAssertions;
using System;
using Xunit;

namespace TDDPlayground
{
    public class PasswordValidatorShould
    {

        // - [ ] La contraseña debe tener como minimo 8 caracteres
        // - [ ] La contraseña debe tener al menos un nùmero.
        // - [ ] La contraseña debe tener al menos letra en mayuscula.
        // - [ ] La contraseña debe tener al menos letra en minuscula.

        [Fact]
        public void verify_at_least_eight_character()
        {
            string password = "pass";

            var validator = new PasswordValidator();
            
            bool result = validator.Verify(password);

            result.Should().BeFalse();
        }

       
    }
}