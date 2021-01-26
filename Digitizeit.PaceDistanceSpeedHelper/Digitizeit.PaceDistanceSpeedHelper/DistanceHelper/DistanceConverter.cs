using System;
using System.Collections.Generic;

namespace Digitizeit.PaceDistanceSpeedHelper.DistanceHelper
{
    public static class DistanceConverter
    {
        private static readonly IReadOnlyDictionary<string, double> ImperialUsInMeters = new Dictionary<string, double>()
        {
            {"Yard",0.9144 },
            {"Mile", 1609.344 },
            {"Foot",0.3048},
            {"Inch", 0.0254 }
        };

        /// <summary>
        /// Convert numeric type value in metric to double metric value.
        /// </summary>
        /// <typeparam name="T">Numeric type</typeparam>
        /// <param name="distance">Distance in metric unit to convert to metric unit</param>
        /// <param name="from">Current metric unit</param>
        /// <param name="to">transform to metric unit</param>
        /// <param name="decimals">number of decimal points</param>
        /// <returns>return transformed metric value as double</returns>
        public static double ConvertDistance<T>(this T distance, DistanceUnitsMetrics from, DistanceUnitsMetrics to, int? decimals = null) where T :
            struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable
        {
            int pow;
            var dd = (double)Convert.ChangeType(distance, typeof(double));
            double result;

            if ((int)to == (int)from) return dd;

            if ((int)to < (int)from)
            {
                pow = (int)to - (int)from;
                result = dd * Math.Pow(10, Math.Abs(pow));

                return decimals != null ? Math.Round(result, (int)decimals) : result;
            }

            if (from >= 0)
            {
                pow = ((int)to + (int)from) * -1;
            }
            else
            {
                pow = (int)to + (int)from;
            }

            result = dd * Math.Pow(10, pow);

            return decimals != null ? Math.Round(result, (int)decimals) : result;
        }

        /// <summary>
        /// Convert a Imperial / US numeric value from one unit to another unit
        /// </summary>
        /// <typeparam name="T">The numeric type</typeparam>
        /// <param name="distance">Numeric in imperial / us unit to convert to another unit </param>
        /// <param name="from">Current imperial / us value to convert from</param>
        /// <param name="to">Imperial / us unit to convert distance to</param>
        /// <param name="decimals">Number of decimals in return value</param>
        /// <returns>Converted distance </returns>
        public static double ConvertDistance<T>(this T distance, DistanceUnitsImperialUS from,
            DistanceUnitsImperialUS to, int? decimals = null) where T :
            struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable
        {
            var dd = (double)Convert.ChangeType(distance, typeof(double));
            double result;

            if (from == to) return dd;

            if (from == DistanceUnitsImperialUS.Inch)
            {
                result = dd / (double)to;
                return decimals != null ? Math.Round(result, (int)decimals) : result;
            }

            if (to == DistanceUnitsImperialUS.Inch)
            {
                result = dd * (double)from;
                return decimals != null ? Math.Round(result, (int)decimals) : result;
            }

            if ((int)from > (int)to)
            {
                result = dd * ((double)from / (double)to);
                return decimals != null ? Math.Round(result, (int)decimals) : result;
            }

            result = dd * ((double)from / (double)to);

            return decimals != null ? Math.Round(result, (int)decimals) : result;
        }

        /// <summary>
        /// Convert Imperial / us unit to metric unit
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="distance">Distance to convert</param>
        /// <param name="from">Current unit</param>
        /// <param name="to">Unit to convert to</param>
        /// <param name="decimals">number of decimals in output</param>
        /// <returns>Converted distance</returns>
        public static double ConvertDistance<T>(this T distance, DistanceUnitsImperialUS from,
            DistanceUnitsMetrics to, int? decimals = null) where T :
            struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable
        {
            var dd = (double)Convert.ChangeType(distance, typeof(double));

            var meters = dd * ImperialUsInMeters[from.ToString()];
            if (to == DistanceUnitsMetrics.Meter)
            {
                return decimals != null ? Math.Round(meters, (int)decimals) : meters;
            }

            var metric = meters.ConvertDistance(DistanceUnitsMetrics.Meter, to);

            return decimals != null ? Math.Round(metric, (int)decimals) : metric;
        }

        /// <summary>
        /// Convert distance in metric unit to imperial / us unit
        /// </summary>
        /// <typeparam name="T">distance type</typeparam>
        /// <param name="distance">numeric distance</param>
        /// <param name="from">Metric unit</param>
        /// <param name="to">Imperial / us unit</param>
        /// <param name="decimals">number of decimals in output </param>
        /// <returns>The converted double imperial value</returns>
        public static double ConvertDistance<T>(this T distance, DistanceUnitsMetrics from,
            DistanceUnitsImperialUS to, int? decimals = null) where T :
            struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable
        {
            var dd = (double)Convert.ChangeType(distance, typeof(double));
            if (from != DistanceUnitsMetrics.Meter)
            {
                dd = dd.ConvertDistance(from, DistanceUnitsMetrics.Meter);
            }

            var imperial = dd / ImperialUsInMeters[to.ToString()];

            return decimals != null ? Math.Round(imperial, (int)decimals) : imperial;
        }
    }
}