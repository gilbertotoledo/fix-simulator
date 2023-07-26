using Serilog.Core;
using Serilog.Events;

namespace FixSimulatorDesktop.Helper
{
    public class TextboxLoggerSink : ILogEventSink
    {
        public event EventHandler NewLogHandler;

        public TextboxLoggerSink() { }

        public void Emit(LogEvent logEvent)
        {
            Console.WriteLine($"{logEvent.Timestamp}] {logEvent.MessageTemplate}");
            NewLogHandler?.Invoke(typeof(TextboxLoggerSink), new LogEventArgs() { Log = logEvent });
        }
    }

    public class LogEventArgs : EventArgs
    {
        public LogEvent Log { get; set; }
    }
}
