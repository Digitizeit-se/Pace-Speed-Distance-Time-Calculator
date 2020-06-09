using Digitizeit.PaceDistanceSpeedHelper.DistanceHelper;
using Xunit;

namespace DigitizeIt.PaceDistanceSpeedHelperTest.DistanceHelper
{
    public class DistanceConverterTest
    {
        [Fact]
        public void Given_a_distance_as_double_in_meters_the_right_miles_value_is_returned()
        {
            //Arrange
            double distance = 3450.0;
            double expected = 2.143730613218802;

            //Act
            var result = distance.ConvertMetersToMiles();

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_distance_as_decimal_in_meters_the_right_miles_value_is_returned()
        {
            //Arrange
            decimal distance = 3450.0m;
            double expected = 2.143730613218802;

            //Act
            var result = distance.ConvertMetersToMiles();

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_distance_as_float_in_meters_the_right_miles_value_is_returned()
        {
            //Arrange
            float distance = 3450.0f;
            double expected = 2.143730613218802;

            //Act
            var result = distance.ConvertMetersToMiles();

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_distance_as_int_in_meters_the_right_miles_value_is_returned()
        {
            //Arrange
            int distance = 3450;
            double expected = 2.143730613218802;

            //Act
            var result = distance.ConvertMetersToMiles();

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_distance_as_long_in_meters_the_right_miles_value_is_returned()
        {
            //Arrange
            long distance = 3450;
            double expected = 2.143730613218802;

            //Act
            var result = distance.ConvertMetersToMiles();

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_distance_as_short_in_meters_the_right_miles_value_is_returned()
        {
            //Arrange
            short distance = 3450;
            double expected = 2.143730613218802;

            //Act
            var result = distance.ConvertMetersToMiles();

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_distance_as_double_in_miles_the_right_meters_value_is_returned()
        {
            //Arrange
            var expected = 3450;
            double distance = 2.143730613218802;

            //Act
            var result = distance.ConvertMileToMeter();

            //Assert
            Assert.Equal(expected, result);
        }
    }
}