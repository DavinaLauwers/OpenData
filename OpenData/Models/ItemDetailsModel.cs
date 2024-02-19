namespace OpenData.Models
{
    public class ItemDetailsModel<TItem>
    {
        public string ItemName { get; set; }
        public TItem Item { get; set; }
        public bool InEdit { get; set; }
        public bool IsNew { get; set; } = false;
    }
}
