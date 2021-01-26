using System;
using System.Collections.Generic;
using System.Text;
using Digitizeit.PaceDistanceSpeedHelper;
using Digitizeit.PaceDistanceSpeedHelper.DistanceHelper;
using Xunit;
using FluentAssertions;

namespace DigitizeIt.PaceDistanceSpeedHelperTest.DistanceHelper
{
    public class ConvertTest
    {
        [Fact]
        public void Test()
        {
            //Act
            var result = 50.Distance()
                .To(DistanceUnitsMetrics.Meter)
                .From(DistanceUnitsMetrics.CentiMeter)
                .SetDecimals(2).Convert();

            //Assert
            result.Should().Be(0.5);
        }
    }
}