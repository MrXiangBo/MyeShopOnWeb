namespace Web.ViewModel
{
    public class PaginationInfoViewModel
    {
        public int TotalItems { get; set; }
        public int ItemPerPage { get; set; }
        public int ActualPage { get; set; }
        public int TotalPage { get; set; }
        public string Previous { get; set; }
        public string Next { get; set; }
    }
}
