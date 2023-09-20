using QuickFix;
using Message = QuickFix.Message;

namespace Business.FixApp
{
    public class InitiatorFixApp : FixApplicationBase
    {
        public InitiatorFixApp(Action<string> logHandler, Action<Message> onMessageHandler)
            : base(logHandler, onMessageHandler, "initiator")
        { }

        public void OnMessage(QuickFix.FIX44.ExecutionReport executionReport, SessionID sessionID)
        {
            _logger.Invoke($"OnMessage_ExecutionReport | {sessionID} | {executionReport}");
        }
    }
}
