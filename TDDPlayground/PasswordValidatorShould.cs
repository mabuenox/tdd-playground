using FluentAssertions;
using System;
using Xunit;

namespace TDDPlayground
{
    public class PasswordValidatorShould
    {

        // - [ ] La contrase�a debe tener como minimo 8 caracteres
        // - [ ] La contrase�a debe tener al menos un n�mero.
        // - [ ] La contrase�a debe tener al menos letra en mayuscula.
        // - [ ] La contrase�a debe tener al menos letra en minuscula.

        [Fact]
        public void verify_password_with_eight_character_is_valid()
        {
            string password = "password";

            var validator = new PasswordValidator();
            
            bool result = validator.Verify(password);

            result.Should().BeTrue();
        }

        [Fact]
        public void verify_password_with_least_of_8_character_is_invalid()
        {
            string password = "pass";

            var validator = new PasswordValidator();

            bool result = validator.Verify(password);

            result.Should().BeFalse();
        }


    }
}