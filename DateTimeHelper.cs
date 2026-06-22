using System;

namespace CSharpConsoleHelpers
{
    /// <summary>
    /// Provides utility methods for date and time manipulations, optimized for secure storage and timezone conversion.
    /// </summary>
    public static class DateTimeHelper
    {
        /// <summary>
        /// Converts a local DateTime object to Coordinated Universal Time (UTC) and returns its Ticks as a 64-bit integer.
        /// Ideal for lightweight database or file storage.
        /// </summary>
        /// <param name="localDateTime">The local date and time to convert.</param>
        /// <returns>A long integer representing the date in UTC ticks.</returns>
        public static long ConvertToUtcTicks(DateTime localDateTime)
        {
            return localDateTime.ToUniversalTime().Ticks;
        }

        /// <summary>
        /// Reconstructs a local DateTime object from a stored UTC Ticks value, automatically adjusting it to the user's system timezone.
        /// </summary>
        /// <param name="utcTicks">The 64-bit signed integer representing UTC ticks.</param>
        /// <returns>A DateTime object converted back to the local time environment.</returns>
        public static DateTime ConvertFromUtcTicks(long utcTicks)
        {
            return new DateTime(utcTicks, DateTimeKind.Utc).ToLocalTime();
        }
    }
}
