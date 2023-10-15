using static System.Net.Mime.MediaTypeNames;

namespace NotionDatabaseStatusViewer.NotionTypes
{
    internal class TextType
    {
        public Text text { get; set; } = new();
    }
}
