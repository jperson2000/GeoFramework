using System;
using System.Globalization;

namespace GeoFramework
{
    /// <summary>
    /// Represents a measurement of an object's rate of travel in a particular direction.
    /// </summary>
    /// <remarks>
    ///     <para>Instances of this class are guaranteed to be thread-safe because the class is
    ///     immutable (its properties can only be changed via constructors).</para>
    /// </remarks>
    public struct Velocity : IFormattable, IEquatable<Velocity>, ICloneable<Velocity>
    {
        private readonly Speed _Speed;
        private readonly Azimuth _Bearing;

        #region  Constructors 
        
        public Velocity(Speed speed, Azimuth bearing)
        {
            _Speed = speed;
            _Bearing = bearing;
        }
        
        public Velocity(Speed speed, double bearingDegrees)
        {
            _Speed = speed;
            _Bearing = new Azimuth(bearingDegrees);
        }

        public Velocity(double speed, SpeedUnit speedUnits, Azimuth bearing)
        {
            _Speed = new Speed(speed, speedUnits);
            _Bearing = bearing;
        }

        public Velocity(double speed, SpeedUnit speedUnits, double bearingDegrees)
        {
            _Speed = new Speed(speed, speedUnits);
            _Bearing = new Azimuth(bearingDegrees);
        }
        
        /// <summary>
        /// Creates a new instance by parsing speed and bearing from the specified strings.
        /// </summary>
        public Velocity(string speed, string bearing) 
            : this(speed, bearing, CultureInfo.CurrentCulture)
        { }

        /// <summary>
        /// Creates a new instance by converting the specified strings using the specific culture.
        /// </summary>
        public Velocity(string speed, string bearing, CultureInfo culture)
        {
            _Speed = new Speed(speed, culture);
            _Bearing = new Azimuth(bearing, culture);
        }

        #endregion

        #region Public Properties

        /// <summary>Gets the objects rate of travel.</summary>
        public Speed Speed
        {
            get { return _Speed; }
        }

        /// <summary>Gets the objects direction of travel.</summary>
        public Azimuth Bearing
        {
            get { return _Bearing; }
        }

        /// <summary>
        /// Indicates whether the speed and bearing are both zero.
        /// </summary>
        public bool IsEmpty
        {
            get
            {
                return _Speed.IsEmpty && _Bearing.IsEmpty;
            }
        }

        /// <summary>Indicates whether the speed or bearing is invalid or unspecified.</summary>
        public bool IsInvalid
        {
            get
            {
                return _Speed.IsInvalid || _Bearing.IsInvalid;
            }
        }

        #endregion

        #region Operators

        public static bool operator ==(Velocity left, Velocity right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Velocity left, Velocity right)
        {
            return !left.Equals(right);
        }

        #endregion

        #region Overrides

        public override int GetHashCode()
        {
            return _Speed.GetHashCode() ^ _Bearing.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(obj is Velocity)
                return Equals((Velocity)obj);
            return false;
        }

        /// <summary>Outputs the current instance as a string using the default format.</summary>
        /// <returns><para>A <strong>String</strong> representing the current instance.</para></returns>
        public override string ToString()
        {
            return ToString("g", CultureInfo.CurrentCulture);
        }

        #endregion

        #region IEquatable<Velocity>

        /// <summary>
        /// Compares the current instance to the specified velocity.
        /// </summary>
        /// <param name="other">A <strong>Velocity</strong> object to compare with.</param>
        /// <returns>A <strong>Boolean</strong>, <strong>True</strong> if the values are identical.</returns>
        public bool Equals(Velocity other)
        {
            return _Speed.Equals(other.Speed)
                && _Bearing.Equals(other.Bearing);
        }

        /// <summary>
        /// Compares the current instance to the specified velocity using the specified numeric precision.
        /// </summary>
        /// <param name="other">A <strong>Velocity</strong> object to compare with.</param>
        /// <param name="decimals">An <strong>Integer</strong> specifying the number of fractional digits to compare.</param>
        /// <returns>A <strong>Boolean</strong>, <strong>True</strong> if the values are identical.</returns>
        public bool Equals(Velocity other, int decimals)
        {
            return _Speed.Equals(other.Speed, decimals)
                && _Bearing.Equals(other.Bearing, decimals);
        }

        #endregion

        #region IFormattable Members

        /// <summary>
        /// Outputs the current instance as a string using the specified format and culture information.
        /// </summary>
        public string ToString(string format, IFormatProvider formatProvider)
        {
            CultureInfo culture = (CultureInfo)formatProvider;

            if (culture == null)
                culture = CultureInfo.CurrentCulture;

            // Output as speed and bearing
            return _Speed.ToString(format, culture)
                + " "
                + _Bearing.ToString(format, culture);
        }

        #endregion

        #region ICloneable<Velocity> Members

        public Velocity Clone()
        {
            return new Velocity(_Speed, _Bearing);
        }

        #endregion
    }
}
