using Business.Helper;

namespace Business.State
{
    public static class StateManager
    {
        public static bool IsAcceptorRunning { get; set; } = false;
        public static bool IsInitiatorRunning { get; set; } = false;

        public static string Account
        {
            get => ConfigHelper.GetString("Account");
            set => ConfigHelper.Persist("Account", value);
        }

        public static string Symbol
        {
            get => ConfigHelper.GetString("Symbol");
            set => ConfigHelper.Persist("Symbol", value);
        }

        public static char Side
        {
            get => ConfigHelper.GetChar("Side");
            set => ConfigHelper.Persist("Side", value);
        }

        public static decimal Price
        {
            get => ConfigHelper.GetDecimal("Price");
            set => ConfigHelper.Persist("Price", value);
        }

        public static decimal Quantity
        {
            get => ConfigHelper.GetDecimal("Quantity");
            set => ConfigHelper.Persist("Quantity", value);
        }

        public static string Operation
        {
            get => ConfigHelper.GetString("Operation");
            set => ConfigHelper.Persist("Operation", value);
        }

        public static bool IsInitiatorShowMessagesReceived
        {
            get => ConfigHelper.GetBool("InitiatorShowMessagesReceived");
            set => ConfigHelper.Persist("InitiatorShowMessagesReceived", value);
        }

        public static bool IsInitiatorShowMessagesSent
        {
            get => ConfigHelper.GetBool("InitiatorShowMessagesSent");
            set => ConfigHelper.Persist("InitiatorShowMessagesSent", value);
        }

        public static bool IsAcceptorShowMessagesReceived
        {
            get => ConfigHelper.GetBool("AcceptorShowMessagesReceived");
            set => ConfigHelper.Persist("AcceptorShowMessagesReceived", value);
        }

        public static bool IsAcceptorShowMessagesSent
        {
            get => ConfigHelper.GetBool("AcceptorShowMessagesSent");
            set => ConfigHelper.Persist("AcceptorShowMessagesSent", value);
        }

        public static int AcceptorIntervalMilis
        {
            get => ConfigHelper.GetInt("AcceptorIntervalMilis");
            set => ConfigHelper.Persist("AcceptorIntervalMilis", value);
        }

        public static bool AcceptorMacroExecutionReportNew
        {
            get => ConfigHelper.GetBool("AcceptorMacroExecutionReportNew");
            set => ConfigHelper.Persist("AcceptorMacroExecutionReportNew", value);
        }

        public static bool AcceptorMacroExecutionReportFilled
        {
            get => ConfigHelper.GetBool("AcceptorMacroExecutionReportFilled");
            set => ConfigHelper.Persist("AcceptorMacroExecutionReportFilled", value);
        }

        public static bool AcceptorMacroExecutionReportPartiallyFilledUnique
        {
            get => ConfigHelper.GetBool("AcceptorMacroExecutionReportPartiallyFilledUnique");
            set => ConfigHelper.Persist("AcceptorMacroExecutionReportPartiallyFilledUnique", value);
        }

        public static bool AcceptorMacroExecutionReportPartiallyFilledScheduled
        {
            get => ConfigHelper.GetBool("AcceptorMacroExecutionReportPartiallyFilledScheduled");
            set => ConfigHelper.Persist("AcceptorMacroExecutionReportPartiallyFilledScheduled", value);
        }

        public static bool AcceptorMacroExecutionReportReplaced
        {
            get => ConfigHelper.GetBool("AcceptorMacroExecutionReportReplaced");
            set => ConfigHelper.Persist("AcceptorMacroExecutionReportReplaced", value);
        }

        public static bool AcceptorMacroExecutionReportReplaceReject
        {
            get => ConfigHelper.GetBool("AcceptorMacroExecutionReportReplaceReject");
            set => ConfigHelper.Persist("AcceptorMacroExecutionReportReplaceReject", value);
        }

        public static bool AcceptorMacroExecutionReportCanceled
        {
            get => ConfigHelper.GetBool("AcceptorMacroExecutionReportCanceled");
            set => ConfigHelper.Persist("AcceptorMacroExecutionReportCanceled", value);
        }

        public static bool AcceptorMacroExecutionReportCancelReject
        {
            get => ConfigHelper.GetBool("AcceptorMacroExecutionReportCancelReject");
            set => ConfigHelper.Persist("AcceptorMacroExecutionReportCancelReject", value);
        }
    }
}
