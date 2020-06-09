using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Digitizeit.PaceDistanceSpeedHelper.PaceHelper
{
    public static class PaceCalculationHelper
    {
        /// <summary>
        /// Transform distance traveled in meters over time passed in seconds to minutes/KM pace
        /// </summary>
        /// <param name="distance">Distance traveled in meters</param>
        /// <param name="seconds">Time passed in seconds</param>
        /// <returns>double minutes/km</returns>
        public static double DistanceMetersInSecondsToMinKm<T>(this T distance, int seconds) where T :
            struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable
        {
            var typedDistance = (double)Convert.ChangeType(distance, typeof(double));
            var distancePart = (typedDistance / 1000.0);
            var distanceSeconds = seconds / distancePart;
            var minSec = distanceSeconds / 60.0;
            var min = (long)minSec;
            var secPart = minSec - min;
            var sec = secPart * 60;
            return Math.Round(min + sec / 100, 2);
        }

        /// <summary>
        /// Transform distance traveled in meters over time passed in seconds to minutes/(English)Mile pace
        /// </summary>
        /// <param name="distance">Distance traveled meters</param>
        /// <param name="seconds">Time passed in seconds</param>
        /// <returns>double minutes/(English)mile</returns>
        public static double DistanceMetersInSecondsToMinutesEnglishMile<T>(this T distance, int seconds) where T :
            struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable
        {
            var typedDistance = (double)Convert.ChangeType(distance, typeof(double));
            var distancePart = (typedDistance / 1609.344);
            var distanceSeconds = seconds / distancePart;
            var minSec = distanceSeconds / 60.0;
            var min = (long)minSec;
            var secPart = minSec - min;
            var sec = secPart * 60;
            return Math.Round(min + sec / 100, 2);
        }

        /// <summary>
        /// Transform distance traveled in meters over time passed in seconds to Km/h
        /// </summary>
        /// <param name="distance">Distance traveled meters</param>
        /// <param name="seconds">Time passed in seconds</param>
        /// <returns>double Km/h</returns>
        public static double DistanceMetersInSecondsToKmHour<T>(this T distance, int seconds) where T :
            struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable
        {
            var typedDistance = (double)Convert.ChangeType(distance, typeof(double));
            var distancePart = (typedDistance / 1000.0);
            var hour = (seconds / 60.0) / 60.0;
            var ret = distancePart / hour;
            return Math.Round(ret, 2);
        }

        /// <summary>
        /// Transform distance traveled in meters over time passed in seconds to (english) MPH
        /// </summary>
        /// <param name="distance">Distance traveled in meters</param>
        /// <param name="seconds">Time passed in seconds</param>
        /// <returns>double (english) MPH </returns>
        public static double DistanceMetersInSecondsToMph<T>(this T distance, int seconds) where T :
            struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable
        {
            var typedDistance = (double)Convert.ChangeType(distance, typeof(double));
            var distancePart = (typedDistance / 1609.344);
            var hour = (seconds / 60.0) / 60.0;
            var ret = distancePart / hour;
            return Math.Round(ret, 2);
        }
    }
}