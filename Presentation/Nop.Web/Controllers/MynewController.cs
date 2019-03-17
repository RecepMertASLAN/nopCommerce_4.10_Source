using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Services.Catalog;
using Nop.Services.Customers;
using Nop.Services.Discounts;
using Nop.Services.ExportImport;
using Nop.Services.Localization;
using Nop.Services.Logging;
using Nop.Services.Media;
using Nop.Services.Security;
using Nop.Services.Seo;
using Nop.Services.Stores;
using Nop.Web.Areas.Admin.Controllers;


namespace Nop.Web.Controllers
{
    public class MynewController : BaseAdminController
	{
		private readonly IAclService _aclService;
		private readonly ICustomerActivityService _customerActivityService;
		private readonly ICustomerService _customerService;
		private readonly IDiscountService _discountService;
		private readonly IExportManager _exportManager;
		private readonly IImportManager _importManager;
		private readonly ILanguageService _languageService;
		private readonly ILocalizationService _localizationService;
		private readonly ILocalizedEntityService _localizedEntityService;
		private readonly IPermissionService _permissionService;
		private readonly IPictureService _pictureService;
		//
		private readonly IProductService _productService;
		// IProductService ten emin degilim
		//
		private readonly IStoreMappingService _storeMappingService;
		private readonly IStoreService _storeService;
		private readonly IUrlRecordService _urlRecordService;
		private readonly IWorkContext _workContext;

		public MynewController(IAclService aclService, ICustomerActivityService customerActivityService, ICustomerService customerService, IDiscountService discountService, IExportManager exportManager, IImportManager importManager, ILanguageService languageService, ILocalizationService localizationService, ILocalizedEntityService localizedEntityService, IPermissionService permissionService, IPictureService pictureService, IProductService productService, IStoreMappingService storeMappingService, IStoreService storeService, IUrlRecordService urlRecordService, IWorkContext workContext)
		{
			_aclService = aclService;
			_customerActivityService = customerActivityService;
			_customerService = customerService;
			_discountService = discountService;
			_exportManager = exportManager;
			_importManager = importManager;
			_languageService = languageService;
			_localizationService = localizationService;
			_localizedEntityService = localizedEntityService;
			_permissionService = permissionService;
			_pictureService = pictureService;
			_productService = productService;
			_storeMappingService = storeMappingService;
			_storeService = storeService;
			_urlRecordService = urlRecordService;
			_workContext = workContext;
		}
	}
}