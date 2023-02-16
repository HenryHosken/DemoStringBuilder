namespace DemoStringBuilder.Entities
{
    internal class Comment
    {
        public string text { get; set; }

        public Comment()
        {
        }

        public Comment(string text)
        {
            this.text = text;
        }
    }
}
