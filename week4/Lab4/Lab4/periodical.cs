using libraryItem;

namespace periodical
{
    public class Periodical : LibraryItems
    {
        protected int issueNumber;
        protected string periodicity;

        public Periodical(string name, bool isAvailable, int issueNumber, string periodicity)
            : base(name, isAvailable)
        {
            this.issueNumber = issueNumber;
            this.periodicity = periodicity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Issue: {issueNumber}, Periodicity: {periodicity}");
        }
    }
}