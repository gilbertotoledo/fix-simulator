using FixSimulatorDesktop.Helper;

namespace FixSimulatorDesktop.State
{
    public static class StateManager
    {
        public static bool IsAcceptorRunning { get; set; } = false;
        public static bool IsInitiatorRunning { get; set; } = false;

        public static bool IsInitiatorShowMessagesReceived
        {
            get { return ConfigHelper.GetBool("InitiatorShowMessagesReceived"); }
            set { ConfigHelper.Persist("InitiatorShowMessagesReceived", value); }
        }

        public static bool IsInitiatorShowMessagesSent
        {
            get { return ConfigHelper.GetBool("InitiatorShowMessagesSent"); }
            set { ConfigHelper.Persist("InitiatorShowMessagesSent", value); }
        }

        public static bool IsAcceptorShowMessagesReceived
        {
            get { return ConfigHelper.GetBool("AcceptorShowMessagesReceived"); }
            set { ConfigHelper.Persist("AcceptorShowMessagesReceived", value); }
        }

        public static bool IsAcceptorShowMessagesSent
        {
            get { return ConfigHelper.GetBool("AcceptorShowMessagesSent"); }
            set { ConfigHelper.Persist("AcceptorShowMessagesSent", value); }
        }

        public static int AcceptorIntervalMilis
        {
            get { return ConfigHelper.GetInt("AcceptorIntervalMilis"); }
            set { ConfigHelper.Persist("AcceptorIntervalMilis", value); }
        }

        public static bool AcceptorMacroExecutionReportNew
        {
            get { return ConfigHelper.GetBool("AcceptorMacroExecutionReportNew"); }
            set { ConfigHelper.Persist("AcceptorMacroExecutionReportNew", value); }
        }

        public static bool AcceptorMacroExecutionReportFilled
        {
            get { return ConfigHelper.GetBool("AcceptorMacroExecutionReportFilled"); }
            set { ConfigHelper.Persist("AcceptorMacroExecutionReportFilled", value); }
        }

        public static bool AcceptorMacroExecutionReportPartiallyFilledUnique
        {
            get { return ConfigHelper.GetBool("AcceptorMacroExecutionReportPartiallyFilledUnique"); }
            set { ConfigHelper.Persist("AcceptorMacroExecutionReportPartiallyFilledUnique", value); }
        }

        public static bool AcceptorMacroExecutionReportPartiallyFilledScheduled
        {
            get { return ConfigHelper.GetBool("AcceptorMacroExecutionReportPartiallyFilledScheduled"); }
            set { ConfigHelper.Persist("AcceptorMacroExecutionReportPartiallyFilledScheduled", value); }
        }

        public static bool AcceptorMacroExecutionReportReplaced
        {
            get { return ConfigHelper.GetBool("AcceptorMacroExecutionReportReplaced"); }
            set { ConfigHelper.Persist("AcceptorMacroExecutionReportReplaced", value); }
        }

        public static bool AcceptorMacroExecutionReportReplaceReject
        {
            get { return ConfigHelper.GetBool("AcceptorMacroExecutionReportReplaceReject"); }
            set { ConfigHelper.Persist("AcceptorMacroExecutionReportReplaceReject", value); }
        }

        public static bool AcceptorMacroExecutionReportCanceled
        {
            get { return ConfigHelper.GetBool("AcceptorMacroExecutionReportCanceled"); }
            set { ConfigHelper.Persist("AcceptorMacroExecutionReportCanceled", value); }
        }

        public static bool AcceptorMacroExecutionReportCancelReject
        {
            get { return ConfigHelper.GetBool("AcceptorMacroExecutionReportCancelReject"); }
            set { ConfigHelper.Persist("AcceptorMacroExecutionReportCancelReject", value); }
        }
    }
}
