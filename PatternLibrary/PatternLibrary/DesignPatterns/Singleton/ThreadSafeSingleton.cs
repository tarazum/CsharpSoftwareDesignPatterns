using System;

namespace PatternLibrary.DesignPatterns.Singleton
{
    /// <summary>
    /// Thread-safe implementation of the Singleton pattern using Lazy<T>.
    /// </summary>
    public sealed class ThreadSafeSingleton
    {
        // Lazy<T> ensures the instance is created in a thread-safe manner only when needed.
        private static readonly Lazy<ThreadSafeSingleton> _instance =
            new Lazy<ThreadSafeSingleton>(() => new ThreadSafeSingleton());

        /// <summary>
        /// Gets the singleton instance.
        /// </summary>
        public static ThreadSafeSingleton Instance => _instance.Value;

        // Private constructor prevents external instantiation.
        private ThreadSafeSingleton()
        {
        }

        /// <summary>
        /// Example method that returns the current timestamp.
        /// </summary>
        public DateTime GetTimestamp()
        {
            return DateTime.UtcNow;
        }
    }
}
