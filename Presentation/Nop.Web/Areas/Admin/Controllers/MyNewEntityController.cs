using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Core.Domain.Catalog;
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
using Nop.Web.Areas.Admin.Factories;
using Nop.Web.Areas.Admin.Models.Catalog;
using Nop.Web.Framework.Controllers;

namespace Nop.Web.Areas.Admin.Controllers
{
	[Route("Admin/MyNewEntity/[action]")]
	public class MyNewEntityController : BaseAdminController
	{
		#region Ctor
		private readonly IAclService _aclService;
		private readonly IMyNewEntityModelFactory _iNewEntityModelFactory;
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



		public MyNewEntityController(IAclService aclService, ICustomerActivityService customerActivityService, ICustomerService customerService, IDiscountService discountService, IExportManager exportManager, IImportManager importManager, ILanguageService languageService, ILocalizationService localizationService, ILocalizedEntityService localizedEntityService, IPermissionService permissionService, IPictureService pictureService, IProductService productService, IStoreMappingService storeMappingService, IStoreService storeService, IUrlRecordService urlRecordService, IWorkContext workContext, IMyNewEntityModelFactory iNewEntityModelFactory)
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
			_iNewEntityModelFactory = iNewEntityModelFactory;
		}
		#endregion

		#region List

		public IActionResult Index()
		{
			return RedirectToAction("List");
		}

		public virtual IActionResult List()
		{
			var model = GetAllAfterAdded();
			return View(model);
		}

		[NonAction]
		public IList<MyNewEntity> GetAllAfterAdded()
		{
			return _iNewEntityModelFactory.GetList();
		}

		#endregion

		#region Ekleme

		public PartialViewResult AddNew(string txtName, string txtSurname)
		{
			//Gelen verileri ekleyecegim ve  sonra partialView olarak geri donecegim hepsini ve yazdiracagim

			if (!String.IsNullOrEmpty(txtName) && !String.IsNullOrEmpty(txtSurname))
			{
				_iNewEntityModelFactory.AddNew(new MyNewEntity() { MyEntityName = txtName, MyEntitySurname = txtSurname });
			}
			var model = GetAllAfterAdded();
			return PartialView("_PartialViewAddNew", model);
		}

		#endregion

		#region  Silme Islemi

		public HtmlString RemoveEntity(int id)
		{
			var entity = _iNewEntityModelFactory.GetById(id);


			_iNewEntityModelFactory.Delete(entity);

			return HtmlString.Empty;
		}
		#endregion


		#region Guncelleme
		[Route("{id:int?}")]

		public IActionResult UpdateEntity(int id)
		{
			var model = _iNewEntityModelFactory.GetById(id);

			return View(model);

		}

		[Route("{id:int?}")]
		[ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult UpdateEntityNew(MyNewEntity entity)
		{
			
			try
			{
				_iNewEntityModelFactory.Update(entity);
			}
			catch (Exception e)
			{
				ViewBag.Hata = "Giris Kaydiniz Hatali Lutfen Tekrar deneyiniz";
				return View("UpdateEntity",entity);
			}

			return RedirectToAction("List");
		}

		#endregion
	}
}