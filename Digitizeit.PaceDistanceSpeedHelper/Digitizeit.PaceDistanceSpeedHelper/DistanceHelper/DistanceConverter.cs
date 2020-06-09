using System;

namespace Digitizeit.PaceDistanceSpeedHelper.DistanceHelper
{
    public static class DistanceConverter
    {
        /// <summary>
        /// Convert english miles to meter
        /// </summary>
        /// <param name="distance">(english) mile</param>
        /// <returns>double distance in meters</returns>
        public static double ConvertMileToMeter<T>(this T distance) where T :
            struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable
        {
            var typedDistance = (double)Convert.ChangeType(distance, typeof(double));
            var mile = 1609.344;
            return typedDistance * mile;
        }

        /// <summary>
        /// Convert meters to english miles.
        /// </summary>
        /// <param name="distance">Meters</param>
        /// <param name="decimals">Number of fractional digits</param>
        /// <returns>double distance in (english) miles</returns>
        public static double ConvertMetersToMiles<T>(this T distance, int? decimals = null) where T :
            struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable
        {
            var mile = 1609.344;
            var typedDistance = (double)Convert.ChangeType(distance, typeof(double));
            var result = typedDistance / mile;
            if (decimals != null)
            {
                return Math.Round(result, (int)decimals);
            }

            return result;
        }
    }
}