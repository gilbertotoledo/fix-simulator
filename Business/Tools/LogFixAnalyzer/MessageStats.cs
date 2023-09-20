using Business.FixApp;

namespace Business.Tools.LogFixAnalyzer
{
    public class MessageStats
    {
        public string MsgType { get; set; }
        public int Quantity { get; set; }
        public IList<TagStats> Tags { get; set; } = new List<TagStats>();

        public string Description { get => FixDictionary.GetMsgTypeText(MsgType); }

        public MessageStats(string msgType, List<string> tags)
        {
            this.MsgType = msgType;
            this.Quantity = 1;
            tags.ForEach(t =>
            {
                if (!string.IsNullOrEmpty(t))
                {
                    var tagInt = int.Parse(t.Split("=")[0]);
                    this.Tags.Add(new TagStats(tagInt));
                }
            });
        }

        public void UpdateStats(List<string> tags)
        {
            Quantity++;
            tags.ForEach((t) =>
            {
                if (!string.IsNullOrEmpty(t))
                {
                    var tagInt = int.Parse(t.Split("=")[0]);
                    var ts = Tags.FirstOrDefault(s => s.Tag == tagInt);
                    if (ts is null)
                    {
                        Tags.Add(new TagStats(tagInt));
                    }
                    else
                    {
                        ts.UpdateStats();
                    }
                }
            });
        }

        public void SortTags()
        {
            Tags = Tags.OrderBy(t => t.Tag).ToList();
        }
    }
}
