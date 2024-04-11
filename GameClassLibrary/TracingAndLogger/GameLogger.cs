using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibraryFramework.TracingAndLogger
{
    ///Solid: Single Responsibility Principle
    /// <summary>
    /// Provides a singleton logger for game-related logging and tracing.
    /// Provides methods for logging information, warnings, and errors.
    /// </summary>
    public class GameLogger
    {
        /// <summary>
        /// Holds the singleton instance of the GameLogger, initialized lazily.
        /// </summary>
        private static readonly Lazy<GameLogger> instance = new Lazy<GameLogger>(() => new GameLogger());

        /// <summary>
        /// Gets the singleton instance of the GameLogger.
        /// </summary>
        public static GameLogger Instance => instance.Value;
         
        /// <summary>
        /// TraceSource used for logging.
        /// </summary>
        private TraceSource gameTraceSource;

        /// <summary>
        /// Initializes a new instance of the GameLogger class with a specific TraceSource.
        /// Uses a ConsoleTraceListener to output log messages to the console.
        /// </summary>
        private GameLogger()
        {
            gameTraceSource = new TraceSource("GameTraceSource");
            gameTraceSource.Switch = new SourceSwitch("GameTraceSwitch", "All");
            gameTraceSource.Listeners.Add(new ConsoleTraceListener());
        }

        /// <summary>
        /// Logs an informational message to the TraceSource.
        /// </summary>
        /// <param name="message"></param>
        public void LogInformation(string message)
        {
            gameTraceSource.TraceEvent(TraceEventType.Information, 0, message);
        }

        /// <summary>
        /// Logs a warning message to the TraceSource.
        /// </summary>
        /// <param name="message"></param>
        public void LogWarning(string message)
        {
            gameTraceSource.TraceEvent(TraceEventType.Warning, 0, message);
        }

        /// <summary>
        /// Logs an error message to the TraceSource.
        /// </summary>
        /// <param name="message"></param>
        public void LogError(string message)
        {
            gameTraceSource.TraceEvent(TraceEventType.Error, 0, message);
        }
    }
}
