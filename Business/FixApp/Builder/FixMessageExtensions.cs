using QuickFix.Fields;
using QuickFix.FIX44;

namespace Business.FixApp.Builder
{
    public static class FixMessageExtensions
    {
        public static void SetApplId(this Message message,  string applId)
        {
            if (!string.IsNullOrEmpty(applId))
            {
                message.SetField(new ApplID(applId));
            }
        }

        public static void AddDefaultGroups(this Message message, string account)
        {
            message.SetField(new NoPartyIDs(3));
            message.AddGroup(new ExecutionReport.NoPartyIDsGroup()
            {
                PartyRole = new PartyRole(36),
                PartyID = new PartyID(account),
                PartyIDSource = new PartyIDSource('D')
            });
            message.AddGroup(new ExecutionReport.NoPartyIDsGroup()
            {
                PartyRole = new PartyRole(7),
                PartyID = new PartyID("4090"),
                PartyIDSource = new PartyIDSource('D')
            });
            message.AddGroup(new ExecutionReport.NoPartyIDsGroup()
            {
                PartyRole = new PartyRole(54),
                PartyID = new PartyID("DMA1"),
                PartyIDSource = new PartyIDSource('D')
            });
        }

        public static void SetBodyLenght(this Message message)
        {
            message.Header.SetField(new BodyLength(message.Header.CalculateLength() + message.CalculateLength() + message.Trailer.CalculateLength()));
        }

        public static void SetCheckSum(this Message message)
        {
            message.Trailer.SetField(new CheckSum(message.CheckSum().ToString()));
        }
    }
}
