using System;
using System.Collections.Generic;
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
        /// Transform a List of tuple(distance, seconds) distance traveled in meters
        /// over time passed in seconds to minutes/KM pace.
        /// </summary>
        /// <typeparam name="T">List Tuple(T, int)</typeparam>
        /// <param name="distances">List of tuple (distance, seconds)</param>
        /// <returns>List of min/km</returns>
        public static List<double> DistanceMetersInSecondsToMinKm<T>(this List<(T, int)> distances)
            where T :
            struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable
        {
            List<double> returnDistances = new List<double>();
            foreach (var distance in distances)
            {
                returnDistances.Add(DistanceMetersInSecondsToMinKm(distance.Item1, distance.Item2));
            }

            return returnDistances;
        }

        public static double[] DistanceMetersInSecondsToMinKm<T>(this (T, int)[] distances)
            where T :
            struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable
        {
            var items = distances.Length;
            double[] returnArray = new double[items];
            var i = 0;
            while (i < items)
            {
                returnArray[i] = DistanceMetersInSecondsToMinKm(distances[i].Item1, distances[i].Item2);
                i++;
            }

            return returnArray;
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