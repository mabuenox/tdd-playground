using FluentAssertions;
using System;
using Xunit;

namespace TDDPlayground
{
    public class FizzBuzzShould
    {
        [Fact]
        public void return_collection_with_same_elements_that_number_given()
        {
            var number = 5;

            string[] result = FizzBuzz.Calculate(number);

            result.Should().HaveCount(number);
        }

        [Fact]
        public void return_collection_with_completed_elements_that_number_given()
        {
            var number = 5;

            string[] result = FizzBuzz.Calculate(number);

            result.Should().NotBeEmpty();
        }

        [Fact]
        public void throw_exception_when_number_given_is_less_than_one()
        {
            var number = 0;

            Action act = () => FizzBuzz.Calculate(number);

            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void replace_with_fizz_when_element_is_multiple_of_3()
        {
            var number = 3;

            string[] result = FizzBuzz.Calculate(number);

            result[2].Should().Be("Fizz");
        }
    }
}