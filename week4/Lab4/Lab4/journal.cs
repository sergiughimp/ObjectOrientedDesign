using periodical;

namespace journal
{
    public class Journal : Periodical
    {
        private string fieldOfStudy;
        private string editorInChief;

        public Journal(string name, bool isAvailable, int issueNumber, string periodicity, string fieldOfStudy, string editorInChief)
            : base(name, isAvailable, issueNumber, periodicity)
        {
            this.fieldOfStudy = fieldOfStudy;
            this.editorInChief = editorInChief;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Field of Study: {fieldOfStudy}, Editor in Chief: {editorInChief}");
        }
    }
}