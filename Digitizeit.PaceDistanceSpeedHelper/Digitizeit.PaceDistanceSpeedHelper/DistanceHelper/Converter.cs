using System;

namespace Digitizeit.PaceDistanceSpeedHelper.DistanceHelper
{
    public static class Converter
    {
        public static Distance<T> Distance<T>(this T distance) where T :
            struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable
        {
            return new Distance<T>(distance);
        }
    }

    public class Distance<T> where T :
        struct,
        IComparable,
        IComparable<T>,
        IConvertible,
        IEquatable<T>,
        IFormattable
    {
        private T _distance;

        public Distance(T distance)
        {
            _distance = distance;
        }

        private object _toUnit;
        private object _fromUnit;
        private int? _decimals;

        public Distance<T> To(DistanceUnitsImperialUS to)
        {
            _toUnit = to;
            return this;
        }

        public Distance<T> To(DistanceUnitsMetrics to)
        {
            _toUnit = to;
            return this;
        }

        public Distance<T> From(DistanceUnitsImperialUS from)
        {
            _fromUnit = from;
            return this;
        }

        public Distance<T> From(DistanceUnitsMetrics from)
        {
            _fromUnit = from;
            return this;
        }

        public Distance<T> SetDecimals(int decimals)
        {
            _decimals = decimals;
            return this;
        }

        public double Convert()
        {
            if (_toUnit == null || _fromUnit == null)
            {
                throw new ArgumentNullException($"From and To need to be set before conversion");
            }

            var dd = (double)System.Convert.ChangeType(_distance, typeof(double));

            switch (_fromUnit.GetType().Name)
            {
                case "DistanceUnitsImperialUS" when _toUnit.GetType().Name == "DistanceUnitsImperialUS":
                    {
                        var from = (DistanceUnitsImperialUS)Enum.Parse(typeof(DistanceUnitsImperialUS),
                            _fromUnit.ToString());
                        var to = (DistanceUnitsImperialUS)Enum.Parse(typeof(DistanceUnitsImperialUS), _toUnit.ToString());

                        return dd.ConvertDistance(from, to, _decimals);
                    }
                case "DistanceUnitsMetrics" when _toUnit.GetType().Name == "DistanceUnitsMetrics":
                    {
                        var from = (DistanceUnitsMetrics)Enum.Parse(typeof(DistanceUnitsMetrics), _fromUnit.ToString());
                        var to = (DistanceUnitsMetrics)Enum.Parse(typeof(DistanceUnitsMetrics), _toUnit.ToString());

                        return dd.ConvertDistance(from, to, _decimals);
                    }
                case "DistanceUnitsMetrics" when _toUnit.GetType().Name == "DistanceUnitsImperialUS":
                    {
                        var from = (DistanceUnitsMetrics)Enum.Parse(typeof(DistanceUnitsMetrics), _fromUnit.ToString());
                        var to = (DistanceUnitsImperialUS)Enum.Parse(typeof(DistanceUnitsImperialUS), _toUnit.ToString());

                        return dd.ConvertDistance(from, to, _decimals);
                    }
                case "DistanceUnitsImperialUS" when _toUnit.GetType().Name == "DistanceUnitsMetrics":
                    {
                        var from = (DistanceUnitsImperialUS)Enum.Parse(typeof(DistanceUnitsImperialUS),
                            _fromUnit.ToString());
                        var to = (DistanceUnitsMetrics)Enum.Parse(typeof(DistanceUnitsMetrics), _toUnit.ToString());

                        return dd.ConvertDistance(from, to, _decimals);
                    }
                default:
                    throw new Exception("Syntax error ");
            }
        }
    }
}