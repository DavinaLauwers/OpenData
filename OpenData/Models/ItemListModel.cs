namespace OpenData.Models
{
    public class ItemListModel<TItem>
    {
        public string Title { get; set; }
        public string ItemName { get; set; }
        public string[] Headers { get; set; }
        public TItem[] Items { get; set; }
    }
}
