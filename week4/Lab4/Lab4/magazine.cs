using periodical;

namespace magazine
{
    public class Magazine : Periodical
    {
        private string celebrityFocus;

        public Magazine(string name, bool isAvailable, int issueNumber, string periodicity, string celebrityFocus)
            : base(name, isAvailable, issueNumber, periodicity)
        {
            this.celebrityFocus = celebrityFocus;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Celebrity Focus: {celebrityFocus}");
        }
    }

}