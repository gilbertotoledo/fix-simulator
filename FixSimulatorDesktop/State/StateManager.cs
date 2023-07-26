namespace FixSimulatorDesktop.Controller
{
    public static class StateManager
    {
        public static AcceptorMacros AcceptorMacrosEnabled { get; set; } = new AcceptorMacros();
        public static bool ShowLogonLogoutMessages { get; set; } = false;

        public static bool IsAcceptorRunning { get; set; } = false;
        public static bool IsInitiatorRunning { get; set; } = false;
    }

    public class AcceptorMacros
    {
        public bool ExecutionReportNew { get; set; }
        public bool ExecutionReportFilled { get; set; }
        public bool ExecutionReportPartiallyFilledUnique { get; set; }
        public bool ExecutionReportPartiallyFilledScheduled { get; set; }
    }
}
