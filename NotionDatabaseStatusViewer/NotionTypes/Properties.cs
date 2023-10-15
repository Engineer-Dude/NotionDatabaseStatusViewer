namespace NotionDatabaseStatusViewer.NotionTypes
{
    internal class Properties
    {
        public TitleType Project { get; set; } = new();
        public RichTextType Status { get; set; } = new();
    }
}
