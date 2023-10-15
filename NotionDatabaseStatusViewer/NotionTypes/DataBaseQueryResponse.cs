namespace NotionDatabaseStatusViewer.NotionTypes
{
    internal class DataBaseQueryResponse
    {
        public bool has_more { get; set; }
        public string type { get; set; } = string.Empty;
        public List<Page> results { get; set; } = new();
    }
}
