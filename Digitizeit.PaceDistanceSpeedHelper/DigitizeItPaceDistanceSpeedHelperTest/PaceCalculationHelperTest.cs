using NUnit.Framework;
using Digitizeit.PaceDistanceSpeedHelper;

namespace DigitizeItPaceDistanceSpeedHelperTest
{
    public class PaceCalculationHelperTest
    {
        [Test]
        public void Given_a_distance_in_meter_over_time_in_seconds_the_right_value_is_returned()
        {
            //Arrange
            int distance = 1000;
            var seconds = 360;
            double expected = 6;

            //Act
            var result = distance.DistanceInSecondsToMinKm(seconds);

            //Assert

            Assert.AreEqual(expected, result);
        }
    }
}