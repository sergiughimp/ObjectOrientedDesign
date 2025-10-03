using printedMaterial;

namespace book
{
    public class Book : PrintedMaterial
    {
        private string subject;
        private string recomandedFor;
        private string plotSummary;
        public Book(string name, bool isAvailable, string genre, string ISBN, string subject, string recomandedFor, string plotSummary)
            : base(name, isAvailable, genre, ISBN)
        {
            this.subject = subject;
            this.recomandedFor = recomandedFor;
            this.plotSummary = plotSummary;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Subject: {subject}, Recommended For: {recomandedFor}, Plot Summary: {plotSummary}");
        }
    }
}