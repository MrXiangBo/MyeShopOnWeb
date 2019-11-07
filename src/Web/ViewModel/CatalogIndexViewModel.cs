using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Web.ViewModel
{
    public class CatalogIndexViewModel
    {
        public IEnumerable<CatalogItemViewModel> CatalogItems { get; set; }
        public IEnumerable<SelectListItem> Brands { get; set; }
        public IEnumerable<SelectListItem> Types { get; set; }
        public int? BrandFilterApplied { get; set; }
        public int? TypeFilterApplied { get; set; }
        public PaginationInfoViewModel PaginationInfo { get; set; }

    }
}
