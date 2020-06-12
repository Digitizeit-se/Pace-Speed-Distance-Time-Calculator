using Digitizeit.PaceDistanceSpeedHelper.PaceHelper;
using System.Collections.Generic;
using Xunit;

namespace DigitizeIt.PaceDistanceSpeedHelperTest.PaceHelper
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
        public void Given_a_list_of_tuples_with_distance_in_meters_over_seconds_the_right_min_km_values_is_returned()
        {
            //Arrange
            List<double> expected = new List<double>() { 6, 6 };
            List<(int, int)> items = new List<(int, int)>() { (1000, 360), (100, 36) };

            //Act
            var result = items.DistanceMetersInSecondsToMinKm();

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_list_of_tuples_with_distance_in_meters_over_seconds_sort_out_only_values_greater_then_0_the_right_min_km_values_is_returned()
        {
            //Arrange
            var expected = new List<double>() { 6, 6 };
            var items = new List<(int, int)>() { (1000, 360), (100, 36), (0, 36), (0, 66), (0, 96) };

            //Act
            var result = items.DistanceMetersInSecondsToMinKm(x => x.distance > 0);

            //Assert
            Assert.Equal(expected, (List<double>)result);
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
        public void Given_a_decimal_distance_in_meter_over_time_in_seconds_the_right_min_km_value_is_returned()
        {
            //Arrange
            decimal distance = 1000;
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
        public void Given_a_decimal_distance_in_meter_over_time_in_seconds_the_right_minute_over_mile_value_is_returned()
        {
            //Arrange
            decimal distance = 1609;
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

        [Fact]
        public void Given_a_double_distance_in_meter_over_time_in_seconds_the_right_Km_hour_value_is_returned()
        {
            //Arrange
            double distance = 1000;
            var seconds = 360;
            double expected = 10;

            //Act
            var result = distance.DistanceMetersInSecondsToKmHour(seconds);

            //Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_float_distance_in_meter_over_time_in_seconds_the_right_Km_hour_value_is_returned()
        {
            //Arrange
            float distance = 1000;
            var seconds = 360;
            double expected = 10;

            //Act
            var result = distance.DistanceMetersInSecondsToKmHour(seconds);

            //Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_short_distance_in_meter_over_time_in_seconds_the_right_Km_hour_value_is_returned()
        {
            //Arrange
            short distance = 1000;
            var seconds = 360;
            double expected = 10;

            //Act
            var result = distance.DistanceMetersInSecondsToKmHour(seconds);

            //Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_long_distance_in_meter_over_time_in_seconds_the_right_Km_hour_value_is_returned()
        {
            //Arrange
            long distance = 1000;
            var seconds = 360;
            double expected = 10;

            //Act
            var result = distance.DistanceMetersInSecondsToKmHour(seconds);

            //Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_decimal_distance_in_meter_over_time_in_seconds_the_right_Km_hour_value_is_returned()
        {
            //Arrange
            decimal distance = 1000;
            var seconds = 360;
            double expected = 10;

            //Act
            var result = distance.DistanceMetersInSecondsToKmHour(seconds);

            //Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_decimal_distance_in_meter_over_time_in_seconds_the_right_Mph_value_is_returned()
        {
            //Arrange
            decimal distance = 100000;
            var seconds = 3600;
            double expected = 62.14;

            //Act
            var result = distance.DistanceMetersInSecondsToMph(seconds);

            //Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_double_distance_in_meter_over_time_in_seconds_the_right_Mph_value_is_returned()
        {
            //Arrange
            double distance = 100000;
            var seconds = 3600;
            double expected = 62.14;

            //Act
            var result = distance.DistanceMetersInSecondsToMph(seconds);

            //Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_float_distance_in_meter_over_time_in_seconds_the_right_Mph_value_is_returned()
        {
            //Arrange
            float distance = 100000;
            var seconds = 3600;
            double expected = 62.14;

            //Act
            var result = distance.DistanceMetersInSecondsToMph(seconds);

            //Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_short_distance_in_meter_over_time_in_seconds_the_right_Mph_value_is_returned()
        {
            //Arrange
            short distance = 1000;
            var seconds = 360;
            double expected = 6.21;

            //Act
            var result = distance.DistanceMetersInSecondsToMph(seconds);

            //Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_a_long_distance_in_meter_over_time_in_seconds_the_right_Mph_value_is_returned()
        {
            //Arrange
            long distance = 1000;
            var seconds = 360;
            double expected = 6.21;

            //Act
            var result = distance.DistanceMetersInSecondsToMph(seconds);

            //Assert

            Assert.Equal(expected, result);
        }
    }
}