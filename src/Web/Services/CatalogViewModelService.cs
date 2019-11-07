using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Entities.BasketAggregate;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Web.Interfaces;
using Web.ViewModel;

namespace Web.Services
{
    public class CatalogViewModelService : ICatalogViewModelService
    {
        //依赖注入
        private readonly ILogger<CatalogViewModelService> _logger;
        private readonly IAsyncRepository<CatalogItem> _itemRepository;
        private readonly IAsyncRepository<CatalogBrand> _brandRepository;
        private readonly IAsyncRepository<CatalogType> _typeRepository;
        private readonly IUriComposer _uriComposer;

        public CatalogViewModelService(
            ILoggerFactory loggerFactory,
            IAsyncRepository<CatalogItem> itemRepository,
            IAsyncRepository<CatalogBrand> brandRepository,
            IAsyncRepository<CatalogType> typeRepository,
            IUriComposer uriComposer)
        {
            _logger = loggerFactory.CreateLogger<CatalogViewModelService>();
            _itemRepository = itemRepository;
            _brandRepository = brandRepository;
            _typeRepository = typeRepository;
            _uriComposer = uriComposer;
        }


        public async Task<IEnumerable<SelectListItem>> GetBrands()
        {
            _logger.LogInformation("GetBrands called");
            var brands = await _brandRepository.ListAllAsync();

            var items = new List<SelectListItem>()
            {
                new SelectListItem(){ Value=null,Text="ALL(全部)",Selected=true }
            };
            foreach (var item in brands)
            {
                items.Add(new SelectListItem() { Value = item.Id.ToString(), Text = item.Brand });
            }
            return items;
        }


        public Task<CatalogIndexViewModel> GetCatalogItems(int pageIndex, int itemsPage, int? brandId, int? typeId)
        {
            _logger.LogInformation("GetCatalogItems called.");


        }

        public async Task<IEnumerable<SelectListItem>> GetTypes()
        {
            _logger.LogInformation("GetTypes called.");
            var types = await _typeRepository.ListAllAsync();
            var items = new List<SelectListItem>
            {
                new SelectListItem(){ Value=null,Text="All(全部)",Selected=true}
            };
            foreach (var item in types)
            {
                items.Add(new SelectListItem() { Value = item.Id.ToString(), Text = item.Type });
            }
            return items;
        }
    }
}
