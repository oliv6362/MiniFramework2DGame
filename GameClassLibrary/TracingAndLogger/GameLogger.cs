using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibraryFramework.TracingAndLogger
{
    public class GameLogger
    {
        private static readonly Lazy<GameLogger> instance = new Lazy<GameLogger>(() => new GameLogger());
        public static GameLogger Instance => instance.Value;

        private TraceSource gameTraceSource;

        private GameLogger()
        {
            gameTraceSource = new TraceSource("GameTraceSource");
            gameTraceSource.Switch = new SourceSwitch("GameTraceSwitch", "All");
            gameTraceSource.Listeners.Add(new ConsoleTraceListener());
        }

        public void LogInformation(string message)
        {
            gameTraceSource.TraceEvent(TraceEventType.Information, 0, message);
        }

        public void LogWarning(string message)
        {
            gameTraceSource.TraceEvent(TraceEventType.Warning, 0, message);
        }

        public void LogError(string message)
        {
            gameTraceSource.TraceEvent(TraceEventType.Error, 0, message);
        }


    }
}
