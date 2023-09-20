using Business.FixApp;

namespace Business.Tools.LogFixAnalyzer
{
    public class TagStats
    {
        public int Tag { get; set; }
        public int Quantity { get; set; }

        public string Description { get => FixDictionary.GetTagDescription(Tag); }

        public TagStats(int tag)
        {
            this.Tag = tag;
            this.Quantity = 1;
        }

        public void UpdateStats()
        {
            this.Quantity++;
        }
    }
}
