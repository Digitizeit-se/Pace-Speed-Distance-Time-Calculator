using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Digitizeit.PaceDistanceSpeedHelper
{
    public static class DistanceConverter
    {
        /// <summary>
        /// Convert english miles to meter
        /// </summary>
        /// <param name="distance">(english) mile</param>
        /// <returns>double distance in meters</returns>
        public static double ConvertMileToMeter(this double distance)
        {
            var mile = 1609.344;
            return distance * mile;
        }

        /// <summary>
        /// Convert english miles to meter
        /// </summary>
        /// <param name="distance">(english) mile</param>
        /// <returns>double distance in meters</returns>
        public static double ConvertMileToMeter(this int distance)
        {
            return ConvertMileToMeter((double)distance);
        }

        /// <summary>
        /// Convert english miles to meter
        /// </summary>
        /// <param name="distance">(english) mile</param>
        /// <returns>double distance in meters</returns>
        public static double ConvertMileToMeter(this decimal distance)
        {
            return ConvertMileToMeter((double)distance);
        }

        /// <summary>
        /// Convert english miles to meter
        /// </summary>
        /// <param name="distance">(english) mile</param>
        /// <returns>double distance in meters</returns>
        public static double ConvertMileToMeter(this float distance)
        {
            return ConvertMileToMeter((double)distance);
        }

        /// <summary>
        /// Convert english miles to meter
        /// </summary>
        /// <param name="distance">(english) mile</param>
        /// <returns>double distance in meters</returns>
        public static double ConvertMileToMeter(this short distance)
        {
            return ConvertMileToMeter((double)distance);
        }

        /// <summary>
        /// Convert english miles to meter
        /// </summary>
        /// <param name="distance">(english) mile</param>
        /// <returns>double distance in meters</returns>
        public static double ConvertMileToMeter(this long distance)
        {
            return ConvertMileToMeter((double)distance);
        }

        /// <summary>
        /// Convert meters to english miles.
        /// </summary>
        /// <param name="distance">Meters</param>
        /// <param name="decimals">Number of fractional digits</param>
        /// <returns>double distance in (english) miles</returns>
        public static double ConvertMetersToMiles(this double distance, int? decimals = null)
        {
            var mile = 1609.344;
            var result = distance / mile;
            if (decimals != null)
            {
                return Math.Round(result, (int)decimals);
            }

            return result;
        }

        /// <summary>
        /// Convert meters to english miles.
        /// </summary>
        /// <param name="distance">Meters</param>
        /// <returns>double distance in (english) miles</returns>
        public static double ConvertMetersToMiles(this int distance)
        {
            return ConvertMileToMeter((double)distance);
        }

        /// <summary>
        /// Convert meters to english miles.
        /// </summary>
        /// <param name="distance">Meters</param>
        /// <returns>double distance in (english) miles</returns>
        public static double ConvertMetersToMiles(this float distance)
        {
            return ConvertMileToMeter((double)distance);
        }

        /// <summary>
        /// Convert meters to english miles.
        /// </summary>
        /// <param name="distance">Meters</param>
        /// <returns>double distance in (english) miles</returns>
        public static double ConvertMetersToMiles(this decimal distance)
        {
            return ConvertMileToMeter((double)distance);
        }

        /// <summary>
        /// Convert meters to english miles.
        /// </summary>
        /// <param name="distance">Meters</param>
        /// <returns>double distance in (english) miles</returns>
        public static double ConvertMetersToMiles(this short distance)
        {
            return ConvertMileToMeter((double)distance);
        }

        /// <summary>
        /// Convert meters to english miles.
        /// </summary>
        /// <param name="distance">Meters</param>
        /// <returns>double distance in (english) miles</returns>
        public static double ConvertMetersToMiles(this long distance)
        {
            return ConvertMileToMeter((double)distance);
        }
    }
}