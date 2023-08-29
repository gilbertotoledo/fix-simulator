using QuickFix.Fields;
using System.Runtime.CompilerServices;
using System.Text;

namespace FixSimulatorDesktop.Business.Tools.LogFixAnalyzer
{
    public class FixLogStats
    {
        public IList<MessageStats> Messages { get; set; } = new List<MessageStats>();

        private readonly string _reportTemplate = @"<html>
            <head><title>LogFixReport</title></head>
            <body>
                <table cellspacing='0' cellpadding='0' width='1000px' border='1' style='margin:auto'>
                    <thead>
                        <tr>
                            <th width='30%'>MsgType</th>
                            <th width='20%'>Qty Messages</th>
                            <th width='30%'>Tag</th>
                            <th width='20%'>Qty</th>
                        </tr>
                    </thead>
                    <tbody>{lines}</tbody>
                </table>
            </body>
            </html>";

        

        public void ProcessText(string text)
        {
            var start = text.IndexOf("8=FIX.4.4");
            var message = text[start..];
            var tags = message.Split("\u0001").ToList();

            AddMessageStats(tags);
        }

        private void AddMessageStats(List<string> tags)
        {
            var msgType = GetTagValue(tags, "35");

            var mt = Messages.FirstOrDefault(p => p.MsgType == msgType);
            if (mt is null)
            {
                Messages.Add(new MessageStats(msgType, tags));
            }
            else
            {
                mt.UpdateStats(tags);
            }
        }

        private static string GetTagValue(List<string> tags, string tag)
        {
            return tags.Find(t => t.StartsWith($"{tag}="))?.Replace($"{tag}=", "");
        }

        public string GenerateReport(string path)
        {
            Messages = Messages.OrderBy(t => t.MsgType).ToList();
            foreach (var messageStats in Messages)
            {
                messageStats.SortTags();
            }

            var filename = @$"{path}\{DateTime.Now:yyyyMMdd-HHmmss}.html";
            var report = _reportTemplate;

            var lines = new StringBuilder();
            
            foreach (var messageStats in Messages)
            {
                lines.Append(@$"<tr>
                    <td rowspan='{messageStats.Tags.Count}'>{messageStats.MsgType} - {messageStats.Description}</td>
                    <td rowspan='{messageStats.Tags.Count}'>{messageStats.Quantity}</td>");

                foreach (var tagStats in messageStats.Tags)
                {
                    lines.Append(@$"
                        <td>{tagStats.Tag} - {tagStats.Description}</td>
                        <td>{tagStats.Quantity}</td>
                    </tr>");
                }
            }

            File.WriteAllText(filename, report.Replace("{lines}", lines.ToString()));

            return filename;
        }
    }
}
