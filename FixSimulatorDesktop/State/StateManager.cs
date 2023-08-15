using System.Configuration;

namespace FixSimulatorDesktop.Controller
{
    public static class StateManager
    {
        public static AcceptorMacros AcceptorMacrosEnabled { get; set; } = new AcceptorMacros();
        public static bool ShowLogonLogoutMessages { get; set; } = false;

        public static bool IsAcceptorRunning { get; set; } = false;
        public static bool IsInitiatorRunning { get; set; } = false;

        public static bool IsInitiatorShowMessagesReceived { get; set; } = ConfigurationManager.AppSettings["InitiatorShowMessagesReceived"] == "true";
        public static bool IsInitiatorShowMessagesSent { get; set; } = ConfigurationManager.AppSettings["InitiatorShowMessagesSent"] == "true";
        public static bool IsAcceptorShowMessagesReceived { get; set; } = ConfigurationManager.AppSettings["AcceptorShowMessagesReceived"] == "true";
        public static bool IsAcceptorShowMessagesSent { get; set; } = ConfigurationManager.AppSettings["AcceptorShowMessagesSent"] == "true";
    }

    public class AcceptorMacros
    {
        public bool ExecutionReportNew { get; set; } = ConfigurationManager.AppSettings["AcceptorMacroExecutionReportNew"] == "true";
        public bool ExecutionReportFilled { get; set; } = ConfigurationManager.AppSettings["AcceptorMacroExecutionReportFilled"] == "true";
        public bool ExecutionReportPartiallyFilledUnique { get; set; } = ConfigurationManager.AppSettings["AcceptorMacroExecutionReportPartiallyFilledUnique"] == "true";
        public bool ExecutionReportPartiallyFilledScheduled { get; set; } = ConfigurationManager.AppSettings["AcceptorMacroExecutionReportPartiallyFilledScheduled"] == "true";
        public int ExecutionReportPartiallyFilledScheduledIntervalMilis { get; set; } = int.Parse(ConfigurationManager.AppSettings["AcceptorMacroExecutionReportPartiallyFilledScheduledIntervalMilis"]);

        public bool ExecutionReportReplaced { get; set; } = ConfigurationManager.AppSettings["AcceptorMacroExecutionReportReplaced"] == "true";
        public bool ExecutionReportReplaceReject { get; set; } = ConfigurationManager.AppSettings["AcceptorMacroExecutionReportReplaceReject"] == "true";

        public bool ExecutionReportCanceled { get; set; } = ConfigurationManager.AppSettings["AcceptorMacroExecutionReportCanceled"] == "true";
        public bool ExecutionReportCancelReject { get; set; } = ConfigurationManager.AppSettings["AcceptorMacroExecutionReportCancelReject"] == "true";
    }
}
