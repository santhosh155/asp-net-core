namespace DotNetCoreAPI.Model
{
    public class RequestOption
    {
        //public string[] Fields {  get; set; }
        //public int page { get; set; }
        //public int pageSize { get; set; }
        public Sort SortElement { get; set; }
    }

    public class Sort
    {
        public string PropertyName { get; set; } = null!;
        public SortOrder SortOrder { get; set; } = SortOrder.NoSort;
    }

    public enum SortOrder
    {
        NoSort = 0,
        Ascending = 1,
        Descending = -1
    }
}
