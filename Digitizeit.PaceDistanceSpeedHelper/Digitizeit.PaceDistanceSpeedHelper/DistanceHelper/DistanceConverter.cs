using System;
using System.Runtime.CompilerServices;

namespace Digitizeit.PaceDistanceSpeedHelper.DistanceHelper
{
    public static class DistanceConverter
    {
        /// <summary>
        /// Convert numeric type value in metric to double metric value.
        /// </summary>
        /// <typeparam name="T">Numeric type</typeparam>
        /// <param name="distance">Distance in metric unit to convert to metric unit</param>
        /// <param name="from">Current metric unit</param>
        /// <param name="to">transform to metric unit</param>
        /// <returns>return transformed metric value as double</returns>
        public static double ConvertDistance<T>(this T distance, DistanceUnitsMetrics from, DistanceUnitsMetrics to, int? decimals = null) where T :
            struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable
        {
            if ((int)to < (int)from)
            {
                var up = (int)to - (int)from;
                var dd = (double)Convert.ChangeType(distance, typeof(double));
                var result = dd * Math.Pow(10, Math.Abs(up));

                return decimals != null ? Math.Round(result, (int)decimals) : result;
            }

            if ((int)to <= (int)@from) return (double)Convert.ChangeType(distance, typeof(double));
            {
                var up = (int)to + (int)@from;
                var dd = (double)Convert.ChangeType(distance, typeof(double));
                var result = dd * Math.Pow(10, up);

                return decimals != null ? Math.Round(result, (int)decimals) : result;
            }
        }

        public static double ConvertDistance<T>(this T distance, DistanceUnitsImperialUS from,
            DistanceUnitsImperialUS to, int? decimals = null) where T :
            struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable
        {
            double dd;
            double result;

            //No convert return value as double
            if (from == to) return (double)Convert.ChangeType(distance, typeof(double));

            if (from == DistanceUnitsImperialUS.Inch)
            {
                dd = (double)Convert.ChangeType(distance, typeof(double));
                result = dd / (double)to;
                return decimals != null ? Math.Round(result, (int)decimals) : result;
            }

            if (to == DistanceUnitsImperialUS.Inch)
            {
                dd = (double)Convert.ChangeType(distance, typeof(double));
                result = dd * (double)from;
                return decimals != null ? Math.Round(result, (int)decimals) : result;
            }

            dd = (double)Convert.ChangeType(distance, typeof(double));
            if ((int)from > (int)to)
            {
                result = dd * ((double)from / (double)to);
                return decimals != null ? Math.Round(result, (int)decimals) : result;
            }

            result = dd * ((double)from / (double)to);

            return decimals != null ? Math.Round(result, (int)decimals) : result;
        }

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