using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Digitizeit.PaceDistanceSpeedHelper;

namespace DigitizeIt.PaceDistanceSpeedHelperTest
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
    }
}