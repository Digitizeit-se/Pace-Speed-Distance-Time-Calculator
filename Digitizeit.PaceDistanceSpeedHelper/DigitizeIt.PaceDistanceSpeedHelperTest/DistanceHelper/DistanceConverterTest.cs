using Digitizeit.PaceDistanceSpeedHelper;
using Digitizeit.PaceDistanceSpeedHelper.DistanceHelper;
using FluentAssertions;
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

        //Metric to metric convertions
        [Fact]
        public void Given_a_number_in_centimeter_transformed_to_millimeter_the_right_value_is_returned()
        {
            //Arrange
            var number = 100;

            //Act
            var result = number.ConvertDistance(DistanceUnitsMetrics.CentiMeter, DistanceUnitsMetrics.MilliMeter);

            //Assert
            result.Should().Be(1000);
        }

        [Fact]
        public void Given_a_number_in_meters_transformed_to_decimater_the_right_value_is_returned()
        {
            //Arrange
            var number = 2;

            //Act
            var result = number.ConvertDistance(DistanceUnitsMetrics.Meter, DistanceUnitsMetrics.DeciMeter);

            //Assert
            result.Should().Be(20);
        }

        [Fact]
        public void Given_a_number_in_decimeter_transformed_to_meter_the_right_value_is_returned()
        {
            //Arrange
            var number = 20;

            //Act
            var result = number.ConvertDistance(DistanceUnitsMetrics.DeciMeter, DistanceUnitsMetrics.Meter);

            //Assert
            result.Should().Be(2);
        }

        [Fact]
        public void Given_a_number_in_milimeter_transformed_to_meter_the_right_value_is_returned()
        {
            //Arrange
            var number = 20000;

            //Act
            var result = number.ConvertDistance(DistanceUnitsMetrics.MilliMeter, DistanceUnitsMetrics.Meter);

            //Assert
            result.Should().Be(20);
        }

        [Fact]
        public void Given_a_number_in_km_transformed_to_meter_the_right_value_is_returned()
        {
            //Arrange
            var number = 1;

            //Act
            var result = number.ConvertDistance(DistanceUnitsMetrics.KiloMeter, DistanceUnitsMetrics.Meter);

            //Assert
            result.Should().Be(1000);
        }

        [Fact]
        public void Given_a_number_in_mile_transformed_to_meter_the_right_value_is_returned()
        {
            //Arrange
            var number = 1;

            //Act
            var result = number.ConvertDistance(DistanceUnitsMetrics.Mile, DistanceUnitsMetrics.Meter);

            //Assert
            result.Should().Be(10000);
        }

        [Fact]
        public void Given_a_number_in_mile_transformed_to_millimeter_the_right_value_is_returned()
        {
            //Arrange
            var number = 1;

            //Act
            var result = number.ConvertDistance(DistanceUnitsMetrics.Mile, DistanceUnitsMetrics.MilliMeter);

            //Assert
            result.Should().Be(10000000);
        }

        [Fact]
        public void Given_a_number_in_meter_transformed_to_meter_the_right_value_is_returned()
        {
            //Arrange
            var number = 100;

            //Act
            var result = number.ConvertDistance(DistanceUnitsMetrics.Meter, DistanceUnitsMetrics.Meter);

            //Assert
            result.Should().Be(100);
        }

        [Fact]
        public void Given_a_number_in_km_transformed_to_meters_right_value_is_returned()
        {
            //Arrange
            var km = 1.609344;

            //Act
            var result = km.ConvertDistance(DistanceUnitsMetrics.KiloMeter, DistanceUnitsMetrics.Meter);

            //Assert
            result.Should().Be(1609.344);
        }

        //Conversion ImperialUs to ImperialUS
        [Fact]
        public void Given_a_number_in_inch_transform_to_foot_the_right_value_is_returned()
        {
            //Arrange
            var number = 50;

            //Act
            var result = number.ConvertDistance(DistanceUnitsImperialUS.Inch, DistanceUnitsImperialUS.Foot);

            //Assert
            result.Should().Be(4.166666666666667);
        }

        [Fact]
        public void Given_a_number_in_foot_transform_to_inch_the_right_value_is_returned()
        {
            //Arrange
            var number = 4.166666666666667;

            //Act
            var result = number.ConvertDistance(DistanceUnitsImperialUS.Foot, DistanceUnitsImperialUS.Inch);

            //Assert
            result.Should().Be(50);
        }

        [Fact]
        public void Given_a_number_in_mile_transform_to_foot_the_right_value_is_returned()
        {
            //Arrange
            var number = 2;

            //Act
            var result = number.ConvertDistance(DistanceUnitsImperialUS.Mile, DistanceUnitsImperialUS.Foot);

            //Assert
            result.Should().Be(10560);
        }

        [Fact]
        public void Given_a_number_in_foot_transform_to_mile_the_right_value_is_returned()
        {
            //Arrange
            var number = 10560;

            //Act
            var result = number.ConvertDistance(DistanceUnitsImperialUS.Foot, DistanceUnitsImperialUS.Mile);

            //Assert
            result.Should().Be(2);
        }
    }
}