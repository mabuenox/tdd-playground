using FluentAssertions;
using System;
using Xunit;

namespace TDDPlayground
{
    public class PasswordValidatorShould
    {

        // - [x] La contraseña debe tener como minimo 8 caracteres
        // - [ ] La contraseña debe tener al menos un nùmero.
        // - [ ] La contraseña debe tener al menos letra en mayuscula.
        // - [ ] La contraseña debe tener al menos letra en minuscula.

        [Fact]
        public void verify_password_with_eight_character_is_valid()
        {
            string password = "Passw0rd";

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

        [Fact]
        public void verify_password_without_a_number_is_invalid()
        {
            string password = "Password";

            var validator = new PasswordValidator();

            bool result = validator.Verify(password);

            result.Should().BeFalse();
        }


    }
}