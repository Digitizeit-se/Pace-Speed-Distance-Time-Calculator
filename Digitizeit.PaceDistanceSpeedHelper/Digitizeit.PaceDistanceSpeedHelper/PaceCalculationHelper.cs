using System;

namespace Digitizeit.PaceDistanceSpeedHelper
{
    public static class PaceCalculationHelper
    {
        /// <summary>
        /// Transform distance traveled in meters over time passed in seconds to minutes/KM pace
        /// </summary>
        /// <param name="distance">Distance traveled in meters</param>
        /// <param name="seconds">Time passed in seconds</param>
        /// <returns>double minutes/km</returns>
        public static double DistanceMetersInSecondsToMinKm(this double distance, int seconds)
        {
            var distancePart = (distance / 1000.0);
            var distanceSeconds = seconds / distancePart;
            var minSec = distanceSeconds / 60.0;
            var min = (long)minSec;
            var secPart = minSec - min;
            var sec = secPart * 60;
            return Math.Round(min + sec / 100, 2);
        }

        /// <summary>
        /// Transform distance traveled in meters over time passed in seconds to minutes/KM pace
        /// </summary>
        /// <param name="distance">Distance traveled in meters</param>
        /// <param name="seconds">Time passed in seconds</param>
        /// <returns>double minutes/km</returns>
        public static double DistanceMetersInSecondsToMinKm(this int distance, int seconds)
        {
            return DistanceMetersInSecondsToMinKm((double)distance, seconds);
        }

        /// <summary>
        /// Transform distance traveled in meters over time passed in seconds to minutes/KM pace
        /// </summary>
        /// <param name="distance">Distance traveled in meters</param>
        /// <param name="seconds">Time passed in seconds</param>
        /// <returns>double minutes/km</returns>
        public static double DistanceMetersInSecondsToMinKm(this long distance, int seconds)
        {
            return DistanceMetersInSecondsToMinKm((double)distance, seconds);
        }

        /// <summary>
        /// Transform distance traveled in meters over time passed in seconds to minutes/KM pace
        /// </summary>
        /// <param name="distance">Distance traveled in meters</param>
        /// <param name="seconds">Time passed in seconds</param>
        /// <returns>double minutes/km</returns>
        public static double DistanceMetersInSecondsToMinKm(this short distance, int seconds)
        {
            return DistanceMetersInSecondsToMinKm((double)distance, seconds);
        }

        /// <summary>
        /// Transform distance traveled in meters over time passed in seconds to minutes/KM pace
        /// </summary>
        /// <param name="distance">Distance traveled in meters</param>
        /// <param name="seconds">Time passed in seconds</param>
        /// <returns>double minutes/km</returns>
        public static double DistanceMetersInSecondsToMinKm(this float distance, int seconds)
        {
            return DistanceMetersInSecondsToMinKm((double)distance, seconds);
        }

        /// <summary>
        /// Transform distance traveled in meters over time passed in seconds to minutes/(English)Mile pace
        /// </summary>
        /// <param name="distance">Distance traveled meters</param>
        /// <param name="seconds">Time passed in seconds</param>
        /// <returns>double minutes/(English)mile</returns>
        public static double DistanceMetersInSecondsToMinutesEnglishMile(this double distance, int seconds)
        {
            var distancePart = (distance / 1609.344);
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
        public static double DistanceMetersInSecondsToMinutesEnglishMile(this long distance, int seconds)
        {
            return DistanceMetersInSecondsToMinutesEnglishMile((double)distance, seconds);
        }

        /// <summary>
        /// Transform distance traveled in meters over time passed in seconds to minutes/(English)Mile pace
        /// </summary>
        /// <param name="distance">Distance traveled meters</param>
        /// <param name="seconds">Time passed in seconds</param>
        /// <returns>double minutes/(English)mile</returns>
        public static double DistanceMetersInSecondsToMinutesEnglishMile(this int distance, int seconds)
        {
            return DistanceMetersInSecondsToMinutesEnglishMile((double)distance, seconds);
        }

        /// <summary>
        /// Transform distance traveled in meters over time passed in seconds to minutes/(English)Mile pace
        /// </summary>
        /// <param name="distance">Distance traveled meters</param>
        /// <param name="seconds">Time passed in seconds</param>
        /// <returns>double minutes/(English)mile</returns>
        public static double DistanceMetersInSecondsToMinutesEnglishMile(this short distance, int seconds)
        {
            return DistanceMetersInSecondsToMinutesEnglishMile((double)distance, seconds);
        }

        /// <summary>
        /// Transform distance traveled in meters over time passed in seconds to minutes/(English)Mile pace
        /// </summary>
        /// <param name="distance">Distance traveled meters</param>
        /// <param name="seconds">Time passed in seconds</param>
        /// <returns>double minutes/(English)mile</returns>
        public static double DistanceMetersInSecondsToMinutesEnglishMile(this float distance, int seconds)
        {
            return DistanceMetersInSecondsToMinutesEnglishMile((double)distance, seconds);
        }

        /// <summary>
        /// Transform distance traveled in meters over time passed in seconds to Km/h
        /// </summary>
        /// <param name="distance">Distance traveled meters</param>
        /// <param name="seconds">Time passed in seconds</param>
        /// <returns>double Km/h</returns>
        public static double DistanceMetersInSecondsToKmHour(this double distance, int seconds)
        {
            var distancePart = (distance / 1000.0);
            var hour = (seconds / 60.0) / 60.0;
            var ret = distancePart / hour;
            return Math.Round(ret, 2);
        }

        /// <summary>
        /// Transform distance traveled in meters over time passed in seconds to Km/h
        /// </summary>
        /// <param name="distance">Distance traveled meters</param>
        /// <param name="seconds">Time passed in seconds</param>
        /// <returns>double Km/h</returns>
        public static double DistanceMetersInSecondsToKmHour(this int distance, int seconds)
        {
            return DistanceMetersInSecondsToKmHour((double)distance, seconds);
        }

        /// <summary>
        /// Transform distance traveled in meters over time passed in seconds to Km/h
        /// </summary>
        /// <param name="distance">Distance traveled meters</param>
        /// <param name="seconds">Time passed in seconds</param>
        /// <returns>double Km/h</returns>
        public static double DistanceMetersInSecondsToKmHour(this float distance, int seconds)
        {
            return DistanceMetersInSecondsToKmHour((double)distance, seconds);
        }

        /// <summary>
        /// Transform distance traveled in meters over time passed in seconds to Km/h
        /// </summary>
        /// <param name="distance">Distance traveled meters</param>
        /// <param name="seconds">Time passed in seconds</param>
        /// <returns>double Km/h</returns>
        public static double DistanceMetersInSecondsToKmHour(this short distance, int seconds)
        {
            return DistanceMetersInSecondsToKmHour((double)distance, seconds);
        }

        /// <summary>
        /// Transform distance traveled in meters over time passed in seconds to Km/h
        /// </summary>
        /// <param name="distance">Distance traveled meters</param>
        /// <param name="seconds">Time passed in seconds</param>
        /// <returns>double Km/h</returns>
        public static double DistanceMetersInSecondsToKmHour(this long distance, int seconds)
        {
            return DistanceMetersInSecondsToKmHour((double)distance, seconds);
        }
    }
}