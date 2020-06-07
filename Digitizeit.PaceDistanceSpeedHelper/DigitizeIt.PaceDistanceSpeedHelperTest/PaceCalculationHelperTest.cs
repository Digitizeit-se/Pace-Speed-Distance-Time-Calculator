using Digitizeit.PaceDistanceSpeedHelper;
using Xunit;

namespace DigitizeIt.PaceDistanceSpeedHelperTest
{
    public class PaceCalculationHelperTest
    {
        [Fact]
        public void Given_a_int_distance_in_meter_over_time_in_seconds_the_right_min_km_value_is_returned()
        {
            //Arrange
            int distance = 1000;
            var seconds = 360;
            double expected = 6;

            //Act
            var result = distance.DistanceMetersInSecondsToMinKm(seconds);

            //Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_double_distance_in_meter_over_time_in_seconds_the_right_min_km_value_is_returned()
        {
            //Arrange
            double distance = 1000;
            var seconds = 360;
            double expected = 6;

            //Act
            var result = distance.DistanceMetersInSecondsToMinKm(seconds);

            //Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_short_distance_in_meter_over_time_in_seconds_the_right_min_km_value_is_returned()
        {
            //Arrange
            short distance = 1000;
            var seconds = 360;
            double expected = 6;

            //Act
            var result = distance.DistanceMetersInSecondsToMinKm(seconds);

            //Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_long_distance_in_meter_over_time_in_seconds_the_right_min_km_value_is_returned()
        {
            //Arrange
            long distance = 1000;
            var seconds = 360;
            double expected = 6;

            //Act
            var result = distance.DistanceMetersInSecondsToMinKm(seconds);

            //Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_float_distance_in_meter_over_time_in_seconds_the_right_min_km_value_is_returned()
        {
            //Arrange
            float distance = 1000;
            var seconds = 360;
            double expected = 6;

            //Act
            var result = distance.DistanceMetersInSecondsToMinKm(seconds);

            //Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_float_distance_in_meter_over_time_in_seconds_the_right_minute_over_mile_value_is_returned()
        {
            //Arrange
            float distance = 1609.344f;
            var seconds = 360;
            double expected = 6;

            //Act
            var result = distance.DistanceMetersInSecondsToMinutesEnglishMile(seconds);

            //Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_int_distance_in_meter_over_time_in_seconds_the_right_minute_over_mile_value_is_returned()
        {
            //Arrange
            int distance = 1609;
            var seconds = 360;
            double expected = 6;

            //Act
            var result = distance.DistanceMetersInSecondsToMinutesEnglishMile(seconds);

            //Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_double_distance_in_meter_over_time_in_seconds_the_right_minute_over_mile_value_is_returned()
        {
            //Arrange
            double distance = 1609.344;
            var seconds = 360;
            double expected = 6;

            //Act
            var result = distance.DistanceMetersInSecondsToMinutesEnglishMile(seconds);

            //Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_short_distance_in_meter_over_time_in_seconds_the_right_minute_over_mile_value_is_returned()
        {
            //Arrange
            short distance = 1609;
            var seconds = 360;
            double expected = 6;

            //Act
            var result = distance.DistanceMetersInSecondsToMinutesEnglishMile(seconds);

            //Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_long_distance_in_meter_over_time_in_seconds_the_right_minute_over_mile_value_is_returned()
        {
            //Arrange
            long distance = 1609;
            var seconds = 360;
            double expected = 6;

            //Act
            var result = distance.DistanceMetersInSecondsToMinutesEnglishMile(seconds);

            //Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_int_distance_in_meter_over_time_in_seconds_the_right_Km_hour_value_is_returned()
        {
            //Arrange
            int distance = 1000;
            var seconds = 360;
            double expected = 10;

            //Act
            var result = distance.DistanceMetersInSecondsToKmHour(seconds);

            //Assert

            Assert.Equal(expected, result);
        }
    }
}